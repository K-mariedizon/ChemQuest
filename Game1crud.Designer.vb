<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game1crud
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lstboxMG = New ListBox()
        txtQuestion = New TextBox()
        txtCorrectAnswer = New TextBox()
        txtRandomAnswer = New TextBox()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        btncancel = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        grpG1 = New GroupBox()
        grpG1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstboxMG
        ' 
        lstboxMG.FormattingEnabled = True
        lstboxMG.Location = New Point(12, 69)
        lstboxMG.Name = "lstboxMG"
        lstboxMG.Size = New Size(365, 484)
        lstboxMG.TabIndex = 0
        ' 
        ' txtQuestion
        ' 
        txtQuestion.Location = New Point(170, 68)
        txtQuestion.Multiline = True
        txtQuestion.Name = "txtQuestion"
        txtQuestion.Size = New Size(414, 85)
        txtQuestion.TabIndex = 1
        ' 
        ' txtCorrectAnswer
        ' 
        txtCorrectAnswer.Location = New Point(170, 171)
        txtCorrectAnswer.Multiline = True
        txtCorrectAnswer.Name = "txtCorrectAnswer"
        txtCorrectAnswer.Size = New Size(414, 87)
        txtCorrectAnswer.TabIndex = 2
        ' 
        ' txtRandomAnswer
        ' 
        txtRandomAnswer.Location = New Point(170, 281)
        txtRandomAnswer.Multiline = True
        txtRandomAnswer.Name = "txtRandomAnswer"
        txtRandomAnswer.Size = New Size(414, 79)
        txtRandomAnswer.TabIndex = 3
        ' 
        ' btnadd
        ' 
        btnadd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnadd.Location = New Point(511, 573)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(94, 29)
        btnadd.TabIndex = 4
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Font = New Font("Arial Rounded MT Bold", 9F)
        btnupdate.Location = New Point(647, 573)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(94, 29)
        btnupdate.TabIndex = 5
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Font = New Font("Arial Rounded MT Bold", 9F)
        btndelete.Location = New Point(771, 573)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 6
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btncancel
        ' 
        btncancel.Font = New Font("Arial Rounded MT Bold", 9F)
        btncancel.Location = New Point(896, 573)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(94, 29)
        btncancel.TabIndex = 7
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(170, 363)
        Label4.Name = "Label4"
        Label4.Size = New Size(408, 17)
        Label4.TabIndex = 18
        Label4.Text = "(Note: Use Comma for seperating the random answers)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 17)
        Label3.TabIndex = 17
        Label3.Text = "Questions:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 17)
        Label2.TabIndex = 16
        Label2.Text = "Correct Answer: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 284)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 17)
        Label1.TabIndex = 15
        Label1.Text = "Random Answers:"
        ' 
        ' grpG1
        ' 
        grpG1.Controls.Add(txtQuestion)
        grpG1.Controls.Add(Label4)
        grpG1.Controls.Add(txtCorrectAnswer)
        grpG1.Controls.Add(Label3)
        grpG1.Controls.Add(txtRandomAnswer)
        grpG1.Controls.Add(Label2)
        grpG1.Controls.Add(Label1)
        grpG1.Font = New Font("Arial Rounded MT Bold", 9F)
        grpG1.Location = New Point(412, 79)
        grpG1.Name = "grpG1"
        grpG1.Size = New Size(657, 474)
        grpG1.TabIndex = 19
        grpG1.TabStop = False
        grpG1.Text = "Game1 Information"
        ' 
        ' Game1crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1122, 647)
        Controls.Add(grpG1)
        Controls.Add(btncancel)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(lstboxMG)
        Name = "Game1crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game1crud"
        TopMost = True
        grpG1.ResumeLayout(False)
        grpG1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstboxMG As ListBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtCorrectAnswer As TextBox
    Friend WithEvents txtRandomAnswer As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpG1 As GroupBox
End Class
