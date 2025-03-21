'Imports System.Net
'Imports System.Net.Sockets
'Imports System.Text
'Imports System.Data.OleDb
'Imports System.Threading.Tasks

'Module ModuleServer
'    Private listener As TcpListener

'    ' Method to start the server
'    Sub StartServer()
'        Dim serverIp As IPAddress = IPAddress.Parse("192.168.100.3") ' Replace with actual WiFi IP
'        Dim port As Integer = 8080
'        listener = New TcpListener(serverIp, port)

'        Try
'            listener.Start()
'            Console.WriteLine("Server started... Waiting for clients...")

'            Task.Run(Sub()
'                         While True
'                             Dim client As TcpClient = listener.AcceptTcpClient()
'                             Console.WriteLine("Client connected.")
'                             Task.Run(Sub() HandleClient(client))
'                         End While
'                     End Sub)

'        Catch ex As Exception
'            Console.WriteLine("Server error: " & ex.Message)
'        End Try
'    End Sub

'    ' Method to handle clients
'    Sub HandleClient(client As TcpClient)
'        Try
'            Using client
'                Dim stream As NetworkStream = client.GetStream()
'                Dim buffer(1024) As Byte
'                Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
'                Dim clientMessage As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

'                Console.WriteLine("Received: " & clientMessage)

'                If clientMessage.Trim() = "GET_DATA" Then
'                    Dim data As String = FetchDataFromDatabase()
'                    Dim responseBytes As Byte() = Encoding.ASCII.GetBytes(data)
'                    stream.Write(responseBytes, 0, responseBytes.Length)
'                End If
'            End Using
'        Catch ex As Exception
'            Console.WriteLine("Client error: " & ex.Message)
'        End Try
'    End Sub

'    ' Fetch data from database
'    Function FetchDataFromDatabase() As String
'        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database\users.accdb;"
'        Dim result As String = "Users: "

'        Try
'            Using conn As New OleDbConnection(connectionString)
'                conn.Open()
'                Dim cmd As New OleDbCommand("SELECT username FROM userTbl", conn)
'                Dim reader As OleDbDataReader = cmd.ExecuteReader()

'                While reader.Read()
'                    result &= reader("username").ToString() & ", "
'                End While

'                result = result.TrimEnd(" "c) ' Remove last comma
'            End Using
'        Catch ex As Exception
'            result = "Database error: " & ex.Message
'        End Try

'        Return result
'    End Function

'End Module

Imports System.Data.OleDb

Module ModuleDatabase
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"

    ' Function to add guest user
    Public Sub RegisterGuest(ByVal uname As String, ByVal pword As String, ByVal nme As String, ByVal ip As String)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO accountTbl (Uname, Pword, Nme, Lvl, Ip) VALUES (@uname, @pword, @nme, @lvl, @ip)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uname", uname)
                    cmd.Parameters.AddWithValue("@pword", pword)
                    cmd.Parameters.AddWithValue("@nme", nme)
                    cmd.Parameters.AddWithValue("@lvl", 1) ' Lvl = 1 (Guest)
                    cmd.Parameters.AddWithValue("@ip", ip)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Guest registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to authenticate guest
    Public Function AuthenticateGuest(ByVal uname As String, ByVal pword As String) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM accountTbl WHERE Uname = @uname AND Pword = @pword AND Lvl = 1"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uname", uname)
                    cmd.Parameters.AddWithValue("@pword", pword)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        Return True ' Login successful
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False ' Login failed
    End Function

End Module
