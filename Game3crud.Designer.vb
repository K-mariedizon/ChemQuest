<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game3crud
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtQuestionnn = New TextBox()
        txtRandomAnswersss = New TextBox()
        txtCorrectAnswerrr = New TextBox()
        btncancelll = New Button()
        btndeleteee = New Button()
        btnupdateee = New Button()
        btnadddd = New Button()
        lstboxMG3 = New ListBox()
        grpG3 = New GroupBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        grpG3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(272, 363)
        Label5.Name = "Label5"
        Label5.Size = New Size(196, 17)
        Label5.TabIndex = 41
        Label5.Text = "Ex: apple, orange, grapes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(171, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(403, 17)
        Label4.TabIndex = 40
        Label4.Text = "Note: Use Comma for seperating the random answers."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(81, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 17)
        Label3.TabIndex = 39
        Label3.Text = "Question"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 17)
        Label2.TabIndex = 38
        Label2.Text = "Correct Answer "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 255)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 37
        Label1.Text = "Random Answers"
        ' 
        ' txtQuestionnn
        ' 
        txtQuestionnn.Location = New Point(158, 61)
        txtQuestionnn.Margin = New Padding(3, 4, 3, 4)
        txtQuestionnn.Multiline = True
        txtQuestionnn.Name = "txtQuestionnn"
        txtQuestionnn.Size = New Size(423, 78)
        txtQuestionnn.TabIndex = 36
        ' 
        ' txtRandomAnswersss
        ' 
        txtRandomAnswersss.Location = New Point(158, 252)
        txtRandomAnswersss.Margin = New Padding(3, 4, 3, 4)
        txtRandomAnswersss.Multiline = True
        txtRandomAnswersss.Name = "txtRandomAnswersss"
        txtRandomAnswersss.Size = New Size(423, 90)
        txtRandomAnswersss.TabIndex = 35
        ' 
        ' txtCorrectAnswerrr
        ' 
        txtCorrectAnswerrr.Location = New Point(158, 166)
        txtCorrectAnswerrr.Margin = New Padding(3, 4, 3, 4)
        txtCorrectAnswerrr.Multiline = True
        txtCorrectAnswerrr.Name = "txtCorrectAnswerrr"
        txtCorrectAnswerrr.Size = New Size(423, 59)
        txtCorrectAnswerrr.TabIndex = 34
        ' 
        ' btncancelll
        ' 
        btncancelll.BackColor = Color.OldLace
        btncancelll.FlatStyle = FlatStyle.Flat
        btncancelll.Font = New Font("Arial Rounded MT Bold", 9F)
        btncancelll.Location = New Point(1136, 513)
        btncancelll.Margin = New Padding(3, 4, 3, 4)
        btncancelll.Name = "btncancelll"
        btncancelll.Size = New Size(96, 32)
        btncancelll.TabIndex = 33
        btncancelll.Text = "Cancel"
        btncancelll.UseVisualStyleBackColor = False
        ' 
        ' btndeleteee
        ' 
        btndeleteee.BackColor = Color.OldLace
        btndeleteee.FlatStyle = FlatStyle.Flat
        btndeleteee.Font = New Font("Arial Rounded MT Bold", 9F)
        btndeleteee.Location = New Point(995, 513)
        btndeleteee.Margin = New Padding(3, 4, 3, 4)
        btndeleteee.Name = "btndeleteee"
        btndeleteee.Size = New Size(96, 32)
        btndeleteee.TabIndex = 32
        btndeleteee.Text = "Delete"
        btndeleteee.UseVisualStyleBackColor = False
        ' 
        ' btnupdateee
        ' 
        btnupdateee.BackColor = Color.OldLace
        btnupdateee.FlatStyle = FlatStyle.Flat
        btnupdateee.Font = New Font("Arial Rounded MT Bold", 9F)
        btnupdateee.Location = New Point(857, 513)
        btnupdateee.Margin = New Padding(3, 4, 3, 4)
        btnupdateee.Name = "btnupdateee"
        btnupdateee.Size = New Size(96, 32)
        btnupdateee.TabIndex = 31
        btnupdateee.Text = "Update"
        btnupdateee.UseVisualStyleBackColor = False
        ' 
        ' btnadddd
        ' 
        btnadddd.BackColor = Color.OldLace
        btnadddd.FlatStyle = FlatStyle.Flat
        btnadddd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnadddd.Location = New Point(712, 513)
        btnadddd.Margin = New Padding(3, 4, 3, 4)
        btnadddd.Name = "btnadddd"
        btnadddd.Size = New Size(96, 32)
        btnadddd.TabIndex = 30
        btnadddd.Text = "Add "
        btnadddd.UseVisualStyleBackColor = False
        ' 
        ' lstboxMG3
        ' 
        lstboxMG3.BackColor = Color.OldLace
        lstboxMG3.FormattingEnabled = True
        lstboxMG3.Location = New Point(27, 81)
        lstboxMG3.Margin = New Padding(3, 4, 3, 4)
        lstboxMG3.Name = "lstboxMG3"
        lstboxMG3.Size = New Size(556, 484)
        lstboxMG3.TabIndex = 29
        ' 
        ' grpG3
        ' 
        grpG3.BackColor = Color.OldLace
        grpG3.Controls.Add(txtQuestionnn)
        grpG3.Controls.Add(Label5)
        grpG3.Controls.Add(txtCorrectAnswerrr)
        grpG3.Controls.Add(Label4)
        grpG3.Controls.Add(txtRandomAnswersss)
        grpG3.Controls.Add(Label3)
        grpG3.Controls.Add(Label1)
        grpG3.Controls.Add(Label2)
        grpG3.Font = New Font("Arial Rounded MT Bold", 9F)
        grpG3.Location = New Point(646, 65)
        grpG3.Name = "grpG3"
        grpG3.Size = New Size(614, 420)
        grpG3.TabIndex = 42
        grpG3.TabStop = False
        grpG3.Text = "Game3 Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Tan
        PictureBox1.Location = New Point(622, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(661, 523)
        PictureBox1.TabIndex = 69
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Goudy Stout", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.OldLace
        Label7.Location = New Point(27, 42)
        Label7.Name = "Label7"
        Label7.Size = New Size(241, 24)
        Label7.TabIndex = 70
        Label7.Text = "GAME 3 - EDIT"
        ' 
        ' Game3crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(1314, 614)
        Controls.Add(Label7)
        Controls.Add(grpG3)
        Controls.Add(btncancelll)
        Controls.Add(btndeleteee)
        Controls.Add(btnupdateee)
        Controls.Add(btnadddd)
        Controls.Add(lstboxMG3)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Game3crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game3crud"
        TopMost = True
        grpG3.ResumeLayout(False)
        grpG3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuestionnn As TextBox
    Friend WithEvents txtRandomAnswersss As TextBox
    Friend WithEvents txtCorrectAnswerrr As TextBox
    Friend WithEvents btncancelll As Button
    Friend WithEvents btndeleteee As Button
    Friend WithEvents btnupdateee As Button
    Friend WithEvents btnadddd As Button
    Friend WithEvents lstboxMG3 As ListBox
    Friend WithEvents grpG3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
