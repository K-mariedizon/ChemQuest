<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game1score
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game1score))
        btnReviewer = New Button()
        btnGame = New Button()
        btnGame3 = New Button()
        btnGame2 = New Button()
        btnGame1 = New Button()
        btnLogo = New Button()
        btnExit = New Button()
        btnBack = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnnote3 = New Button()
        btnnote2 = New Button()
        btnnote1 = New Button()
        dgvHighScores = New DataGridView()
        cmbRemarksFilter = New ComboBox()
        CType(dgvHighScores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnReviewer
        ' 
        btnReviewer.BackgroundImage = CType(resources.GetObject("btnReviewer.BackgroundImage"), Image)
        btnReviewer.FlatStyle = FlatStyle.Flat
        btnReviewer.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnReviewer.Location = New Point(1, 278)
        btnReviewer.Name = "btnReviewer"
        btnReviewer.Size = New Size(186, 29)
        btnReviewer.TabIndex = 25
        btnReviewer.UseVisualStyleBackColor = True
        ' 
        ' btnGame
        ' 
        btnGame.BackgroundImage = CType(resources.GetObject("btnGame.BackgroundImage"), Image)
        btnGame.FlatStyle = FlatStyle.Flat
        btnGame.ForeColor = Color.FromArgb(CByte(94), CByte(150), CByte(129))
        btnGame.Location = New Point(1, 106)
        btnGame.Name = "btnGame"
        btnGame.Size = New Size(179, 25)
        btnGame.TabIndex = 24
        btnGame.UseVisualStyleBackColor = True
        ' 
        ' btnGame3
        ' 
        btnGame3.BackgroundImage = CType(resources.GetObject("btnGame3.BackgroundImage"), Image)
        btnGame3.FlatStyle = FlatStyle.Flat
        btnGame3.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame3.Location = New Point(37, 236)
        btnGame3.Name = "btnGame3"
        btnGame3.Size = New Size(142, 26)
        btnGame3.TabIndex = 23
        btnGame3.UseVisualStyleBackColor = True
        ' 
        ' btnGame2
        ' 
        btnGame2.BackgroundImage = CType(resources.GetObject("btnGame2.BackgroundImage"), Image)
        btnGame2.FlatStyle = FlatStyle.Flat
        btnGame2.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame2.Location = New Point(37, 191)
        btnGame2.Name = "btnGame2"
        btnGame2.Size = New Size(133, 27)
        btnGame2.TabIndex = 22
        btnGame2.UseVisualStyleBackColor = True
        ' 
        ' btnGame1
        ' 
        btnGame1.BackgroundImage = CType(resources.GetObject("btnGame1.BackgroundImage"), Image)
        btnGame1.FlatStyle = FlatStyle.Flat
        btnGame1.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnGame1.Location = New Point(37, 151)
        btnGame1.Name = "btnGame1"
        btnGame1.Size = New Size(142, 25)
        btnGame1.TabIndex = 21
        btnGame1.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(1, 2)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 81)
        btnLogo.TabIndex = 20
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(1, 324)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(186, 26)
        btnExit.TabIndex = 27
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1359, 16)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(51, 52)
        btnBack.TabIndex = 28
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Button1.Location = New Point(300, 706)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 40)
        Button1.TabIndex = 29
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1182, 357)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 31)
        Label4.TabIndex = 51
        Label4.Text = "NOTE 3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(1182, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 31)
        Label3.TabIndex = 50
        Label3.Text = "NOTE 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1182, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 31)
        Label2.TabIndex = 49
        Label2.Text = "NOTE 1"
        ' 
        ' btnnote3
        ' 
        btnnote3.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.FlatStyle = FlatStyle.Flat
        btnnote3.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote3.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.Location = New Point(1137, 358)
        btnnote3.Name = "btnnote3"
        btnnote3.Size = New Size(169, 35)
        btnnote3.TabIndex = 48
        btnnote3.Text = "Note 1"
        btnnote3.UseVisualStyleBackColor = False
        ' 
        ' btnnote2
        ' 
        btnnote2.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.FlatStyle = FlatStyle.Flat
        btnnote2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote2.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.Location = New Point(1148, 271)
        btnnote2.Name = "btnnote2"
        btnnote2.Size = New Size(150, 33)
        btnnote2.TabIndex = 47
        btnnote2.Text = "Note 1"
        btnnote2.UseVisualStyleBackColor = False
        ' 
        ' btnnote1
        ' 
        btnnote1.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.FlatStyle = FlatStyle.Flat
        btnnote1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote1.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.Location = New Point(1148, 185)
        btnnote1.Name = "btnnote1"
        btnnote1.Size = New Size(150, 36)
        btnnote1.TabIndex = 46
        btnnote1.Text = "Note 1"
        btnnote1.UseVisualStyleBackColor = False
        ' 
        ' dgvHighScores
        ' 
        dgvHighScores.BackgroundColor = Color.Honeydew
        dgvHighScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHighScores.GridColor = Color.Black
        dgvHighScores.Location = New Point(300, 296)
        dgvHighScores.Name = "dgvHighScores"
        dgvHighScores.RowHeadersWidth = 51
        dgvHighScores.Size = New Size(674, 376)
        dgvHighScores.TabIndex = 52
        ' 
        ' cmbRemarksFilter
        ' 
        cmbRemarksFilter.BackColor = Color.Honeydew
        cmbRemarksFilter.FormattingEnabled = True
        cmbRemarksFilter.Location = New Point(300, 253)
        cmbRemarksFilter.Name = "cmbRemarksFilter"
        cmbRemarksFilter.Size = New Size(151, 28)
        cmbRemarksFilter.TabIndex = 53
        ' 
        ' Game1score
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1440, 810)
        Controls.Add(cmbRemarksFilter)
        Controls.Add(dgvHighScores)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnnote3)
        Controls.Add(btnnote2)
        Controls.Add(btnnote1)
        Controls.Add(Button1)
        Controls.Add(btnBack)
        Controls.Add(btnExit)
        Controls.Add(btnReviewer)
        Controls.Add(btnGame)
        Controls.Add(btnGame3)
        Controls.Add(btnGame2)
        Controls.Add(btnGame1)
        Controls.Add(btnLogo)
        Name = "Game1score"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Game1score"
        CType(dgvHighScores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReviewer As Button
    Friend WithEvents btnGame As Button
    Friend WithEvents btnGame3 As Button
    Friend WithEvents btnGame2 As Button
    Friend WithEvents btnGame1 As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnnote3 As Button
    Friend WithEvents btnnote2 As Button
    Friend WithEvents btnnote1 As Button
    Friend WithEvents dgvHighScores As DataGridView
    Friend WithEvents cmbRemarksFilter As ComboBox
End Class
