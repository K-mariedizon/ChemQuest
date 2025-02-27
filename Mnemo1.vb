Imports System.Data.OleDb

Public Class Mnemo1
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kiana\Documents\AlgoMasters_Project\Database2.accdb"
    Private connection As OleDbConnection
    Private textBoxes As New List(Of TextBox) ' Store TextBoxes for scrolling

    Private Sub Mnemo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionString)
        LoadContents()
    End Sub

    Private Sub LoadContents()
        Try
            connection.Open()
            Dim query As String = "SELECT contents FROM mnemo"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If Not reader.HasRows Then
                MessageBox.Show("No records found in the database.")
                Return
            End If

            Dim yPosition As Integer = 50 ' Starting Y position for the TextBoxes
            Dim maxWidth As Integer = 1050 ' Maximum width for TextBox
            Dim font As New Font("Arial", 12) ' Font with size 12
            textBoxes.Clear() ' Clear previous list

            While reader.Read()
                Dim content As String = reader("contents").ToString().Replace("_", vbCrLf)

                Dim txtContent As New TextBox()
                txtContent.Text = content
                txtContent.Multiline = True
                txtContent.Width = maxWidth
                txtContent.ReadOnly = True
                txtContent.BorderStyle = BorderStyle.None
                txtContent.Location = New Point(20, yPosition)
                txtContent.Font = font
                txtContent.BackColor = SystemColors.Info

                Dim requiredHeight As Integer = CalculateTextBoxHeight(content, font, maxWidth)
                txtContent.Height = requiredHeight

                ' Add TextBox to the form and store it in the list
                Me.Controls.Add(txtContent)
                textBoxes.Add(txtContent)

                Me.AutoScroll = True
                txtContent.BringToFront()

                yPosition += txtContent.Height + 10
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading contents: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Function to calculate height
    Private Function CalculateTextBoxHeight(content As String, font As Font, width As Integer) As Integer
        Dim graphics As Graphics = Me.CreateGraphics()
        Dim textSize As SizeF = graphics.MeasureString(content, font, width)
        Dim lines As Integer = Math.Ceiling(textSize.Height / font.GetHeight(graphics))
        Return (lines * font.GetHeight(graphics)) - 2
    End Function

    Private Sub btnC1_Click(sender As Object, e As EventArgs) Handles btnC1.Click
        If textBoxes.Count > 0 Then
            Me.ScrollControlIntoView(textBoxes(0)) ' Scroll to the first TextBox
        End If
    End Sub

    Private Sub btnC2_Click(sender As Object, e As EventArgs) Handles btnC2.Click
        If textBoxes.Count > 3 Then
            Me.ScrollControlIntoView(textBoxes(3)) ' Scroll to the second TextBox
        End If
    End Sub

    Private Sub btnC3_Click(sender As Object, e As EventArgs) Handles btnC3.Click
        If textBoxes.Count > 5 Then
            Me.ScrollControlIntoView(textBoxes(5)) ' Scroll to the third TextBox
        End If
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim revForm As New Chapter2
        revForm.Show()
        Hide()
    End Sub

    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click
        Dim m As New Chapter3rev
        m.Show()
        Me.Hide()
    End Sub


End Class
