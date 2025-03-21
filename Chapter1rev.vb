Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Chapter1rev
    ' Connection string to the Access database
    'Dim txtNotes As New RichTextBox()

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\192.168.100.3\TableTutorDB\Database2.accdb;"

    Private connection As OleDbConnection
    Private selectedSubtopic As String
    Private selectedChapter As String
    Private selectedImage As PictureBox = Nothing

    Private Sub btnLogo_Click_1(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim revForm As New ReviewerForm
        revForm.Show()
        Hide()
    End Sub


    Private Sub Chapter1rev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddImage.Enabled = False
        btnDeleteImage.Enabled = False
        txtNotes.Focus()
        connection = New OleDbConnection(connectionString)
        LoadChapters()
    End Sub



    ' Load and display images dynamically
    Private Sub LoadImages()
        pnlImages.Controls.Clear()
        pnlImages.AutoScroll = True

        Try
            connection.Open()
            Dim query As String = "SELECT img FROM SubtopicsTbl WHERE subTitle = @subTitle"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@subTitle", selectedSubtopic)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If reader.Read() AndAlso Not IsDBNull(reader("img")) Then
                Dim images As String() = reader("img").ToString().Split(","c)
                Dim yOffset As Integer = 10

                For Each imgPath As String In images
                    Dim picBox As New PictureBox()
                    picBox.ImageLocation = imgPath.Trim()
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage
                    picBox.Size = New Size(300, 380)
                    picBox.Location = New Point(15, yOffset)
                    pnlImages.Controls.Add(picBox)
                    yOffset += 390

                    ' Allow selection on click
                    AddHandler picBox.Click, AddressOf PictureBox_Click

                    pnlImages.Controls.Add(picBox)
                Next
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading images: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Handle image selection
    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        If selectedImage IsNot Nothing Then
            selectedImage.BorderStyle = BorderStyle.None ' Reset previous selection
        End If

        selectedImage = DirectCast(sender, PictureBox)
        selectedImage.BorderStyle = BorderStyle.Fixed3D ' Highlight selection
    End Sub

    ' Add new image to database
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim newImagePath As String = openFileDialog.FileName

                Try
                    connection.Open()
                    Dim query As String = "SELECT img FROM SubtopicsTbl WHERE subTitle = @subTitle"
                    Dim command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@subTitle", selectedSubtopic)
                    Dim currentImages As String = Convert.ToString(command.ExecuteScalar())

                    ' Append new image
                    Dim updatedImages As String
                    If String.IsNullOrEmpty(currentImages) Then
                        updatedImages = newImagePath
                    Else
                        updatedImages = currentImages & "," & newImagePath
                    End If

                    ' Update database
                    query = "UPDATE SubtopicsTbl SET img = @img WHERE subTitle = @subTitle"
                    command = New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@img", updatedImages)
                    command.Parameters.AddWithValue("@subTitle", selectedSubtopic)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Image added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error adding image: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
        End Using
        LoadImages()
    End Sub


    Private Sub btnDeleteImage_Click(sender As Object, e As EventArgs) Handles btnDeleteImage.Click
        If pnlImages.Controls.Count = 0 Then
            MessageBox.Show("No images to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If selectedImage Is Nothing Then
            MessageBox.Show("Please select an image to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmDelete As DialogResult = MessageBox.Show("Do you want to delete this image?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmDelete = DialogResult.Yes Then
            Try
                connection.Open()
                Dim query As String = "SELECT img FROM SubtopicsTbl WHERE subTitle = @subTitle"
                Dim command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@subTitle", selectedSubtopic)
                Dim currentImages As String = Convert.ToString(command.ExecuteScalar())

                ' Remove selected image from the list
                Dim images As List(Of String) = currentImages.Split(","c).ToList()
                images.Remove(selectedImage.ImageLocation)
                Dim updatedImages As String = String.Join(",", images)

                ' Update database
                query = "UPDATE SubtopicsTbl SET img = @img WHERE subTitle = @subTitle"
                command = New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@img", updatedImages)
                command.Parameters.AddWithValue("@subTitle", selectedSubtopic)
                command.ExecuteNonQuery()

                ' Remove from UI
                pnlImages.Controls.Remove(selectedImage)
                selectedImage.Dispose()
                selectedImage = Nothing

                MessageBox.Show("Image deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error deleting image: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
        LoadImages()
    End Sub



    '''CALCULATOR
    ' Event to handle the conversion logic
    'Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    '    Dim inputValue As Double
    '    Dim resultValue As Double
    '    Dim selectedUnitFrom As String = cmbFrom.SelectedItem?.ToString()
    '    Dim selectedUnitTo As String = cmbTo.SelectedItem?.ToString()

    '    ' Validation: Ensure a valid number is entered
    '    If Not Double.TryParse(txtInput.Text, inputValue) Then
    '        MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        txtInput.Clear()
    '        Return
    '    End If

    '    ' Validation: Ensure both "From" and "To" units are selected
    '    If cmbFrom.SelectedIndex = -1 Or cmbTo.SelectedIndex = -1 Then
    '        MessageBox.Show("Please select both 'From' and 'To' units.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return
    '    End If

    '    ' Conversion logic for length (meters and kilometers)
    '    If selectedUnitFrom = "Meters" And selectedUnitTo = "Kilometers" Then
    '        resultValue = inputValue / 1000
    '    ElseIf selectedUnitFrom = "Kilometers" And selectedUnitTo = "Meters" Then
    '        resultValue = inputValue * 1000
    '    End If

    '    ' Conversion logic for weight (grams and kilograms)
    '    If selectedUnitFrom = "Grams" And selectedUnitTo = "Kilograms" Then
    '        resultValue = inputValue / 1000
    '    ElseIf selectedUnitFrom = "Kilograms" And selectedUnitTo = "Grams" Then
    '        resultValue = inputValue * 1000
    '    End If

    '    ' Conversion logic for temperature (Celsius to Fahrenheit)
    '    If selectedUnitFrom = "Celsius" And selectedUnitTo = "Fahrenheit" Then
    '        resultValue = (inputValue * 9 / 5) + 32
    '    ElseIf selectedUnitFrom = "Fahrenheit" And selectedUnitTo = "Celsius" Then
    '        resultValue = (inputValue - 32) * 5 / 9
    '    End If

    '    ' Validation: Ensure valid conversion logic was selected
    '    If resultValue = 0 AndAlso selectedUnitFrom <> selectedUnitTo Then
    '        MessageBox.Show("The selected conversion is not valid.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return
    '    End If

    '    ' Display the result
    '    txtResult.Text = resultValue.ToString()
    'End Sub

    ' Event to handle clearing the input and result textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtResult.Clear()
        cmbFrom.SelectedIndex = -1
        cmbTo.SelectedIndex = -1
        btnConvert.Enabled = False ' Disable Convert button when clearing
    End Sub

    ' Enable Convert button when both input and units are valid
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        ValidateInput()
    End Sub

    Private Sub cmbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        ValidateInput()
    End Sub

    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        ValidateInput()
    End Sub

    ' Validation for enabling/disabling the Convert button
    Private Sub ValidateInput()
        If Not String.IsNullOrWhiteSpace(txtInput.Text) AndAlso
           cmbFrom.SelectedIndex <> -1 AndAlso
           cmbTo.SelectedIndex <> -1 Then
            btnConvert.Enabled = True ' Enable the Convert button
        Else
            btnConvert.Enabled = False ' Disable the Convert button if input is invalid
        End If
    End Sub

    Private Sub LoadChapters()
        Try
            connection.Open()
            Dim query As String = "SELECT chapter FROM ChapterTbl"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            cmbChapters.Items.Clear()
            While reader.Read()
                cmbChapters.Items.Add(reader("chapter").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading chapters: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub cmbChapters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChapters.SelectedIndexChanged
        selectedChapter = cmbChapters.SelectedItem.ToString()
        cmbSubtopics.Items.Clear()
        txtNotes.Clear()
        Try
            connection.Open()
            Dim query As String = "SELECT subTitle FROM SubtopicsTbl WHERE chapter = @chapter"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@chapter", cmbChapters.SelectedItem.ToString())
            Dim reader As OleDbDataReader = command.ExecuteReader()

            cmbSubtopics.Items.Clear()
            While reader.Read()
                cmbSubtopics.Items.Add(reader("subTitle").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading subtopics: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function CalculateTextBoxHeight(text As String, font As Font, maxWidth As Integer) As Integer
        Dim textSize As SizeF
        Using g As Graphics = Graphics.FromImage(New Bitmap(1, 1))
            textSize = g.MeasureString(text, font, maxWidth)
        End Using
        Return CInt(Math.Ceiling(textSize.Height)) + 10
    End Function

    Private Sub cmbSubtopics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubtopics.SelectedIndexChanged
        selectedSubtopic = cmbSubtopics.SelectedItem.ToString()

        txtNotes.Focus()
        Try
            connection.Open()
            Dim query As String = "SELECT notes, img FROM SubtopicsTbl WHERE subTitle = @subTitle"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@subTitle", cmbSubtopics.SelectedItem.ToString())
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtNotes.Text = reader("notes").ToString().Replace("_", vbCrLf)
                txtNotes.Multiline = True
                'txtNotes.Width = 1025
                'txtNotes.Height = CalculateTextBoxHeight(txtNotes.Text, New Font("Arial", 12), 950)
                txtNotes.ReadOnly = True
                txtNotes.Font = New Font("Arial", 12)
                txtNotes.BackColor = ColorTranslator.FromHtml("#FFF8E9")
                txtNotes.BorderStyle = BorderStyle.None
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading content: " & ex.Message)
        Finally
            connection.Close()
        End Try
        LoadImages()
        btnAddImage.Enabled = True
        btnDeleteImage.Enabled = True
    End Sub


    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        Dim game As New MiniGamesForm
        game.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rev As New reviewerCrud
        rev.Show()
    End Sub

    Private Sub btnViewImage_Click(sender As Object, e As EventArgs)
        LoadImages()
    End Sub
End Class