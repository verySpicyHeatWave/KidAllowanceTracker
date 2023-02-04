<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.lblLastMon = New System.Windows.Forms.Label()
        Me.lblNextMonday = New System.Windows.Forms.Label()
        Me.lblLastMondayRead = New System.Windows.Forms.Label()
        Me.lblNextMondayRead = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPricePerWkst = New System.Windows.Forms.TextBox()
        Me.txtPricePerBhvr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLastMon
        '
        Me.lblLastMon.AutoSize = True
        Me.lblLastMon.Location = New System.Drawing.Point(12, 9)
        Me.lblLastMon.Name = "lblLastMon"
        Me.lblLastMon.Size = New System.Drawing.Size(78, 15)
        Me.lblLastMon.TabIndex = 0
        Me.lblLastMon.Text = "Last Monday:"
        '
        'lblNextMonday
        '
        Me.lblNextMonday.AutoSize = True
        Me.lblNextMonday.Location = New System.Drawing.Point(12, 35)
        Me.lblNextMonday.Name = "lblNextMonday"
        Me.lblNextMonday.Size = New System.Drawing.Size(82, 15)
        Me.lblNextMonday.TabIndex = 1
        Me.lblNextMonday.Text = "Next Monday:"
        '
        'lblLastMondayRead
        '
        Me.lblLastMondayRead.Location = New System.Drawing.Point(100, 9)
        Me.lblLastMondayRead.Name = "lblLastMondayRead"
        Me.lblLastMondayRead.Size = New System.Drawing.Size(93, 15)
        Me.lblLastMondayRead.TabIndex = 3
        Me.lblLastMondayRead.Text = "Label2"
        Me.lblLastMondayRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNextMondayRead
        '
        Me.lblNextMondayRead.Location = New System.Drawing.Point(100, 35)
        Me.lblNextMondayRead.Name = "lblNextMondayRead"
        Me.lblNextMondayRead.Size = New System.Drawing.Size(93, 15)
        Me.lblNextMondayRead.TabIndex = 4
        Me.lblNextMondayRead.Text = "Label1"
        Me.lblNextMondayRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price/wkst:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price/bhvr:"
        '
        'txtPricePerWkst
        '
        Me.txtPricePerWkst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPricePerWkst.Location = New System.Drawing.Point(93, 58)
        Me.txtPricePerWkst.Name = "txtPricePerWkst"
        Me.txtPricePerWkst.Size = New System.Drawing.Size(100, 23)
        Me.txtPricePerWkst.TabIndex = 7
        '
        'txtPricePerBhvr
        '
        Me.txtPricePerBhvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPricePerBhvr.Location = New System.Drawing.Point(93, 84)
        Me.txtPricePerBhvr.Name = "txtPricePerBhvr"
        Me.txtPricePerBhvr.Size = New System.Drawing.Size(100, 23)
        Me.txtPricePerBhvr.TabIndex = 8
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 125)
        Me.Controls.Add(Me.txtPricePerBhvr)
        Me.Controls.Add(Me.txtPricePerWkst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNextMondayRead)
        Me.Controls.Add(Me.lblLastMondayRead)
        Me.Controls.Add(Me.lblNextMonday)
        Me.Controls.Add(Me.lblLastMon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLastMon As Label
    Friend WithEvents lblNextMonday As Label
    Friend WithEvents lblLastMondayRead As Label
    Friend WithEvents lblNextMondayRead As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPricePerWkst As TextBox
    Friend WithEvents txtPricePerBhvr As TextBox
End Class
