Imports System.Data.OleDb

Public Class startgame3
    Private availableQuestions As List(Of DataRow) ' Holds the questions and answers
    Private currentQuestion As DataRow ' Current question being displayed
    Private random As New Random() ' Random number generator
    Private playerSpeed As Integer = 20 ' Speed of horizontal movement
    Private score As Integer = 0 ' Player's score
    Private incorrectCatches As Integer = 0 ' Count for incorrect catches
    Private gameStartTime As DateTime ' Tracks when the game started
    Private gameRemark As String = "incomplete" ' Default remark is "incomplete"
    Private WithEvents gameTimer1 As New Timer() With {.Interval = 50} ' Controls the falling speed
    Private fallingAnswers As New List(Of Label) ' List of falling answer objects
    Private Sub startgame3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Ensure the form captures key events
        LoadQuestions()
        InitializeGame()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Ensure the game is marked as incomplete if not completed
        If gameRemark = "incomplete" Then
            Dim elapsedTime As TimeSpan = DateTime.Now - gameStartTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectCatches, elapsedTime, "incomplete")
        End If
    End Sub

    Private Sub LoadQuestions()
        Dim allQuestions = Module3.GetQuestions()

        ' Randomize the list of questions
        availableQuestions = allQuestions.AsEnumerable().OrderBy(Function(q) random.Next()).ToList()

        If availableQuestions.Count = 0 Then
            MessageBox.Show("No questions available in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub InitializeGame()
        ' Reset the game state
        score = 0
        incorrectCatches = 0
        lblScore.Text = $"Score: {score}"
        lblIncorrect.Text = $"Incorrect: {incorrectCatches}"
        lblQuestion.Text = ""
        lblTime.Text = "Time: 00:00"
        gameStartTime = DateTime.Now ' Record game start time

        ' Position the player
        playerBox.Left = (gamePanel.Width - playerBox.Width) \ 2
        playerBox.Top = gamePanel.Height - playerBox.Height - 10

        ShowNextQuestion()
        gameTimer1.Start()
    End Sub

    Private Sub ShowNextQuestion()
        If availableQuestions.Count = 0 Then
            gameRemark = "complete" ' Mark the game as complete
            EndGame()
            Return
        End If

        ' Select the next question
        currentQuestion = availableQuestions(0)
        lblQuestion.Text = currentQuestion("questions").ToString()
        GenerateFallingAnswers()
    End Sub

    Private Sub GenerateFallingAnswers()
        ClearFallingAnswers()


        Dim answers As New List(Of String)(currentQuestion("randAns").ToString().Split(","c))
        answers.Add(currentQuestion("correctAns").ToString())
        answers = answers.OrderBy(Function(a) random.Next()).ToList()

        Dim existingPositions As New List(Of Rectangle)

        For Each answer As String In answers
            Dim lbl As New Label With {
                .Text = answer,
                .AutoSize = True,
                .BackColor = Color.Transparent,
                .Top = 0,
                .Tag = New With {.IsCorrect = (answer = currentQuestion("correctAns").ToString()), .Processed = False}
            }

            Dim positionValid As Boolean
            Do
                positionValid = True
                lbl.Left = random.Next(0, gamePanel.Width - lbl.Width)

                For Each existingRect In existingPositions
                    If existingRect.IntersectsWith(New Rectangle(lbl.Left, lbl.Top, lbl.Width, lbl.Height)) Then
                        positionValid = False
                        Exit For
                    End If
                Next
            Loop While Not positionValid

            existingPositions.Add(New Rectangle(lbl.Left, lbl.Top, lbl.Width, lbl.Height))
            fallingAnswers.Add(lbl)
            gamePanel.Controls.Add(lbl)
        Next
    End Sub

    Private Sub ClearFallingAnswers()
        For Each lbl In fallingAnswers.ToList()
            gamePanel.Controls.Remove(lbl)
        Next
        fallingAnswers.Clear()
    End Sub

    Private Sub gameTimer1_Tick(sender As Object, e As EventArgs) Handles gameTimer1.Tick
        Dim elapsedTime As TimeSpan = DateTime.Now - gameStartTime
        lblTime.Text = $"Time: {elapsedTime.Minutes:00}:{elapsedTime.Seconds:00}"

        For Each lbl In fallingAnswers.ToList()
            lbl.Top += 20

            If lbl.Top >= gamePanel.Height Then
                lbl.Top = 0
                lbl.Left = random.Next(0, gamePanel.Width - lbl.Width)
                Dim tagInfo = DirectCast(lbl.Tag, Object)
                lbl.Tag = New With {.IsCorrect = tagInfo.IsCorrect, .Processed = False}
                Continue For
            End If

            Dim collisionTag = DirectCast(lbl.Tag, Object)
            If playerBox.Bounds.IntersectsWith(lbl.Bounds) AndAlso Not collisionTag.Processed Then
                lbl.Tag = New With {.IsCorrect = collisionTag.IsCorrect, .Processed = True}
                HandleAnswerCatch(lbl)
                Exit For
            End If
        Next
    End Sub

    Private Sub HandleAnswerCatch(lbl As Label)
        Dim labelTag = DirectCast(lbl.Tag, Object)

        If labelTag.IsCorrect Then
            score += 1
            lblScore.Text = $"Score: {score}"
            availableQuestions.Remove(currentQuestion)
            MessageBox.Show("Correct! Good job!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Indication of a correct answer
            ShowNextQuestion()
        Else
            incorrectCatches += 1
            lblIncorrect.Text = $"Incorrect: {incorrectCatches}"
            MessageBox.Show("Wrong answer. Try again!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning) ' Indication of a wrong answer
            lbl.Top = 0
            lbl.Left = random.Next(0, gamePanel.Width - lbl.Width)
            lbl.Tag = New With {.IsCorrect = labelTag.IsCorrect, .Processed = False}
        End If
    End Sub


    Private Sub EndGame()
        gameTimer1.Stop()
        Dim totalTime As TimeSpan = DateTime.Now - gameStartTime
        MessageBox.Show($"Game Over! Score: {score}, Incorrect: {incorrectCatches}, Time: {totalTime.Minutes}:{totalTime.Seconds}.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectCatches, totalTime, gameRemark)
        Dim g2 As New Game3score()
        g2.Show()
        Me.Close()
    End Sub

    Private Sub SaveResultsToDatabase(playDate As String, uScore As Integer, uIncorrect As Integer, uTime As TimeSpan, remark As String)
        Using connection As New OleDbConnection(Module3.ConnectionString)
            Dim query As String = "INSERT INTO HSMG3 (playDate, uScore, InScore, uTimer, remarks) VALUES (@playDate, @uScore, @InScore, @uTimer, @remarks)"
            Dim command As New OleDbCommand(query, connection)
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

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to return to the main menu? Your progress will be marked as incomplete.",
                                                     "Return to Main Menu",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim elapsedTime As TimeSpan = DateTime.Now - gameStartTime
            SaveResultsToDatabase(DateTime.Now.ToString("yyyy-MM-dd"), score, incorrectCatches, elapsedTime, "incomplete")
            Dim g3 As New Game3score
            g3.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            playerBox.Left = Math.Max(0, playerBox.Left - playerSpeed)
        ElseIf e.KeyCode = Keys.D Then
            playerBox.Left = Math.Min(gamePanel.Width - playerBox.Width, playerBox.Left + playerSpeed)
        End If
    End Sub

    Private Sub gamePanel_Paint(sender As Object, e As PaintEventArgs) Handles gamePanel.Paint

    End Sub
End Class