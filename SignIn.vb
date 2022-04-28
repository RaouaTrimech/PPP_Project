
Imports System.Data.OleDb

Public Class SignIn
    ReadOnly con As New OleDb.OleDbConnection(My.Settings.PPPConnectionString)

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click

        If CheckUsernameAndPassword(txtUsername.Text.Trim(), txtpassword.Text.Trim()) = True Then
            txtUsername.Text = ""
            txtpassword.Text = ""
            MsgBox("success de login")
            ListeStagieres.Show()
            Me.Hide()
        Else
            txtUsername.Text = ""
            txtpassword.Text = ""
            MsgBox("Echec de connection: wrong username or password")
        End If

    End Sub

    Private Sub BtnshowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles btnshowPassword.CheckedChanged
        If txtpassword.PasswordChar = "*" Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Public Function CheckUsernameAndPassword(ByVal UserName As String, ByVal Pass As String) As Boolean
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDb.OleDbCommand("select count(*) from compte_utilisateur WHERE username = ? and password = ? ", con)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = UserName
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Pass

        Dim count = Convert.ToInt32(cmd.ExecuteScalar())

        If (count > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class