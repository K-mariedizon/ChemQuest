Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class reviewerCrud
    Private Sub reviewerCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDataSet.Clear()
        stateControl(True, True, False)
        If OpenConnection() Then
            notesSet() ' Load data into DataSet
            LoadChapters()
        End If
    End Sub

    Private Sub LoadChapters()
        Dim dt As DataTable = accountDataSet.Tables("SubtopicsTbl")
        Dim distinctChapters As DataTable = dt.DefaultView.ToTable(True, "chapter")

        ' Bind to ComboBox
        cmbChap.DataSource = distinctChapters
        cmbChap.DisplayMember = "chapter"

    End Sub

    Sub stateControl(ByVal c As Boolean, ByVal lst As Boolean, ByVal grp As Boolean)
        cmbChap.Enabled = c
        lsbSub.Enabled = lst
        grpDisplay.Enabled = grp
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
    End Sub

    Private Sub cmbChap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChap.SelectedIndexChanged
        Dim selectedChapter As String = cmbChap.Text
        Dim dt As DataTable = accountDataSet.Tables("SubtopicsTbl")

        ' Filter subtopics based on the selected chapter
        Dim rows() As DataRow = dt.Select("chapter = '" & selectedChapter & "'")

        If rows.Length > 0 Then
            Dim subtopics As DataTable = rows.CopyToDataTable()
            lsbSub.DataSource = subtopics
            lsbSub.DisplayMember = "Subtitle"
        Else
            lsbSub.DataSource = Nothing ' Clear if no subtopics exist
        End If
    End Sub

    Private Sub lsbSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbSub.SelectedIndexChanged
        If lsbSub.SelectedItem IsNot Nothing Then
            Dim selectedChapter As String = cmbChap.Text
            Dim selectedSubtopic As String = lsbSub.Text
            Dim dt As DataTable = accountDataSet.Tables("SubtopicsTbl")

            ' Find the corresponding note
            Dim rows() As DataRow = dt.Select("chapter = '" & selectedChapter & "' AND Subtitle = '" & selectedSubtopic & "'")

            If rows.Length > 0 Then
                txtChap.Text = selectedChapter
                txtSub.Text = selectedSubtopic
                txtNotes.Text = rows(0)("notes").ToString()
            Else
                txtNotes.Clear()
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtChap.Clear()
        txtSub.Clear()
        txtNotes.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            lsbSub.ClearSelected()
            stateControl(False, False, True)
            ClearFields()
            btnAdd.Text = "Save"
        ElseIf btnAdd.Text = "Save" Then

            If txtChap.Text = "" Or txtSub.Text = "" Or txtNotes.Text = "" Then
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim newRow As DataRow = accountDataSet.Tables("SubtopicsTbl").NewRow()
            newRow("chapter") = txtChap.Text
            newRow("Subtitle") = txtSub.Text
            newRow("notes") = txtNotes.Text
            accountDataSet.Tables("SubtopicsTbl").Rows.Add(newRow)

            ' Update database
            BuilderConn(oledbAdapterAccount)
            oledbAdapterAccount.Update(accountDataSet, "SubtopicsTbl")

            MessageBox.Show("Note added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh UI
            btnAdd.Text = "Add"
            LoadChapters()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            lsbSub.ClearSelected()
            stateControl(True, True, False)
            ClearFields()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtChap.Text = "" Or txtSub.Text = "" Or txtNotes.Text = "" Then
            MessageBox.Show("Please select a note to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If btnUpdate.Text = "Update" Then
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            stateControl(False, False, True)
            txtChap.Enabled = False
            txtSub.Enabled = False
            btnUpdate.Text = "Save"
        ElseIf btnUpdate.Text = "Save" Then

            Dim dt As DataTable = accountDataSet.Tables("SubtopicsTbl")
            Dim rows() As DataRow = dt.Select("chapter = '" & txtChap.Text & "' AND Subtitle = '" & txtSub.Text & "'")

            If rows.Length > 0 Then
                rows(0)("notes") = txtNotes.Text

                ' Update database
                BuilderConn(oledbAdapterAccount)
                oledbAdapterAccount.Update(accountDataSet, "SubtopicsTbl")

                MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnUpdate.Text = "Update"
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                stateControl(True, True, False)
            Else
                MessageBox.Show("No record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        grpDisplay.Enabled = False
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        stateControl(False, False, True)
        If txtChap.Text = "" Or txtSub.Text = "" Then
            MessageBox.Show("Please select a note to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Do you want to delete this whole chapter?", "delete Note", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dt As DataTable = accountDataSet.Tables("SubtopicsTbl")
            Dim rows() As DataRow = dt.Select("chapter = '" & txtChap.Text & "' AND Subtitle = '" & txtSub.Text & "'")

            If rows.Length > 0 Then
                rows(0).Delete()

                ' Update database
                BuilderConn(oledbAdapterAccount)
                oledbAdapterAccount.Update(accountDataSet, "SubtopicsTbl")

                MessageBox.Show("Chapter deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh UI
                LoadChapters()
                ClearFields()
                btnAdd.Enabled = True
                btnUpdate.Enabled = True
                stateControl(True, True, False)
            Else
                MessageBox.Show("No record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        stateControl(True, True, False)
        ClearFields()
    End Sub


End Class