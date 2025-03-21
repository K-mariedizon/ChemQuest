<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game2crud
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
        Label9 = New Label()
        Label8 = New Label()
        te = New Label()
        label = New Label()
        txtquestionn = New TextBox()
        txtCorrectAnswerr = New TextBox()
        txtRandAnss = New TextBox()
        txtLabResults = New TextBox()
        txtMedicalHistory = New TextBox()
        txtGender = New TextBox()
        txtAge = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btncancell = New Button()
        btndeletee = New Button()
        btnupdate = New Button()
        btnaddd = New Button()
        lstboxMG2 = New ListBox()
        grpG2 = New GroupBox()
        txtPatientName = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        grpG2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 7.8F)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(696, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 15)
        Label5.TabIndex = 66
        Label5.Text = "Ex: apple, orange, grapes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 7.8F)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(591, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(356, 15)
        Label4.TabIndex = 65
        Label4.Text = "Note: Use Comma for seperating the random answers."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(41, 303)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 17)
        Label9.TabIndex = 64
        Label9.Text = "Lab Results"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 17)
        Label8.TabIndex = 63
        Label8.Text = "Medical History"
        ' 
        ' te
        ' 
        te.AutoSize = True
        te.Location = New Point(71, 146)
        te.Name = "te"
        te.Size = New Size(63, 17)
        te.TabIndex = 62
        te.Text = "Gender"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(97, 94)
        label.Name = "label"
        label.Size = New Size(37, 17)
        label.TabIndex = 61
        label.Text = "Age"
        ' 
        ' txtquestionn
        ' 
        txtquestionn.Location = New Point(627, 118)
        txtquestionn.Margin = New Padding(3, 4, 3, 4)
        txtquestionn.Multiline = True
        txtquestionn.Name = "txtquestionn"
        txtquestionn.Size = New Size(294, 55)
        txtquestionn.TabIndex = 60
        ' 
        ' txtCorrectAnswerr
        ' 
        txtCorrectAnswerr.Location = New Point(627, 198)
        txtCorrectAnswerr.Margin = New Padding(3, 4, 3, 4)
        txtCorrectAnswerr.Multiline = True
        txtCorrectAnswerr.Name = "txtCorrectAnswerr"
        txtCorrectAnswerr.Size = New Size(294, 55)
        txtCorrectAnswerr.TabIndex = 59
        ' 
        ' txtRandAnss
        ' 
        txtRandAnss.Location = New Point(627, 276)
        txtRandAnss.Margin = New Padding(3, 4, 3, 4)
        txtRandAnss.Multiline = True
        txtRandAnss.Name = "txtRandAnss"
        txtRandAnss.Size = New Size(294, 55)
        txtRandAnss.TabIndex = 58
        ' 
        ' txtLabResults
        ' 
        txtLabResults.Location = New Point(135, 303)
        txtLabResults.Margin = New Padding(3, 4, 3, 4)
        txtLabResults.Multiline = True
        txtLabResults.Name = "txtLabResults"
        txtLabResults.Size = New Size(317, 121)
        txtLabResults.TabIndex = 57
        ' 
        ' txtMedicalHistory
        ' 
        txtMedicalHistory.Location = New Point(135, 197)
        txtMedicalHistory.Margin = New Padding(3, 4, 3, 4)
        txtMedicalHistory.Multiline = True
        txtMedicalHistory.Name = "txtMedicalHistory"
        txtMedicalHistory.Size = New Size(317, 82)
        txtMedicalHistory.TabIndex = 56
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(135, 146)
        txtGender.Margin = New Padding(3, 4, 3, 4)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(161, 25)
        txtGender.TabIndex = 55
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(135, 94)
        txtAge.Margin = New Padding(3, 4, 3, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(161, 25)
        txtAge.TabIndex = 54
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(491, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 53
        Label1.Text = "Random Answers"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(540, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 17)
        Label3.TabIndex = 52
        Label3.Text = "Questions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(498, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 17)
        Label2.TabIndex = 51
        Label2.Text = "Correct Answer "
        ' 
        ' btncancell
        ' 
        btncancell.BackColor = Color.OldLace
        btncancell.FlatStyle = FlatStyle.Flat
        btncancell.Font = New Font("Arial Rounded MT Bold", 9F)
        btncancell.Location = New Point(1034, 590)
        btncancell.Margin = New Padding(3, 4, 3, 4)
        btncancell.Name = "btncancell"
        btncancell.Size = New Size(95, 31)
        btncancell.TabIndex = 50
        btncancell.Text = "Cancel"
        btncancell.UseVisualStyleBackColor = False
        ' 
        ' btndeletee
        ' 
        btndeletee.BackColor = Color.OldLace
        btndeletee.FlatStyle = FlatStyle.Flat
        btndeletee.Font = New Font("Arial Rounded MT Bold", 9F)
        btndeletee.Location = New Point(894, 590)
        btndeletee.Margin = New Padding(3, 4, 3, 4)
        btndeletee.Name = "btndeletee"
        btndeletee.Size = New Size(95, 31)
        btndeletee.TabIndex = 49
        btndeletee.Text = "Delete"
        btndeletee.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.OldLace
        btnupdate.FlatStyle = FlatStyle.Flat
        btnupdate.Font = New Font("Arial Rounded MT Bold", 9F)
        btnupdate.Location = New Point(759, 590)
        btnupdate.Margin = New Padding(3, 4, 3, 4)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(95, 31)
        btnupdate.TabIndex = 48
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btnaddd
        ' 
        btnaddd.BackColor = Color.OldLace
        btnaddd.FlatStyle = FlatStyle.Flat
        btnaddd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnaddd.Location = New Point(609, 590)
        btnaddd.Margin = New Padding(3, 4, 3, 4)
        btnaddd.Name = "btnaddd"
        btnaddd.Size = New Size(95, 31)
        btnaddd.TabIndex = 47
        btnaddd.Text = "Add"
        btnaddd.UseVisualStyleBackColor = False
        ' 
        ' lstboxMG2
        ' 
        lstboxMG2.BackColor = Color.OldLace
        lstboxMG2.FormattingEnabled = True
        lstboxMG2.Location = New Point(25, 114)
        lstboxMG2.Margin = New Padding(3, 4, 3, 4)
        lstboxMG2.Name = "lstboxMG2"
        lstboxMG2.Size = New Size(300, 524)
        lstboxMG2.TabIndex = 46
        ' 
        ' grpG2
        ' 
        grpG2.BackColor = Color.OldLace
        grpG2.Controls.Add(txtPatientName)
        grpG2.Controls.Add(Label6)
        grpG2.Controls.Add(txtAge)
        grpG2.Controls.Add(Label5)
        grpG2.Controls.Add(Label2)
        grpG2.Controls.Add(Label4)
        grpG2.Controls.Add(Label3)
        grpG2.Controls.Add(Label9)
        grpG2.Controls.Add(Label1)
        grpG2.Controls.Add(Label8)
        grpG2.Controls.Add(txtGender)
        grpG2.Controls.Add(te)
        grpG2.Controls.Add(txtMedicalHistory)
        grpG2.Controls.Add(label)
        grpG2.Controls.Add(txtLabResults)
        grpG2.Controls.Add(txtquestionn)
        grpG2.Controls.Add(txtRandAnss)
        grpG2.Controls.Add(txtCorrectAnswerr)
        grpG2.Font = New Font("Arial Rounded MT Bold", 9F)
        grpG2.Location = New Point(386, 80)
        grpG2.Name = "grpG2"
        grpG2.Size = New Size(954, 486)
        grpG2.TabIndex = 67
        grpG2.TabStop = False
        grpG2.Text = "Game2 Information"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(135, 48)
        txtPatientName.Margin = New Padding(3, 4, 3, 4)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(161, 25)
        txtPatientName.TabIndex = 67
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(84, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 17)
        Label6.TabIndex = 68
        Label6.Text = "Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Tan
        PictureBox1.Location = New Point(359, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1008, 582)
        PictureBox1.TabIndex = 68
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Goudy Stout", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.OldLace
        Label7.Location = New Point(25, 66)
        Label7.Name = "Label7"
        Label7.Size = New Size(241, 24)
        Label7.TabIndex = 69
        Label7.Text = "GAME 2 - EDIT"
        ' 
        ' Game2crud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(1379, 688)
        Controls.Add(Label7)
        Controls.Add(grpG2)
        Controls.Add(btncancell)
        Controls.Add(btndeletee)
        Controls.Add(btnupdate)
        Controls.Add(btnaddd)
        Controls.Add(lstboxMG2)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Game2crud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game2crud"
        TopMost = True
        grpG2.ResumeLayout(False)
        grpG2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents te As Label
    Friend WithEvents label As Label
    Friend WithEvents txtquestionn As TextBox
    Friend WithEvents txtCorrectAnswerr As TextBox
    Friend WithEvents txtRandAnss As TextBox
    Friend WithEvents txtLabResults As TextBox
    Friend WithEvents txtMedicalHistory As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btncancell As Button
    Friend WithEvents btndeletee As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnaddd As Button
    Friend WithEvents lstboxMG2 As ListBox
    Friend WithEvents grpG2 As GroupBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
