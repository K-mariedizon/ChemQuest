Imports System.Data.OleDb

Public Class startgame2
    Private correctAnswer As String
    Private availableQuestions As List(Of DataRow) ' To track unselected rows/questions
    Private currentQuestionRow As DataRow ' To store the current question row
    Private random As New Random() ' Random number generator
    Private startTime As DateTime ' To track the start time
    Private elapsedTime As TimeSpan ' To track elapsed time
    Private score As Integer = 0 ' To track the user's score
    Private incorrectAnswers As Integer = 0 ' To track the user's incorrect answers
    Private gameRemark As String = "incomplete" ' Default remark is "incomplete"    

    Private WithEvents quizTimer1 As New Timer() With {.Interval = 1000} ' Update every second
    Private Sub startgame2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the timer and fetch questions
        startTime = DateTime.Now
        quizTimer1.Start() ' Start the timer
        LoadPatientData()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If the game is closing and was not marked complete, save it as incomplete
        If gameRemark = "incomplete" Then
            elapsedTime = DateTime.Now - startTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, "incomplete")
        End If
    End Sub

    Private Sub quizTimer1_Tick(sender As Object, e As EventArgs)
        elapsedTime = Date.Now - startTime
        lblTimer.Text = $"Time: {elapsedTime.Minutes:00}:{elapsedTime.Seconds:00}" ' Update the timer label
    End Sub

    Private Sub LoadPatientData()
        Dim patientData As DataTable = Module2.GetPatientData()

        ' Check if data is retrieved
        If patientData IsNot Nothing AndAlso patientData.Rows.Count > 0 Then
            ' Convert rows to a list for random selection
            availableQuestions = patientData.AsEnumerable().ToList()

            ' Load the first random question
            ShowRandomQuestion()
        Else
            MessageBox.Show("No data found in the database.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
    End Sub

    Private Sub ShowRandomQuestion()
        If availableQuestions.Count = 0 Then
            ' No more questions available, end the quiz
            gameRemark = "complete" ' Mark the game as complete
            EndQuiz()
            Return
        End If

        ' Select a random question
        Dim randomIndex As Integer = random.Next(availableQuestions.Count)
        currentQuestionRow = availableQuestions(randomIndex)

        ' Remove the selected row from the list to prevent repetition
        availableQuestions.RemoveAt(randomIndex)

        ' Display patient details
        lblPatientName.Text = "Name: " & currentQuestionRow("PatientName").ToString()
        lblAge.Text = "Age: " & currentQuestionRow("Age").ToString()
        lblGender.Text = "Gender: " & currentQuestionRow("Gender").ToString()
        lblMedicalHistory.Text = "Medical History: " & currentQuestionRow("MedicalHistory").ToString()

        ' Display lab results
        txtLabResults.Text = currentQuestionRow("labResults").ToString()

        ' Display the question
        lblQuestion.Text = currentQuestionRow("questions").ToString()

        ' Retrieve and shuffle answers
        Dim answers As New List(Of String)(currentQuestionRow("randAns").ToString().Split(","c))
        correctAnswer = currentQuestionRow("correctAns").ToString() ' Store the correct answer
        answers.Add(correctAnswer) ' Add the correct answer to the list
        Dim shuffledAnswers As List(Of String) = ShuffleAnswers(answers)

        ' Assign shuffled answers to buttons
        btnAnswer1.Text = shuffledAnswers(0)
        btnAnswer2.Text = shuffledAnswers(1)
        btnAnswer3.Text = shuffledAnswers(2)
        btnAnswer4.Text = shuffledAnswers(3)

        ' Enable buttons for new selection
        EnableAnswerButtons(True)
    End Sub

    Private Sub AnswerButton_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click, btnAnswer2.Click, btnAnswer3.Click, btnAnswer4.Click
        Dim selectedAnswer As String = CType(sender, Button).Text

        ' Validate the selected answer
        If selectedAnswer = correctAnswer Then
            MessageBox.Show("Correct! Great job!", "Answer Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Increment the score
            score += 1
            lblScore.Text = $"Score: {score}" ' Update the score label in the UI
            ' Load the next question only if the answer is correct
            ShowRandomQuestion()
        Else
            MessageBox.Show("Incorrect. Try again.", "Answer Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Increment the incorrect answers count
            incorrectAnswers += 1
            lblIncorrect.Text = $"Incorrect: {incorrectAnswers}" ' Update the incorrect answers label
        End If
    End Sub

    Private Sub EndQuiz()
        ' Stop the timer
        quizTimer1.Stop()
        ' Calculate and display the total time taken, the score, and the number of incorrect answers
        elapsedTime = DateTime.Now - startTime
        Dim totalSeconds As String = elapsedTime.TotalSeconds.ToString("F2")
        MessageBox.Show($"You completed the quiz in {totalSeconds} seconds! " &
                            $"Your score is {score}, and you got {incorrectAnswers} answers wrong.",
                            "Quiz Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Save results to the database
        SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, gameRemark)

        Dim game2score As New Game2score
        game2score.Show()
        Me.Hide() ' Close the form or navigate to another screen
    End Sub

    Private Sub SaveResultsToDatabase(playDate As String, uScore As Integer, uIncorrect As Integer, uTime As TimeSpan, remark As String)
        Using connection As New OleDbConnection(Module2.connectionString)
            Dim query As String = "INSERT INTO HSMG2 (playDate, uScore, InScore, uTimer, remarks) VALUES (@playDate, @uScore, @InScore, @uTimer, @remarks)"
            Dim command As New OleDbCommand(query, connection)

            ' Set parameters
            command.Parameters.AddWithValue("@playDate", playDate)
            command.Parameters.AddWithValue("@uScore", uScore)
            command.Parameters.AddWithValue("@InScore", uIncorrect)
            command.Parameters.AddWithValue("@uTimer", $"{uTime.Minutes:00}:{uTime.Seconds:00}")
            command.Parameters.AddWithValue("@remarks", remark)

            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error saving results: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function ShuffleAnswers(answers As List(Of String)) As List(Of String)
        Return answers.OrderBy(Function(a) random.Next()).ToList()
    End Function

    Private Sub EnableAnswerButtons(enable As Boolean)
        btnAnswer1.Enabled = enable
        btnAnswer2.Enabled = enable
        btnAnswer3.Enabled = enable
        btnAnswer4.Enabled = enable
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' Confirm if the user wants to go back to the main menu
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to return to the main menu? Your progress will be marked as incomplete.",
                                                         "Return to Main Menu",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Mark the game as incomplete and save the data
            elapsedTime = DateTime.Now - startTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, "incomplete")

            ' Close the form to return to the main menu
            Dim game2score As New Game2score
            game2score.Show()
            Me.Close()
        End If
    End Sub
End Class