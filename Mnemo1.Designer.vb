<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mnemo1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mnemo1))
        Button1 = New Button()
        btnLogo = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnC1 = New Button()
        btnC2 = New Button()
        btnC3 = New Button()
        PanelButtons = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Button1.Location = New Point(1341, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(60, 40)
        Button1.TabIndex = 30
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 0)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(80, 40)
        btnLogo.TabIndex = 27
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(705, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(710, 43)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(710, 43)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' btnC1
        ' 
        btnC1.BackColor = Color.Tan
        btnC1.FlatStyle = FlatStyle.Flat
        btnC1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnC1.ForeColor = SystemColors.ActiveCaptionText
        btnC1.Location = New Point(36, 30)
        btnC1.Name = "btnC1"
        btnC1.Size = New Size(170, 42)
        btnC1.TabIndex = 33
        btnC1.Text = "Chapter 1"
        btnC1.UseVisualStyleBackColor = False
        ' 
        ' btnC2
        ' 
        btnC2.BackColor = Color.Tan
        btnC2.FlatStyle = FlatStyle.Flat
        btnC2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnC2.ForeColor = SystemColors.ActiveCaptionText
        btnC2.Location = New Point(36, 102)
        btnC2.Name = "btnC2"
        btnC2.Size = New Size(170, 42)
        btnC2.TabIndex = 34
        btnC2.Text = "Chapter 2"
        btnC2.UseVisualStyleBackColor = False
        ' 
        ' btnC3
        ' 
        btnC3.BackColor = Color.Tan
        btnC3.FlatStyle = FlatStyle.Flat
        btnC3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnC3.ForeColor = SystemColors.ActiveCaptionText
        btnC3.Location = New Point(36, 165)
        btnC3.Name = "btnC3"
        btnC3.Size = New Size(170, 42)
        btnC3.TabIndex = 35
        btnC3.Text = "Chapter 3"
        btnC3.UseVisualStyleBackColor = False
        ' 
        ' PanelButtons
        ' 
        PanelButtons.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        PanelButtons.BorderStyle = BorderStyle.FixedSingle
        PanelButtons.Controls.Add(btnC1)
        PanelButtons.Controls.Add(btnC3)
        PanelButtons.Controls.Add(btnC2)
        PanelButtons.Location = New Point(1161, 59)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Size = New Size(240, 237)
        PanelButtons.TabIndex = 36
        ' 
        ' Mnemo1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.Honeydew
        ClientSize = New Size(1413, 1014)
        Controls.Add(PanelButtons)
        Controls.Add(Button1)
        Controls.Add(btnLogo)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Mnemo1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mnemo1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnC1 As Button
    Friend WithEvents btnC2 As Button
    Friend WithEvents btnC3 As Button
    Friend WithEvents PanelButtons As Panel
End Class
