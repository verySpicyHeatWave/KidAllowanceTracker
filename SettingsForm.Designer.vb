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
        lblLastResetDay = New Label()
        lblNextResetDay = New Label()
        lblLastResetRead = New Label()
        lblNextResetRead = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtPricePerWkst = New TextBox()
        txtPricePerBhvr = New TextBox()
        Label3 = New Label()
        txtBaselinePrice = New TextBox()
        txt_NewPassword = New TextBox()
        Label4 = New Label()
        lbl_PasswordSet = New Label()
        txt_SaveFilePath = New TextBox()
        SaveFileLabel = New Label()
        btn_SelectSaveDirectory = New Button()
        txtPricePerA = New TextBox()
        Label5 = New Label()
        txtPricePerB = New TextBox()
        Label6 = New Label()
        txtPricePerC = New TextBox()
        Label7 = New Label()
        txtPricePerD = New TextBox()
        Label8 = New Label()
        txtPricePerF = New TextBox()
        Label9 = New Label()
        cmb_Weekdays = New ComboBox()
        lblSelectDay = New Label()
        grpbxResetDay = New GroupBox()
        grpbx_Prices = New GroupBox()
        lbl_ChorePrice = New Label()
        txtPricePerChore = New TextBox()
        grpbxPassword = New GroupBox()
        grpbxFileSave = New GroupBox()
        grpbxResetDay.SuspendLayout()
        grpbx_Prices.SuspendLayout()
        grpbxPassword.SuspendLayout()
        grpbxFileSave.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblLastResetDay
        ' 
        lblLastResetDay.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblLastResetDay.Location = New Point(6, 53)
        lblLastResetDay.Name = "lblLastResetDay"
        lblLastResetDay.Size = New Size(100, 15)
        lblLastResetDay.TabIndex = 0
        lblLastResetDay.Text = "Last Friday:"
        lblLastResetDay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNextResetDay
        ' 
        lblNextResetDay.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblNextResetDay.Location = New Point(6, 78)
        lblNextResetDay.Name = "lblNextResetDay"
        lblNextResetDay.Size = New Size(100, 15)
        lblNextResetDay.TabIndex = 1
        lblNextResetDay.Text = "Next Friday:"
        lblNextResetDay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblLastResetRead
        ' 
        lblLastResetRead.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblLastResetRead.Location = New Point(129, 53)
        lblLastResetRead.Name = "lblLastResetRead"
        lblLastResetRead.Size = New Size(93, 15)
        lblLastResetRead.TabIndex = 3
        lblLastResetRead.Text = "Label2"
        lblLastResetRead.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNextResetRead
        ' 
        lblNextResetRead.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblNextResetRead.Location = New Point(129, 78)
        lblNextResetRead.Name = "lblNextResetRead"
        lblNextResetRead.Size = New Size(93, 15)
        lblNextResetRead.TabIndex = 4
        lblNextResetRead.Text = "Label1"
        lblNextResetRead.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 5
        Label1.Text = "Worksheet Price:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 6
        Label2.Text = "Behavior Price:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerWkst
        ' 
        txtPricePerWkst.BorderStyle = BorderStyle.FixedSingle
        txtPricePerWkst.Cursor = Cursors.IBeam
        txtPricePerWkst.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerWkst.Location = New Point(122, 28)
        txtPricePerWkst.Name = "txtPricePerWkst"
        txtPricePerWkst.Size = New Size(141, 23)
        txtPricePerWkst.TabIndex = 7
        ' 
        ' txtPricePerBhvr
        ' 
        txtPricePerBhvr.BorderStyle = BorderStyle.FixedSingle
        txtPricePerBhvr.Cursor = Cursors.IBeam
        txtPricePerBhvr.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerBhvr.Location = New Point(122, 57)
        txtPricePerBhvr.Name = "txtPricePerBhvr"
        txtPricePerBhvr.Size = New Size(141, 23)
        txtPricePerBhvr.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 15)
        Label3.TabIndex = 9
        Label3.Text = "Baseline:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtBaselinePrice
        ' 
        txtBaselinePrice.BorderStyle = BorderStyle.FixedSingle
        txtBaselinePrice.Cursor = Cursors.IBeam
        txtBaselinePrice.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtBaselinePrice.Location = New Point(122, 260)
        txtBaselinePrice.Name = "txtBaselinePrice"
        txtBaselinePrice.Size = New Size(141, 23)
        txtBaselinePrice.TabIndex = 10
        ' 
        ' txt_NewPassword
        ' 
        txt_NewPassword.BorderStyle = BorderStyle.FixedSingle
        txt_NewPassword.Cursor = Cursors.IBeam
        txt_NewPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_NewPassword.Location = New Point(122, 22)
        txt_NewPassword.Name = "txt_NewPassword"
        txt_NewPassword.Size = New Size(141, 23)
        txt_NewPassword.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 12
        Label4.Text = "New Password:"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_PasswordSet
        ' 
        lbl_PasswordSet.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_PasswordSet.Location = New Point(6, 48)
        lbl_PasswordSet.Name = "lbl_PasswordSet"
        lbl_PasswordSet.Size = New Size(100, 15)
        lbl_PasswordSet.TabIndex = 13
        lbl_PasswordSet.Text = "Password Is Set!"
        lbl_PasswordSet.TextAlign = ContentAlignment.MiddleRight
        lbl_PasswordSet.Visible = False
        ' 
        ' txt_SaveFilePath
        ' 
        txt_SaveFilePath.BorderStyle = BorderStyle.FixedSingle
        txt_SaveFilePath.Cursor = Cursors.IBeam
        txt_SaveFilePath.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_SaveFilePath.Location = New Point(6, 47)
        txt_SaveFilePath.Name = "txt_SaveFilePath"
        txt_SaveFilePath.ReadOnly = True
        txt_SaveFilePath.Size = New Size(257, 23)
        txt_SaveFilePath.TabIndex = 14
        ' 
        ' SaveFileLabel
        ' 
        SaveFileLabel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SaveFileLabel.Location = New Point(6, 29)
        SaveFileLabel.Name = "SaveFileLabel"
        SaveFileLabel.Size = New Size(100, 15)
        SaveFileLabel.TabIndex = 15
        SaveFileLabel.Text = "Save File:"
        SaveFileLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_SelectSaveDirectory
        ' 
        btn_SelectSaveDirectory.Cursor = Cursors.Hand
        btn_SelectSaveDirectory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btn_SelectSaveDirectory.Image = My.Resources.Resources.SelectFolder
        btn_SelectSaveDirectory.Location = New Point(233, 14)
        btn_SelectSaveDirectory.Name = "btn_SelectSaveDirectory"
        btn_SelectSaveDirectory.Size = New Size(30, 30)
        btn_SelectSaveDirectory.TabIndex = 16
        btn_SelectSaveDirectory.UseVisualStyleBackColor = True
        ' 
        ' txtPricePerA
        ' 
        txtPricePerA.BorderStyle = BorderStyle.FixedSingle
        txtPricePerA.Cursor = Cursors.IBeam
        txtPricePerA.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerA.Location = New Point(122, 115)
        txtPricePerA.Name = "txtPricePerA"
        txtPricePerA.Size = New Size(141, 23)
        txtPricePerA.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(6, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 15)
        Label5.TabIndex = 17
        Label5.Text = "A Grade Price:"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerB
        ' 
        txtPricePerB.BorderStyle = BorderStyle.FixedSingle
        txtPricePerB.Cursor = Cursors.IBeam
        txtPricePerB.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerB.Location = New Point(122, 144)
        txtPricePerB.Name = "txtPricePerB"
        txtPricePerB.Size = New Size(141, 23)
        txtPricePerB.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(6, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 15)
        Label6.TabIndex = 19
        Label6.Text = "B Grade Price:"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerC
        ' 
        txtPricePerC.BorderStyle = BorderStyle.FixedSingle
        txtPricePerC.Cursor = Cursors.IBeam
        txtPricePerC.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerC.Location = New Point(122, 173)
        txtPricePerC.Name = "txtPricePerC"
        txtPricePerC.Size = New Size(141, 23)
        txtPricePerC.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(6, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 15)
        Label7.TabIndex = 21
        Label7.Text = "C Grade Price:"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerD
        ' 
        txtPricePerD.BorderStyle = BorderStyle.FixedSingle
        txtPricePerD.Cursor = Cursors.IBeam
        txtPricePerD.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerD.Location = New Point(122, 202)
        txtPricePerD.Name = "txtPricePerD"
        txtPricePerD.Size = New Size(141, 23)
        txtPricePerD.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(6, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 15)
        Label8.TabIndex = 23
        Label8.Text = "D Grade Price:"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerF
        ' 
        txtPricePerF.BorderStyle = BorderStyle.FixedSingle
        txtPricePerF.Cursor = Cursors.IBeam
        txtPricePerF.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerF.Location = New Point(122, 231)
        txtPricePerF.Name = "txtPricePerF"
        txtPricePerF.Size = New Size(141, 23)
        txtPricePerF.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(6, 233)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 15)
        Label9.TabIndex = 25
        Label9.Text = "F Grade Price:"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cmb_Weekdays
        ' 
        cmb_Weekdays.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_Weekdays.FormattingEnabled = True
        cmb_Weekdays.Location = New Point(122, 25)
        cmb_Weekdays.Name = "cmb_Weekdays"
        cmb_Weekdays.Size = New Size(141, 23)
        cmb_Weekdays.TabIndex = 27
        ' 
        ' lblSelectDay
        ' 
        lblSelectDay.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblSelectDay.Location = New Point(6, 28)
        lblSelectDay.Name = "lblSelectDay"
        lblSelectDay.Size = New Size(100, 15)
        lblSelectDay.TabIndex = 28
        lblSelectDay.Text = "Week Reset Day:"
        lblSelectDay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' grpbxResetDay
        ' 
        grpbxResetDay.Controls.Add(lblSelectDay)
        grpbxResetDay.Controls.Add(lblLastResetDay)
        grpbxResetDay.Controls.Add(cmb_Weekdays)
        grpbxResetDay.Controls.Add(lblNextResetDay)
        grpbxResetDay.Controls.Add(lblLastResetRead)
        grpbxResetDay.Controls.Add(lblNextResetRead)
        grpbxResetDay.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpbxResetDay.Location = New Point(12, 12)
        grpbxResetDay.Name = "grpbxResetDay"
        grpbxResetDay.Size = New Size(279, 104)
        grpbxResetDay.TabIndex = 29
        grpbxResetDay.TabStop = False
        grpbxResetDay.Text = "Weekly Reset Day Settings"' 
        ' grpbx_Prices
        ' 
        grpbx_Prices.Controls.Add(lbl_ChorePrice)
        grpbx_Prices.Controls.Add(Label1)
        grpbx_Prices.Controls.Add(Label2)
        grpbx_Prices.Controls.Add(txtPricePerChore)
        grpbx_Prices.Controls.Add(txtPricePerF)
        grpbx_Prices.Controls.Add(txtPricePerWkst)
        grpbx_Prices.Controls.Add(Label9)
        grpbx_Prices.Controls.Add(txtPricePerBhvr)
        grpbx_Prices.Controls.Add(txtPricePerD)
        grpbx_Prices.Controls.Add(Label3)
        grpbx_Prices.Controls.Add(Label8)
        grpbx_Prices.Controls.Add(txtBaselinePrice)
        grpbx_Prices.Controls.Add(txtPricePerC)
        grpbx_Prices.Controls.Add(Label5)
        grpbx_Prices.Controls.Add(Label7)
        grpbx_Prices.Controls.Add(txtPricePerA)
        grpbx_Prices.Controls.Add(txtPricePerB)
        grpbx_Prices.Controls.Add(Label6)
        grpbx_Prices.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpbx_Prices.Location = New Point(12, 122)
        grpbx_Prices.Name = "grpbx_Prices"
        grpbx_Prices.Size = New Size(279, 296)
        grpbx_Prices.TabIndex = 30
        grpbx_Prices.TabStop = False
        grpbx_Prices.Text = "Price Settings"' 
        ' lbl_ChorePrice
        ' 
        lbl_ChorePrice.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_ChorePrice.Location = New Point(6, 88)
        lbl_ChorePrice.Name = "lbl_ChorePrice"
        lbl_ChorePrice.Size = New Size(100, 15)
        lbl_ChorePrice.TabIndex = 27
        lbl_ChorePrice.Text = "Chore Price:"
        lbl_ChorePrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtPricePerChore
        ' 
        txtPricePerChore.BorderStyle = BorderStyle.FixedSingle
        txtPricePerChore.Cursor = Cursors.IBeam
        txtPricePerChore.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPricePerChore.Location = New Point(122, 86)
        txtPricePerChore.Name = "txtPricePerChore"
        txtPricePerChore.Size = New Size(141, 23)
        txtPricePerChore.TabIndex = 28
        ' 
        ' grpbxPassword
        ' 
        grpbxPassword.Controls.Add(Label4)
        grpbxPassword.Controls.Add(txt_NewPassword)
        grpbxPassword.Controls.Add(lbl_PasswordSet)
        grpbxPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpbxPassword.Location = New Point(12, 424)
        grpbxPassword.Name = "grpbxPassword"
        grpbxPassword.Size = New Size(279, 75)
        grpbxPassword.TabIndex = 31
        grpbxPassword.TabStop = False
        grpbxPassword.Text = "Password Reset"' 
        ' grpbxFileSave
        ' 
        grpbxFileSave.Controls.Add(txt_SaveFilePath)
        grpbxFileSave.Controls.Add(SaveFileLabel)
        grpbxFileSave.Controls.Add(btn_SelectSaveDirectory)
        grpbxFileSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpbxFileSave.Location = New Point(12, 505)
        grpbxFileSave.Name = "grpbxFileSave"
        grpbxFileSave.Size = New Size(279, 80)
        grpbxFileSave.TabIndex = 32
        grpbxFileSave.TabStop = False
        grpbxFileSave.Text = "File Save Location"' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 608)
        Controls.Add(grpbxFileSave)
        Controls.Add(grpbxPassword)
        Controls.Add(grpbx_Prices)
        Controls.Add(grpbxResetDay)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TopMost = True
        grpbxResetDay.ResumeLayout(False)
        grpbx_Prices.ResumeLayout(False)
        grpbx_Prices.PerformLayout()
        grpbxPassword.ResumeLayout(False)
        grpbxPassword.PerformLayout()
        grpbxFileSave.ResumeLayout(False)
        grpbxFileSave.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLastResetDay As Label
    Friend WithEvents lblNextResetDay As Label
    Friend WithEvents lblLastResetRead As Label
    Friend WithEvents lblNextResetRead As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPricePerWkst As TextBox
    Friend WithEvents txtPricePerBhvr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBaselinePrice As TextBox
    Friend WithEvents txt_NewPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_PasswordSet As Label
    Friend WithEvents txt_SaveFilePath As TextBox
    Friend WithEvents SaveFileLabel As Label
    Friend WithEvents btn_SelectSaveDirectory As Button
    Friend WithEvents txtPricePerA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPricePerB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPricePerC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPricePerD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPricePerF As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_Weekdays As ComboBox
    Friend WithEvents lblSelectDay As Label
    Friend WithEvents grpbxResetDay As GroupBox
    Friend WithEvents grpbx_Prices As GroupBox
    Friend WithEvents lbl_ChorePrice As Label
    Friend WithEvents txtPricePerChore As TextBox
    Friend WithEvents grpbxPassword As GroupBox
    Friend WithEvents grpbxFileSave As GroupBox
End Class
