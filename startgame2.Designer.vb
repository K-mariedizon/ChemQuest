<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startgame2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startgame2))
        lblTimer = New Label()
        lblScore = New Label()
        lblIncorrect = New Label()
        btnAnswer4 = New Button()
        btnAnswer3 = New Button()
        btnAnswer2 = New Button()
        btnAnswer1 = New Button()
        lblQuestion = New Label()
        lblPatientName = New Label()
        lblAge = New Label()
        lblGender = New Label()
        lblMedicalHistory = New Label()
        txtLabResults = New TextBox()
        btnMainMenu = New Button()
        Timer = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = Color.Transparent
        lblTimer.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblTimer.Location = New Point(1158, 30)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(106, 25)
        lblTimer.TabIndex = 16
        lblTimer.Text = "Time: 00:00"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblScore.Location = New Point(953, 30)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(77, 25)
        lblScore.TabIndex = 15
        lblScore.Text = "Score: 0"
        ' 
        ' lblIncorrect
        ' 
        lblIncorrect.AutoSize = True
        lblIncorrect.BackColor = Color.Transparent
        lblIncorrect.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblIncorrect.Location = New Point(720, 30)
        lblIncorrect.Name = "lblIncorrect"
        lblIncorrect.Size = New Size(105, 25)
        lblIncorrect.TabIndex = 14
        lblIncorrect.Text = "Incorrect: 0"
        ' 
        ' btnAnswer4
        ' 
        btnAnswer4.BackColor = Color.Honeydew
        btnAnswer4.FlatStyle = FlatStyle.Popup
        btnAnswer4.Font = New Font("Calisto MT", 16.2F)
        btnAnswer4.Location = New Point(925, 693)
        btnAnswer4.Name = "btnAnswer4"
        btnAnswer4.Size = New Size(409, 64)
        btnAnswer4.TabIndex = 13
        btnAnswer4.Text = "Button4"
        btnAnswer4.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer3
        ' 
        btnAnswer3.BackColor = Color.Honeydew
        btnAnswer3.FlatStyle = FlatStyle.Popup
        btnAnswer3.Font = New Font("Calisto MT", 16.2F)
        btnAnswer3.Location = New Point(925, 602)
        btnAnswer3.Name = "btnAnswer3"
        btnAnswer3.Size = New Size(409, 64)
        btnAnswer3.TabIndex = 12
        btnAnswer3.Text = "Button3"
        btnAnswer3.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer2
        ' 
        btnAnswer2.BackColor = Color.Honeydew
        btnAnswer2.FlatStyle = FlatStyle.Popup
        btnAnswer2.Font = New Font("Calisto MT", 16.2F)
        btnAnswer2.Location = New Point(925, 512)
        btnAnswer2.Name = "btnAnswer2"
        btnAnswer2.Size = New Size(409, 64)
        btnAnswer2.TabIndex = 11
        btnAnswer2.Text = "Button2"
        btnAnswer2.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer1
        ' 
        btnAnswer1.BackColor = Color.Honeydew
        btnAnswer1.FlatStyle = FlatStyle.Popup
        btnAnswer1.Font = New Font("Calisto MT", 16.2F)
        btnAnswer1.Location = New Point(925, 421)
        btnAnswer1.Name = "btnAnswer1"
        btnAnswer1.Size = New Size(409, 64)
        btnAnswer1.TabIndex = 10
        btnAnswer1.Text = "Button1"
        btnAnswer1.UseVisualStyleBackColor = False
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.BackColor = Color.Transparent
        lblQuestion.Font = New Font("Calisto MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.Location = New Point(973, 282)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(79, 26)
        lblQuestion.TabIndex = 9
        lblQuestion.Text = "Label1"
        ' 
        ' lblPatientName
        ' 
        lblPatientName.AutoSize = True
        lblPatientName.BackColor = Color.Transparent
        lblPatientName.Font = New Font("Microsoft Sans Serif", 12F)
        lblPatientName.Location = New Point(219, 212)
        lblPatientName.Name = "lblPatientName"
        lblPatientName.Size = New Size(71, 25)
        lblPatientName.TabIndex = 22
        lblPatientName.Text = "Label6"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.BackColor = Color.Transparent
        lblAge.Font = New Font("Microsoft Sans Serif", 12F)
        lblAge.Location = New Point(219, 282)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(71, 25)
        lblAge.TabIndex = 23
        lblAge.Text = "Label6"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.Transparent
        lblGender.Font = New Font("Microsoft Sans Serif", 12F)
        lblGender.Location = New Point(219, 357)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(71, 25)
        lblGender.TabIndex = 24
        lblGender.Text = "Label6"
        ' 
        ' lblMedicalHistory
        ' 
        lblMedicalHistory.AutoSize = True
        lblMedicalHistory.BackColor = Color.Transparent
        lblMedicalHistory.Font = New Font("Microsoft Sans Serif", 12F)
        lblMedicalHistory.Location = New Point(297, 442)
        lblMedicalHistory.Name = "lblMedicalHistory"
        lblMedicalHistory.Size = New Size(71, 25)
        lblMedicalHistory.TabIndex = 25
        lblMedicalHistory.Text = "Label6"
        ' 
        ' txtLabResults
        ' 
        txtLabResults.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        txtLabResults.BorderStyle = BorderStyle.None
        txtLabResults.Font = New Font("Microsoft Sans Serif", 12F)
        txtLabResults.Location = New Point(297, 572)
        txtLabResults.Multiline = True
        txtLabResults.Name = "txtLabResults"
        txtLabResults.Size = New Size(444, 161)
        txtLabResults.TabIndex = 26
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), Image)
        btnMainMenu.FlatStyle = FlatStyle.Flat
        btnMainMenu.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnMainMenu.Location = New Point(1357, 1)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(57, 68)
        btnMainMenu.TabIndex = 27
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        ' 
        ' startgame2
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1445, 809)
        Controls.Add(btnMainMenu)
        Controls.Add(txtLabResults)
        Controls.Add(lblMedicalHistory)
        Controls.Add(lblGender)
        Controls.Add(lblAge)
        Controls.Add(lblPatientName)
        Controls.Add(lblTimer)
        Controls.Add(lblScore)
        Controls.Add(lblIncorrect)
        Controls.Add(btnAnswer4)
        Controls.Add(btnAnswer3)
        Controls.Add(btnAnswer2)
        Controls.Add(btnAnswer1)
        Controls.Add(lblQuestion)
        Name = "startgame2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "startgame2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblMedicalHistory As Label
    Friend WithEvents txtLabResults As TextBox
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents Timer As Timer
End Class
