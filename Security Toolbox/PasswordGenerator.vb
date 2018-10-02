Module PasswordGenerator
    Public Generator As System.Random

    Private Enum CharType
        Number = 1
        Letter = 2
        SpecialChar = 3
    End Enum

    Public Sub Generate(ByVal Length As Integer)
        Dim strNewPassword As String = GeneratePassword(Length)
        frmSecurityToolbox.txtNewPassword.Text = strNewPassword
        frmSecurityToolbox.lblLength.Text = $"Password Length: {Len(strNewPassword)}"
        Select Case CheckPasswordStrength(strNewPassword)
            Case 0
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: No Password"
                frmSecurityToolbox.lblStrength.ForeColor = Color.Black
            Case 1
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: Very Weak"
                frmSecurityToolbox.lblStrength.ForeColor = Color.Red
            Case 2
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: Weak"
                frmSecurityToolbox.lblStrength.ForeColor = Color.Orange
            Case 3
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: Moderate"
                frmSecurityToolbox.lblStrength.ForeColor = Color.Gold
            Case 4
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: Strong"
                frmSecurityToolbox.lblStrength.ForeColor = Color.Green
            Case 5
                frmSecurityToolbox.lblStrength.Text = $"Password Strength: Very Strong"
                frmSecurityToolbox.lblStrength.ForeColor = Color.DarkGreen
        End Select
    End Sub

    Private Function GeneratePassword(ByVal Length As Integer) As String
        Dim outputPassword As String = ""
        Dim strNewChar As Char = ""
        Generator = New System.Random

        For i = 1 To Length
            outputPassword &= GetRandomChar()
        Next

        Return outputPassword
    End Function

    Private Function GetRandomChar() As String
        Dim intRandom As Integer = Generator.Next(1, 5)
        Dim blnCapital As Boolean = frmSecurityToolbox.chkCapitalLetters.Checked
        Dim blnLower As Boolean = frmSecurityToolbox.chkLowerLetters.Checked
        Dim blnNumbers As Boolean = frmSecurityToolbox.chkNumbers.Checked
        Dim blnSpecial As Boolean = frmSecurityToolbox.chkSpecialCharacters.Checked
        Dim Letters() As String

        If Not blnCapital And Not blnLower And Not blnNumbers And Not blnSpecial Then Return ""

Reset:
        Select Case True
            Case blnNumbers And intRandom = 1
                Dim Numbers() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
                intRandom = Generator.Next(0, Numbers.Length)
                Return Numbers(intRandom)
            Case blnLower And intRandom = 2
                Letters = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
                intRandom = Generator.Next(0, Letters.Length)
                Return Letters(intRandom)
            Case blnCapital And intRandom = 3
                Letters = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
                intRandom = Generator.Next(0, Letters.Length)
                Return Letters(intRandom)
            Case blnSpecial And intRandom = 4
                Dim SpecialChars() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "`", "~", "[", "]", "{", "}", ":", ";", "?", ".", ",", "\", "/", "|", "<", ">"}
                intRandom = Generator.Next(0, SpecialChars.Length)
                Return SpecialChars(intRandom)
            Case Else
                intRandom = Generator.Next(1, 5)
                GoTo Reset
        End Select

        Return ""
    End Function

    Private Function CheckPasswordStrength(ByVal Password As String) As Integer
        Dim intStrength As Integer = 0
        Dim arrPassword() As Char = Password.ToCharArray
        Dim ContainsSpecialChar As Boolean = False
        Dim ContainsNumber As Boolean = False
        Dim ContainsLowerChar As Boolean = False
        Dim ContainsUpperChar As Boolean = False
        Dim Numbers() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim LCaseLetters() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim UCaseLetters() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim SpecialChars() As String = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "`", "~", "[", "]", "{", "}", ":", ";", "?", ".", ",", "\", "/", "|", "<", ">"}

        For X = 0 To arrPassword.Length - 1
            ' Check if password contains a number.
            If Numbers.Contains(arrPassword(X)) Then
                ContainsNumber = True
            End If
            ' Check if password contains a special character.
            If SpecialChars.Contains(arrPassword(X)) Then
                ContainsSpecialChar = True
            End If
            ' Check if password contains a lowercase character.
            If LCaseLetters.Contains(arrPassword(X)) Then
                ContainsLowerChar = True
            End If
            ' Check if password contains an uppercase character.
            If UCaseLetters.Contains(arrPassword(X)) Then
                ContainsUpperChar = True
            End If
        Next

        If ContainsNumber Then intStrength += 1
        If ContainsSpecialChar Then intStrength += 1
        If ContainsLowerChar Then intStrength += 1
        If ContainsUpperChar Then intStrength += 1
        If Len(Password) >= 12 Then intStrength += 1
        If Len(Password) >= 25 Then intStrength = 5

        Return intStrength
    End Function
End Module
