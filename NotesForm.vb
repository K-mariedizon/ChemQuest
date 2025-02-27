Imports System.Drawing.Drawing2D
Imports System.IO

Public Class NotesForm

    Private Sub txtNotes2_TextChanged(sender As Object, e As EventArgs) Handles txtNote2.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnReviewer_Click(sender As Object, e As EventArgs) Handles btnReviewer.Click
        Dim reviewerForm As New ReviewerForm()
        reviewerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub


    ' Save the note from txtNote1 to a file when btnSave1 is clicked
    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        SaveNote(txtNote1, "note1.txt")
    End Sub

    ' Save the note from txtNote2 to a file when btnSave2 is clicked
    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        SaveNote(txtNote2, "note2.txt")
    End Sub

    ' Save the note from txtNote3 to a file when btnSave3 is clicked
    Private Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        SaveNote(txtNote3, "note3.txt")
    End Sub

    ' Method to save the note content to a file with a timestamp
    Private Sub SaveNote(textBox As TextBox, fileName As String)
        Dim notesDirectory As String = "\ChemQuest\Notes\"

        ' Ensure the directory exists
        If Not Directory.Exists(notesDirectory) Then
            Directory.CreateDirectory(notesDirectory)
        End If

        Dim filePath As String = (notesDirectory + fileName)
        Dim noteContent As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {textBox.Text}"

        ' Append the note content to the file
        File.AppendAllText(filePath, noteContent & Environment.NewLine)

        MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Public method to view the content of a specific note file, accessible from other forms
    Public Shared Sub ViewNotes(noteFile As String, listView As ListView)
        Dim notesDirectory As String = "\ChemQuest\Notes\"

        Dim filePath As String = (notesDirectory + noteFile)

        If File.Exists(filePath) Then
            Dim notes As String() = File.ReadAllLines(filePath)

            ' Clear the ListView and add headers
            listView.Clear()
            listView.View = View.Details
            listView.Columns.Add("Timestamp", 150)
            listView.Columns.Add("Note", 500)

            ' Populate the ListView with notes
            For Each line As String In notes
                Dim parts As String() = line.Split(New String() {" - "}, 2, StringSplitOptions.None)
                If parts.Length = 2 Then
                    listView.Items.Add(New ListViewItem(parts))
                End If
            Next
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

    Private Sub NotesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Button to view the content of a specific note file

End Class