﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBaselinePrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLastMon
        '
        Me.lblLastMon.Location = New System.Drawing.Point(12, 9)
        Me.lblLastMon.Name = "lblLastMon"
        Me.lblLastMon.Size = New System.Drawing.Size(100, 15)
        Me.lblLastMon.TabIndex = 0
        Me.lblLastMon.Text = "Last Monday:"
        Me.lblLastMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNextMonday
        '
        Me.lblNextMonday.Location = New System.Drawing.Point(12, 35)
        Me.lblNextMonday.Name = "lblNextMonday"
        Me.lblNextMonday.Size = New System.Drawing.Size(100, 15)
        Me.lblNextMonday.TabIndex = 1
        Me.lblNextMonday.Text = "Next Monday:"
        Me.lblNextMonday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastMondayRead
        '
        Me.lblLastMondayRead.Location = New System.Drawing.Point(135, 9)
        Me.lblLastMondayRead.Name = "lblLastMondayRead"
        Me.lblLastMondayRead.Size = New System.Drawing.Size(93, 15)
        Me.lblLastMondayRead.TabIndex = 3
        Me.lblLastMondayRead.Text = "Label2"
        Me.lblLastMondayRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNextMondayRead
        '
        Me.lblNextMondayRead.Location = New System.Drawing.Point(135, 35)
        Me.lblNextMondayRead.Name = "lblNextMondayRead"
        Me.lblNextMondayRead.Size = New System.Drawing.Size(93, 15)
        Me.lblNextMondayRead.TabIndex = 4
        Me.lblNextMondayRead.Text = "Label1"
        Me.lblNextMondayRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Price/wkst:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price/bhvr:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPricePerWkst
        '
        Me.txtPricePerWkst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPricePerWkst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPricePerWkst.Location = New System.Drawing.Point(128, 58)
        Me.txtPricePerWkst.Name = "txtPricePerWkst"
        Me.txtPricePerWkst.Size = New System.Drawing.Size(100, 23)
        Me.txtPricePerWkst.TabIndex = 7
        '
        'txtPricePerBhvr
        '
        Me.txtPricePerBhvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPricePerBhvr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPricePerBhvr.Location = New System.Drawing.Point(128, 84)
        Me.txtPricePerBhvr.Name = "txtPricePerBhvr"
        Me.txtPricePerBhvr.Size = New System.Drawing.Size(100, 23)
        Me.txtPricePerBhvr.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Baseline:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBaselinePrice
        '
        Me.txtBaselinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaselinePrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBaselinePrice.Location = New System.Drawing.Point(128, 111)
        Me.txtBaselinePrice.Name = "txtBaselinePrice"
        Me.txtBaselinePrice.Size = New System.Drawing.Size(100, 23)
        Me.txtBaselinePrice.TabIndex = 10
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 145)
        Me.Controls.Add(Me.txtBaselinePrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPricePerBhvr)
        Me.Controls.Add(Me.txtPricePerWkst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNextMondayRead)
        Me.Controls.Add(Me.lblLastMondayRead)
        Me.Controls.Add(Me.lblNextMonday)
        Me.Controls.Add(Me.lblLastMon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBaselinePrice As TextBox
End Class
