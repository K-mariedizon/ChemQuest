<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotesForm))
        txtNote1 = New TextBox()
        txtNote2 = New TextBox()
        txtNote3 = New TextBox()
        btnBack = New Button()
        btnLogo = New Button()
        btnReviewer = New Button()
        btnExit = New Button()
        btnSave1 = New Button()
        btnSave2 = New Button()
        btnSave3 = New Button()
        btnnote1 = New Button()
        btnnote2 = New Button()
        btnnote3 = New Button()
        SuspendLayout()
        ' 
        ' txtNote1
        ' 
        txtNote1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNote1.Location = New Point(273, 215)
        txtNote1.Multiline = True
        txtNote1.Name = "txtNote1"
        txtNote1.Size = New Size(298, 439)
        txtNote1.TabIndex = 2
        ' 
        ' txtNote2
        ' 
        txtNote2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNote2.Location = New Point(670, 215)
        txtNote2.Multiline = True
        txtNote2.Name = "txtNote2"
        txtNote2.Size = New Size(296, 439)
        txtNote2.TabIndex = 3
        ' 
        ' txtNote3
        ' 
        txtNote3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNote3.Location = New Point(1066, 215)
        txtNote3.Multiline = True
        txtNote3.Name = "txtNote3"
        txtNote3.Size = New Size(296, 439)
        txtNote3.TabIndex = 4
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1355, 21)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(61, 47)
        btnBack.TabIndex = 11
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 4)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 81)
        btnLogo.TabIndex = 12
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' btnReviewer
        ' 
        btnReviewer.BackgroundImage = CType(resources.GetObject("btnReviewer.BackgroundImage"), Image)
        btnReviewer.FlatStyle = FlatStyle.Flat
        btnReviewer.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnReviewer.Location = New Point(0, 148)
        btnReviewer.Name = "btnReviewer"
        btnReviewer.Size = New Size(186, 29)
        btnReviewer.TabIndex = 20
        btnReviewer.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(0, 192)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 28)
        btnExit.TabIndex = 21
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave1
        ' 
        btnSave1.BackgroundImage = CType(resources.GetObject("btnSave1.BackgroundImage"), Image)
        btnSave1.Cursor = Cursors.AppStarting
        btnSave1.FlatStyle = FlatStyle.Flat
        btnSave1.ForeColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        btnSave1.Location = New Point(344, 690)
        btnSave1.Name = "btnSave1"
        btnSave1.Size = New Size(151, 29)
        btnSave1.TabIndex = 28
        btnSave1.UseVisualStyleBackColor = True
        ' 
        ' btnSave2
        ' 
        btnSave2.BackgroundImage = CType(resources.GetObject("btnSave2.BackgroundImage"), Image)
        btnSave2.Cursor = Cursors.AppStarting
        btnSave2.FlatStyle = FlatStyle.Flat
        btnSave2.ForeColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        btnSave2.Location = New Point(737, 690)
        btnSave2.Name = "btnSave2"
        btnSave2.Size = New Size(151, 29)
        btnSave2.TabIndex = 29
        btnSave2.UseVisualStyleBackColor = True
        ' 
        ' btnSave3
        ' 
        btnSave3.BackgroundImage = CType(resources.GetObject("btnSave3.BackgroundImage"), Image)
        btnSave3.Cursor = Cursors.AppStarting
        btnSave3.FlatStyle = FlatStyle.Flat
        btnSave3.ForeColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        btnSave3.Location = New Point(1133, 690)
        btnSave3.Name = "btnSave3"
        btnSave3.Size = New Size(151, 29)
        btnSave3.TabIndex = 30
        btnSave3.UseVisualStyleBackColor = True
        ' 
        ' btnnote1
        ' 
        btnnote1.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnnote1.FlatStyle = FlatStyle.Flat
        btnnote1.ForeColor = Color.White
        btnnote1.Location = New Point(359, 163)
        btnnote1.Name = "btnnote1"
        btnnote1.Size = New Size(94, 29)
        btnnote1.TabIndex = 31
        btnnote1.Text = "View"
        btnnote1.UseVisualStyleBackColor = False
        ' 
        ' btnnote2
        ' 
        btnnote2.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnnote2.FlatStyle = FlatStyle.Flat
        btnnote2.ForeColor = Color.White
        btnnote2.Location = New Point(752, 163)
        btnnote2.Name = "btnnote2"
        btnnote2.Size = New Size(94, 29)
        btnnote2.TabIndex = 32
        btnnote2.Text = "View"
        btnnote2.UseVisualStyleBackColor = False
        ' 
        ' btnnote3
        ' 
        btnnote3.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnnote3.FlatStyle = FlatStyle.Flat
        btnnote3.ForeColor = Color.White
        btnnote3.Location = New Point(1148, 163)
        btnnote3.Name = "btnnote3"
        btnnote3.Size = New Size(94, 29)
        btnnote3.TabIndex = 33
        btnnote3.Text = "View"
        btnnote3.UseVisualStyleBackColor = False
        ' 
        ' NotesForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1420, 794)
        Controls.Add(btnnote3)
        Controls.Add(btnnote2)
        Controls.Add(btnnote1)
        Controls.Add(btnSave3)
        Controls.Add(btnSave2)
        Controls.Add(btnSave1)
        Controls.Add(btnExit)
        Controls.Add(btnReviewer)
        Controls.Add(btnLogo)
        Controls.Add(btnBack)
        Controls.Add(txtNote3)
        Controls.Add(txtNote2)
        Controls.Add(txtNote1)
        Name = "NotesForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NotesForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNote1 As TextBox
    Friend WithEvents txtNote2 As TextBox
    Friend WithEvents txtNote3 As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents btnReviewer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave1 As Button
    Friend WithEvents btnSave2 As Button
    Friend WithEvents btnSave3 As Button
    Friend WithEvents btnnote1 As Button
    Friend WithEvents btnnote2 As Button
    Friend WithEvents btnnote3 As Button
End Class
