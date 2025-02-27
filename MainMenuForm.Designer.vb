<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnReviewer = New Button()
        btnMiniGames = New Button()
        btnNotes = New Button()
        btnInstructions = New Button()
        btnExit = New Button()
        btnAbout = New Button()
        ToolTip1 = New ToolTip(components)
        btnLogo = New Button()
        SuspendLayout()
        ' 
        ' btnReviewer
        ' 
        btnReviewer.BackgroundImage = CType(resources.GetObject("btnReviewer.BackgroundImage"), Image)
        btnReviewer.FlatStyle = FlatStyle.Flat
        btnReviewer.ForeColor = Color.FromArgb(CByte(235), CByte(230), CByte(217))
        btnReviewer.Location = New Point(631, 640)
        btnReviewer.Name = "btnReviewer"
        btnReviewer.Size = New Size(221, 107)
        btnReviewer.TabIndex = 0
        btnReviewer.UseVisualStyleBackColor = True
        ' 
        ' btnMiniGames
        ' 
        btnMiniGames.BackgroundImage = CType(resources.GetObject("btnMiniGames.BackgroundImage"), Image)
        btnMiniGames.FlatStyle = FlatStyle.Flat
        btnMiniGames.ForeColor = Color.Bisque
        btnMiniGames.Location = New Point(611, 339)
        btnMiniGames.Name = "btnMiniGames"
        btnMiniGames.Size = New Size(298, 205)
        btnMiniGames.TabIndex = 1
        btnMiniGames.UseVisualStyleBackColor = True
        ' 
        ' btnNotes
        ' 
        btnNotes.BackgroundImage = CType(resources.GetObject("btnNotes.BackgroundImage"), Image)
        btnNotes.FlatStyle = FlatStyle.Flat
        btnNotes.ForeColor = Color.Linen
        btnNotes.Location = New Point(998, 140)
        btnNotes.Name = "btnNotes"
        btnNotes.Size = New Size(365, 215)
        btnNotes.TabIndex = 3
        btnNotes.UseVisualStyleBackColor = True
        ' 
        ' btnInstructions
        ' 
        btnInstructions.BackgroundImage = CType(resources.GetObject("btnInstructions.BackgroundImage"), Image)
        btnInstructions.BackgroundImageLayout = ImageLayout.None
        btnInstructions.FlatStyle = FlatStyle.Flat
        btnInstructions.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnInstructions.Location = New Point(0, 102)
        btnInstructions.Name = "btnInstructions"
        btnInstructions.Size = New Size(191, 34)
        btnInstructions.TabIndex = 2
        btnInstructions.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(0, 197)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(191, 32)
        btnExit.TabIndex = 5
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.BackgroundImage = CType(resources.GetObject("btnAbout.BackgroundImage"), Image)
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnAbout.Location = New Point(0, 151)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(191, 31)
        btnAbout.TabIndex = 4
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 1)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 81)
        btnLogo.TabIndex = 6
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1430, 811)
        Controls.Add(btnLogo)
        Controls.Add(btnExit)
        Controls.Add(btnAbout)
        Controls.Add(btnNotes)
        Controls.Add(btnInstructions)
        Controls.Add(btnMiniGames)
        Controls.Add(btnReviewer)
        ForeColor = Color.PeachPuff
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnReviewer As Button
    Friend WithEvents btnMiniGames As Button
    Friend WithEvents btnNotes As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLogo As Button

End Class
