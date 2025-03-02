<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructionsForm))
        btnBack = New Button()
        btnExit = New Button()
        btnAbout = New Button()
        btnLogo = New Button()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1360, 21)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(53, 51)
        btnBack.TabIndex = 0
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(1, 196)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 32)
        btnExit.TabIndex = 6
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.BackgroundImage = CType(resources.GetObject("btnAbout.BackgroundImage"), Image)
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnAbout.Location = New Point(1, 150)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(191, 31)
        btnAbout.TabIndex = 7
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(1, 0)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 83)
        btnLogo.TabIndex = 8
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' InstructionsForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1435, 799)
        Controls.Add(btnLogo)
        Controls.Add(btnAbout)
        Controls.Add(btnExit)
        Controls.Add(btnBack)
        Name = "InstructionsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InstructionsForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnLogo As Button
End Class
