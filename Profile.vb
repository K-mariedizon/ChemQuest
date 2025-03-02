
Imports System.Data.OleDb
Public Class Profile
    Dim username As String
    Dim op1 As Integer

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPword.Enabled = False
        accountDataSet.Clear()
        accountSet()

        If accountDataSet.Tables("accountTbl").Rows.Count > 0 Then
            Dim firstRow = accountDataSet.Tables("accountTbl").Rows(0)
            txtUname.Text = firstRow("Uname").ToString()
            txtPword.Text = firstRow("Pword").ToString()
        End If


    End Sub

    Sub clearRecord()
        txtUname.Text = ""
        txtPword.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPword.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            txtPword.Enabled = True
            btnUpdate.Text = "Save"
        ElseIf btnUpdate.Text = "Save" Then
            If txtPword.Text = "" Then
                MessageBox.Show("Fill up all fields!", "Error", MessageBoxButtons.OK)
                Return
            End If

            ' Search for the username
            For ctr = 0 To accountDataSet.Tables("accountTbl").Rows.Count - 1
                Dim drow = accountDataSet.Tables("accountTbl").Rows(ctr)
                If drow("Uname").ToString() = txtUname.Text Then
                    op1 = ctr
                    username = drow("Uname").ToString()
                    Exit For
                End If
            Next


            Dim drowUpdate = accountDataSet.Tables("accountTbl").Rows(op1)
            drowUpdate("Pword") = txtPword.Text

            BuilderConn(oledbAdapterAccount)
            oledbAdapterAccount.Update(accountDataSet, "accountTbl")

            MessageBox.Show("Successfully Updated!", "Information", MessageBoxButtons.OK)
            clearRecord()
            Me.Hide()
        End If

    End Sub


End Class