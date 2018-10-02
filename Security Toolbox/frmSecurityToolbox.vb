Public Class frmSecurityToolbox
    Public IsLoaded As Boolean
    ' Begin encryption routines.

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles radEncrypt.CheckedChanged, radDecrypt.CheckedChanged
        Dim rad As RadioButton = sender

        If rad.Text = "Encrypt" Then
            btnPerformAction.Text = "Encrypt"
            ActionToTake = CryptoAction.ActionEncrypt
        Else
            btnPerformAction.Text = "Decrypt"
            ActionToTake = CryptoAction.ActionDecrypt
        End If
    End Sub

    Private Sub btnPerformAction_Click(sender As Object, e As EventArgs) Handles btnPerformAction.Click
        PerformAction()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ChangeFileExt()
    End Sub

    Public Sub ResetEncryptionControls()
        txtTargetPath.Text = ""
        txtDestinationPath.Text = ""
        txtPassword1.Text = ""
        txtPassword2.Text = ""
        chkDeleteFile.Checked = True
    End Sub

    Private Sub frmSecurityToolbox_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        IsLoaded = True

        Dim intLength As Integer = trackPasswordLength.Value
        PasswordGenerator.Generate(intLength)

        If radEncrypt.Checked Then
            btnPerformAction.Text = "Encrypt"
            ActionToTake = CryptoAction.ActionEncrypt
        Else
            btnPerformAction.Text = "Decrypt"
            ActionToTake = CryptoAction.ActionDecrypt
        End If
    End Sub

    ' End encryption routines.

    Private Sub trackPasswordLength_ValueChanged(sender As Object, e As EventArgs) Handles trackPasswordLength.ValueChanged
        Dim intLength As Integer = trackPasswordLength.Value
        PasswordGenerator.Generate(intLength)
    End Sub

    Private Sub PasswordOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkCapitalLetters.CheckedChanged, chkLowerLetters.CheckedChanged, chkNumbers.CheckedChanged, chkSpecialCharacters.CheckedChanged
        If IsLoaded Then
            Dim intLength As Integer = trackPasswordLength.Value
            PasswordGenerator.Generate(intLength)
        End If
    End Sub
End Class
