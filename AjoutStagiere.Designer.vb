<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Stagiere
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajout_Stagiere))
        Me.PPPDataSet = New PPP_Project.PPPDataSet()
        Me.StagiereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StagiereTableAdapter = New PPP_Project.PPPDataSetTableAdapters.stagiereTableAdapter()
        Me.TableAdapterManager = New PPP_Project.PPPDataSetTableAdapters.TableAdapterManager()
        Me.StagiereBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StagiereBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PPPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StagiereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StagiereBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StagiereBindingNavigator.SuspendLayout()
        Me.Position.SuspendLayout()
        Me.Coordonnees_Perso.SuspendLayout()
        Me.SuspendLayout()
        '
        'PPPDataSet
        '
        Me.PPPDataSet.DataSetName = "PPPDataSet"
        Me.PPPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StagiereBindingSource
        '
        Me.StagiereBindingSource.DataMember = "stagiere"
        Me.StagiereBindingSource.DataSource = Me.PPPDataSet
        '
        'StagiereTableAdapter
        '
        Me.StagiereTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.stagiereTableAdapter = Me.StagiereTableAdapter
        Me.TableAdapterManager.UpdateOrder = PPP_Project.PPPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StagiereBindingNavigator
        '
        Me.StagiereBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StagiereBindingNavigator.BindingSource = Me.StagiereBindingSource
        Me.StagiereBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StagiereBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StagiereBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StagiereBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StagiereBindingNavigatorSaveItem})
        Me.StagiereBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StagiereBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StagiereBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StagiereBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StagiereBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StagiereBindingNavigator.Name = "StagiereBindingNavigator"
        Me.StagiereBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StagiereBindingNavigator.Size = New System.Drawing.Size(1208, 27)
        Me.StagiereBindingNavigator.TabIndex = 2
        Me.StagiereBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StagiereBindingNavigatorSaveItem
        '
        Me.StagiereBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StagiereBindingNavigatorSaveItem.Image = CType(resources.GetObject("StagiereBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StagiereBindingNavigatorSaveItem.Name = "StagiereBindingNavigatorSaveItem"
        Me.StagiereBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.StagiereBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Position
        '
        Me.Position.Controls.Add(Me.CompétenceTextBox)
        Me.Position.Controls.Add(Me.EmailTextBox1)
        Me.Position.Controls.Add(Me.Label3)
        Me.Position.Controls.Add(Me.Label4)
        Me.Position.Location = New System.Drawing.Point(228, 273)
        Me.Position.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Name = "Position"
        Me.Position.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Position.Size = New System.Drawing.Size(752, 100)
        Me.Position.TabIndex = 23
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
        Me.Coordonnees_Perso.Location = New System.Drawing.Point(228, 165)
        Me.Coordonnees_Perso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Name = "Coordonnees_Perso"
        Me.Coordonnees_Perso.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Coordonnees_Perso.Size = New System.Drawing.Size(752, 178)
        Me.Coordonnees_Perso.TabIndex = 22
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
        Me.SaveButton.Location = New System.Drawing.Point(479, 392)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(211, 44)
        Me.SaveButton.TabIndex = 21
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Pristina", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(426, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(301, 58)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ajouter un Stagiére"
        '
        'Ajout_Stagiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 601)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Coordonnees_Perso)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.StagiereBindingNavigator)
        Me.Name = "Ajout_Stagiere"
        Me.Text = "Ajout_Stagiere"
        CType(Me.PPPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StagiereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StagiereBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StagiereBindingNavigator.ResumeLayout(False)
        Me.StagiereBindingNavigator.PerformLayout()
        Me.Position.ResumeLayout(False)
        Me.Position.PerformLayout()
        Me.Coordonnees_Perso.ResumeLayout(False)
        Me.Coordonnees_Perso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PPPDataSet As PPPDataSet
    Friend WithEvents StagiereBindingSource As BindingSource
    Friend WithEvents StagiereTableAdapter As PPPDataSetTableAdapters.stagiereTableAdapter
    Friend WithEvents TableAdapterManager As PPPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StagiereBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StagiereBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Position As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Coordonnees_Perso As GroupBox
    Friend WithEvents PrénomTextBox1 As TextBox
    Friend WithEvents NomTextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents Lieu_de_résidenceTextBox As TextBox
    Friend WithEvents CompétenceTextBox As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents SexeComboBox As ComboBox
    Friend WithEvents Numéro_de_téléphoneTextBox1 As TextBox
    Friend WithEvents Date_de_naissanceDateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
