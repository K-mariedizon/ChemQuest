﻿Public Class MnemoForm
    Private Sub btnMnemo_Click(sender As Object, e As EventArgs) Handles btnMnemo.Click
        Dim mnemoForm As New MnemoForm
        mnemoForm.Show()
        Hide()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        Dim gameForm As New MiniGamesForm()
        gameForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    'Private Sub btnChap1_Click(sender As Object, e As EventArgs)
    '    Dim chap1Form As New Chapter1
    '    chap1Form.Show
    '    Hide
    'End Sub

    'Private Sub btnChap2_Click(sender As Object, e As EventArgs)
    '    Dim chap2Form As New Chapter2
    '    chap2Form.Show
    '    Hide
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()
        Hide()
    End Sub

    Private Sub btnReviewer1_Click(sender As Object, e As EventArgs) Handles btnReviewer1.Click
        Dim reviewerForm As New ReviewerForm
        reviewerForm.Show()
        Hide()
    End Sub

    'Private Sub btnChap3_Click(sender As Object, e As EventArgs)
    '    Dim chap3Form As New Chapter3
    '    chap3Form.Show
    '    Hide
    'End Sub

    Private Sub btnnote1_Click(sender As Object, e As EventArgs) Handles btnnote1.Click
        Dim notesForm As New NoteViewerForm("note1.txt")
        notesForm.ShowDialog()
    End Sub

    Private Sub btnnote2_Click(sender As Object, e As EventArgs) Handles btnnote2.Click
        Dim notesForm As New NoteViewerForm("note2.txt")
        notesForm.ShowDialog()
    End Sub

    Private Sub btnnote3_Click(sender As Object, e As EventArgs) Handles btnnote3.Click
        Dim notesForm As New NoteViewerForm("note3.txt")
        notesForm.ShowDialog()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim m As New Mnemo1
        m.Show()
        Hide()
    End Sub

    Private Sub MnemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class