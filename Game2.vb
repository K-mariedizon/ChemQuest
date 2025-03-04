Public Class Game2
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass()
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

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim g2 As New startgame2()
        g2.Show()
        Me.Hide()
    End Sub

    Private Sub btnHscore_Click(sender As Object, e As EventArgs) Handles btnHscore.Click
        Dim g2s As New Game2score()
        g2s.Show()
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
    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Game2c As New Game2crud()
        Game2c.Show()
    End Sub
End Class