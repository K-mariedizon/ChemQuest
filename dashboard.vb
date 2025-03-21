Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Text = "Welcome" & Form1.Name
    End Sub

    Private Sub dashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim Login As New Login
        Login.Show()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Dim mainmenuForm As New btnPass
        mainmenuForm.Show()

    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim admin As New Admin
        admin.Show()
    End Sub
End Class