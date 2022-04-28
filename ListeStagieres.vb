Imports System.Text

Public Class ListeStagieres
    Dim identif As String

    Private Sub StagiereBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StagiereBindingSource.EndEdit()
        Me.Compte_utilisateurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PPPDataSet)

    End Sub

    Private Sub ListeStagieres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PPPDataSet.stagiere' table. You can move, or remove it, as needed.
        Me.StagiereTableAdapter.Fill(Me.PPPDataSet.stagiere)

    End Sub

    Private Sub ButtonAjout_Click(sender As Object, e As EventArgs) Handles ButtonAjout.Click
        StagiereBindingSource.AddNew()
        Compte_utilisateurBindingSource.AddNew()
        txtPassword.Text = Gen(15)
        identif = "_" + Gen(2)
    End Sub

    Private Sub ButtonSupp_Click(sender As Object, e As EventArgs) Handles ButtonSupp.Click
        StagiereBindingSource.RemoveCurrent()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        On Error GoTo SaveErr
        txtUsername.Text = NomTextBox1.Text + "_" + PrénomTextBox1.Text + identif
        StagiereBindingSource.Current.Row(9) = Compte_utilisateurBindingSource.Current.Row(0)
        StagiereBindingSource.EndEdit()
        Compte_utilisateurBindingSource.EndEdit()
        StagiereTableAdapter.Update(PPPDataSet.stagiere)
        Compte_utilisateurTableAdapter.Update(PPPDataSet.compte_utilisateur)
        MessageBox.Show("Stagiere ajouté avec succes")

SaveErr: Exit Sub
    End Sub

    Function Gen(ByVal i As Integer)
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz+_)(*&^%$#@!-={}][':;?><,./\|"
        Dim producer As New Random
        Dim collector As New StringBuilder
        For counter As Integer = 1 To i
            Dim supplier As Integer = producer.Next(0, characters.Length)
            collector.Append(characters.Substring(supplier, 1))
        Next
        Return collector.ToString()
    End Function

End Class
