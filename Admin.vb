'Imports System.Net.Sockets
'Imports System.Text
'Imports System.Threading.Tasks
'Imports Microsoft.SqlServer

'Public Class Admin
'    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Task.Run(Sub() ModuleServer.StartServer()) ' Start the server in the background
'    End Sub


'    ' Button to connect to the server
'    Private Async Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
'        Dim serverIp As String = txtIpAddress.Text ' Get IP dynamically from a textbox
'        Dim port As Integer = 8080 ' Match the server's port

'        If String.IsNullOrWhiteSpace(serverIp) Then
'            MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            Exit Sub
'        End If

'        Try
'            Using client As New TcpClient()
'                Await client.ConnectAsync(serverIp, port)
'                Using stream As NetworkStream = client.GetStream()
'                    Dim request As Byte() = Encoding.ASCII.GetBytes("GET_DATA")
'                    Await stream.WriteAsync(request, 0, request.Length)

'                    Dim buffer(1024) As Byte
'                    Dim bytesRead As Integer = Await stream.ReadAsync(buffer, 0, buffer.Length)
'                    Dim response As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

'                    ' Update the UI with the response
'                    lblData.Text = "Data: " & response
'                End Using
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Connection failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'End Class


Imports System.Data.OleDb
Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Public Class Admin
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim uname As String = txtUsername.Text
        Dim pword As String = txtPassword.Text
        Dim nme As String = txtFullname.Text
        Dim ip As String = txtIp.Text

        If String.IsNullOrWhiteSpace(uname) OrElse String.IsNullOrWhiteSpace(pword) OrElse String.IsNullOrWhiteSpace(nme) OrElse String.IsNullOrWhiteSpace(ip) Then
            MessageBox.Show("Please fill in all details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Call function to register guest
        RegisterGuest(uname, pword, nme, ip)
    End Sub

End Class

