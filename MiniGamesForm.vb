Imports System.IO

Public Class MiniGamesForm
    Private Sub MiniGamesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnReviewer_Click(sender As Object, e As EventArgs) Handles btnReviewer.Click
        Dim reviewerForm As New ReviewerForm()
        reviewerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnGame1_Click(sender As Object, e As EventArgs) Handles btnGame1.Click
        Dim game As New Game1()
        game.Show()
        Me.Hide()
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

    ''NOTES VIEW
    Public Shared Sub ViewNotes(noteFile As String)
        Dim notesDirectory As String = Path.Combine(Application.StartupPath, "ChemQuest", "Notes")
        Dim filePath As String = Path.Combine(notesDirectory, noteFile)

        If File.Exists(filePath) Then
            Dim notes As String = File.ReadAllText(filePath)
            MessageBox.Show(notes, "Notes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No notes found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
End Class