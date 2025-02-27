Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome" & Form1.Name

        If Login.level = 1 Then
            btnA.Enabled = False
        ElseIf Login.level = 2 Then
            btnS.Enabled = False
        End If
    End Sub

    Private Sub dashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Login As New Login
        Login.Show()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        If Login.level = 1 Then
            Dim mainmenuForm As New Form1
            mainmenuForm.Show()
            Me.Hide()
        ElseIf Login.level = 2 Then


        End If

    End Sub
End Class