Imports System.Data.OleDb
Imports System.Reflection

Public Class Game1crud
    Private conn As OleDbConnection
    Private adapter As OleDbDataAdapter
    Private dt As DataTable
    Private selectedID As Integer = 0 ' Default no selection


    Private Sub Game1crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpG1.Enabled = False
        btnadd.Enabled = True

        conn = Module4.GetConnection()
        LoadQuestions()
        'ValidateInputs() ' Ensure buttons start in the correct state
    End Sub

    ' Load questions into ListBox
    Private Sub LoadQuestions()
        lstboxMG.Items.Clear()
        dt = New DataTable()

        Dim query As String = "SELECT [Numbers], [questions] FROM DBMG1"
        adapter = New OleDbDataAdapter(query, conn)
        adapter.Fill(dt)

        For Each row As DataRow In dt.Rows
            lstboxMG.Items.Add(row("questions"))
        Next
    End Sub

    ' Populate textboxes when a question is selected
    Private Sub lstboxMG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMG.SelectedIndexChanged
        If lstboxMG.SelectedIndex <> -1 Then
            Dim query As String = "SELECT * FROM DBMG1 WHERE [questions] = @questions"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@questions", lstboxMG.SelectedItem.ToString())

            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                selectedID = Convert.ToInt32(reader("Numbers")) ' Store the selected ID
                txtQuestion.Text = reader("questions").ToString()
                txtCorrectAnswer.Text = reader("correctAns").ToString()
                txtRandomAnswers.Text = reader("randAns").ToString()
            End If
            conn.Close()
        End If
        ValidateInputs()
    End Sub

    ' Validate input fields to enable/disable buttons
    Private Sub ValidateInputs()
        Dim allFieldsFilled As Boolean = (txtQuestion.Text.Trim() <> "" AndAlso
                                          txtCorrectAnswer.Text.Trim() <> "" AndAlso
                                          txtRandomAnswers.Text.Trim() <> "")

        btnadd.Enabled = allFieldsFilled
        btnupdate.Enabled = allFieldsFilled AndAlso selectedID > 0
        btndelete.Enabled = selectedID > 0
    End Sub

    Sub stateControl(ByVal lst As Boolean, ByVal grp As Boolean)
        lstboxMG.Enabled = lst
        grpG1.Enabled = grp
        btnadd.Text = "Add"
        btnupdate.Text = "Update"
    End Sub

    ' Add a new question
    ' Add a new question
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            lstboxMG.Enabled = False
            btnupdate.Enabled = False
            btndelete.Enabled = False
            grpG1.Enabled = True
            ClearFields()
            btnadd.Text = "Save"
        ElseIf btnadd.Text = "Save" Then

            ' Ensure all fields are filled
            If txtQuestion.Text = "" Or txtCorrectAnswer.Text = "" Or txtRandomAnswers.Text = "" Then
                MessageBox.Show("Please fill in all fields before adding.")
                Return
            End If

            ' Check if the question already exists
            Dim queryCheck As String = "SELECT COUNT(*) FROM DBMG1 WHERE [questions] = @questions"
            Dim cmdCheck As New OleDbCommand(queryCheck, conn)
            cmdCheck.Parameters.AddWithValue("@questions", txtQuestion.Text)

            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            conn.Close()

            If count > 0 Then
                MessageBox.Show("This question already exists in the database.")
                Return
            End If

            ' Insert the new question
            Dim query As String = "INSERT INTO DBMG1 ([questions], [correctAns], [randAns]) VALUES (@questions, @correctAns, @randAns)"
            Dim cmd As New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("@questions", txtQuestion.Text)
            cmd.Parameters.AddWithValue("@correctAns", txtCorrectAnswer.Text)
            cmd.Parameters.AddWithValue("@randAns", txtRandomAnswers.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadQuestions()

            MessageBox.Show("Question added successfully!")
            ClearFields()
            btnadd.Enabled = True
            btnupdate.Enabled = True
            btndelete.Enabled = True
            stateControl(True, False)
        End If
    End Sub


    ' Update selected question
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtCorrectAnswer.Text = "" Or txtQuestion.Text = "" Or txtRandomAnswers.Text = "" Then
            MessageBox.Show("Please select a note to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If btnupdate.Text = "Update" Then
            lstboxMG.Enabled = False
            btnadd.Enabled = False
            btndelete.Enabled = False
            grpG1.Enabled = True
            btnupdate.Text = "Save"
        ElseIf btnupdate.Text = "Save" Then
            If Not btnupdate.Enabled Then Return

            Dim query As String = "UPDATE DBMG1 SET [questions] = @questions, [correctAns] = @correctAns, [randAns] = @randAns WHERE [Numbers] = @Numbers"
            Dim cmd As New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("@questions", txtQuestion.Text)
            cmd.Parameters.AddWithValue("@correctAns", txtCorrectAnswer.Text)
            cmd.Parameters.AddWithValue("@randAns", txtRandomAnswers.Text)
            cmd.Parameters.AddWithValue("@Numbers", selectedID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadQuestions()
            'ClearFields()
            MessageBox.Show("Question updated successfully!")
            btnadd.Enabled = True
            btndelete.Enabled = True
            stateControl(True, False)
        End If
    End Sub

    ' Delete selected question
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtCorrectAnswer.Text = "" Or txtQuestion.Text = "" Then
            MessageBox.Show("Please select a Question to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        grpG1.Enabled = False
        btnadd.Enabled = False
        btnupdate.Enabled = False
        If MessageBox.Show("Do you want to delete this?", "delete Note", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If Not btndelete.Enabled Then Return

            Dim query As String = "DELETE FROM DBMG1 WHERE [Numbers] = @Numbers"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Numbers", selectedID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadQuestions()

            MessageBox.Show("Question deleted successfully!")
            ClearFields()
            btnupdate.Enabled = True
            btnadd.Enabled = True
            stateControl(True, False)
        End If
        ClearFields()
        btnupdate.Enabled = True
        btnadd.Enabled = True
        stateControl(True, False)
    End Sub

    Private Sub ClearText()
        txtQuestion.Clear()
        txtCorrectAnswer.Clear()
        txtRandomAnswers.Clear()
    End Sub

    ' Clear input fields and reset selected ID
    Private Sub ClearFields()
        txtQuestion.Text = ""
        txtCorrectAnswer.Text = ""
        txtRandomAnswers.Text = ""
        selectedID = 0
        'ValidateInputs()
    End Sub

    ' Close form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnadd.Enabled = True
        stateControl(True, False)
        ClearFields()
    End Sub

    ' Trigger validation when user types in textboxes
    Private Sub txtQuestion_TextChanged(sender As Object, e As EventArgs) Handles txtQuestion.TextChanged
        ValidateInputs()
    End Sub

    Private Sub txtCorrectAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtCorrectAnswer.TextChanged
        ValidateInputs()
    End Sub

    Private Sub txtRandomAnswers_TextChanged(sender As Object, e As EventArgs) Handles txtRandomAnswers.TextChanged
        ValidateInputs()
    End Sub


End Class