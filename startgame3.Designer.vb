<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startgame3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startgame3))
        lblTime = New Label()
        lblScore = New Label()
        lblIncorrect = New Label()
        btnMainMenu = New Button()
        lblQuestion = New Label()
        playerBox = New TextBox()
        gamePanel = New Panel()
        gamePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblTime.Location = New Point(1152, 32)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(106, 25)
        lblTime.TabIndex = 13
        lblTime.Text = "Time: 00:00"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblScore.Location = New Point(953, 32)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(77, 25)
        lblScore.TabIndex = 12
        lblScore.Text = "Score: 0"
        ' 
        ' lblIncorrect
        ' 
        lblIncorrect.AutoSize = True
        lblIncorrect.BackColor = Color.Transparent
        lblIncorrect.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lblIncorrect.Location = New Point(715, 32)
        lblIncorrect.Name = "lblIncorrect"
        lblIncorrect.Size = New Size(105, 25)
        lblIncorrect.TabIndex = 11
        lblIncorrect.Text = "Incorrect: 0"
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), Image)
        btnMainMenu.FlatStyle = FlatStyle.Flat
        btnMainMenu.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnMainMenu.Location = New Point(1355, 1)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(57, 68)
        btnMainMenu.TabIndex = 10
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.BackColor = Color.Transparent
        lblQuestion.Font = New Font("Calisto MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuestion.Location = New Point(43, 116)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(95, 32)
        lblQuestion.TabIndex = 9
        lblQuestion.Text = "Label1"
        ' 
        ' playerBox
        ' 
        playerBox.BackColor = Color.Black
        playerBox.BorderStyle = BorderStyle.None
        playerBox.Location = New Point(681, 563)
        playerBox.Name = "playerBox"
        playerBox.Size = New Size(98, 20)
        playerBox.TabIndex = 14
        ' 
        ' gamePanel
        ' 
        gamePanel.BackgroundImage = CType(resources.GetObject("gamePanel.BackgroundImage"), Image)
        gamePanel.Controls.Add(playerBox)
        gamePanel.Location = New Point(1, 107)
        gamePanel.Name = "gamePanel"
        gamePanel.Size = New Size(1438, 612)
        gamePanel.TabIndex = 15
        ' 
        ' startgame3
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1440, 808)
        Controls.Add(lblQuestion)
        Controls.Add(gamePanel)
        Controls.Add(lblTime)
        Controls.Add(lblScore)
        Controls.Add(lblIncorrect)
        Controls.Add(btnMainMenu)
        Name = "startgame3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "startgame3"
        gamePanel.ResumeLayout(False)
        gamePanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents playerBox As TextBox
    Friend WithEvents gamePanel As Panel
End Class
