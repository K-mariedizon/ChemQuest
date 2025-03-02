Public Class btnPass
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToolTip As New ToolTip()

        ToolTip.SetToolTip(btnReviewer, "REVIEWER")
        ToolTip.SetToolTip(btnNotes, "NOTES")
        ToolTip.SetToolTip(btnMiniGames, "GAMES")
    End Sub

    Private Sub btnReviewer_Click(sender As Object, e As EventArgs) Handles btnReviewer.Click
        Dim reviewerForm As New ReviewerForm()
        reviewerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMiniGames_Click(sender As Object, e As EventArgs) Handles btnMiniGames.Click
        Dim miniGamesForm As New MiniGamesForm()
        miniGamesForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        Dim notesForm As New NotesForm()
        notesForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim instructionsForm As New InstructionsForm()
        instructionsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutForm As New AboutForm()
        aboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass()
        mainmenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ProfileForm As New Profile()
        ProfileForm.Show()
    End Sub
End Class
