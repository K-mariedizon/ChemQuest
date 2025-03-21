Public Class GuestLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname As String = txtUname.Text
        Dim pword As String = txtPword.Text

        If String.IsNullOrWhiteSpace(uname) OrElse String.IsNullOrWhiteSpace(pword) Then
            MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If AuthenticateGuest(uname, pword) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            btnPass.Show() ' Open guest access form
        Else
            MessageBox.Show("Invalid login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GuestLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
