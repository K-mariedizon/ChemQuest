<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chapter1rev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chapter1rev))
        cmbFrom = New ComboBox()
        cmbTo = New ComboBox()
        txtInput = New TextBox()
        txtResult = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnConvert = New Button()
        btnClear = New Button()
        TextBox1 = New TextBox()
        cmbChapters = New ComboBox()
        txtNotes = New TextBox()
        picImage = New PictureBox()
        cmbSubtopics = New ComboBox()
        btnGame = New Button()
        btnExit = New Button()
        btnBack = New Button()
        btnLogo = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbFrom
        ' 
        cmbFrom.BackColor = Color.White
        cmbFrom.FormattingEnabled = True
        cmbFrom.Items.AddRange(New Object() {"Meters", "Kilometers", "Grams", "Kilograms", "Celsius", "Fahrenheit"})
        cmbFrom.Location = New Point(49, 309)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(209, 28)
        cmbFrom.TabIndex = 35
        ' 
        ' cmbTo
        ' 
        cmbTo.BackColor = Color.White
        cmbTo.FormattingEnabled = True
        cmbTo.Items.AddRange(New Object() {"Meters", "Kilometers", "Grams", "Kilograms", "Celsius", "Fahrenheit"})
        cmbTo.Location = New Point(49, 375)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(209, 28)
        cmbTo.TabIndex = 36
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.White
        txtInput.Location = New Point(49, 452)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(176, 27)
        txtInput.TabIndex = 37
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(49, 514)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(176, 27)
        txtResult.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(66, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 56)
        Label1.TabIndex = 39
        Label1.Text = "Units of Measure " & vbCrLf & "Basic Calculator"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Label2.Location = New Point(49, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 40
        Label2.Text = "From:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Label3.Location = New Point(49, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 20)
        Label3.TabIndex = 41
        Label3.Text = "To:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Label4.Location = New Point(49, 429)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 42
        Label4.Text = "Input:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        Label5.Location = New Point(49, 491)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 43
        Label5.Text = "Result:"
        ' 
        ' btnConvert
        ' 
        btnConvert.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnConvert.FlatStyle = FlatStyle.Popup
        btnConvert.Location = New Point(49, 570)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(83, 29)
        btnConvert.TabIndex = 44
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Location = New Point(175, 570)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 29)
        btnClear.TabIndex = 45
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Enabled = False
        TextBox1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        TextBox1.Location = New Point(12, 198)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(283, 425)
        TextBox1.TabIndex = 46
        ' 
        ' cmbChapters
        ' 
        cmbChapters.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        cmbChapters.FlatStyle = FlatStyle.Popup
        cmbChapters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbChapters.ForeColor = Color.White
        cmbChapters.FormattingEnabled = True
        cmbChapters.Location = New Point(621, 27)
        cmbChapters.Name = "cmbChapters"
        cmbChapters.Size = New Size(165, 36)
        cmbChapters.TabIndex = 47
        ' 
        ' txtNotes
        ' 
        txtNotes.BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        txtNotes.BorderStyle = BorderStyle.None
        txtNotes.Location = New Point(354, 127)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ReadOnly = True
        txtNotes.Size = New Size(316, 45)
        txtNotes.TabIndex = 50
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(800, 127)
        picImage.Name = "picImage"
        picImage.Size = New Size(125, 45)
        picImage.TabIndex = 51
        picImage.TabStop = False
        ' 
        ' cmbSubtopics
        ' 
        cmbSubtopics.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        cmbSubtopics.FlatStyle = FlatStyle.Popup
        cmbSubtopics.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbSubtopics.ForeColor = Color.White
        cmbSubtopics.FormattingEnabled = True
        cmbSubtopics.Location = New Point(980, 27)
        cmbSubtopics.Name = "cmbSubtopics"
        cmbSubtopics.Size = New Size(373, 36)
        cmbSubtopics.TabIndex = 53
        ' 
        ' btnGame
        ' 
        btnGame.BackgroundImage = CType(resources.GetObject("btnGame.BackgroundImage"), Image)
        btnGame.FlatStyle = FlatStyle.Flat
        btnGame.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnGame.Location = New Point(0, 106)
        btnGame.Name = "btnGame"
        btnGame.Size = New Size(178, 25)
        btnGame.TabIndex = 54
        btnGame.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnExit.Location = New Point(0, 146)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(192, 26)
        btnExit.TabIndex = 55
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnBack.Location = New Point(1359, 24)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(51, 47)
        btnBack.TabIndex = 56
        btnBack.Text = "c"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogo
        ' 
        btnLogo.BackgroundImage = CType(resources.GetObject("btnLogo.BackgroundImage"), Image)
        btnLogo.FlatStyle = FlatStyle.Flat
        btnLogo.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnLogo.Location = New Point(0, 5)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(179, 85)
        btnLogo.TabIndex = 57
        btnLogo.UseVisualStyleBackColor = True
        ' 
        ' Chapter1rev
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1440, 806)
        Controls.Add(btnLogo)
        Controls.Add(btnBack)
        Controls.Add(btnExit)
        Controls.Add(btnGame)
        Controls.Add(cmbSubtopics)
        Controls.Add(picImage)
        Controls.Add(txtNotes)
        Controls.Add(cmbChapters)
        Controls.Add(btnClear)
        Controls.Add(btnConvert)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtResult)
        Controls.Add(txtInput)
        Controls.Add(cmbTo)
        Controls.Add(cmbFrom)
        Controls.Add(TextBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Chapter1rev"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chapter1rev"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbChapters As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbSubtopics As ComboBox
    Friend WithEvents btnGame As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogo As Button
End Class
