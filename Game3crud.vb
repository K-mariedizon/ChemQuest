Imports System.Data.OleDb

Public Class Game3crud
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"
    Private Sub Game3crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    ' Function to load questions into the listbox
    Private Sub LoadQuestions()
        lstboxMG3.Items.Clear()
        Using conn As New OleDbConnection(ConnectionString)
            Dim query As String = "SELECT questions FROM DBMG3"
            Dim cmd As New OleDbCommand(query, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                lstboxMG3.Items.Add(reader("questions").ToString())
            End While
            conn.Close()
        End Using
    End Sub

    ' Button conditions handler
    Private Sub PerformDatabaseAction(query As String, parameters As List(Of Object), successMessage As String)
        Using conn As New OleDbConnection(ConnectionString)
            Dim cmd As New OleDbCommand(query, conn)
            For Each param In parameters
                cmd.Parameters.AddWithValue("?", param)
            Next
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadQuestions()
        ClearFields()
    End Sub

    ' ADD NEW QUESTION
    Private Sub btnadddd_Click(sender As Object, e As EventArgs) Handles btnadddd.Click
        Dim newQuestion As String = txtQuestionnn.Text.Trim()
        Dim correctAnswer As String = txtCorrectAnswerrr.Text.Trim()
        Dim randomAnswer As String = txtRandomAnswersss.Text.Trim()

        ' Check if any of the textboxes are empty
        If newQuestion = "" OrElse correctAnswer = "" OrElse randomAnswer = "" Then
            MessageBox.Show("Please fill in all fields (Question, Correct Answer, and Random Answer).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if the question already exists
        If lstboxMG3.Items.Contains(newQuestion) Then
            MessageBox.Show("Question already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert new question into the database
        Using conn As New OleDbConnection(ConnectionString)
            Dim query As String = "INSERT INTO DBMG3 (questions, correctAns, randAns) VALUES (?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", newQuestion)
            cmd.Parameters.AddWithValue("?", correctAnswer)
            cmd.Parameters.AddWithValue("?", randomAnswer)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadQuestions() ' Refresh the listbox
                ClearFields() ' Clear textboxes
            Catch ex As Exception
                MessageBox.Show("Error adding question: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' UPDATE QUESTION
    Private Sub btnupdateee_Click(sender As Object, e As EventArgs) Handles btnupdateee.Click
        If lstboxMG3.SelectedIndex = -1 Then
            MessageBox.Show("Please select a question to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim selectedQuestion As String = lstboxMG3.SelectedItem.ToString()
        PerformDatabaseAction("UPDATE DBMG3 SET questions=?, correctAns=?, randAns=? WHERE questions=?",
                              New List(Of Object) From {txtQuestionnn.Text, txtCorrectAnswerrr.Text, txtRandomAnswersss.Text, selectedQuestion},
                              "Question updated successfully!")
    End Sub

    ' DELETE QUESTION
    Private Sub btndeleteee_Click(sender As Object, e As EventArgs) Handles btndeleteee.Click
        If lstboxMG3.SelectedIndex = -1 Then
            MessageBox.Show("Please select a question to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim selectedQuestion As String = lstboxMG3.SelectedItem.ToString()
        If MessageBox.Show("Are you sure you want to delete this question?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub
        PerformDatabaseAction("DELETE FROM DBMG3 WHERE questions = ?",
                              New List(Of Object) From {selectedQuestion},
                              "Question deleted successfully!")
    End Sub

    ' CLEAR TEXTBOXES
    Private Sub btncancelll_Click(sender As Object, e As EventArgs) Handles btncancelll.Click
        ClearFields()
    End Sub

    ' Function to clear all textboxes
    Private Sub ClearFields()
        txtQuestionnn.Clear()
        txtCorrectAnswerrr.Clear()
        txtRandomAnswersss.Clear()
    End Sub
    ' Fill textboxes when a question is selected in the listbox
    Private Sub lstboxMG3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMG3.SelectedIndexChanged
        If lstboxMG3.SelectedIndex <> -1 Then
            Dim selectedQuestion As String = lstboxMG3.SelectedItem.ToString()
            Using conn As New OleDbConnection(ConnectionString)
                Dim query As String = "SELECT questions, correctAns, randAns FROM DBMG3 WHERE questions = ?"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", selectedQuestion)

                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtQuestionnn.Text = reader("questions").ToString()
                        txtCorrectAnswerrr.Text = reader("correctAns").ToString()
                        txtRandomAnswersss.Text = reader("randAns").ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving question details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End Using
        End If
    End Sub


End Class