<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Label1 = New Label()
        txtIp = New TextBox()
        lblData = New Label()
        btnConnect = New Button()
        grpIp = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        btnRegister = New Button()
        txtFullname = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        grpIp.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Address:"
        ' 
        ' txtIp
        ' 
        txtIp.Location = New Point(149, 80)
        txtIp.Name = "txtIp"
        txtIp.Size = New Size(213, 27)
        txtIp.TabIndex = 1
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Location = New Point(652, 175)
        lblData.Name = "lblData"
        lblData.Size = New Size(108, 20)
        lblData.TabIndex = 2
        lblData.Text = "Data: Waiting..."
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.AntiqueWhite
        btnConnect.FlatStyle = FlatStyle.Flat
        btnConnect.Location = New Point(629, 126)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(142, 29)
        btnConnect.TabIndex = 3
        btnConnect.Text = "Connect to Server"
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' grpIp
        ' 
        grpIp.BackColor = Color.OldLace
        grpIp.Controls.Add(Label5)
        grpIp.Controls.Add(Label4)
        grpIp.Controls.Add(Label2)
        grpIp.Controls.Add(btnRegister)
        grpIp.Controls.Add(txtFullname)
        grpIp.Controls.Add(txtPassword)
        grpIp.Controls.Add(txtUsername)
        grpIp.Controls.Add(Label3)
        grpIp.Controls.Add(txtIp)
        grpIp.Controls.Add(Label1)
        grpIp.Location = New Point(25, 25)
        grpIp.Name = "grpIp"
        grpIp.Size = New Size(424, 368)
        grpIp.TabIndex = 4
        grpIp.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(81, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 12
        Label5.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 11
        Label4.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 10
        Label2.Text = "Username"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.AntiqueWhite
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(200, 297)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 9
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(149, 249)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(213, 27)
        txtFullname.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(149, 191)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(213, 27)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(149, 136)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(213, 27)
        txtUsername.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Label3.Location = New Point(110, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(217, 28)
        Label3.TabIndex = 5
        Label3.Text = "Add Guest Account"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(474, 417)
        Controls.Add(grpIp)
        Controls.Add(btnConnect)
        Controls.Add(lblData)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        TopMost = True
        grpIp.ResumeLayout(False)
        grpIp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents lblData As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents grpIp As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
