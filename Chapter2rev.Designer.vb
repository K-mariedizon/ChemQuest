<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chapter2rev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chapter2rev))
        btnB2 = New Button()
        btnB1 = New Button()
        Button1 = New Button()
        btnLogo = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnB2
        ' 
        btnB2.BackgroundImage = CType(resources.GetObject("btnB2.BackgroundImage"), Image)
        btnB2.FlatStyle = FlatStyle.Flat
        btnB2.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnB2.Location = New Point(1276, -1)
        btnB2.Name = "btnB2"
        btnB2.Size = New Size(31, 44)
        btnB2.TabIndex = 40
        btnB2.UseVisualStyleBackColor = True
        ' 
        ' btnB1
        ' 
        btnB1.BackgroundImage = CType(resources.GetObject("btnB1.BackgroundImage"), Image)
        btnB1.FlatStyle = FlatStyle.Flat
        btnB1.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnB1.Location = New Point(1231, 1)
        btnB1.Name = "btnB1"
        btnB1.Size = New Size(39, 40)
        btnB1.TabIndex = 39
        btnB1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Button1.Location = New Point(1345, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(55, 40)
        Button1.TabIndex = 38
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, -1)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(80, 40)
        btnLogo.TabIndex = 35
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(705, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(710, 44)
        PictureBox2.TabIndex = 37
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(710, 44)
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' Chapter2rev
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1412, 998)
        Controls.Add(btnB2)
        Controls.Add(btnB1)
        Controls.Add(Button1)
        Controls.Add(btnLogo)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Chapter2rev"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chapter2rev"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnB2 As Button
    Friend WithEvents btnB1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
