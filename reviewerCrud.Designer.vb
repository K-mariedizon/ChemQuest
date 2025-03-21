<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reviewerCrud
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
        lsbSub = New ListBox()
        txtNotes = New RichTextBox()
        cmbChap = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnCancel = New Button()
        txtChap = New TextBox()
        txtSub = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        grpDisplay = New GroupBox()
        pbImage = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        grpDisplay.SuspendLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lsbSub
        ' 
        lsbSub.BackColor = Color.OldLace
        lsbSub.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lsbSub.FormattingEnabled = True
        lsbSub.ItemHeight = 18
        lsbSub.Location = New Point(21, 126)
        lsbSub.Name = "lsbSub"
        lsbSub.Size = New Size(290, 508)
        lsbSub.TabIndex = 0
        ' 
        ' txtNotes
        ' 
        txtNotes.BorderStyle = BorderStyle.FixedSingle
        txtNotes.Location = New Point(32, 136)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(748, 441)
        txtNotes.TabIndex = 1
        txtNotes.Text = ""
        ' 
        ' cmbChap
        ' 
        cmbChap.BackColor = Color.OldLace
        cmbChap.Font = New Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbChap.FormattingEnabled = True
        cmbChap.Location = New Point(24, 62)
        cmbChap.Name = "cmbChap"
        cmbChap.Size = New Size(212, 29)
        cmbChap.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.AntiqueWhite
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Arial Rounded MT Bold", 9F)
        btnAdd.Location = New Point(526, 671)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.AntiqueWhite
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial Rounded MT Bold", 9F)
        btnUpdate.Location = New Point(656, 671)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.AntiqueWhite
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial Rounded MT Bold", 9F)
        btnDelete.Location = New Point(788, 671)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.AntiqueWhite
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial Rounded MT Bold", 9F)
        btnCancel.Location = New Point(918, 671)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtChap
        ' 
        txtChap.Font = New Font("Arial Rounded MT Bold", 9F)
        txtChap.Location = New Point(106, 38)
        txtChap.Name = "txtChap"
        txtChap.Size = New Size(208, 25)
        txtChap.TabIndex = 7
        ' 
        ' txtSub
        ' 
        txtSub.Font = New Font("Arial Rounded MT Bold", 9F)
        txtSub.Location = New Point(106, 83)
        txtSub.Name = "txtSub"
        txtSub.Size = New Size(427, 25)
        txtSub.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9F)
        Label1.Location = New Point(27, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 17)
        Label1.TabIndex = 9
        Label1.Text = "Chapter:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9F)
        Label2.Location = New Point(27, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 17)
        Label2.TabIndex = 10
        Label2.Text = "Subtopic:"
        ' 
        ' grpDisplay
        ' 
        grpDisplay.BackColor = Color.OldLace
        grpDisplay.Controls.Add(pbImage)
        grpDisplay.Controls.Add(Label2)
        grpDisplay.Controls.Add(txtChap)
        grpDisplay.Controls.Add(txtSub)
        grpDisplay.Controls.Add(Label1)
        grpDisplay.Controls.Add(txtNotes)
        grpDisplay.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpDisplay.Location = New Point(367, 43)
        grpDisplay.Name = "grpDisplay"
        grpDisplay.Size = New Size(805, 606)
        grpDisplay.TabIndex = 11
        grpDisplay.TabStop = False
        grpDisplay.Text = "Chapter Information"
        ' 
        ' pbImage
        ' 
        pbImage.Location = New Point(612, 41)
        pbImage.Name = "pbImage"
        pbImage.Size = New Size(125, 62)
        pbImage.TabIndex = 11
        pbImage.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Stout", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.OldLace
        Label3.Location = New Point(24, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(287, 24)
        Label3.TabIndex = 12
        Label3.Text = "EDIT REVIEWER"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Tan
        PictureBox1.Location = New Point(342, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(852, 691)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9F)
        Label4.ForeColor = Color.OldLace
        Label4.Location = New Point(21, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 11
        Label4.Text = "Subtopics:"
        ' 
        ' reviewerCrud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(67), CByte(55))
        ClientSize = New Size(1215, 737)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnCancel)
        Controls.Add(cmbChap)
        Controls.Add(lsbSub)
        Controls.Add(btnDelete)
        Controls.Add(grpDisplay)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "reviewerCrud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "reviewerCrud"
        TopMost = True
        grpDisplay.ResumeLayout(False)
        grpDisplay.PerformLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsbSub As ListBox
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents cmbChap As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtChap As TextBox
    Friend WithEvents txtSub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbImage As PictureBox
End Class
