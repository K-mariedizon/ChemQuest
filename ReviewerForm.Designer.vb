<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReviewerForm))
        btnGame = New Button()
        btnBack = New Button()
        Label1 = New Label()
        btnExit = New Button()
        btnLogo = New Button()
        ColorDialog1 = New ColorDialog()
        btnnote1 = New Button()
        btnnote2 = New Button()
        btnnote3 = New Button()
        Button1 = New Button()
        btnMnemo = New Button()
        SuspendLayout()
        ' 
        ' btnGame
        ' 
        btnGame.BackgroundImage = CType(resources.GetObject("btnGame.BackgroundImage"), Image)
        btnGame.FlatStyle = FlatStyle.Flat
        btnGame.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnGame.Location = New Point(2, 111)
        btnGame.Name = "btnGame"
        btnGame.Size = New Size(189, 25)
        btnGame.TabIndex = 2
        btnGame.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1358, 22)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(51, 47)
        btnBack.TabIndex = 3
        btnBack.Text = "c"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Label1.Location = New Point(1259, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 4
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(0, 233)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 26)
        btnExit.TabIndex = 8
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 3)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 85)
        btnLogo.TabIndex = 10
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' btnnote1
        ' 
        btnnote1.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.BackgroundImage = CType(resources.GetObject("btnnote1.BackgroundImage"), Image)
        btnnote1.FlatStyle = FlatStyle.Flat
        btnnote1.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote1.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote1.Location = New Point(1148, 184)
        btnnote1.Margin = New Padding(0)
        btnnote1.Name = "btnnote1"
        btnnote1.Size = New Size(150, 39)
        btnnote1.TabIndex = 34
        btnnote1.UseVisualStyleBackColor = False
        ' 
        ' btnnote2
        ' 
        btnnote2.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.BackgroundImage = CType(resources.GetObject("btnnote2.BackgroundImage"), Image)
        btnnote2.FlatStyle = FlatStyle.Flat
        btnnote2.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote2.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote2.Location = New Point(1137, 272)
        btnnote2.Name = "btnnote2"
        btnnote2.Size = New Size(169, 28)
        btnnote2.TabIndex = 35
        btnnote2.UseVisualStyleBackColor = False
        ' 
        ' btnnote3
        ' 
        btnnote3.BackColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.BackgroundImage = CType(resources.GetObject("btnnote3.BackgroundImage"), Image)
        btnnote3.FlatStyle = FlatStyle.Flat
        btnnote3.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnnote3.ForeColor = Color.FromArgb(CByte(245), CByte(244), CByte(230))
        btnnote3.Location = New Point(1137, 359)
        btnnote3.Name = "btnnote3"
        btnnote3.Size = New Size(169, 29)
        btnnote3.TabIndex = 36
        btnnote3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Snow
        Button1.Location = New Point(817, 693)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 45)
        Button1.TabIndex = 37
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnMnemo
        ' 
        btnMnemo.BackgroundImage = CType(resources.GetObject("btnMnemo.BackgroundImage"), Image)
        btnMnemo.FlatStyle = FlatStyle.Flat
        btnMnemo.ForeColor = Color.FromArgb(CByte(124), CByte(171), CByte(153))
        btnMnemo.Location = New Point(39, 194)
        btnMnemo.Name = "btnMnemo"
        btnMnemo.Size = New Size(152, 20)
        btnMnemo.TabIndex = 19
        btnMnemo.UseVisualStyleBackColor = True
        ' 
        ' ReviewerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1439, 811)
        Controls.Add(Button1)
        Controls.Add(btnMnemo)
        Controls.Add(btnLogo)
        Controls.Add(btnExit)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(btnGame)
        Controls.Add(btnnote3)
        Controls.Add(btnnote2)
        Controls.Add(btnnote1)
        ForeColor = Color.White
        Name = "ReviewerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReviewerForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGame As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnnote1 As Button
    Friend WithEvents btnnote2 As Button
    Friend WithEvents btnnote3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMnemo As Button
End Class
