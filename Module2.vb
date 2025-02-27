Imports System.Data.OleDb

Module Module2
    ' Connection string to the Access database
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kiana\Documents\AlgoMasters_Project\Database2.accdb"

    ' Retrieves patient details and lab results based on ID
    Public Function GetPatientData() As DataTable
        Using connection As New OleDbConnection(connectionString)
            ' Query to fetch all rows from the table
            Dim query As String = "SELECT * FROM DBMG2" ' Adjust table name as needed
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            Try
                connection.Open()
                adapter.Fill(dataSet, "PatientData")
                Return dataSet.Tables("PatientData")
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function

    ' Retrieves all questions from the database
    Public Function GetQuestionsFromDBMG2() As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT randAns, correctAns, questions FROM DBMG2"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            Try
                connection.Open()
                adapter.Fill(dataSet, "Questions")
                Return dataSet.Tables("Questions")
            Catch ex As Exception
                MessageBox.Show("Error loading questions: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function

End Module