Public Class Login
    Dim Tryout As Integer = 1
    Dim op As Integer
    Public Shared name, username As String
    Public Shared level As Integer


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenConnection() Then
            'MessageBox.Show("Success")
            accountSet()

        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Tryout < 3 Then
            op = 0
            For ctr = 0 To accountDataSet.Tables("accountTbl").Rows.Count - 1
                drow = accountDataSet.Tables("accountTbl").Rows(ctr)
                If drow("Uname") = txtUname.Text And drow("Pword") = txtPword.Text Then
                    'MessageBox.Show("Login Good")
                    name = drow("Nme")
                    username = drow("Uname")
                    level = drow("Lvl")

                    Dim dashboard As New dashboard
                    dashboard.Show
                    Hide


                    op = 1
                    Exit Sub
                End If

            Next
            If op = 0 Then
                MessageBox.Show("check your username and password", "Error", MessageBoxButtons.OK)
                Tryout += 1
            End If
        Else
            MessageBox.Show("maximum 3 tries only")
            Application.Exit

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New GuestLogin
        log.Show()
    End Sub
End Class