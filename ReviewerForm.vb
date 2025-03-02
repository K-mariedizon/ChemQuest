Imports System.Data.OleDb
Imports System.IO

Public Class ReviewerForm
    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        Dim gameForm As New MiniGamesForm()
        gameForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    'Private Sub btnChap1_Click(sender As Object, e As EventArgs) Handles btnChap1.Click
    '    Dim chap1Form As New Chapter1
    '    chap1Form.Show()
    '    Hide()
    'End Sub

    'Private Sub btnChap2_Click(sender As Object, e As EventArgs) Handles btnChap2.Click
    '    Dim chap2Form As New Chapter2
    '    chap2Form.Show()
    '    Hide()
    'End Sub

    'Private Sub btnChap3_Click(sender As Object, e As EventArgs) Handles btnChap3.Click
    '    Dim chap3Form As New Chapter3
    '    chap3Form.Show()
    '    Hide()
    'End Sub

    Private Sub btnMnemo_Click(sender As Object, e As EventArgs) Handles btnMnemo.Click
        Dim MnemoForm As New MnemoForm
        MnemoForm.Show()
        Hide()
    End Sub

    ''NOTES VIEW
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Rev As New Chapter1rev
        Rev.Show()
        Hide()
    End Sub
End Class
