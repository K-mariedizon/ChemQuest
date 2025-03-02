Public Class AboutForm

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim instructionsForm As New InstructionsForm()
        instructionsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub
End Class