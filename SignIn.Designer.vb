<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.SignInLabel = New System.Windows.Forms.Label()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.btnshowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(151, 179)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(79, 16)
        Me.username.TabIndex = 0
        Me.username.Text = "Username : "
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(151, 230)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(73, 16)
        Me.Password.TabIndex = 1
        Me.Password.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(259, 179)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(353, 22)
        Me.txtUsername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(259, 230)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(353, 22)
        Me.txtpassword.TabIndex = 3
        '
        'SignInLabel
        '
        Me.SignInLabel.AutoSize = True
        Me.SignInLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignInLabel.Font = New System.Drawing.Font("Pristina", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLabel.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.SignInLabel.Location = New System.Drawing.Point(284, 68)
        Me.SignInLabel.Name = "SignInLabel"
        Me.SignInLabel.Size = New System.Drawing.Size(198, 57)
        Me.SignInLabel.TabIndex = 31
        Me.SignInLabel.Text = "--Sign In--"
        '
        'SignUpButton
        '
        Me.SignUpButton.BackColor = System.Drawing.Color.PowderBlue
        Me.SignUpButton.Location = New System.Drawing.Point(287, 310)
        Me.SignUpButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(211, 44)
        Me.SignUpButton.TabIndex = 32
        Me.SignUpButton.Text = "log in "
        Me.SignUpButton.UseVisualStyleBackColor = False
        '
        'btnshowPassword
        '
        Me.btnshowPassword.AutoSize = True
        Me.btnshowPassword.Location = New System.Drawing.Point(259, 269)
        Me.btnshowPassword.Name = "btnshowPassword"
        Me.btnshowPassword.Size = New System.Drawing.Size(122, 20)
        Me.btnshowPassword.TabIndex = 33
        Me.btnshowPassword.Text = "show password"
        Me.btnshowPassword.UseVisualStyleBackColor = True
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshowPassword)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.SignInLabel)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.username)
        Me.Name = "SignIn"
        Me.Text = "SignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As Label
    Friend WithEvents Password As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents SignInLabel As Label
    Friend WithEvents SignUpButton As Button
    Friend WithEvents btnshowPassword As CheckBox
End Class
