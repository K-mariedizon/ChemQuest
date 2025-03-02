<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        btnS = New Button()
        btnA = New Button()
        SuspendLayout()
        ' 
        ' btnS
        ' 
        btnS.BackColor = Color.Tan
        btnS.FlatStyle = FlatStyle.Flat
        btnS.Font = New Font("Segoe UI", 12F)
        btnS.Location = New Point(621, 374)
        btnS.Name = "btnS"
        btnS.Size = New Size(254, 67)
        btnS.TabIndex = 0
        btnS.Text = "Student"
        btnS.UseVisualStyleBackColor = False
        ' 
        ' btnA
        ' 
        btnA.BackColor = Color.Tan
        btnA.FlatStyle = FlatStyle.Flat
        btnA.Font = New Font("Segoe UI", 12F)
        btnA.Location = New Point(621, 464)
        btnA.Name = "btnA"
        btnA.Size = New Size(254, 67)
        btnA.TabIndex = 1
        btnA.Text = "Admin"
        btnA.UseVisualStyleBackColor = False
        ' 
        ' dashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1434, 810)
        Controls.Add(btnA)
        Controls.Add(btnS)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnS As Button
    Friend WithEvents btnA As Button
End Class
