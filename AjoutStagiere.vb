Public Class Ajout_Stagiere
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub StagiereBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StagiereBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StagiereBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PPPDataSet)

    End Sub

    Private Sub Ajout_Stagiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PPPDataSet.stagiere' table. You can move, or remove it, as needed.

        Me.StagiereTableAdapter.Fill(Me.PPPDataSet.stagiere)

    End Sub

    Private Sub Lieu_de_résidenceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Lieu_de_résidenceTextBox.TextChanged

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        On Error GoTo SaveErr

        StagiereBindingSource.EndEdit()
        StagiereTableAdapter.Update(PPPDataSet.stagiere)
        MessageBox.Show("Stagiere ajouté avec succes")

SaveErr: Exit Sub
    End Sub

    Private Sub Position_Enter(sender As Object, e As EventArgs) Handles Position.Enter

    End Sub

    Private Sub Coordonnees_Perso_Enter(sender As Object, e As EventArgs) Handles Coordonnees_Perso.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class