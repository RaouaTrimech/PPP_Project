<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifStagiere
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Position = New System.Windows.Forms.GroupBox()
        Me.CompétenceTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Coordonnees_Perso = New System.Windows.Forms.GroupBox()
        Me.SexeComboBox = New System.Windows.Forms.ComboBox()
        Me.Numéro_de_téléphoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.Date_de_naissanceDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lieu_de_résidenceTextBox = New System.Windows.Forms.TextBox()
        Me.PrénomTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Position.SuspendLayout()
        Me.Coordonnees_Perso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Pristina", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(264, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(323, 58)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Modifier un Stagiére"
        '
        'Position
        '
        Me.Position.Controls.Add(Me.CompétenceTextBox)
        Me.Position.Controls.Add(Me.EmailTextBox1)
        Me.Position.Controls.Add(Me.Label3)
        Me.Position.Controls.Add(Me.Label4)
        Me.Position.Location = New System.Drawing.Point(66, 265)
        Me.Position.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Name = "Position"
        Me.Position.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Size = New System.Drawing.Size(752, 100)
        Me.Position.TabIndex = 27
        Me.Position.TabStop = False
        Me.Position.Text = "Position"
        '
        'CompétenceTextBox
        '
        Me.CompétenceTextBox.Location = New System.Drawing.Point(168, 31)
        Me.CompétenceTextBox.Name = "CompétenceTextBox"
        Me.CompétenceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CompétenceTextBox.TabIndex = 24
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.Location = New System.Drawing.Point(455, 29)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(265, 22)
        Me.EmailTextBox1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Compétence"
        '
        'Coordonnees_Perso
        '
        Me.Coordonnees_Perso.Controls.Add(Me.SexeComboBox)
        Me.Coordonnees_Perso.Controls.Add(Me.Numéro_de_téléphoneTextBox1)
        Me.Coordonnees_Perso.Controls.Add(Me.Date_de_naissanceDateTimePicker1)
        Me.Coordonnees_Perso.Controls.Add(Me.Lieu_de_résidenceTextBox)
        Me.Coordonnees_Perso.Controls.Add(Me.PrénomTextBox1)
        Me.Coordonnees_Perso.Controls.Add(Me.NomTextBox1)
        Me.Coordonnees_Perso.Controls.Add(Me.Label7)
        Me.Coordonnees_Perso.Controls.Add(Me.Label8)
        Me.Coordonnees_Perso.Controls.Add(Me.Label2)
        Me.Coordonnees_Perso.Controls.Add(Me.Label6)
        Me.Coordonnees_Perso.Controls.Add(Me.Label5)
        Me.Coordonnees_Perso.Controls.Add(Me.Label1)
        Me.Coordonnees_Perso.Location = New System.Drawing.Point(66, 157)
        Me.Coordonnees_Perso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Name = "Coordonnees_Perso"
        Me.Coordonnees_Perso.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Size = New System.Drawing.Size(752, 178)
        Me.Coordonnees_Perso.TabIndex = 26
        Me.Coordonnees_Perso.TabStop = False
        Me.Coordonnees_Perso.Text = "Coordonnées Personnelles"
        '
        'SexeComboBox
        '
        Me.SexeComboBox.DisplayMember = "sexe"
        Me.SexeComboBox.FormattingEnabled = True
        Me.SexeComboBox.Location = New System.Drawing.Point(82, 63)
        Me.SexeComboBox.Name = "SexeComboBox"
        Me.SexeComboBox.Size = New System.Drawing.Size(115, 24)
        Me.SexeComboBox.TabIndex = 24
        Me.SexeComboBox.ValueMember = "sexe"
        '
        'Numéro_de_téléphoneTextBox1
        '
        Me.Numéro_de_téléphoneTextBox1.Location = New System.Drawing.Point(582, 63)
        Me.Numéro_de_téléphoneTextBox1.Name = "Numéro_de_téléphoneTextBox1"
        Me.Numéro_de_téléphoneTextBox1.Size = New System.Drawing.Size(147, 22)
        Me.Numéro_de_téléphoneTextBox1.TabIndex = 24
        '
        'Date_de_naissanceDateTimePicker1
        '
        Me.Date_de_naissanceDateTimePicker1.Location = New System.Drawing.Point(328, 63)
        Me.Date_de_naissanceDateTimePicker1.Name = "Date_de_naissanceDateTimePicker1"
        Me.Date_de_naissanceDateTimePicker1.Size = New System.Drawing.Size(120, 22)
        Me.Date_de_naissanceDateTimePicker1.TabIndex = 24
        '
        'Lieu_de_résidenceTextBox
        '
        Me.Lieu_de_résidenceTextBox.Location = New System.Drawing.Point(582, 28)
        Me.Lieu_de_résidenceTextBox.Name = "Lieu_de_résidenceTextBox"
        Me.Lieu_de_résidenceTextBox.Size = New System.Drawing.Size(147, 22)
        Me.Lieu_de_résidenceTextBox.TabIndex = 24
        '
        'PrénomTextBox1
        '
        Me.PrénomTextBox1.Location = New System.Drawing.Point(328, 28)
        Me.PrénomTextBox1.Name = "PrénomTextBox1"
        Me.PrénomTextBox1.Size = New System.Drawing.Size(120, 22)
        Me.PrénomTextBox1.TabIndex = 24
        '
        'NomTextBox1
        '
        Me.NomTextBox1.Location = New System.Drawing.Point(84, 32)
        Me.NomTextBox1.Name = "NomTextBox1"
        Me.NomTextBox1.Size = New System.Drawing.Size(113, 22)
        Me.NomTextBox1.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(459, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Lieu de résidence"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Numéro de Tel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date de naissance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sexe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.PowderBlue
        Me.SaveButton.Location = New System.Drawing.Point(317, 384)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(211, 44)
        Me.SaveButton.TabIndex = 25
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ModifStagiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 521)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Coordonnees_Perso)
        Me.Controls.Add(Me.SaveButton)
        Me.Name = "ModifStagiere"
        Me.Text = "ModifStagiere"
        Me.Position.ResumeLayout(False)
        Me.Position.PerformLayout()
        Me.Coordonnees_Perso.ResumeLayout(False)
        Me.Coordonnees_Perso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Position As GroupBox
    Friend WithEvents CompétenceTextBox As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Coordonnees_Perso As GroupBox
    Friend WithEvents SexeComboBox As ComboBox
    Friend WithEvents Numéro_de_téléphoneTextBox1 As TextBox
    Friend WithEvents Date_de_naissanceDateTimePicker1 As DateTimePicker
    Friend WithEvents Lieu_de_résidenceTextBox As TextBox
    Friend WithEvents PrénomTextBox1 As TextBox
    Friend WithEvents NomTextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As Button
End Class
