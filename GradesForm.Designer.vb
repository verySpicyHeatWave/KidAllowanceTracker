<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradesForm))
        Me.numbx_A = New System.Windows.Forms.NumericUpDown()
        Me.numbx_B = New System.Windows.Forms.NumericUpDown()
        Me.numbx_C = New System.Windows.Forms.NumericUpDown()
        Me.numbx_D = New System.Windows.Forms.NumericUpDown()
        Me.numbx_F = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        CType(Me.numbx_A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numbx_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numbx_C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numbx_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numbx_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numbx_A
        '
        Me.numbx_A.Location = New System.Drawing.Point(118, 8)
        Me.numbx_A.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numbx_A.Name = "numbx_A"
        Me.numbx_A.Size = New System.Drawing.Size(52, 23)
        Me.numbx_A.TabIndex = 0
        '
        'numbx_B
        '
        Me.numbx_B.Location = New System.Drawing.Point(118, 37)
        Me.numbx_B.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numbx_B.Name = "numbx_B"
        Me.numbx_B.Size = New System.Drawing.Size(52, 23)
        Me.numbx_B.TabIndex = 1
        '
        'numbx_C
        '
        Me.numbx_C.Location = New System.Drawing.Point(118, 66)
        Me.numbx_C.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numbx_C.Name = "numbx_C"
        Me.numbx_C.Size = New System.Drawing.Size(52, 23)
        Me.numbx_C.TabIndex = 2
        '
        'numbx_D
        '
        Me.numbx_D.Location = New System.Drawing.Point(118, 95)
        Me.numbx_D.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numbx_D.Name = "numbx_D"
        Me.numbx_D.Size = New System.Drawing.Size(52, 23)
        Me.numbx_D.TabIndex = 3
        '
        'numbx_F
        '
        Me.numbx_F.Location = New System.Drawing.Point(118, 124)
        Me.numbx_F.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numbx_F.Name = "numbx_F"
        Me.numbx_F.Size = New System.Drawing.Size(52, 23)
        Me.numbx_F.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of A's:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number of B's:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of C's:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of D's:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of F's:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_OK
        '
        Me.btn_OK.Location = New System.Drawing.Point(12, 161)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 10
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(95, 161)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 11
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'GradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numbx_F)
        Me.Controls.Add(Me.numbx_D)
        Me.Controls.Add(Me.numbx_C)
        Me.Controls.Add(Me.numbx_B)
        Me.Controls.Add(Me.numbx_A)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GradesForm"
        Me.Text = "Grades"
        CType(Me.numbx_A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numbx_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numbx_C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numbx_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numbx_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents numbx_A As NumericUpDown
    Friend WithEvents numbx_B As NumericUpDown
    Friend WithEvents numbx_C As NumericUpDown
    Friend WithEvents numbx_D As NumericUpDown
    Friend WithEvents numbx_F As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents btn_Cancel As Button
End Class
