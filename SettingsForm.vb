Imports System.IO
Imports System.IO.Packaging

Public Class Settings

    Private Sub SettingsLoad() Handles Me.Load

        lblLastMondayRead.Text = AllowanceTracker.stats.LastMonday.ToShortDateString
        lblNextMondayRead.Text = AllowanceTracker.stats.NextMonday.ToShortDateString
        txtPricePerWkst.Text = AllowanceTracker.stats.PricePerWorksheet.ToString
        txtPricePerBhvr.Text = AllowanceTracker.stats.PricePerBehavior.ToString
        txtBaselinePrice.Text = AllowanceTracker.stats.PriceBaseline.ToString
        txtPricePerWkst.Text = FormatNumber(CDbl(txtPricePerWkst.Text), 2).ToString
        txtPricePerBhvr.Text = FormatNumber(CDbl(txtPricePerBhvr.Text), 2).ToString
        txtBaselinePrice.Text = FormatNumber(CDbl(txtBaselinePrice.Text), 2).ToString

        txt_SaveFilePath.Text = My.Settings.SaveFile
        Me.Icon = My.Resources.Settings

    End Sub


    Private Sub UpdatePricePerWorksheet() Handles txtPricePerWkst.Leave

        If Not IsNumeric(txtPricePerWkst.Text) Then
            MessageBox.Show("You must enter a number here!", "Error!")
            txtPricePerWkst.Text = "0.50"
        ElseIf CDbl(txtPricePerWkst.Text) = 0 Then
            MessageBox.Show("You can't enter zero!", "Error!")
            txtPricePerWkst.Text = "0.50"
        Else
            txtPricePerWkst.Text = FormatNumber(CDbl(txtPricePerWkst.Text), 2).ToString
            AllowanceTracker.stats.PricePerWorksheet = txtPricePerWkst.Text.ToString
        End If

    End Sub


    Private Sub UpdatePricePerBehavior() Handles txtPricePerBhvr.Leave

        If Not IsNumeric(txtPricePerBhvr.Text) Then
            MessageBox.Show("You must enter a number here!", "Error!")
            txtPricePerBhvr.Text = "1.00"
        ElseIf CDbl(txtPricePerBhvr.Text) = 0 Then
            MessageBox.Show("You can't enter zero!", "Error!")
            txtPricePerBhvr.Text = "1.00"
        Else
            txtPricePerBhvr.Text = FormatNumber(CDbl(txtPricePerBhvr.Text), 2).ToString
            AllowanceTracker.stats.PricePerBehavior = txtPricePerBhvr.Text.ToString
        End If

    End Sub

    Private Sub UpdateBaselinePrice() Handles txtBaselinePrice.TextChanged

        If Not IsNumeric(txtBaselinePrice.Text) Then
            MessageBox.Show("You must enter a number here!", "Error!")
            txtBaselinePrice.Text = "1.00"
        ElseIf CDbl(txtBaselinePrice.Text) = 0 Then
            MessageBox.Show("You can't enter zero!", "Error!")
            txtBaselinePrice.Text = "1.00"
        Else
            txtBaselinePrice.Text = FormatNumber(CDbl(txtBaselinePrice.Text), 2).ToString
            AllowanceTracker.stats.PriceBaseline = txtBaselinePrice.Text.ToString
        End If

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


    Private Sub ClosingTheForm() Handles Me.Closed

        UpdatePricePerWorksheet()
        UpdatePricePerBehavior()
        UpdateBaselinePrice()
        WriteToCSVFile(AllowanceTracker.stats.SaveFile)
        AllowanceTracker.UpdateLabels()

    End Sub


    Private Sub btn_SelectSaveDirectory_Click(sender As Object, e As EventArgs) Handles btn_SelectSaveDirectory.Click

        Dim dirselect As New FolderBrowserDialog

        If dirselect.ShowDialog() = DialogResult.OK Then
            My.Settings.SaveFile = dirselect.SelectedPath + "\KidBehaviorLog.csv"

            If MessageBox.Show("Would you like to move the existing file to the new location?", "Move existing file?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                My.Computer.FileSystem.MoveFile(AllowanceTracker.stats.SaveFile, My.Settings.SaveFile)
            End If

            AllowanceTracker.stats.SaveFile = My.Settings.SaveFile
            txt_SaveFilePath.Text = My.Settings.SaveFile

        End If

    End Sub

End Class