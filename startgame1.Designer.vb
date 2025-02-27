<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startgame1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startgame1))
        lblQuestion = New Label()
        btnAnswer1 = New Button()
        btnAnswer2 = New Button()
        btnAnswer3 = New Button()
        btnAnswer4 = New Button()
        btnMainMenu = New Button()
        lblIncorrect = New Label()
        lblScore = New Label()
        lblTimer = New Label()
        gameTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.BackColor = Color.Transparent
        lblQuestion.Font = New Font("Calisto MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.Location = New Point(334, 307)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(95, 32)
        lblQuestion.TabIndex = 0
        lblQuestion.Text = "Label1"
        ' 
        ' btnAnswer1
        ' 
        btnAnswer1.BackColor = Color.Honeydew
        btnAnswer1.FlatStyle = FlatStyle.Popup
        btnAnswer1.Font = New Font("Calisto MT", 12F)
        btnAnswer1.Location = New Point(109, 475)
        btnAnswer1.Name = "btnAnswer1"
        btnAnswer1.Size = New Size(595, 72)
        btnAnswer1.TabIndex = 1
        btnAnswer1.Text = "Button1"
        btnAnswer1.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer2
        ' 
        btnAnswer2.BackColor = Color.Honeydew
        btnAnswer2.FlatStyle = FlatStyle.Popup
        btnAnswer2.Font = New Font("Calisto MT", 12F)
        btnAnswer2.Location = New Point(109, 575)
        btnAnswer2.Name = "btnAnswer2"
        btnAnswer2.Size = New Size(595, 72)
        btnAnswer2.TabIndex = 2
        btnAnswer2.Text = "Button2"
        btnAnswer2.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer3
        ' 
        btnAnswer3.BackColor = Color.Honeydew
        btnAnswer3.FlatStyle = FlatStyle.Popup
        btnAnswer3.Font = New Font("Calisto MT", 12F)
        btnAnswer3.Location = New Point(762, 475)
        btnAnswer3.Name = "btnAnswer3"
        btnAnswer3.Size = New Size(595, 72)
        btnAnswer3.TabIndex = 3
        btnAnswer3.Text = "Button3"
        btnAnswer3.UseVisualStyleBackColor = False
        ' 
        ' btnAnswer4
        ' 
        btnAnswer4.BackColor = Color.Honeydew
        btnAnswer4.FlatStyle = FlatStyle.Popup
        btnAnswer4.Font = New Font("Calisto MT", 12F)
        btnAnswer4.Location = New Point(762, 571)
        btnAnswer4.Name = "btnAnswer4"
        btnAnswer4.Size = New Size(595, 72)
        btnAnswer4.TabIndex = 4
        btnAnswer4.Text = "Button4"
        btnAnswer4.UseVisualStyleBackColor = False
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), Image)
        btnMainMenu.FlatStyle = FlatStyle.Flat
        btnMainMenu.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnMainMenu.Location = New Point(1353, 1)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(57, 68)
        btnMainMenu.TabIndex = 5
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' lblIncorrect
        ' 
        lblIncorrect.AutoSize = True
        lblIncorrect.BackColor = Color.Transparent
        lblIncorrect.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblIncorrect.Location = New Point(713, 32)
        lblIncorrect.Name = "lblIncorrect"
        lblIncorrect.Size = New Size(105, 25)
        lblIncorrect.TabIndex = 6
        lblIncorrect.Text = "Incorrect: 0"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblScore.Location = New Point(951, 32)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(77, 25)
        lblScore.TabIndex = 7
        lblScore.Text = "Score: 0"
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = Color.Transparent
        lblTimer.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblTimer.Location = New Point(1150, 32)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(106, 25)
        lblTimer.TabIndex = 8
        lblTimer.Text = "Time: 00:00"
        ' 
        ' gameTimer
        ' 
        ' 
        ' startgame1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1435, 807)
        Controls.Add(lblTimer)
        Controls.Add(lblScore)
        Controls.Add(lblIncorrect)
        Controls.Add(btnMainMenu)
        Controls.Add(btnAnswer4)
        Controls.Add(btnAnswer3)
        Controls.Add(btnAnswer2)
        Controls.Add(btnAnswer1)
        Controls.Add(lblQuestion)
        Name = "startgame1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "startgame1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents gameTimer As Timer
End Class
