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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AllowanceTracker))
        Ruby_AddWorksheet = New Button()
        Pepper_AddWorksheet = New Button()
        Ruby_AddBehavior = New Button()
        Pepper_AddBehavior = New Button()
        Ruby_NameLabel = New Label()
        Pepper_NameLabel = New Label()
        Pepper_Allowance = New Label()
        Ruby_Allowance = New Label()
        Ruby_WorksheetCount = New Label()
        Ruby_BehaviorCount = New Label()
        Pepper_WorksheetCount = New Label()
        Pepper_BehaviorCount = New Label()
        SaveButton = New Button()
        SettingsButton = New Button()
        LoadButton = New Button()
        PepperRainbowWorker = New ComponentModel.BackgroundWorker()
        RubyRainbowWorker = New ComponentModel.BackgroundWorker()
        ToolTipThingy = New ToolTip(components)
        CloseButton = New Button()
        ckbtn_PasswordLock = New CheckBox()
        PepperGradesCount = New Label()
        RubyGradesCount = New Label()
        Ruby_AddGrades = New Button()
        Pepper_AddGrades = New Button()
        Ruby_AddBehaviorNote = New Button()
        Pepper_AddBehaviorNote = New Button()
        NewWeekButton = New Button()
        DateChecker = New Timer(components)
        grpbx_Ruby = New GroupBox()
        Ruby_ChoresButton = New Button()
        Ruby_ChoresCount = New Label()
        grpbx_Pepper = New GroupBox()
        Pepper_ChoresButton = New Button()
        Pepper_ChoresCount = New Label()
        grpbx_Ruby.SuspendLayout()
        grpbx_Pepper.SuspendLayout()
        SuspendLayout()
        ' 
        ' Ruby_AddWorksheet
        ' 
        Ruby_AddWorksheet.Cursor = Cursors.Hand
        Ruby_AddWorksheet.Image = My.Resources.Resources.WorksheetButton
        Ruby_AddWorksheet.Location = New Point(6, 76)
        Ruby_AddWorksheet.Name = "Ruby_AddWorksheet"
        Ruby_AddWorksheet.Size = New Size(41, 41)
        Ruby_AddWorksheet.TabIndex = 0
        Ruby_AddWorksheet.TabStop = False
        Ruby_AddWorksheet.UseVisualStyleBackColor = True
        ' 
        ' Pepper_AddWorksheet
        ' 
        Pepper_AddWorksheet.Cursor = Cursors.Hand
        Pepper_AddWorksheet.Image = My.Resources.Resources.WorksheetButton
        Pepper_AddWorksheet.Location = New Point(6, 76)
        Pepper_AddWorksheet.Name = "Pepper_AddWorksheet"
        Pepper_AddWorksheet.Size = New Size(41, 41)
        Pepper_AddWorksheet.TabIndex = 0
        Pepper_AddWorksheet.TabStop = False
        Pepper_AddWorksheet.UseVisualStyleBackColor = True
        ' 
        ' Ruby_AddBehavior
        ' 
        Ruby_AddBehavior.Cursor = Cursors.Hand
        Ruby_AddBehavior.Image = My.Resources.Resources.BehaviorButton
        Ruby_AddBehavior.Location = New Point(100, 76)
        Ruby_AddBehavior.Name = "Ruby_AddBehavior"
        Ruby_AddBehavior.Size = New Size(41, 41)
        Ruby_AddBehavior.TabIndex = 0
        Ruby_AddBehavior.TabStop = False
        Ruby_AddBehavior.UseVisualStyleBackColor = True
        ' 
        ' Pepper_AddBehavior
        ' 
        Pepper_AddBehavior.Cursor = Cursors.Hand
        Pepper_AddBehavior.Image = My.Resources.Resources.BehaviorButton
        Pepper_AddBehavior.Location = New Point(100, 76)
        Pepper_AddBehavior.Name = "Pepper_AddBehavior"
        Pepper_AddBehavior.Size = New Size(41, 41)
        Pepper_AddBehavior.TabIndex = 0
        Pepper_AddBehavior.TabStop = False
        Pepper_AddBehavior.UseVisualStyleBackColor = True
        ' 
        ' Ruby_NameLabel
        ' 
        Ruby_NameLabel.Font = New Font("Alba Super", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Ruby_NameLabel.Location = New Point(6, 19)
        Ruby_NameLabel.Name = "Ruby_NameLabel"
        Ruby_NameLabel.Size = New Size(182, 50)
        Ruby_NameLabel.TabIndex = 4
        Ruby_NameLabel.Text = "Ruby"
        Ruby_NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pepper_NameLabel
        ' 
        Pepper_NameLabel.Font = New Font("Alba Super", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Pepper_NameLabel.Location = New Point(6, 19)
        Pepper_NameLabel.Name = "Pepper_NameLabel"
        Pepper_NameLabel.Size = New Size(182, 50)
        Pepper_NameLabel.TabIndex = 5
        Pepper_NameLabel.Text = "Pepper"
        Pepper_NameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pepper_Allowance
        ' 
        Pepper_Allowance.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Pepper_Allowance.Location = New Point(6, 223)
        Pepper_Allowance.Name = "Pepper_Allowance"
        Pepper_Allowance.Size = New Size(182, 23)
        Pepper_Allowance.TabIndex = 6
        Pepper_Allowance.Text = "Allowance: $1.00"
        Pepper_Allowance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ruby_Allowance
        ' 
        Ruby_Allowance.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Ruby_Allowance.Location = New Point(6, 223)
        Ruby_Allowance.Name = "Ruby_Allowance"
        Ruby_Allowance.Size = New Size(182, 23)
        Ruby_Allowance.TabIndex = 7
        Ruby_Allowance.Text = "Allowance: $1.00"
        Ruby_Allowance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ruby_WorksheetCount
        ' 
        Ruby_WorksheetCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Ruby_WorksheetCount.Location = New Point(6, 122)
        Ruby_WorksheetCount.Name = "Ruby_WorksheetCount"
        Ruby_WorksheetCount.Size = New Size(182, 23)
        Ruby_WorksheetCount.TabIndex = 8
        Ruby_WorksheetCount.Text = "Worksheets: 0"
        Ruby_WorksheetCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ruby_BehaviorCount
        ' 
        Ruby_BehaviorCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Ruby_BehaviorCount.Location = New Point(6, 145)
        Ruby_BehaviorCount.Name = "Ruby_BehaviorCount"
        Ruby_BehaviorCount.Size = New Size(182, 23)
        Ruby_BehaviorCount.TabIndex = 9
        Ruby_BehaviorCount.Text = "Behavior: 0"
        Ruby_BehaviorCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pepper_WorksheetCount
        ' 
        Pepper_WorksheetCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Pepper_WorksheetCount.Location = New Point(6, 122)
        Pepper_WorksheetCount.Name = "Pepper_WorksheetCount"
        Pepper_WorksheetCount.Size = New Size(182, 23)
        Pepper_WorksheetCount.TabIndex = 10
        Pepper_WorksheetCount.Text = "Worksheets: 0"
        Pepper_WorksheetCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Pepper_BehaviorCount
        ' 
        Pepper_BehaviorCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Pepper_BehaviorCount.Location = New Point(6, 145)
        Pepper_BehaviorCount.Name = "Pepper_BehaviorCount"
        Pepper_BehaviorCount.Size = New Size(182, 23)
        Pepper_BehaviorCount.TabIndex = 11
        Pepper_BehaviorCount.Text = "Behavior: 0"
        Pepper_BehaviorCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SaveButton
        ' 
        SaveButton.Cursor = Cursors.Hand
        SaveButton.Image = My.Resources.Resources.SaveButton
        SaveButton.Location = New Point(12, 12)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(41, 41)
        SaveButton.TabIndex = 0
        SaveButton.TabStop = False
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' SettingsButton
        ' 
        SettingsButton.Cursor = Cursors.Hand
        SettingsButton.Image = My.Resources.Resources.SettingsButton
        SettingsButton.Location = New Point(200, 12)
        SettingsButton.Name = "SettingsButton"
        SettingsButton.Size = New Size(41, 41)
        SettingsButton.TabIndex = 0
        SettingsButton.TabStop = False
        SettingsButton.UseVisualStyleBackColor = True
        ' 
        ' LoadButton
        ' 
        LoadButton.Cursor = Cursors.Hand
        LoadButton.Image = My.Resources.Resources.LoadIcon
        LoadButton.Location = New Point(59, 12)
        LoadButton.Name = "LoadButton"
        LoadButton.Size = New Size(41, 41)
        LoadButton.TabIndex = 0
        LoadButton.TabStop = False
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' PepperRainbowWorker
        ' 
        PepperRainbowWorker.WorkerReportsProgress = True
        PepperRainbowWorker.WorkerSupportsCancellation = True
        ' 
        ' RubyRainbowWorker
        ' 
        RubyRainbowWorker.WorkerReportsProgress = True
        RubyRainbowWorker.WorkerSupportsCancellation = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Cursor = Cursors.Hand
        CloseButton.Image = My.Resources.Resources.CloseButton
        CloseButton.Location = New Point(247, 12)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(41, 41)
        CloseButton.TabIndex = 0
        CloseButton.TabStop = False
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ckbtn_PasswordLock
        ' 
        ckbtn_PasswordLock.Appearance = Appearance.Button
        ckbtn_PasswordLock.CheckAlign = ContentAlignment.MiddleCenter
        ckbtn_PasswordLock.Checked = True
        ckbtn_PasswordLock.CheckState = CheckState.Checked
        ckbtn_PasswordLock.Cursor = Cursors.Hand
        ckbtn_PasswordLock.FlatAppearance.CheckedBackColor = Color.White
        ckbtn_PasswordLock.Image = My.Resources.Resources.LockButton
        ckbtn_PasswordLock.Location = New Point(153, 12)
        ckbtn_PasswordLock.Name = "ckbtn_PasswordLock"
        ckbtn_PasswordLock.Size = New Size(41, 41)
        ckbtn_PasswordLock.TabIndex = 0
        ckbtn_PasswordLock.TabStop = False
        ckbtn_PasswordLock.UseVisualStyleBackColor = True
        ' 
        ' PepperGradesCount
        ' 
        PepperGradesCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        PepperGradesCount.ForeColor = Color.Silver
        PepperGradesCount.Location = New Point(6, 191)
        PepperGradesCount.Name = "PepperGradesCount"
        PepperGradesCount.Size = New Size(182, 23)
        PepperGradesCount.TabIndex = 21
        PepperGradesCount.Text = "No Report Card"
        PepperGradesCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RubyGradesCount
        ' 
        RubyGradesCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RubyGradesCount.ForeColor = Color.Silver
        RubyGradesCount.Location = New Point(6, 191)
        RubyGradesCount.Name = "RubyGradesCount"
        RubyGradesCount.Size = New Size(182, 23)
        RubyGradesCount.TabIndex = 20
        RubyGradesCount.Text = "No Report Card"
        RubyGradesCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Ruby_AddGrades
        ' 
        Ruby_AddGrades.Cursor = Cursors.Hand
        Ruby_AddGrades.Image = CType(resources.GetObject("Ruby_AddGrades.Image"), Image)
        Ruby_AddGrades.Location = New Point(53, 76)
        Ruby_AddGrades.Name = "Ruby_AddGrades"
        Ruby_AddGrades.Size = New Size(41, 41)
        Ruby_AddGrades.TabIndex = 0
        Ruby_AddGrades.TabStop = False
        Ruby_AddGrades.UseVisualStyleBackColor = True
        ' 
        ' Pepper_AddGrades
        ' 
        Pepper_AddGrades.Cursor = Cursors.Hand
        Pepper_AddGrades.Image = My.Resources.Resources.GradesButton1
        Pepper_AddGrades.Location = New Point(53, 76)
        Pepper_AddGrades.Name = "Pepper_AddGrades"
        Pepper_AddGrades.Size = New Size(41, 41)
        Pepper_AddGrades.TabIndex = 0
        Pepper_AddGrades.TabStop = False
        Pepper_AddGrades.UseVisualStyleBackColor = True
        ' 
        ' Ruby_AddBehaviorNote
        ' 
        Ruby_AddBehaviorNote.Cursor = Cursors.Hand
        Ruby_AddBehaviorNote.Enabled = False
        Ruby_AddBehaviorNote.Image = My.Resources.Resources.BehaviorNoteIcon
        Ruby_AddBehaviorNote.Location = New Point(147, 142)
        Ruby_AddBehaviorNote.Name = "Ruby_AddBehaviorNote"
        Ruby_AddBehaviorNote.Size = New Size(30, 30)
        Ruby_AddBehaviorNote.TabIndex = 0
        Ruby_AddBehaviorNote.TabStop = False
        Ruby_AddBehaviorNote.UseVisualStyleBackColor = True
        Ruby_AddBehaviorNote.Visible = False
        ' 
        ' Pepper_AddBehaviorNote
        ' 
        Pepper_AddBehaviorNote.Cursor = Cursors.Hand
        Pepper_AddBehaviorNote.Enabled = False
        Pepper_AddBehaviorNote.Image = My.Resources.Resources.BehaviorNoteIcon
        Pepper_AddBehaviorNote.Location = New Point(147, 142)
        Pepper_AddBehaviorNote.Name = "Pepper_AddBehaviorNote"
        Pepper_AddBehaviorNote.Size = New Size(30, 30)
        Pepper_AddBehaviorNote.TabIndex = 0
        Pepper_AddBehaviorNote.TabStop = False
        Pepper_AddBehaviorNote.UseVisualStyleBackColor = True
        Pepper_AddBehaviorNote.Visible = False
        ' 
        ' NewWeekButton
        ' 
        NewWeekButton.Image = My.Resources.Resources.NewWeekButton
        NewWeekButton.Location = New Point(106, 12)
        NewWeekButton.Name = "NewWeekButton"
        NewWeekButton.Size = New Size(41, 41)
        NewWeekButton.TabIndex = 22
        NewWeekButton.UseVisualStyleBackColor = True
        ' 
        ' DateChecker
        ' 
        DateChecker.Interval = 3600000
        ' 
        ' grpbx_Ruby
        ' 
        grpbx_Ruby.Controls.Add(Ruby_NameLabel)
        grpbx_Ruby.Controls.Add(Ruby_AddWorksheet)
        grpbx_Ruby.Controls.Add(Ruby_AddBehavior)
        grpbx_Ruby.Controls.Add(Ruby_ChoresButton)
        grpbx_Ruby.Controls.Add(Ruby_Allowance)
        grpbx_Ruby.Controls.Add(RubyGradesCount)
        grpbx_Ruby.Controls.Add(Ruby_AddGrades)
        grpbx_Ruby.Controls.Add(Ruby_AddBehaviorNote)
        grpbx_Ruby.Controls.Add(Ruby_ChoresCount)
        grpbx_Ruby.Controls.Add(Ruby_WorksheetCount)
        grpbx_Ruby.Controls.Add(Ruby_BehaviorCount)
        grpbx_Ruby.Location = New Point(12, 59)
        grpbx_Ruby.Name = "grpbx_Ruby"
        grpbx_Ruby.Size = New Size(194, 258)
        grpbx_Ruby.TabIndex = 23
        grpbx_Ruby.TabStop = False
        ' 
        ' Ruby_ChoresButton
        ' 
        Ruby_ChoresButton.Cursor = Cursors.Hand
        Ruby_ChoresButton.Image = CType(resources.GetObject("Ruby_ChoresButton.Image"), Image)
        Ruby_ChoresButton.Location = New Point(147, 76)
        Ruby_ChoresButton.Name = "Ruby_ChoresButton"
        Ruby_ChoresButton.Size = New Size(41, 41)
        Ruby_ChoresButton.TabIndex = 25
        Ruby_ChoresButton.TabStop = False
        Ruby_ChoresButton.UseVisualStyleBackColor = True
        ' 
        ' Ruby_ChoresCount
        ' 
        Ruby_ChoresCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Ruby_ChoresCount.Location = New Point(6, 168)
        Ruby_ChoresCount.Name = "Ruby_ChoresCount"
        Ruby_ChoresCount.Size = New Size(182, 23)
        Ruby_ChoresCount.TabIndex = 27
        Ruby_ChoresCount.Text = "Chores: 0"
        Ruby_ChoresCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpbx_Pepper
        ' 
        grpbx_Pepper.Controls.Add(Pepper_NameLabel)
        grpbx_Pepper.Controls.Add(Pepper_ChoresButton)
        grpbx_Pepper.Controls.Add(Pepper_AddWorksheet)
        grpbx_Pepper.Controls.Add(Pepper_AddBehavior)
        grpbx_Pepper.Controls.Add(Pepper_Allowance)
        grpbx_Pepper.Controls.Add(Pepper_AddBehaviorNote)
        grpbx_Pepper.Controls.Add(Pepper_AddGrades)
        grpbx_Pepper.Controls.Add(PepperGradesCount)
        grpbx_Pepper.Controls.Add(Pepper_ChoresCount)
        grpbx_Pepper.Controls.Add(Pepper_WorksheetCount)
        grpbx_Pepper.Controls.Add(Pepper_BehaviorCount)
        grpbx_Pepper.Location = New Point(212, 59)
        grpbx_Pepper.Name = "grpbx_Pepper"
        grpbx_Pepper.Size = New Size(194, 258)
        grpbx_Pepper.TabIndex = 24
        grpbx_Pepper.TabStop = False
        ' 
        ' Pepper_ChoresButton
        ' 
        Pepper_ChoresButton.Cursor = Cursors.Hand
        Pepper_ChoresButton.Image = CType(resources.GetObject("Pepper_ChoresButton.Image"), Image)
        Pepper_ChoresButton.Location = New Point(147, 76)
        Pepper_ChoresButton.Name = "Pepper_ChoresButton"
        Pepper_ChoresButton.Size = New Size(41, 41)
        Pepper_ChoresButton.TabIndex = 26
        Pepper_ChoresButton.TabStop = False
        Pepper_ChoresButton.UseVisualStyleBackColor = True
        ' 
        ' Pepper_ChoresCount
        ' 
        Pepper_ChoresCount.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Pepper_ChoresCount.Location = New Point(6, 168)
        Pepper_ChoresCount.Name = "Pepper_ChoresCount"
        Pepper_ChoresCount.Size = New Size(182, 23)
        Pepper_ChoresCount.TabIndex = 28
        Pepper_ChoresCount.Text = "Chores: 0"
        Pepper_ChoresCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AllowanceTracker
        ' 
        AcceptButton = SaveButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = CloseButton
        ClientSize = New Size(420, 329)
        ControlBox = False
        Controls.Add(grpbx_Pepper)
        Controls.Add(grpbx_Ruby)
        Controls.Add(NewWeekButton)
        Controls.Add(ckbtn_PasswordLock)
        Controls.Add(CloseButton)
        Controls.Add(LoadButton)
        Controls.Add(SettingsButton)
        Controls.Add(SaveButton)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "AllowanceTracker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Allowance Tracker"
        grpbx_Ruby.ResumeLayout(False)
        grpbx_Pepper.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Ruby_AddWorksheet As Button
    Friend WithEvents Pepper_AddWorksheet As Button
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
    Friend WithEvents PepperRainbowWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RubyRainbowWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTipThingy As ToolTip
    Friend WithEvents CloseButton As Button
    Friend WithEvents ckbtn_PasswordLock As CheckBox
    Friend WithEvents PepperGradesCount As Label
    Friend WithEvents RubyGradesCount As Label
    Friend WithEvents Ruby_AddGrades As Button
    Friend WithEvents Pepper_AddGrades As Button
    Friend WithEvents Ruby_AddBehaviorNote As Button
    Friend WithEvents Pepper_AddBehaviorNote As Button
    Friend WithEvents NewWeekButton As Button
    Friend WithEvents DateChecker As Timer
    Friend WithEvents grpbx_Ruby As GroupBox
    Friend WithEvents Ruby_ChoresButton As Button
    Friend WithEvents Ruby_ChoresCount As Label
    Friend WithEvents grpbx_Pepper As GroupBox
    Friend WithEvents Pepper_ChoresButton As Button
    Friend WithEvents Pepper_ChoresCount As Label
End Class
