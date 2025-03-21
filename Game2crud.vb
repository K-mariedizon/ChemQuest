Imports System.Data.OleDb

Public Class Game2crud
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"

    Private Sub Game2crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        ValidateFields()
    End Sub

    ' Function to load patient names into the listbox
    Private Sub LoadPatients()
        lstboxMG2.Items.Clear()
        Using conn As New OleDbConnection(connectionString)
            Dim query As String = "SELECT PatientName FROM DBMG2"
            Dim cmd As New OleDbCommand(query, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                lstboxMG2.Items.Add(reader("PatientName").ToString())
            End While
            conn.Close()
        End Using
    End Sub

    ' Fill textboxes when a patient name is selected in the listbox
    Private Sub lstboxMG2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMG2.SelectedIndexChanged
        If lstboxMG2.SelectedIndex <> -1 Then
            Dim selectedName As String = lstboxMG2.SelectedItem.ToString()
            Using conn As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM DBMG2 WHERE PatientName = ?"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", selectedName)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Populate all relevant textboxes including txtPatientName
                    txtPatientName.Text = reader("PatientName").ToString()
                    txtAge.Text = reader("Age").ToString()
                    txtGender.Text = reader("Gender").ToString()
                    txtMedicalHistory.Text = reader("MedicalHistory").ToString()
                    txtquestionn.Text = reader("questions").ToString()
                    txtCorrectAnswerr.Text = reader("correctAns").ToString()
                    txtRandAnss.Text = reader("randAns").ToString()
                    txtLabResults.Text = reader("labResults").ToString()
                End If
                conn.Close()
            End Using
        End If
        ValidateFields() ' Enable/Disable buttons accordingly
    End Sub

    ' ADD NEW PATIENT - Check if the name exists before adding
    Private Sub btnaddd_Click(sender As Object, e As EventArgs) Handles btnaddd.Click
        ' Ensure all fields are filled before proceeding
        If String.IsNullOrWhiteSpace(txtPatientName.Text) OrElse
       String.IsNullOrWhiteSpace(txtAge.Text) OrElse
       String.IsNullOrWhiteSpace(txtGender.Text) OrElse
       String.IsNullOrWhiteSpace(txtMedicalHistory.Text) OrElse
       String.IsNullOrWhiteSpace(txtquestionn.Text) OrElse
       String.IsNullOrWhiteSpace(txtCorrectAnswerr.Text) OrElse
       String.IsNullOrWhiteSpace(txtRandAnss.Text) OrElse
       String.IsNullOrWhiteSpace(txtLabResults.Text) Then
            MessageBox.Show("Please fill in all fields before adding a patient.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newName As String = txtPatientName.Text

        ' Check if the name already exists in the database
        Using conn As New OleDbConnection(connectionString)
            Dim checkQuery As String = "SELECT COUNT(*) FROM DBMG2 WHERE PatientName = ?"
            Dim checkCmd As New OleDbCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("?", newName)

            conn.Open()
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            conn.Close()

            If count > 0 Then
                MessageBox.Show("Patient name already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        ' Insert new patient into database
        Using conn As New OleDbConnection(connectionString)
            Dim query As String = "INSERT INTO DBMG2 (PatientName, Age, Gender, MedicalHistory, questions, correctAns, randAns, labResults) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", newName)
            cmd.Parameters.AddWithValue("?", txtAge.Text)
            cmd.Parameters.AddWithValue("?", txtGender.Text)
            cmd.Parameters.AddWithValue("?", txtMedicalHistory.Text)
            cmd.Parameters.AddWithValue("?", txtquestionn.Text)
            cmd.Parameters.AddWithValue("?", txtCorrectAnswerr.Text)
            cmd.Parameters.AddWithValue("?", txtRandAnss.Text)
            cmd.Parameters.AddWithValue("?", txtLabResults.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh the patient list and clear fields
        LoadPatients()
        ClearFields()
    End Sub


    ' UPDATE PATIENT DATA
    Private Sub btnupdatee_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If lstboxMG2.SelectedIndex = -1 Then
            MessageBox.Show("Please select a patient to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedName As String = lstboxMG2.SelectedItem.ToString()

        Using conn As New OleDbConnection(connectionString)
            Dim query As String = "UPDATE DBMG2 SET Age=?, Gender=?, MedicalHistory=?, questions=?, correctAns=?, randAns=?, labResults=? WHERE PatientName=?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtAge.Text)
            cmd.Parameters.AddWithValue("?", txtGender.Text)
            cmd.Parameters.AddWithValue("?", txtMedicalHistory.Text)
            cmd.Parameters.AddWithValue("?", txtquestionn.Text)
            cmd.Parameters.AddWithValue("?", txtCorrectAnswerr.Text)
            cmd.Parameters.AddWithValue("?", txtRandAnss.Text)
            cmd.Parameters.AddWithValue("?", txtLabResults.Text)
            cmd.Parameters.AddWithValue("?", selectedName)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        MessageBox.Show("Patient data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' DELETE PATIENT
    Private Sub btndeletee_Click(sender As Object, e As EventArgs) Handles btndeletee.Click
        If lstboxMG2.SelectedIndex = -1 Then
            MessageBox.Show("Please select a patient to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedName As String = lstboxMG2.SelectedItem.ToString()
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        Using conn As New OleDbConnection(connectionString)
            Dim query As String = "DELETE FROM DBMG2 WHERE PatientName = ?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", selectedName)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadPatients() ' Refresh the list
        ClearFields() ' Clear textboxes
    End Sub

    ' CLEAR TEXTBOXES
    Private Sub btncancell_Click(sender As Object, e As EventArgs) Handles btncancell.Click
        ClearFields()
    End Sub

    ' Function to clear all textboxes
    Private Sub ClearFields()
        txtAge.Clear()
        txtGender.Clear()
        txtMedicalHistory.Clear()
        txtquestionn.Clear()
        txtCorrectAnswerr.Clear()
        txtRandAnss.Clear()
        txtLabResults.Clear()
        ValidateFields()
    End Sub

    ' Function to enable/disable buttons based on field validation
    Private Sub ValidateFields()
        Dim allFilled As Boolean = Not String.IsNullOrWhiteSpace(txtPatientName.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtAge.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtGender.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtMedicalHistory.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtquestionn.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtCorrectAnswerr.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtRandAnss.Text) AndAlso
                                   Not String.IsNullOrWhiteSpace(txtLabResults.Text)

        btnaddd.Enabled = allFilled
        btnupdate.Enabled = allFilled AndAlso lstboxMG2.SelectedIndex <> -1
        btndeletee.Enabled = lstboxMG2.SelectedIndex <> -1
    End Sub

    ' Attach the validation function to text change events
    Private Sub TextFieldsChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged, txtGender.TextChanged, txtMedicalHistory.TextChanged, txtquestionn.TextChanged, txtCorrectAnswerr.TextChanged, txtRandAnss.TextChanged, txtLabResults.TextChanged
        ValidateFields()
    End Sub


End Class