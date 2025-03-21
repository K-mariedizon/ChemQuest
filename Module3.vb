Imports System.Data.OleDb

Module Module3
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"

    Public Function GetQuestions() As List(Of DataRow)
        Dim query As String = "SELECT * FROM DBMG3" ' Replace with your table name
        Dim connection As New OleDbConnection(ConnectionString)
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dataSet As New DataSet()

        Try
            connection.Open()
            adapter.Fill(dataSet, "Questions")
            Return dataSet.Tables("Questions").AsEnumerable().ToList()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New List(Of DataRow)
        Finally
            connection.Close()
        End Try
    End Function
End Module
