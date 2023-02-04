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

        Me.Icon = My.Resources.Settings

    End Sub


    Private Sub UpdatePricePerWorksheet() Handles txtPricePerWkst.Leave

        If Not IsNumeric(txtPricePerWkst.Text) Then
            MessageBox.Show("You must enter a number here!", "Error!")
            txtPricePerWkst.Text = "0.50"
        ElseIf CDbl(txtPricePerWkst.text) = 0 Then
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
        ElseIf CDbl(txtPricePerbhvr.Text) = 0 Then
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


    Private Sub ClosingTheForm() Handles Me.Closed

        UpdatePricePerWorksheet()
        UpdatePricePerBehavior()
        UpdateBaselinePrice()
        WriteToCSVFile(AllowanceTracker.stats.SaveFile)
        AllowanceTracker.UpdateLabels()

    End Sub


End Class