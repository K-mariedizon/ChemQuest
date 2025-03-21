Imports System.Data.OleDb

Module Module4
    ' Connection string for Access database
    Private ReadOnly dbPath As String = "\\192.168.100.3\TableTutorDB\Database2.accdb;"

    Private ReadOnly connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;"

    ' Function to get the database connection
    Public Function GetConnection() As OleDbConnection
        Try
            Dim conn As New OleDbConnection(connectionString)
            Return conn
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Function to test the connection
    Public Sub TestConnection()
        Using conn As OleDbConnection = GetConnection()
            If conn IsNot Nothing Then
                Try
                    conn.Open()
                    MessageBox.Show("Connection Successful!", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to connect: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        End Using
    End Sub

End Module
