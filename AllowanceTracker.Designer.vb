<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllowanceTracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Ruby_AddWorksheet = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Ruby_AddBehavior = New System.Windows.Forms.Button()
        Me.Pepper_AddBehavior = New System.Windows.Forms.Button()
        Me.Ruby_NameLabel = New System.Windows.Forms.Label()
        Me.Pepper_NameLabel = New System.Windows.Forms.Label()
        Me.Pepper_Allowance = New System.Windows.Forms.Label()
        Me.Ruby_Allowance = New System.Windows.Forms.Label()
        Me.Ruby_WorksheetCount = New System.Windows.Forms.Label()
        Me.Ruby_BehaviorCount = New System.Windows.Forms.Label()
        Me.Pepper_WorksheetCount = New System.Windows.Forms.Label()
        Me.Pepper_BehaviorCount = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.NewWeekButton = New System.Windows.Forms.Button()
        Me.PepperRainbowWorker = New System.ComponentModel.BackgroundWorker()
        Me.RubyRainbowWorker = New System.ComponentModel.BackgroundWorker()
        Me.ToolTipThingy = New System.Windows.Forms.ToolTip(Me.components)
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ruby_AddWorksheet
        '
        Me.Ruby_AddWorksheet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ruby_AddWorksheet.Image = Global.KidAllowanceTracker.My.Resources.Resources.WorksheetButton
        Me.Ruby_AddWorksheet.Location = New System.Drawing.Point(12, 118)
        Me.Ruby_AddWorksheet.Name = "Ruby_AddWorksheet"
        Me.Ruby_AddWorksheet.Size = New System.Drawing.Size(41, 41)
        Me.Ruby_AddWorksheet.TabIndex = 0
        Me.Ruby_AddWorksheet.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.KidAllowanceTracker.My.Resources.Resources.WorksheetButton
        Me.Button2.Location = New System.Drawing.Point(225, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ruby_AddBehavior
        '
        Me.Ruby_AddBehavior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ruby_AddBehavior.Image = Global.KidAllowanceTracker.My.Resources.Resources.BehaviorButton
        Me.Ruby_AddBehavior.Location = New System.Drawing.Point(106, 118)
        Me.Ruby_AddBehavior.Name = "Ruby_AddBehavior"
        Me.Ruby_AddBehavior.Size = New System.Drawing.Size(41, 41)
        Me.Ruby_AddBehavior.TabIndex = 2
        Me.Ruby_AddBehavior.UseVisualStyleBackColor = True
        '
        'Pepper_AddBehavior
        '
        Me.Pepper_AddBehavior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pepper_AddBehavior.Image = Global.KidAllowanceTracker.My.Resources.Resources.BehaviorButton
        Me.Pepper_AddBehavior.Location = New System.Drawing.Point(319, 118)
        Me.Pepper_AddBehavior.Name = "Pepper_AddBehavior"
        Me.Pepper_AddBehavior.Size = New System.Drawing.Size(41, 41)
        Me.Pepper_AddBehavior.TabIndex = 3
        Me.Pepper_AddBehavior.UseVisualStyleBackColor = True
        '
        'Ruby_NameLabel
        '
        Me.Ruby_NameLabel.Font = New System.Drawing.Font("Alba Super", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ruby_NameLabel.Location = New System.Drawing.Point(12, 61)
        Me.Ruby_NameLabel.Name = "Ruby_NameLabel"
        Me.Ruby_NameLabel.Size = New System.Drawing.Size(135, 50)
        Me.Ruby_NameLabel.TabIndex = 4
        Me.Ruby_NameLabel.Text = "Ruby"
        Me.Ruby_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pepper_NameLabel
        '
        Me.Pepper_NameLabel.Font = New System.Drawing.Font("Alba Super", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pepper_NameLabel.Location = New System.Drawing.Point(225, 61)
        Me.Pepper_NameLabel.Name = "Pepper_NameLabel"
        Me.Pepper_NameLabel.Size = New System.Drawing.Size(135, 50)
        Me.Pepper_NameLabel.TabIndex = 5
        Me.Pepper_NameLabel.Text = "Pepper"
        Me.Pepper_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pepper_Allowance
        '
        Me.Pepper_Allowance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Pepper_Allowance.Location = New System.Drawing.Point(225, 210)
        Me.Pepper_Allowance.Name = "Pepper_Allowance"
        Me.Pepper_Allowance.Size = New System.Drawing.Size(135, 23)
        Me.Pepper_Allowance.TabIndex = 6
        Me.Pepper_Allowance.Text = "Allowance: $1.00"
        Me.Pepper_Allowance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ruby_Allowance
        '
        Me.Ruby_Allowance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Ruby_Allowance.Location = New System.Drawing.Point(12, 210)
        Me.Ruby_Allowance.Name = "Ruby_Allowance"
        Me.Ruby_Allowance.Size = New System.Drawing.Size(135, 23)
        Me.Ruby_Allowance.TabIndex = 7
        Me.Ruby_Allowance.Text = "Allowance: $1.00"
        Me.Ruby_Allowance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ruby_WorksheetCount
        '
        Me.Ruby_WorksheetCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ruby_WorksheetCount.Location = New System.Drawing.Point(12, 164)
        Me.Ruby_WorksheetCount.Name = "Ruby_WorksheetCount"
        Me.Ruby_WorksheetCount.Size = New System.Drawing.Size(135, 23)
        Me.Ruby_WorksheetCount.TabIndex = 8
        Me.Ruby_WorksheetCount.Text = "Worksheets: 0"
        Me.Ruby_WorksheetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ruby_BehaviorCount
        '
        Me.Ruby_BehaviorCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Ruby_BehaviorCount.Location = New System.Drawing.Point(12, 187)
        Me.Ruby_BehaviorCount.Name = "Ruby_BehaviorCount"
        Me.Ruby_BehaviorCount.Size = New System.Drawing.Size(135, 23)
        Me.Ruby_BehaviorCount.TabIndex = 9
        Me.Ruby_BehaviorCount.Text = "Behavior: 0"
        Me.Ruby_BehaviorCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pepper_WorksheetCount
        '
        Me.Pepper_WorksheetCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pepper_WorksheetCount.Location = New System.Drawing.Point(225, 164)
        Me.Pepper_WorksheetCount.Name = "Pepper_WorksheetCount"
        Me.Pepper_WorksheetCount.Size = New System.Drawing.Size(135, 23)
        Me.Pepper_WorksheetCount.TabIndex = 10
        Me.Pepper_WorksheetCount.Text = "Worksheets: 0"
        Me.Pepper_WorksheetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pepper_BehaviorCount
        '
        Me.Pepper_BehaviorCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pepper_BehaviorCount.Location = New System.Drawing.Point(225, 187)
        Me.Pepper_BehaviorCount.Name = "Pepper_BehaviorCount"
        Me.Pepper_BehaviorCount.Size = New System.Drawing.Size(135, 23)
        Me.Pepper_BehaviorCount.TabIndex = 11
        Me.Pepper_BehaviorCount.Text = "Behavior: 0"
        Me.Pepper_BehaviorCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveButton
        '
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.Image = Global.KidAllowanceTracker.My.Resources.Resources.SaveButton
        Me.SaveButton.Location = New System.Drawing.Point(12, 12)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(41, 41)
        Me.SaveButton.TabIndex = 14
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.Image = Global.KidAllowanceTracker.My.Resources.Resources.SettingsButton
        Me.SettingsButton.Location = New System.Drawing.Point(153, 12)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(41, 41)
        Me.SettingsButton.TabIndex = 15
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'LoadButton
        '
        Me.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadButton.Image = Global.KidAllowanceTracker.My.Resources.Resources.LoadIcon
        Me.LoadButton.Location = New System.Drawing.Point(59, 12)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(41, 41)
        Me.LoadButton.TabIndex = 16
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'NewWeekButton
        '
        Me.NewWeekButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewWeekButton.Image = Global.KidAllowanceTracker.My.Resources.Resources.NewWeekButton
        Me.NewWeekButton.Location = New System.Drawing.Point(106, 12)
        Me.NewWeekButton.Name = "NewWeekButton"
        Me.NewWeekButton.Size = New System.Drawing.Size(41, 41)
        Me.NewWeekButton.TabIndex = 17
        Me.NewWeekButton.UseVisualStyleBackColor = True
        '
        'PepperRainbowWorker
        '
        Me.PepperRainbowWorker.WorkerReportsProgress = True
        Me.PepperRainbowWorker.WorkerSupportsCancellation = True
        '
        'RubyRainbowWorker
        '
        Me.RubyRainbowWorker.WorkerReportsProgress = True
        Me.RubyRainbowWorker.WorkerSupportsCancellation = True
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Image = Global.KidAllowanceTracker.My.Resources.Resources.CloseButton
        Me.CloseButton.Location = New System.Drawing.Point(319, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(41, 41)
        Me.CloseButton.TabIndex = 18
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'AllowanceTracker
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NewWeekButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Pepper_BehaviorCount)
        Me.Controls.Add(Me.Pepper_WorksheetCount)
        Me.Controls.Add(Me.Ruby_BehaviorCount)
        Me.Controls.Add(Me.Ruby_WorksheetCount)
        Me.Controls.Add(Me.Ruby_Allowance)
        Me.Controls.Add(Me.Pepper_Allowance)
        Me.Controls.Add(Me.Pepper_NameLabel)
        Me.Controls.Add(Me.Ruby_NameLabel)
        Me.Controls.Add(Me.Pepper_AddBehavior)
        Me.Controls.Add(Me.Ruby_AddBehavior)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ruby_AddWorksheet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AllowanceTracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allowance Tracker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ruby_AddWorksheet As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Ruby_AddBehavior As Button
    Friend WithEvents Pepper_AddBehavior As Button
    Friend WithEvents Ruby_NameLabel As Label
    Friend WithEvents Pepper_NameLabel As Label
    Friend WithEvents Pepper_Allowance As Label
    Friend WithEvents Ruby_Allowance As Label
    Friend WithEvents Ruby_WorksheetCount As Label
    Friend WithEvents Ruby_BehaviorCount As Label
    Friend WithEvents Pepper_WorksheetCount As Label
    Friend WithEvents Pepper_BehaviorCount As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents NewWeekButton As Button
    Friend WithEvents PepperRainbowWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RubyRainbowWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTipThingy As ToolTip
    Friend WithEvents CloseButton As Button
End Class
