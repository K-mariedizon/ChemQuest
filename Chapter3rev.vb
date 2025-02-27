Imports System.Data.OleDb

Public Class Chapter3rev
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kiana\Documents\AlgoMasters_Project\Database2.accdb"
    Private connection As OleDbConnection

    Private Sub Chapter3rev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(ConnectionString)
        LoadContents()
    End Sub
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim revForm As New Chapter3
        revForm.Show()
        Hide()
    End Sub

    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click
        Dim m As New Chapter2rev
        m.Show()
        Me.Hide()
    End Sub

    Private Sub btnB2_Click(sender As Object, e As EventArgs) Handles btnB2.Click
        Dim m As New Mnemo1
        m.Show()
        Me.Hide()
    End Sub

    Private Sub LoadContents()
        Try
            connection.Open()
            Dim query As String = "SELECT contents FROM Chapter3"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If Not reader.HasRows Then
                MessageBox.Show("No records found in the database.")
                Return
            End If

            Dim yPosition As Integer = 50 ' Starting Y position for the TextBoxes
            Dim maxWidth As Integer = 1050 ' Maximum width for TextBox
            Dim font As New Font("Arial", 12) ' Font with size 12

            While reader.Read()
                ' Retrieve the content and replace underscores with newlines
                Dim content As String = reader("contents").ToString().Replace("_", vbCrLf)

                ' Create a new TextBox
                Dim txtContent As New TextBox()
                txtContent.Text = content
                txtContent.Multiline = True
                txtContent.Width = maxWidth
                txtContent.ReadOnly = True
                txtContent.BorderStyle = BorderStyle.None
                txtContent.Location = New Point(20, yPosition)

                ' Set the font size
                txtContent.Font = font

                ' Automatically resize the TextBox based on content length
                Dim requiredHeight As Integer = CalculateTextBoxHeight(content, font, maxWidth)
                txtContent.Height = requiredHeight

                ' Remove internal padding to avoid extra space below the text
                txtContent.Padding = New Padding(0)

                ' Set the background color to the Info color
                txtContent.BackColor = SystemColors.Info

                ' Add the TextBox to the form
                Me.Controls.Add(txtContent)

                Me.AutoScroll = True

                ' Ensure the TextBox is displayed above other controls
                txtContent.BringToFront()

                ' Increment the Y position for the next TextBox
                yPosition += txtContent.Height + 10
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading contents: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    ' Function to calculate the required height based on content length
    Private Function CalculateTextBoxHeight(content As String, font As Font, width As Integer) As Integer
        Dim graphics As Graphics = Me.CreateGraphics()
        Dim textSize As SizeF = graphics.MeasureString(content, font, width)

        ' Calculate height: Divide by line height (based on font size) and round up
        Dim lines As Integer = Math.Ceiling(textSize.Height / font.GetHeight(graphics))

        ' Adjust the height to prevent unnecessary extra space at the bottom
        Return (lines * font.GetHeight(graphics)) - 2 ' Reducing padding space
    End Function

End Class