Imports System.IO

Public Class NoteViewerForm
    Inherits Form

    Private listView As New ListView()
    Private noteTextBox As New TextBox()
    Private saveButton As New Button()
    Public Sub New(noteFile As String)
        Me.Text = "Notes Viewer"
        Me.Size = New Size(700, 500)

        ' Configure ListView
        listView.Dock = DockStyle.Fill
        listView.View = View.Details
        listView.FullRowSelect = True

        ' Add ListView to form
        Me.Controls.Add(listView)

        ' Load notes into ListView
        ViewNotes(noteFile, listView)
    End Sub

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

    Private Sub NoteViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Private listView As New ListView()
    'Private deleteButton As New Button()

    'Public Sub New(noteFile As String)
    '    Me.Text = "Notes Viewer"
    '    Me.Size = New Size(700, 500)

    '    ' Configure ListView
    '    listView.Dock = DockStyle.Top
    '    listView.Height = 400
    '    listView.View = View.Details
    '    listView.FullRowSelect = True

    '    ' Add ListView to form
    '    Me.Controls.Add(listView)

    '    ' Configure Delete Button
    '    deleteButton.Text = "Delete Note"
    '    deleteButton.Dock = DockStyle.Bottom
    '    AddHandler deleteButton.Click, AddressOf DeleteButton_Click
    '    Me.Controls.Add(deleteButton)

    '    ' Load notes into ListView
    '    ViewNotes(noteFile, listView)
    'End Sub


    'Public Shared Sub ViewNotes(noteFile As String, listView As ListView)
    '    Dim notesDirectory As String = "\ChemQuest\Notes\"
    '    Dim filePath As String = (notesDirectory + noteFile)

    '    If File.Exists(filePath) Then
    '        Dim notes As String() = File.ReadAllLines(filePath)

    '        ' Clear the ListView and add headers
    '        listView.Clear()
    '        listView.View = View.Details
    '        listView.Columns.Add("Timestamp", 150)
    '        listView.Columns.Add("Note", 500)

    '        ' Populate the ListView with notes
    '        For Each line As String In notes
    '            Dim parts As String() = line.Split(New String() {" - "}, 2, StringSplitOptions.None)
    '            If parts.Length = 2 Then
    '                listView.Items.Add(New ListViewItem(parts))
    '            End If
    '        Next
    '    Else
    '        MessageBox.Show("No notes found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub


    'Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
    '    If listView.SelectedItems.Count > 0 Then
    '        Dim selectedItem As ListViewItem = listView.SelectedItems(0)
    '        Dim noteText As String = selectedItem.SubItems(1).Text
    '        Dim notesDirectory As String = "\ChemQuest\Notes\"
    '        Dim filePath As String = notesDirectory & "note1.txt"  ' You can update this to target the correct file name

    '        ' Read all lines and remove the selected note
    '        Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
    '        lines.RemoveAll(Function(line) line.Contains(noteText))

    '        ' Save the updated file without the deleted note
    '        File.WriteAllLines(filePath, lines)

    '        ' Refresh the ListView to show updated notes
    '        ViewNotes("note1.txt", listView) ' Make sure the correct file name is passed
    '    Else
    '        MessageBox.Show("Please select a note to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub
End Class