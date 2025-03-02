<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        btnBack = New Button()
        btnExit = New Button()
        btnInstructions = New Button()
        btnLogo = New Button()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1359, 22)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(53, 51)
        btnBack.TabIndex = 1
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(-1, 196)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 32)
        btnExit.TabIndex = 7
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnInstructions
        ' 
        btnInstructions.BackgroundImage = CType(resources.GetObject("btnInstructions.BackgroundImage"), Image)
        btnInstructions.BackgroundImageLayout = ImageLayout.None
        btnInstructions.FlatStyle = FlatStyle.Flat
        btnInstructions.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnInstructions.Location = New Point(-1, 102)
        btnInstructions.Name = "btnInstructions"
        btnInstructions.Size = New Size(191, 34)
        btnInstructions.TabIndex = 8
        btnInstructions.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(-1, 1)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 85)
        btnLogo.TabIndex = 9
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' AboutForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1437, 796)
        Controls.Add(btnLogo)
        Controls.Add(btnInstructions)
        Controls.Add(btnExit)
        Controls.Add(btnBack)
        Name = "AboutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AboutForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnLogo As Button
End Class
