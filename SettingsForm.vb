Imports System.IO
Imports System.IO.Packaging

Public Class Settings

    Private Sub SettingsLoad() Handles MyBase.Load

        'Populate the text boxes
        txtPricePerWkst.Text = AllowanceTracker.Stats.PricePer.Worksheet.ToString
        txtPricePerBhvr.Text = AllowanceTracker.Stats.PricePer.Behavior.ToString
        txtPricePerA.Text = AllowanceTracker.Stats.PricePer.AGrades.ToString
        txtPricePerB.Text = AllowanceTracker.Stats.PricePer.BGrades.ToString
        txtPricePerC.Text = AllowanceTracker.Stats.PricePer.CGrades.ToString
        txtPricePerD.Text = AllowanceTracker.Stats.PricePer.DGrades.ToString
        txtPricePerF.Text = AllowanceTracker.Stats.PricePer.FGrades.ToString
        txtBaselinePrice.Text = AllowanceTracker.Stats.BaselinePay.ToString

        'Format the text boxes
        txtPricePerWkst.Text = FormatNumber(CDbl(txtPricePerWkst.Text), 2).ToString
        txtPricePerBhvr.Text = FormatNumber(CDbl(txtPricePerBhvr.Text), 2).ToString
        txtPricePerA.Text = FormatNumber(CDbl(txtPricePerA.Text), 2).ToString
        txtPricePerB.Text = FormatNumber(CDbl(txtPricePerB.Text), 2).ToString
        txtPricePerC.Text = FormatNumber(CDbl(txtPricePerC.Text), 2).ToString
        txtPricePerD.Text = FormatNumber(CDbl(txtPricePerD.Text), 2).ToString
        txtPricePerF.Text = FormatNumber(CDbl(txtPricePerF.Text), 2).ToString
        txtBaselinePrice.Text = FormatNumber(CDbl(txtBaselinePrice.Text), 2).ToString

        GetDaysOfWeek()

        txt_SaveFilePath.Text = My.Settings.SaveFile
        Me.Icon = My.Resources.Settings
    End Sub


    Private Sub GetDaysOfWeek()

        cmb_Weekdays.Items.Clear()
        For Each day As DayOfWeek In System.Enum.GetValues(GetType(DayOfWeek))
            cmb_Weekdays.Items.Add(day)
        Next

        cmb_Weekdays.SelectedIndex = AllowanceTracker.Stats.ResetDay

        lblLastResetDay.Text = "Last " + AllowanceTracker.Stats.ResetDay.ToString
        lblNextResetDay.Text = "Next " + AllowanceTracker.Stats.ResetDay.ToString
        lblLastResetRead.Text = AllowanceTracker.Stats.LastResetDay.ToShortDateString
        lblNextResetRead.Text = AllowanceTracker.Stats.NextResetDay.ToShortDateString

        'writing the dayofweek.day writes the NUMBER which will correspond with the index of the cmb


    End Sub

    Private Function UpdatePrices(txt As TextBox) As Double
        If Not IsNumeric(txt.Text) Then
            MessageBox.Show("You must enter a number here!", "Error!")
            txt.Text = "1"
            Return 1
        End If

        txt.Text = FormatNumber(CDbl(txt.Text), 2).ToString
        Return CDbl(txt.Text.ToString)

    End Function


    Private Sub UpdatePricePerWorksheet() Handles txtPricePerWkst.Leave
        AllowanceTracker.Stats.PricePer.Worksheet = UpdatePrices(txtPricePerWkst)
    End Sub


    Private Sub UpdatePricePerBehavior() Handles txtPricePerBhvr.Leave
        AllowanceTracker.Stats.PricePer.Behavior = UpdatePrices(txtPricePerBhvr)
    End Sub


    Private Sub UpdateAGradePrice() Handles txtPricePerA.TextChanged
        AllowanceTracker.Stats.PricePer.AGrades = UpdatePrices(txtPricePerA)
    End Sub


    Private Sub UpdateBGradePrice() Handles txtPricePerB.TextChanged
        AllowanceTracker.Stats.PricePer.BGrades = UpdatePrices(txtPricePerB)
    End Sub


    Private Sub UpdateCGradePrice() Handles txtPricePerC.TextChanged
        AllowanceTracker.Stats.PricePer.CGrades = UpdatePrices(txtPricePerC)
    End Sub


    Private Sub UpdateDGradePrice() Handles txtPricePerD.TextChanged
        AllowanceTracker.Stats.PricePer.DGrades = UpdatePrices(txtPricePerD)
    End Sub


    Private Sub UpdatefGradePrice() Handles txtPricePerF.TextChanged
        AllowanceTracker.Stats.PricePer.FGrades = UpdatePrices(txtPricePerF)
    End Sub


    Private Sub UpdateBaselinePrice() Handles txtBaselinePrice.TextChanged
        AllowanceTracker.Stats.BaselinePay = UpdatePrices(txtBaselinePrice)
    End Sub

    Private Sub UpdateResetDay() Handles cmb_Weekdays.SelectedIndexChanged
        AllowanceTracker.Stats.ResetDay = cmb_Weekdays.SelectedIndex
        AllowanceTracker.GetTheResetDays()
        lblLastResetDay.Text = "Last " + AllowanceTracker.Stats.ResetDay.ToString
        lblNextResetDay.Text = "Next " + AllowanceTracker.Stats.ResetDay.ToString
        lblLastResetRead.Text = AllowanceTracker.Stats.LastResetDay.ToShortDateString
        lblNextResetRead.Text = AllowanceTracker.Stats.NextResetDay.ToShortDateString
    End Sub


    Private Sub ChangePassword(sender As Object, e As KeyPressEventArgs) Handles txt_NewPassword.KeyPress
        If e.KeyChar <> Chr(13) Then Exit Sub
        Dim answer As DialogResult = MessageBox.Show("Are you sure you want to change your password?", "Password Change?", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            My.Settings.Password = txt_NewPassword.Text
            AllowanceTracker.stats.Password = My.Settings.Password
            txt_NewPassword.Text = ""
            lbl_PasswordSet.Visible = True
        End If
    End Sub

    Private Sub TypingPassword(sender As Object, e As EventArgs) Handles txt_NewPassword.TextChanged
        lbl_PasswordSet.Visible = False
    End Sub


    Private Sub ClosingTheForm() Handles MyBase.Closed
        UpdatePricePerWorksheet()
        UpdatePricePerBehavior()
        UpdateBaselinePrice()
        UpdateAGradePrice()
        UpdateBGradePrice()
        UpdateCGradePrice()
        UpdateDGradePrice()
        UpdatefGradePrice()
        WriteToCSVFile(AllowanceTracker.stats.SaveFile)
        AllowanceTracker.UpdateLabels()
    End Sub


    Private Sub btn_SelectSaveDirectory_Click(sender As Object, e As EventArgs) Handles btn_SelectSaveDirectory.Click
        Dim dirselect As New FolderBrowserDialog

        If dirselect.ShowDialog() = DialogResult.OK Then
            My.Settings.SaveFile = dirselect.SelectedPath + "\KidBehaviorLog.csv"

            If MessageBox.Show("Would you like to move the existing file to the new location?", "Move existing file?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If My.Computer.FileSystem.FileExists(AllowanceTracker.stats.SaveFile) Then
                    My.Computer.FileSystem.MoveFile(AllowanceTracker.stats.SaveFile, My.Settings.SaveFile)
                Else
                    MessageBox.Show("There's no existing file to move! A new one will be generated in the new location.", "File does not exist!")
                    CreateNewCSVFile(My.Settings.SaveFile)
                End If

                AllowanceTracker.stats.SaveFile = My.Settings.SaveFile
                txt_SaveFilePath.Text = My.Settings.SaveFile

            End If
        End If
    End Sub

End Class