Imports System.Data.OleDb

Public Class Chapter1rev
    ' Connection string to the Access database
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kiana\Documents\AlgoMasters_Project\Database2.accdb"
    Private connection As OleDbConnection

    Private Sub btnLogo_Click_1(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New Form1
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim revForm As New ReviewerForm
        revForm.Show()
        Hide()
    End Sub


    Private Sub Chapter1rev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(connectionString)
        LoadChapters()
    End Sub


    '''CALCULATOR
    ' Event to handle the conversion logic
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputValue As Double
        Dim resultValue As Double
        Dim selectedUnitFrom As String = cmbFrom.SelectedItem?.ToString()
        Dim selectedUnitTo As String = cmbTo.SelectedItem?.ToString()

        ' Validation: Ensure a valid number is entered
        If Not Double.TryParse(txtInput.Text, inputValue) Then
            MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Clear()
            Return
        End If

        ' Validation: Ensure both "From" and "To" units are selected
        If cmbFrom.SelectedIndex = -1 Or cmbTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both 'From' and 'To' units.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Conversion logic for length (meters and kilometers)
        If selectedUnitFrom = "Meters" And selectedUnitTo = "Kilometers" Then
            resultValue = inputValue / 1000
        ElseIf selectedUnitFrom = "Kilometers" And selectedUnitTo = "Meters" Then
            resultValue = inputValue * 1000
        End If

        ' Conversion logic for weight (grams and kilograms)
        If selectedUnitFrom = "Grams" And selectedUnitTo = "Kilograms" Then
            resultValue = inputValue / 1000
        ElseIf selectedUnitFrom = "Kilograms" And selectedUnitTo = "Grams" Then
            resultValue = inputValue * 1000
        End If

        ' Conversion logic for temperature (Celsius to Fahrenheit)
        If selectedUnitFrom = "Celsius" And selectedUnitTo = "Fahrenheit" Then
            resultValue = (inputValue * 9 / 5) + 32
        ElseIf selectedUnitFrom = "Fahrenheit" And selectedUnitTo = "Celsius" Then
            resultValue = (inputValue - 32) * 5 / 9
        End If

        ' Validation: Ensure valid conversion logic was selected
        If resultValue = 0 AndAlso selectedUnitFrom <> selectedUnitTo Then
            MessageBox.Show("The selected conversion is not valid.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Display the result
        txtResult.Text = resultValue.ToString()
    End Sub

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
        Try
            connection.Open()
            Dim query As String = "SELECT notes, img FROM SubtopicsTbl WHERE subTitle = @subTitle"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@subTitle", cmbSubtopics.SelectedItem.ToString())
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If reader.Read() Then
                txtNotes.Text = reader("notes").ToString().Replace("_", vbCrLf)
                txtNotes.Multiline = True
                txtNotes.Width = 950
                txtNotes.Height = CalculateTextBoxHeight(txtNotes.Text, New Font("Arial", 12), 950)
                txtNotes.ReadOnly = True
                txtNotes.Font = New Font("Arial", 12)
                txtNotes.BackColor = ColorTranslator.FromHtml("#FFF8E9")
                txtNotes.BorderStyle = BorderStyle.FixedSingle

                ' Load image
                If Not IsDBNull(reader("img")) Then
                    picImage.ImageLocation = reader("img").ToString()
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage
                    picImage.Visible = True
                Else
                    picImage.Visible = False
                End If
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading content: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


End Class