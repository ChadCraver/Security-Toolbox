Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Module Encryption
    ' Global variables.
    Public ActionToTake As CryptoAction
    Public strTargetPath As String
    Public strDestinationPath As String
    Public fsInput As FileStream
    Public fsOutput As FileStream

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        ' Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        ' Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        ' Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte


        ' Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        ' Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        ' Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        ' Declare bytKey(31). It will hold 256 bits.
        Dim bytKey(31) As Byte

        ' Use For Next to put a specific size (256 bits) of byteResult into bytKey.
        ' The 0 to 31 will put the first 256 bits of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        ' Reutrn the key.
        Return bytKey
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        ' Intitialization vector.
        ' Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        ' Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        ' Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte


        ' Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        ' Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        ' Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        ' Declare bytIV(15). It will hold 128 bits.
        Dim bytIV(15) As Byte

        ' Use For Next to put a specific size (128 bits) of bytResult into bytIV.
        ' The 0 to 30 for bytKey used the first 256 bits of the hashed password.
        ' The 32 to 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        ' Return the IV.
        Return bytIV
    End Function

    Public Enum CryptoAction
        ' Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Function EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction) As Boolean
        Try
            ' Setup file streams to handle input and output.
            fsInput = New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)

            ' Ensure fsOutput is empty.
            fsOutput.SetLength(0)

            ' Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte ' Holds a block of bytes for processing.
            Dim lngBytesProcessed As Long = 0 ' A running count of bytes processed.
            Dim lngFileLength As Long = fsInput.Length ' The input file's length.
            Dim intBytesInCurrentBlock As Integer ' Current bytes being processed.
            Dim csCryptoStream As CryptoStream = Nothing

            ' Declare the CryptoServiceProvider.
            Dim cspRijndael As New RijndaelManaged

            ' Determine if encryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select

            ' Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                ' Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                ' Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                ' Update lngBytesProcessed
                lngBytesProcessed += CLng(intBytesInCurrentBlock)

                ' Update Progress Bar
            End While

            ' Close filestreams and cryptostream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
            Return True
        Catch ex As Exception
            fsInput.Close()
            fsOutput.Close()
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Unhandled Error Encountered")
            Return False
        End Try
    End Function

    Public Function ChangeFileExt() As String
        ' Change file extension.
        Select Case ActionToTake
            Case CryptoAction.ActionEncrypt
                frmSecurityToolbox.OpenFileDialog1.FileName = ""
                frmSecurityToolbox.OpenFileDialog1.Title = "Choose a file to encrypt"
                frmSecurityToolbox.OpenFileDialog1.InitialDirectory = "C:\"
                frmSecurityToolbox.OpenFileDialog1.Filter = "All Files (*.*) | *.*"

                ' Find out if the user chose a file.
                If frmSecurityToolbox.OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    strTargetPath = frmSecurityToolbox.OpenFileDialog1.FileName
                    frmSecurityToolbox.txtTargetPath.Text = strTargetPath

                    Dim iPosition As Integer = 0
                    Dim i As Integer = 0

                    ' Get the position of the last "\" in the OpenFileDialog.FileName path.
                    ' Returns -1 when the character your searching for is absent.
                    ' IndexOf searches for left to right.
                    While strTargetPath.IndexOf("\"c, i) <> -1
                        iPosition = strTargetPath.IndexOf("\"c, i)
                        i = iPosition + 1
                    End While

                    ' Assign strOutputFile to the position after the last "\" in the path.
                    ' This position is the beginning of the file name.
                    strDestinationPath = strTargetPath.Substring(iPosition + 1)
                    ' Assign S the entire path, ending at the last "\".
                    Dim S As String = strTargetPath.Substring(0, iPosition + 1)
                    ' Replace the "." in the file extension with "_".
                    strDestinationPath = strDestinationPath.Replace("."c, "_"c)
                    ' The final file name. XXXX.encrypt
                    frmSecurityToolbox.txtDestinationPath.Text = S & strDestinationPath & ".encrypt"

                    Return S & strDestinationPath & ".encrypt"
                End If
            Case CryptoAction.ActionDecrypt
                frmSecurityToolbox.OpenFileDialog1.FileName = ""
                frmSecurityToolbox.OpenFileDialog1.Title = "Choose a file to decrypt"
                frmSecurityToolbox.OpenFileDialog1.InitialDirectory = "C:\"
                frmSecurityToolbox.OpenFileDialog1.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

                ' Find out if the user chose a file.
                If frmSecurityToolbox.OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    strTargetPath = frmSecurityToolbox.OpenFileDialog1.FileName
                    frmSecurityToolbox.txtTargetPath.Text = strTargetPath

                    Dim iPosition As Integer = 0
                    Dim i As Integer = 0

                    ' Get the position of the last "\" in the OpenFileDialog.FileName path.
                    ' Returns -1 when the character your searching for is absent.
                    ' IndexOf searches for left to right.
                    While strTargetPath.IndexOf("\"c, i) <> -1
                        iPosition = strTargetPath.IndexOf("\"c, i)
                        i = iPosition + 1
                    End While

                    ' Assign strOutputFile to the position after the last "\" in the path.
                    ' This position is the beginning of the file name.
                    strDestinationPath = strTargetPath.Substring(0, strTargetPath.Length - 8)
                    ' Assign S the entire path, ending at the last "\".
                    Dim S As String = strTargetPath.Substring(0, iPosition + 1)
                    ' Replace the "_" in the file extension with ".".
                    strDestinationPath = strDestinationPath.Substring((iPosition + 1))
                    frmSecurityToolbox.txtDestinationPath.Text = S & strDestinationPath.Replace("_"c, "."c)

                    Return S & strDestinationPath.Replace("_"c, "."c)
                End If
        End Select
        Return ""
    End Function

    Public Sub PerformAction()
        Dim bytKey As Byte()
        Dim bytIV As Byte()

        If frmSecurityToolbox.txtTargetPath.Text = "" Then
            ChangeFileExt()
        End If

        If frmSecurityToolbox.txtPassword1.Text = "" Or frmSecurityToolbox.txtPassword2.Text = "" Then
            If ActionToTake = CryptoAction.ActionEncrypt Then
                MsgBox("You must provide and confirm a password to encrypt the file!", vbOKOnly + vbCritical, "Password Required")
                Exit Sub
            Else
                MsgBox("You must provide and confirm the password used to encrypt the file!", vbOKOnly + vbCritical, "Password Required")
                Exit Sub
            End If
        End If

        If frmSecurityToolbox.txtPassword1.Text = frmSecurityToolbox.txtPassword2.Text Then
            bytKey = CreateKey(frmSecurityToolbox.txtPassword1.Text)
            bytIV = CreateIV(frmSecurityToolbox.txtPassword1.Text)
            If EncryptOrDecryptFile(strTargetPath, frmSecurityToolbox.txtDestinationPath.Text, bytKey, bytIV, ActionToTake) = False Then
                If ActionToTake = CryptoAction.ActionEncrypt Then
                    MsgBox("Encryption failed!", vbOKOnly + vbCritical, "Encryption Failed")
                    Exit Sub
                Else
                    MsgBox("Decryption failed!", vbOKOnly + vbCritical, "Decryption Failed")
                    Exit Sub
                End If
            End If
            frmSecurityToolbox.txtPassword1.Text = ""
            frmSecurityToolbox.txtPassword2.Text = ""
            If frmSecurityToolbox.chkDeleteFile.Checked = True Then
                My.Computer.FileSystem.DeleteFile(frmSecurityToolbox.txtTargetPath.Text)
            End If
            If ActionToTake = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption complete!", vbOKOnly, "Process Successful")
            Else
                MsgBox("Decryption complete!", vbOKOnly, "Successful Decryption")
            End If
        Else
            MsgBox("Your passwords don't match!", vbOKOnly + vbCritical, "Password Don't Match")
        End If

        frmSecurityToolbox.ResetEncryptionControls()
    End Sub
End Module
