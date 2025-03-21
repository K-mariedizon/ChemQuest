Imports System.Data.OleDb

Module DatabaseModule
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"

    ' Retrieves all questions for Form1
    Public Function GetQuestions() As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT randAns, correctAns, questions FROM DBMG1"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataSet As New DataSet()

            Try
                connection.Open()
                adapter.Fill(dataSet, "Questions")
                Return dataSet.Tables("Questions")
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function
End Module