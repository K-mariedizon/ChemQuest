Imports System.Data.OleDb

Public Class startgame1
    Private availableQuestions As List(Of DataRow)
    Private startTime As DateTime
    Private score As Integer = 0
    Private incorrectAnswers As Integer = 0
    Private random As New Random()
    Private currentQuestionRow As DataRow
    Private gameRemark As String = "incomplete" ' Default remark is "incomplete"
    Private Sub startgame1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize game state
        startTime = DateTime.Now
        score = 0
        incorrectAnswers = 0

        ' Fetch questions from the database
        Dim questionDataTable As DataTable = DatabaseModule.GetQuestions()
        If questionDataTable Is Nothing OrElse questionDataTable.Rows.Count = 0 Then
            MessageBox.Show("No questions available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            availableQuestions = questionDataTable.AsEnumerable().ToList()
            ShowNextQuestion()
            gameTimer.Start()
        End If
    End Sub



    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        ' Update the timer display
        Dim elapsedTime As TimeSpan = DateTime.Now - startTime
        lblTimer.Text = $"Time: {elapsedTime.Minutes:00}:{elapsedTime.Seconds:00}"
    End Sub

    Private Sub ShowNextQuestion()
        If availableQuestions.Count = 0 Then
            ' All questions answered
            gameRemark = "complete" ' Mark game as complete
            EndGame()
            Return
        End If

        ' Randomly select a question
        Dim randomIndex As Integer = random.Next(availableQuestions.Count)
        currentQuestionRow = availableQuestions(randomIndex)

        ' Remove the selected question
        availableQuestions.RemoveAt(randomIndex)

        ' Prepare question and answers
        Dim question As String = currentQuestionRow("questions").ToString()
        Dim correctAnswer As String = currentQuestionRow("correctAns").ToString()
        Dim randomAnswers As String = currentQuestionRow("randAns").ToString()

        ' Create and shuffle the answers
        Dim answers As New List(Of String)(randomAnswers.Split(","c))
        answers.Add(correctAnswer)
        answers = ShuffleAnswers(answers)

        ' Display question and assign answers
        lblQuestion.Text = question
        btnAnswer1.Text = answers(0)
        btnAnswer2.Text = answers(1)
        btnAnswer3.Text = answers(2)
        btnAnswer4.Text = answers(3)

        ' Tag answers to buttons
        btnAnswer1.Tag = (answers(0) = correctAnswer)
        btnAnswer2.Tag = (answers(1) = correctAnswer)
        btnAnswer3.Tag = (answers(2) = correctAnswer)
        btnAnswer4.Tag = (answers(3) = correctAnswer)

        ' Enable answer buttons
        EnableAnswerButtons(True)
    End Sub

    Private Sub AnswerButton_Click(sender As Object, e As EventArgs) Handles btnAnswer1.Click, btnAnswer2.Click, btnAnswer3.Click, btnAnswer4.Click
        Dim button As Button = CType(sender, Button)
        Dim isCorrect As Boolean = CType(button.Tag, Boolean)

        If isCorrect Then
            MessageBox.Show("Correct!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            score += 1
            lblScore.Text = $"Score: {score}"
            ShowNextQuestion()
        Else
            MessageBox.Show("Incorrect! Try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            incorrectAnswers += 1
            lblIncorrect.Text = $"Incorrect: {incorrectAnswers}"
        End If
    End Sub

    Private Sub EndGame()
        ' Stop the timer and calculate elapsed time
        gameTimer.Stop()
        Dim elapsedTime As TimeSpan = DateTime.Now - startTime
        Dim totalSeconds As String = elapsedTime.TotalSeconds.ToString("F2")

        ' Save results with the current date and remark (complete or incomplete)
        SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, gameRemark)

        ' Display game summary
        MessageBox.Show($"You completed the quiz in {totalSeconds} seconds! " &
                        $"Your final score is {score}, and you got {incorrectAnswers} answers wrong.",
                        "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim game1score As New Game1score
        game1score.Show()
        Me.Close()
    End Sub

    Private Sub SaveResultsToDatabase(datePlayed As String, uScore As Integer, uIncorrect As Integer, uTime As TimeSpan, remark As String)
        Using connection As New OleDbConnection(DatabaseModule.connectionString)
            Dim query As String = "INSERT INTO HSMG1 (playDate, uScore, InScore, uTimer, remarks) VALUES (@playDate, @uScore, @InScore, @uTimer, @remarks)"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@playDate", datePlayed)
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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If the game is closing and was not marked complete, save it as incomplete
        If gameRemark = "incomplete" Then
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, "incomplete")
        End If
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
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectAnswers, elapsedTime, "incomplete")

            ' Close the form to return to the main menu
            Dim game1score As New Game1score
            game1score.Show()
            Me.Close()
        End If
    End Sub

End Class