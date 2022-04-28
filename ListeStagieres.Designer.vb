<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeStagieres
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.StagiereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PPPDataSet = New PPP_Project.PPPDataSet()
        Me.StagiereDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.ButtonSupp = New System.Windows.Forms.Button()
        Me.StagiereTableAdapter = New PPP_Project.PPPDataSetTableAdapters.stagiereTableAdapter()
        Me.TableAdapterManager = New PPP_Project.PPPDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Compte_utilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Compte_utilisateurTableAdapter = New PPP_Project.PPPDataSetTableAdapters.compte_utilisateurTableAdapter()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.StagiereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PPPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StagiereDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Position.SuspendLayout()
        Me.Coordonnees_Perso.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Compte_utilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StagiereBindingSource
        '
        Me.StagiereBindingSource.DataMember = "stagiere"
        Me.StagiereBindingSource.DataSource = Me.PPPDataSet
        '
        'PPPDataSet
        '
        Me.PPPDataSet.DataSetName = "PPPDataSet"
        Me.PPPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StagiereDataGridView
        '
        Me.StagiereDataGridView.AllowDrop = True
        Me.StagiereDataGridView.AllowUserToOrderColumns = True
        Me.StagiereDataGridView.AutoGenerateColumns = False
        Me.StagiereDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StagiereDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.StagiereDataGridView.DataSource = Me.StagiereBindingSource
        Me.StagiereDataGridView.Location = New System.Drawing.Point(24, 86)
        Me.StagiereDataGridView.Name = "StagiereDataGridView"
        Me.StagiereDataGridView.RowHeadersWidth = 51
        Me.StagiereDataGridView.RowTemplate.Height = 24
        Me.StagiereDataGridView.Size = New System.Drawing.Size(749, 505)
        Me.StagiereDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prénom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prénom"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lieu de résidence"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lieu de résidence"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date de naissance"
        Me.DataGridViewTextBoxColumn5.HeaderText = "date de naissance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sexe"
        Me.DataGridViewTextBoxColumn6.HeaderText = "sexe"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "numéro de téléphone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "numéro de téléphone"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "compétence"
        Me.DataGridViewTextBoxColumn9.HeaderText = "compétence"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'ButtonAjout
        '
        Me.ButtonAjout.BackColor = System.Drawing.Color.PowderBlue
        Me.ButtonAjout.Location = New System.Drawing.Point(42, 502)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(197, 50)
        Me.ButtonAjout.TabIndex = 2
        Me.ButtonAjout.Text = "Ajouter"
        Me.ButtonAjout.UseVisualStyleBackColor = False
        '
        'ButtonModif
        '
        Me.ButtonModif.BackColor = System.Drawing.Color.PowderBlue
        Me.ButtonModif.Location = New System.Drawing.Point(287, 502)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(197, 50)
        Me.ButtonModif.TabIndex = 3
        Me.ButtonModif.Text = "Modifier"
        Me.ButtonModif.UseVisualStyleBackColor = False
        '
        'ButtonSupp
        '
        Me.ButtonSupp.BackColor = System.Drawing.Color.PowderBlue
        Me.ButtonSupp.Location = New System.Drawing.Point(536, 502)
        Me.ButtonSupp.Name = "ButtonSupp"
        Me.ButtonSupp.Size = New System.Drawing.Size(197, 50)
        Me.ButtonSupp.TabIndex = 4
        Me.ButtonSupp.Text = "Supprimer"
        Me.ButtonSupp.UseVisualStyleBackColor = False
        '
        'StagiereTableAdapter
        '
        Me.StagiereTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.compte_utilisateurTableAdapter = Nothing
        Me.TableAdapterManager.stagiereTableAdapter = Me.StagiereTableAdapter
        Me.TableAdapterManager.UpdateOrder = PPP_Project.PPPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Position)
        Me.GroupBox1.Controls.Add(Me.ButtonSupp)
        Me.GroupBox1.Controls.Add(Me.Coordonnees_Perso)
        Me.GroupBox1.Controls.Add(Me.ButtonModif)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.ButtonAjout)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 609)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametres"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Pristina", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(151, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(435, 57)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Modifier/Ajouter un Stagiére"
        '
        'Position
        '
        Me.Position.Controls.Add(PasswordLabel)
        Me.Position.Controls.Add(Me.txtPassword)
        Me.Position.Controls.Add(UsernameLabel)
        Me.Position.Controls.Add(Me.txtUsername)
        Me.Position.Controls.Add(Me.CompétenceTextBox)
        Me.Position.Controls.Add(Me.EmailTextBox1)
        Me.Position.Controls.Add(Me.Label3)
        Me.Position.Controls.Add(Me.Label4)
        Me.Position.Location = New System.Drawing.Point(12, 236)
        Me.Position.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Name = "Position"
        Me.Position.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Size = New System.Drawing.Size(752, 146)
        Me.Position.TabIndex = 26
        Me.Position.TabStop = False
        Me.Position.Text = "Position"
        '
        'CompétenceTextBox
        '
        Me.CompétenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "compétence", True))
        Me.CompétenceTextBox.Location = New System.Drawing.Point(168, 31)
        Me.CompétenceTextBox.Name = "CompétenceTextBox"
        Me.CompétenceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CompétenceTextBox.TabIndex = 24
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "email", True))
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
        Me.Coordonnees_Perso.Location = New System.Drawing.Point(12, 128)
        Me.Coordonnees_Perso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Name = "Coordonnees_Perso"
        Me.Coordonnees_Perso.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Size = New System.Drawing.Size(752, 178)
        Me.Coordonnees_Perso.TabIndex = 25
        Me.Coordonnees_Perso.TabStop = False
        Me.Coordonnees_Perso.Text = "Coordonnées Personnelles"
        '
        'SexeComboBox
        '
        Me.SexeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "sexe", True))
        Me.SexeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StagiereBindingSource, "sexe", True))
        Me.SexeComboBox.DataSource = Me.StagiereBindingSource
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
        Me.Numéro_de_téléphoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "numéro de téléphone", True))
        Me.Numéro_de_téléphoneTextBox1.Location = New System.Drawing.Point(582, 63)
        Me.Numéro_de_téléphoneTextBox1.Name = "Numéro_de_téléphoneTextBox1"
        Me.Numéro_de_téléphoneTextBox1.Size = New System.Drawing.Size(147, 22)
        Me.Numéro_de_téléphoneTextBox1.TabIndex = 24
        '
        'Date_de_naissanceDateTimePicker1
        '
        Me.Date_de_naissanceDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StagiereBindingSource, "date de naissance", True))
        Me.Date_de_naissanceDateTimePicker1.Location = New System.Drawing.Point(331, 61)
        Me.Date_de_naissanceDateTimePicker1.Name = "Date_de_naissanceDateTimePicker1"
        Me.Date_de_naissanceDateTimePicker1.Size = New System.Drawing.Size(120, 22)
        Me.Date_de_naissanceDateTimePicker1.TabIndex = 24
        '
        'Lieu_de_résidenceTextBox
        '
        Me.Lieu_de_résidenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "lieu de résidence", True))
        Me.Lieu_de_résidenceTextBox.Location = New System.Drawing.Point(582, 28)
        Me.Lieu_de_résidenceTextBox.Name = "Lieu_de_résidenceTextBox"
        Me.Lieu_de_résidenceTextBox.Size = New System.Drawing.Size(147, 22)
        Me.Lieu_de_résidenceTextBox.TabIndex = 24
        '
        'PrénomTextBox1
        '
        Me.PrénomTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "prénom", True))
        Me.PrénomTextBox1.Location = New System.Drawing.Point(328, 28)
        Me.PrénomTextBox1.Name = "PrénomTextBox1"
        Me.PrénomTextBox1.Size = New System.Drawing.Size(120, 22)
        Me.PrénomTextBox1.TabIndex = 24
        '
        'NomTextBox1
        '
        Me.NomTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StagiereBindingSource, "nom", True))
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
        Me.SaveButton.Location = New System.Drawing.Point(284, 402)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(211, 44)
        Me.SaveButton.TabIndex = 24
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.StagiereDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(827, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(779, 609)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste de stagieres"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Pristina", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(279, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 57)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Liste de Stagiéres"
        '
        'Compte_utilisateurBindingSource
        '
        Me.Compte_utilisateurBindingSource.DataMember = "compte_utilisateur"
        Me.Compte_utilisateurBindingSource.DataSource = Me.PPPDataSet
        '
        'Compte_utilisateurTableAdapter
        '
        Me.Compte_utilisateurTableAdapter.ClearBeforeFill = True
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(21, 93)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(70, 16)
        UsernameLabel.TabIndex = 24
        UsernameLabel.Text = "username:"
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compte_utilisateurBindingSource, "username", True))
        Me.txtUsername.Location = New System.Drawing.Point(121, 87)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(147, 22)
        Me.txtUsername.TabIndex = 25
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(365, 93)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(69, 16)
        PasswordLabel.TabIndex = 25
        PasswordLabel.Text = "password:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compte_utilisateurBindingSource, "password", True))
        Me.txtPassword.Location = New System.Drawing.Point(455, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(265, 22)
        Me.txtPassword.TabIndex = 26
        '
        'ListeStagieres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1636, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ListeStagieres"
        Me.Text = "ListeStagieres"
        CType(Me.StagiereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Compte_utilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PPPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StagiereDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Position.ResumeLayout(False)
        Me.Position.PerformLayout()
        Me.Coordonnees_Perso.ResumeLayout(False)
        Me.Coordonnees_Perso.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PPPDataSet As PPPDataSet
    Friend WithEvents StagiereBindingSource As BindingSource
    Friend WithEvents StagiereTableAdapter As PPPDataSetTableAdapters.stagiereTableAdapter
    Friend WithEvents TableAdapterManager As PPPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StagiereDataGridView As DataGridView
    Friend WithEvents ButtonAjout As Button
    Friend WithEvents ButtonModif As Button
    Friend WithEvents ButtonSupp As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Compte_utilisateurBindingSource As BindingSource
    Friend WithEvents Compte_utilisateurTableAdapter As PPPDataSetTableAdapters.compte_utilisateurTableAdapter
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
End Class
