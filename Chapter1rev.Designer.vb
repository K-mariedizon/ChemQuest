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
        picImage = New PictureBox()
        cmbSubtopics = New ComboBox()
        btnGame = New Button()
        btnExit = New Button()
        btnBack = New Button()
        btnLogo = New Button()
        TextBox2 = New TextBox()
        btnReviewer = New Button()
        TextBox3 = New TextBox()
        txtNotes = New RichTextBox()
        txt = New RichTextBox()
        Button1 = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbFrom
        ' 
        cmbFrom.BackColor = Color.White
        cmbFrom.FormattingEnabled = True
        cmbFrom.Items.AddRange(New Object() {"Meters", "Kilometers", "Grams", "Kilograms", "Celsius", "Fahrenheit"})
        cmbFrom.Location = New Point(46, 363)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(209, 28)
        cmbFrom.TabIndex = 35
        ' 
        ' cmbTo
        ' 
        cmbTo.BackColor = Color.White
        cmbTo.FormattingEnabled = True
        cmbTo.Items.AddRange(New Object() {"Meters", "Kilometers", "Grams", "Kilograms", "Celsius", "Fahrenheit"})
        cmbTo.Location = New Point(46, 429)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(209, 28)
        cmbTo.TabIndex = 36
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.White
        txtInput.Location = New Point(46, 506)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(176, 27)
        txtInput.TabIndex = 37
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(46, 568)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(176, 27)
        txtResult.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Label1.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(69, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 46)
        Label1.TabIndex = 39
        Label1.Text = "Units of Measure " & vbCrLf & "Basic Calculator"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Label2.Location = New Point(46, 340)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 40
        Label2.Text = "From:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Label3.Location = New Point(46, 406)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 20)
        Label3.TabIndex = 41
        Label3.Text = "To:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Label4.Location = New Point(46, 483)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 42
        Label4.Text = "Input:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Label5.Location = New Point(46, 545)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 43
        Label5.Text = "Result:"
        ' 
        ' btnConvert
        ' 
        btnConvert.BackColor = Color.Tan
        btnConvert.FlatStyle = FlatStyle.Popup
        btnConvert.Location = New Point(46, 624)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(83, 29)
        btnConvert.TabIndex = 44
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Tan
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Location = New Point(172, 624)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 29)
        btnClear.TabIndex = 45
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        TextBox1.Enabled = False
        TextBox1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        TextBox1.Location = New Point(28, 263)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(247, 414)
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
        ' picImage
        ' 
        picImage.Location = New Point(219, 174)
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
        btnGame.Location = New Point(1, 150)
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
        btnExit.Location = New Point(1, 190)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(192, 29)
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
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Tan
        TextBox2.Enabled = False
        TextBox2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        TextBox2.Location = New Point(9, 250)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(281, 445)
        TextBox2.TabIndex = 58
        ' 
        ' btnReviewer
        ' 
        btnReviewer.BackgroundImage = CType(resources.GetObject("btnReviewer.BackgroundImage"), Image)
        btnReviewer.FlatStyle = FlatStyle.Flat
        btnReviewer.ForeColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        btnReviewer.Location = New Point(1, 105)
        btnReviewer.Name = "btnReviewer"
        btnReviewer.Size = New Size(192, 28)
        btnReviewer.TabIndex = 61
        btnReviewer.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(185, 105)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(1213, 28)
        TextBox3.TabIndex = 62
        ' 
        ' txtNotes
        ' 
        txtNotes.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        txtNotes.BorderStyle = BorderStyle.None
        txtNotes.Location = New Point(396, 121)
        txtNotes.Name = "txtNotes"
        txtNotes.ReadOnly = True
        txtNotes.Size = New Size(1002, 611)
        txtNotes.TabIndex = 64
        txtNotes.Text = ""
        ' 
        ' txt
        ' 
        txt.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        txt.BorderStyle = BorderStyle.None
        txt.Location = New Point(372, 105)
        txt.Name = "txt"
        txt.ReadOnly = True
        txt.Size = New Size(1026, 642)
        txt.TabIndex = 65
        txt.Text = ""
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(255), CByte(248), CByte(233))
        Button1.Location = New Point(372, 753)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 31)
        Button1.TabIndex = 66
        Button1.Text = "Edit Reviewer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Chapter1rev
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(195), CByte(235), CByte(222))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1440, 806)
        Controls.Add(Button1)
        Controls.Add(txtNotes)
        Controls.Add(btnReviewer)
        Controls.Add(btnLogo)
        Controls.Add(btnBack)
        Controls.Add(btnExit)
        Controls.Add(btnGame)
        Controls.Add(cmbSubtopics)
        Controls.Add(picImage)
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
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(txt)
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
    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbSubtopics As ComboBox
    Friend WithEvents btnGame As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnReviewer As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents txt As RichTextBox
    Friend WithEvents Button1 As Button
End Class
