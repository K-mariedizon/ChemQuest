<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game1))
        btnLogo = New Button()
        btnGame3 = New Button()
        btnGame2 = New Button()
        btnGame1 = New Button()
        btnGame = New Button()
        btnReviewer = New Button()
        btnExit = New Button()
        btnBack = New Button()
        btnHscore = New Button()
        btnnote3 = New Button()
        btnnote2 = New Button()
        btnnote1 = New Button()
        btnPlay = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 2)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 81)
        btnLogo.TabIndex = 8
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' btnGame3
        ' 
        btnGame3.BackgroundImage = CType(resources.GetObject("btnGame3.BackgroundImage"), Image)
        btnGame3.FlatStyle = FlatStyle.Flat
        btnGame3.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame3.Location = New Point(36, 236)
        btnGame3.Name = "btnGame3"
        btnGame3.Size = New Size(142, 26)
        btnGame3.TabIndex = 17
        btnGame3.UseVisualStyleBackColor = True
        ' 
        ' btnGame2
        ' 
        btnGame2.BackgroundImage = CType(resources.GetObject("btnGame2.BackgroundImage"), Image)
        btnGame2.FlatStyle = FlatStyle.Flat
        btnGame2.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame2.Location = New Point(36, 191)
        btnGame2.Name = "btnGame2"
        btnGame2.Size = New Size(133, 27)
        btnGame2.TabIndex = 16
        btnGame2.UseVisualStyleBackColor = True
        ' 
        ' btnGame1
        ' 
        btnGame1.BackgroundImage = CType(resources.GetObject("btnGame1.BackgroundImage"), Image)
        btnGame1.FlatStyle = FlatStyle.Flat
        btnGame1.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame1.Location = New Point(36, 147)
        btnGame1.Name = "btnGame1"
        btnGame1.Size = New Size(142, 29)
        btnGame1.TabIndex = 15
        btnGame1.UseVisualStyleBackColor = True
        ' 
        ' btnGame
        ' 
        btnGame.BackgroundImage = CType(resources.GetObject("btnGame.BackgroundImage"), Image)
        btnGame.FlatStyle = FlatStyle.Flat
        btnGame.ForeColor = Color.FromArgb(CByte(94), CByte(150), CByte(129))
        btnGame.Location = New Point(0, 106)
        btnGame.Name = "btnGame"
        btnGame.Size = New Size(179, 25)
        btnGame.TabIndex = 18
        btnGame.UseVisualStyleBackColor = True
        ' 
        ' btnReviewer
        ' 
        btnReviewer.BackgroundImage = CType(resources.GetObject("btnReviewer.BackgroundImage"), Image)
        btnReviewer.FlatStyle = FlatStyle.Flat
        btnReviewer.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnReviewer.Location = New Point(0, 278)
        btnReviewer.Name = "btnReviewer"
        btnReviewer.Size = New Size(186, 29)
        btnReviewer.TabIndex = 19
        btnReviewer.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(0, 323)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 26)
        btnExit.TabIndex = 26
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1361, 16)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(51, 52)
        btnBack.TabIndex = 27
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnHscore
        ' 
        btnHscore.BackgroundImage = CType(resources.GetObject("btnHscore.BackgroundImage"), Image)
        btnHscore.FlatStyle = FlatStyle.Flat
        btnHscore.Location = New Point(698, 666)
        btnHscore.Name = "btnHscore"
        btnHscore.Size = New Size(194, 43)
        btnHscore.TabIndex = 28
        btnHscore.UseVisualStyleBackColor = True
        ' 
        ' btnnote3
        ' 
        btnnote3.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.BackgroundImage = CType(resources.GetObject("btnnote3.BackgroundImage"), Image)
        btnnote3.FlatStyle = FlatStyle.Flat
        btnnote3.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote3.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.Location = New Point(1138, 359)
        btnnote3.Name = "btnnote3"
        btnnote3.Size = New Size(169, 29)
        btnnote3.TabIndex = 39
        btnnote3.UseVisualStyleBackColor = False
        ' 
        ' btnnote2
        ' 
        btnnote2.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.BackgroundImage = CType(resources.GetObject("btnnote2.BackgroundImage"), Image)
        btnnote2.FlatStyle = FlatStyle.Flat
        btnnote2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote2.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.Location = New Point(1138, 272)
        btnnote2.Name = "btnnote2"
        btnnote2.Size = New Size(169, 28)
        btnnote2.TabIndex = 38
        btnnote2.UseVisualStyleBackColor = False
        ' 
        ' btnnote1
        ' 
        btnnote1.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.BackgroundImage = CType(resources.GetObject("btnnote1.BackgroundImage"), Image)
        btnnote1.FlatStyle = FlatStyle.Flat
        btnnote1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote1.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.Location = New Point(1149, 184)
        btnnote1.Margin = New Padding(0)
        btnnote1.Name = "btnnote1"
        btnnote1.Size = New Size(150, 39)
        btnnote1.TabIndex = 37
        btnnote1.UseVisualStyleBackColor = False
        ' 
        ' btnPlay
        ' 
        btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), Image)
        btnPlay.FlatStyle = FlatStyle.Flat
        btnPlay.Location = New Point(394, 661)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(194, 52)
        btnPlay.TabIndex = 40
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.OldLace
        Button1.Location = New Point(937, 106)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 35)
        Button1.TabIndex = 41
        Button1.Text = "Edit Game1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Game1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1439, 810)
        Controls.Add(Button1)
        Controls.Add(btnPlay)
        Controls.Add(btnnote3)
        Controls.Add(btnnote2)
        Controls.Add(btnnote1)
        Controls.Add(btnHscore)
        Controls.Add(btnBack)
        Controls.Add(btnExit)
        Controls.Add(btnReviewer)
        Controls.Add(btnGame)
        Controls.Add(btnGame3)
        Controls.Add(btnGame2)
        Controls.Add(btnGame1)
        Controls.Add(btnLogo)
        ForeColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Name = "Game1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogo As Button
    Friend WithEvents btnGame3 As Button
    Friend WithEvents btnGame2 As Button
    Friend WithEvents btnGame1 As Button
    Friend WithEvents btnGame As Button
    Friend WithEvents btnReviewer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnHscore As Button
    Friend WithEvents btnnote3 As Button
    Friend WithEvents btnnote2 As Button
    Friend WithEvents btnnote1 As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents Button1 As Button
End Class
