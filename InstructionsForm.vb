Public Class InstructionsForm

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainmenuForm As New btnPass()
        mainmenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub InstructionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutForm As New AboutForm()
        aboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass()
        mainmenuForm.Show()
        Me.Hide()
    End Sub
End Class