Imports System.Data.OleDb

Module ModuleLog
    Dim connectionString As String
    Public oledbCnn As OleDbConnection
    Public oledbAdapterAccount As OleDbDataAdapter
    Public accountDataSet As New DataSet
    Public drow As DataRow
    Public sql As String



    Public Function OpenConnection() As Boolean

        connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kiana\Documents\AlgoMasters_Project\Database2.accdb"
        oledbCnn = New OleDbConnection(connectionString)

        Try
            oledbCnn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
        Return True

    End Function

    Public Sub accountSet()
        sql = "Select * from accountTbl"
        oledbAdapterAccount = New OleDbDataAdapter(sql, oledbCnn)
        oledbAdapterAccount.Fill(accountDataSet, "accountTbl")
    End Sub

    Public Sub BuilderConn(ByVal b As OleDbDataAdapter)
        Dim builder As New OleDbCommandBuilder(b)
        builder.GetUpdateCommand()
        builder.ConflictOption = ConflictOption.OverwriteChanges
    End Sub

End Module
