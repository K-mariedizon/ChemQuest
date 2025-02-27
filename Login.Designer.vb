<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        txtUname = New TextBox()
        txtPword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtUname
        ' 
        txtUname.BorderStyle = BorderStyle.FixedSingle
        txtUname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUname.Location = New Point(607, 420)
        txtUname.Multiline = True
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(268, 34)
        txtUname.TabIndex = 0
        ' 
        ' txtPword
        ' 
        txtPword.BorderStyle = BorderStyle.FixedSingle
        txtPword.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPword.Location = New Point(607, 506)
        txtPword.Multiline = True
        txtPword.Name = "txtPword"
        txtPword.Size = New Size(268, 34)
        txtPword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Tan
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(789, 361)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(128, 37)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1440, 808)
        Controls.Add(btnLogin)
        Controls.Add(txtPword)
        Controls.Add(txtUname)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPword As TextBox
    Friend WithEvents btnLogin As Button
End Class
