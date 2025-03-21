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
        txtRandomAnswers = New TextBox()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        btncancel = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        grpG1 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        grpG1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstboxMG
        ' 
        lstboxMG.BackColor = Color.OldLace
        lstboxMG.ForeColor = Color.Black
        lstboxMG.FormattingEnabled = True
        lstboxMG.Location = New Point(33, 86)
        lstboxMG.Name = "lstboxMG"
        lstboxMG.Size = New Size(424, 504)
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
        ' txtRandomAnswers
        ' 
        txtRandomAnswers.Location = New Point(170, 281)
        txtRandomAnswers.Multiline = True
        txtRandomAnswers.Name = "txtRandomAnswers"
        txtRandomAnswers.Size = New Size(414, 79)
        txtRandomAnswers.TabIndex = 3
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.OldLace
        btnadd.FlatStyle = FlatStyle.Flat
        btnadd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnadd.Location = New Point(585, 540)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(94, 29)
        btnadd.TabIndex = 4
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.OldLace
        btnupdate.FlatStyle = FlatStyle.Flat
        btnupdate.Font = New Font("Arial Rounded MT Bold", 9F)
        btnupdate.Location = New Point(721, 540)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(94, 29)
        btnupdate.TabIndex = 5
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.OldLace
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Arial Rounded MT Bold", 9F)
        btndelete.Location = New Point(845, 540)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 6
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.OldLace
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Arial Rounded MT Bold", 9F)
        btncancel.Location = New Point(970, 540)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(94, 29)
        btncancel.TabIndex = 7
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(176, 363)
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
        grpG1.BackColor = Color.OldLace
        grpG1.Controls.Add(txtQuestion)
        grpG1.Controls.Add(Label4)
        grpG1.Controls.Add(txtCorrectAnswer)
        grpG1.Controls.Add(Label3)
        grpG1.Controls.Add(txtRandomAnswers)
        grpG1.Controls.Add(Label2)
        grpG1.Controls.Add(Label1)
        grpG1.Font = New Font("Arial Rounded MT Bold", 9F)
        grpG1.Location = New Point(505, 58)
        grpG1.Name = "grpG1"
        grpG1.Size = New Size(638, 462)
        grpG1.TabIndex = 19
        grpG1.TabStop = False
        grpG1.Text = "Game1 Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Tan
        PictureBox1.Location = New Point(480, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(695, 567)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Goudy Stout", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.OldLace
        Label5.Location = New Point(33, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(241, 24)
        Label5.TabIndex = 21
        Label5.Text = "GAME 1 - EDIT"
        ' 
        ' Game1crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(1197, 620)
        Controls.Add(Label5)
        Controls.Add(grpG1)
        Controls.Add(btncancel)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(lstboxMG)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Game1crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game1crud"
        TopMost = True
        grpG1.ResumeLayout(False)
        grpG1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstboxMG As ListBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtCorrectAnswer As TextBox
    Friend WithEvents txtRandomAnswers As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpG1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
