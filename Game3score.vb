Imports System.Data.OleDb

Public Class Game3score
    ' Connection string to the Access database
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass()
        mainmenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnGame1_Click(sender As Object, e As EventArgs) Handles btnGame1.Click
        Dim game As New Game1
        game.Show()
        Hide()
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
        Dim g1Form As New Game1()
        g1Form.Show()
        Me.Hide()
    End Sub
    Private Sub Game3score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize dropdown with filtering options
        cmbRemarksFilter.Items.AddRange(New String() {"All", "complete", "incomplete"})
        cmbRemarksFilter.SelectedIndex = 0 ' Default to "All"

        ' Load high scores on form load
        LoadHighScores("All")
    End Sub

    Private Sub LoadHighScores(remarksFilter As String)
        ' Query to select and filter data from HSMG1
        Dim query As String = "SELECT playDate, uScore, InScore, uTimer, remarks FROM HSMG3"
        If remarksFilter <> "All" Then
            query &= " WHERE remarks = @remarks"
        End If
        query &= " ORDER BY uScore DESC, InScore ASC, uTimer ASC" ' Sort data

        ' Connecting to the database
        Using connection As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand(query, connection)
            If remarksFilter <> "All" Then
                command.Parameters.AddWithValue("@remarks", remarksFilter) ' Add parameter for filtering
            End If

            Try
                connection.Open()
                Dim adapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ' Bind data to DataGridView
                dgvHighScores.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error loading high scores: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Event handler for dropdown selection change
    Private Sub cmbRemarksFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRemarksFilter.SelectedIndexChanged
        ' Reload high scores based on selected remarks filter
        LoadHighScores(cmbRemarksFilter.SelectedItem.ToString())
    End Sub
End Class