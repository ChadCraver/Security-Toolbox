<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecurityToolbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecurityToolbox))
        Me.tabEncryption = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpEncryptionAction = New System.Windows.Forms.GroupBox()
        Me.radDecrypt = New System.Windows.Forms.RadioButton()
        Me.radEncrypt = New System.Windows.Forms.RadioButton()
        Me.grpEncryptionControls = New System.Windows.Forms.GroupBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtDestinationPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtTargetPath = New System.Windows.Forms.TextBox()
        Me.btnPerformAction = New System.Windows.Forms.Button()
        Me.chkDeleteFile = New System.Windows.Forms.CheckBox()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.lblPassword1 = New System.Windows.Forms.Label()
        Me.lblDestinationPath = New System.Windows.Forms.Label()
        Me.lblTargetPath = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.chkSpecialCharacters = New System.Windows.Forms.CheckBox()
        Me.chkNumbers = New System.Windows.Forms.CheckBox()
        Me.chkLowerLetters = New System.Windows.Forms.CheckBox()
        Me.chkCapitalLetters = New System.Windows.Forms.CheckBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.trackPasswordLength = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tabEncryption.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpEncryptionAction.SuspendLayout()
        Me.grpEncryptionControls.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.trackPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabEncryption
        '
        Me.tabEncryption.Controls.Add(Me.TabPage1)
        Me.tabEncryption.Controls.Add(Me.TabPage2)
        Me.tabEncryption.Location = New System.Drawing.Point(5, 3)
        Me.tabEncryption.Name = "tabEncryption"
        Me.tabEncryption.SelectedIndex = 0
        Me.tabEncryption.Size = New System.Drawing.Size(411, 250)
        Me.tabEncryption.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.grpEncryptionAction)
        Me.TabPage1.Controls.Add(Me.grpEncryptionControls)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(403, 224)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encryption"
        '
        'grpEncryptionAction
        '
        Me.grpEncryptionAction.Controls.Add(Me.radDecrypt)
        Me.grpEncryptionAction.Controls.Add(Me.radEncrypt)
        Me.grpEncryptionAction.Location = New System.Drawing.Point(6, 6)
        Me.grpEncryptionAction.Name = "grpEncryptionAction"
        Me.grpEncryptionAction.Size = New System.Drawing.Size(388, 39)
        Me.grpEncryptionAction.TabIndex = 2
        Me.grpEncryptionAction.TabStop = False
        Me.grpEncryptionAction.Text = "Action to Take"
        '
        'radDecrypt
        '
        Me.radDecrypt.AutoSize = True
        Me.radDecrypt.Location = New System.Drawing.Point(197, 16)
        Me.radDecrypt.Name = "radDecrypt"
        Me.radDecrypt.Size = New System.Drawing.Size(62, 17)
        Me.radDecrypt.TabIndex = 2
        Me.radDecrypt.Text = "Decrypt"
        Me.radDecrypt.UseVisualStyleBackColor = True
        '
        'radEncrypt
        '
        Me.radEncrypt.AutoSize = True
        Me.radEncrypt.Checked = True
        Me.radEncrypt.Location = New System.Drawing.Point(130, 16)
        Me.radEncrypt.Name = "radEncrypt"
        Me.radEncrypt.Size = New System.Drawing.Size(61, 17)
        Me.radEncrypt.TabIndex = 1
        Me.radEncrypt.TabStop = True
        Me.radEncrypt.Text = "Encrypt"
        Me.radEncrypt.UseVisualStyleBackColor = True
        '
        'grpEncryptionControls
        '
        Me.grpEncryptionControls.Controls.Add(Me.txtPassword2)
        Me.grpEncryptionControls.Controls.Add(Me.txtPassword1)
        Me.grpEncryptionControls.Controls.Add(Me.txtDestinationPath)
        Me.grpEncryptionControls.Controls.Add(Me.btnBrowse)
        Me.grpEncryptionControls.Controls.Add(Me.txtTargetPath)
        Me.grpEncryptionControls.Controls.Add(Me.btnPerformAction)
        Me.grpEncryptionControls.Controls.Add(Me.chkDeleteFile)
        Me.grpEncryptionControls.Controls.Add(Me.lblPassword2)
        Me.grpEncryptionControls.Controls.Add(Me.lblPassword1)
        Me.grpEncryptionControls.Controls.Add(Me.lblDestinationPath)
        Me.grpEncryptionControls.Controls.Add(Me.lblTargetPath)
        Me.grpEncryptionControls.Location = New System.Drawing.Point(6, 51)
        Me.grpEncryptionControls.Name = "grpEncryptionControls"
        Me.grpEncryptionControls.Size = New System.Drawing.Size(388, 168)
        Me.grpEncryptionControls.TabIndex = 0
        Me.grpEncryptionControls.TabStop = False
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(108, 91)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(271, 20)
        Me.txtPassword2.TabIndex = 7
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(108, 65)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(271, 20)
        Me.txtPassword1.TabIndex = 6
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.Enabled = False
        Me.txtDestinationPath.Location = New System.Drawing.Point(108, 39)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(271, 20)
        Me.txtDestinationPath.TabIndex = 5
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(304, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtTargetPath
        '
        Me.txtTargetPath.Enabled = False
        Me.txtTargetPath.Location = New System.Drawing.Point(108, 13)
        Me.txtTargetPath.Name = "txtTargetPath"
        Me.txtTargetPath.Size = New System.Drawing.Size(190, 20)
        Me.txtTargetPath.TabIndex = 3
        '
        'btnPerformAction
        '
        Me.btnPerformAction.Location = New System.Drawing.Point(304, 135)
        Me.btnPerformAction.Name = "btnPerformAction"
        Me.btnPerformAction.Size = New System.Drawing.Size(75, 23)
        Me.btnPerformAction.TabIndex = 9
        Me.btnPerformAction.Text = "Encrypt"
        Me.btnPerformAction.UseVisualStyleBackColor = True
        '
        'chkDeleteFile
        '
        Me.chkDeleteFile.AutoSize = True
        Me.chkDeleteFile.Checked = True
        Me.chkDeleteFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDeleteFile.Location = New System.Drawing.Point(10, 141)
        Me.chkDeleteFile.Name = "chkDeleteFile"
        Me.chkDeleteFile.Size = New System.Drawing.Size(112, 17)
        Me.chkDeleteFile.TabIndex = 8
        Me.chkDeleteFile.Text = "Delete original file."
        Me.chkDeleteFile.UseVisualStyleBackColor = True
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(8, 98)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(94, 13)
        Me.lblPassword2.TabIndex = 0
        Me.lblPassword2.Text = "Confirm Password:"
        '
        'lblPassword1
        '
        Me.lblPassword1.AutoSize = True
        Me.lblPassword1.Location = New System.Drawing.Point(8, 72)
        Me.lblPassword1.Name = "lblPassword1"
        Me.lblPassword1.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword1.TabIndex = 0
        Me.lblPassword1.Text = "Password:"
        '
        'lblDestinationPath
        '
        Me.lblDestinationPath.AutoSize = True
        Me.lblDestinationPath.Location = New System.Drawing.Point(8, 46)
        Me.lblDestinationPath.Name = "lblDestinationPath"
        Me.lblDestinationPath.Size = New System.Drawing.Size(88, 13)
        Me.lblDestinationPath.TabIndex = 0
        Me.lblDestinationPath.Text = "Destination Path:"
        '
        'lblTargetPath
        '
        Me.lblTargetPath.AutoSize = True
        Me.lblTargetPath.Location = New System.Drawing.Point(7, 20)
        Me.lblTargetPath.Name = "lblTargetPath"
        Me.lblTargetPath.Size = New System.Drawing.Size(66, 13)
        Me.lblTargetPath.TabIndex = 0
        Me.lblTargetPath.Text = "Target Path:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.lblStrength)
        Me.TabPage2.Controls.Add(Me.lblLength)
        Me.TabPage2.Controls.Add(Me.chkSpecialCharacters)
        Me.TabPage2.Controls.Add(Me.chkNumbers)
        Me.TabPage2.Controls.Add(Me.chkLowerLetters)
        Me.TabPage2.Controls.Add(Me.chkCapitalLetters)
        Me.TabPage2.Controls.Add(Me.txtNewPassword)
        Me.TabPage2.Controls.Add(Me.trackPasswordLength)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(403, 224)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Password Generator"
        '
        'lblStrength
        '
        Me.lblStrength.Location = New System.Drawing.Point(37, 163)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(335, 18)
        Me.lblStrength.TabIndex = 3
        Me.lblStrength.Text = "Label1"
        '
        'lblLength
        '
        Me.lblLength.Location = New System.Drawing.Point(37, 145)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(335, 18)
        Me.lblLength.TabIndex = 3
        Me.lblLength.Text = "Label1"
        '
        'chkSpecialCharacters
        '
        Me.chkSpecialCharacters.AutoSize = True
        Me.chkSpecialCharacters.Checked = True
        Me.chkSpecialCharacters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSpecialCharacters.Location = New System.Drawing.Point(325, 112)
        Me.chkSpecialCharacters.Name = "chkSpecialCharacters"
        Me.chkSpecialCharacters.Size = New System.Drawing.Size(47, 17)
        Me.chkSpecialCharacters.TabIndex = 2
        Me.chkSpecialCharacters.Text = "!@#"
        Me.chkSpecialCharacters.UseVisualStyleBackColor = True
        '
        'chkNumbers
        '
        Me.chkNumbers.AutoSize = True
        Me.chkNumbers.Checked = True
        Me.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNumbers.Location = New System.Drawing.Point(230, 112)
        Me.chkNumbers.Name = "chkNumbers"
        Me.chkNumbers.Size = New System.Drawing.Size(44, 17)
        Me.chkNumbers.TabIndex = 2
        Me.chkNumbers.Text = "123"
        Me.chkNumbers.UseVisualStyleBackColor = True
        '
        'chkLowerLetters
        '
        Me.chkLowerLetters.AutoSize = True
        Me.chkLowerLetters.Checked = True
        Me.chkLowerLetters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLowerLetters.Location = New System.Drawing.Point(135, 112)
        Me.chkLowerLetters.Name = "chkLowerLetters"
        Me.chkLowerLetters.Size = New System.Drawing.Size(44, 17)
        Me.chkLowerLetters.TabIndex = 2
        Me.chkLowerLetters.Text = "abc"
        Me.chkLowerLetters.UseVisualStyleBackColor = True
        '
        'chkCapitalLetters
        '
        Me.chkCapitalLetters.AutoSize = True
        Me.chkCapitalLetters.Checked = True
        Me.chkCapitalLetters.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCapitalLetters.Location = New System.Drawing.Point(37, 112)
        Me.chkCapitalLetters.Name = "chkCapitalLetters"
        Me.chkCapitalLetters.Size = New System.Drawing.Size(47, 17)
        Me.chkCapitalLetters.TabIndex = 2
        Me.chkCapitalLetters.Text = "ABC"
        Me.chkCapitalLetters.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(41, 26)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(321, 20)
        Me.txtNewPassword.TabIndex = 1
        '
        'trackPasswordLength
        '
        Me.trackPasswordLength.Location = New System.Drawing.Point(55, 61)
        Me.trackPasswordLength.Maximum = 50
        Me.trackPasswordLength.Minimum = 12
        Me.trackPasswordLength.Name = "trackPasswordLength"
        Me.trackPasswordLength.Size = New System.Drawing.Size(287, 45)
        Me.trackPasswordLength.TabIndex = 0
        Me.trackPasswordLength.TickFrequency = 8
        Me.trackPasswordLength.Value = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSecurityToolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 255)
        Me.Controls.Add(Me.tabEncryption)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSecurityToolbox"
        Me.Text = "Security Toolbox"
        Me.tabEncryption.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpEncryptionAction.ResumeLayout(False)
        Me.grpEncryptionAction.PerformLayout()
        Me.grpEncryptionControls.ResumeLayout(False)
        Me.grpEncryptionControls.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.trackPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabEncryption As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grpEncryptionAction As GroupBox
    Friend WithEvents radDecrypt As RadioButton
    Friend WithEvents radEncrypt As RadioButton
    Friend WithEvents grpEncryptionControls As GroupBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents txtDestinationPath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtTargetPath As TextBox
    Friend WithEvents btnPerformAction As Button
    Friend WithEvents chkDeleteFile As CheckBox
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblPassword1 As Label
    Friend WithEvents lblDestinationPath As Label
    Friend WithEvents lblTargetPath As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chkSpecialCharacters As CheckBox
    Friend WithEvents chkNumbers As CheckBox
    Friend WithEvents chkLowerLetters As CheckBox
    Friend WithEvents chkCapitalLetters As CheckBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents trackPasswordLength As TrackBar
    Friend WithEvents lblStrength As Label
    Friend WithEvents lblLength As Label
End Class
