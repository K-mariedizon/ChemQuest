Public Class Game1
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1()
        mainmenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnGame1_Click(sender As Object, e As EventArgs) Handles btnGame1.Click
        Dim game As New Game1
        game.Show
        Hide
    End Sub

    Private Sub btnGame2_Click(sender As Object, e As EventArgs) Handles btnGame2.Click
        Dim game As New Game2()
        game.Show()
        Me.Hide()
    End Sub

    Private Sub btnGame3_Click(sender As Object, e As EventArgs) Handles btnGame3.Click
        Dim game As New Game3()
        game.Show()
        Me.Hide()
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        Dim game As New MiniGamesForm()
        game.Show()
        Me.Hide()
    End Sub

    Private Sub btnReviewer_Click(sender As Object, e As EventArgs) Handles btnReviewer.Click
        Dim reviewerForm As New ReviewerForm()
        reviewerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHscore.Click
        Dim score1Form As New Game1score()
        score1Form.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim Game1 As New startgame1()
        Game1.Show()
        Me.Hide()
    End Sub
    Private Sub btnnote1_Click(sender As Object, e As EventArgs) Handles btnnote1.Click
        Dim notesForm As New NoteViewerForm("note1.txt")
        notesForm.ShowDialog()
    End Sub

    Private Sub btnnote2_Click(sender As Object, e As EventArgs) Handles btnnote2.Click
        Dim notesForm As New NoteViewerForm("note2.txt")
        notesForm.ShowDialog()
    End Sub

    Private Sub btnnote3_Click(sender As Object, e As EventArgs) Handles btnnote3.Click
        Dim notesForm As New NoteViewerForm("note3.txt")
        notesForm.ShowDialog()
    End Sub
    Private Sub Game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class