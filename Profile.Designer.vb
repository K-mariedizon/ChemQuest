<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        txtUname = New TextBox()
        btnUpdate = New Button()
        btnCancel = New Button()
        txtPword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUname
        ' 
        txtUname.Enabled = False
        txtUname.Location = New Point(119, 83)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(178, 27)
        txtUname.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.AntiqueWhite
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Location = New Point(76, 222)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.AntiqueWhite
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(237, 222)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtPword
        ' 
        txtPword.Location = New Point(119, 133)
        txtPword.Name = "txtPword"
        txtPword.Size = New Size(178, 27)
        txtPword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.OldLace
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtUname)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtPword)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(22, 22)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(331, 275)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Label3.Location = New Point(66, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(203, 28)
        Label3.TabIndex = 2
        Label3.Text = "Change Password"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(380, 320)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Profile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profile"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUname As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
End Class
