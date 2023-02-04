﻿Public Class AllowanceTracker

    Public Structure DataStructure

        Dim PepperWorksheets As Integer
        Dim RubyWorksheets As Integer
        Dim PepperBehavior As Integer
        Dim RubyBehavior As Integer

        Dim PepperAllowance As Double
        Dim RubyAllowance As Double

        Dim Headers As String
        Dim SaveFile As String
        Dim ConfigFile As String

        Dim NextMonday As Date
        Dim LastMonday As Date

        Dim PricePerWorksheet As Double
        Dim PricePerBehavior As Double

    End Structure

    Public Shared stats As DataStructure

    Private Sub FormLoad() Handles Me.Load

        stats.PepperAllowance = 1
        stats.RubyAllowance = 1

        stats.SaveFile = "C:\Users\smash\Desktop\Dad's Stuff\Coding\KidBehaviorLog.csv"

        GetTheMondays()
        ReportTheCSVData()
        UpdateLabels()

        SaveButton.Enabled = False
        LoadButton.Enabled = False

        ToolTipThingy.SetToolTip(SaveButton, "Save")
        ToolTipThingy.SetToolTip(LoadButton, "Load")
        ToolTipThingy.SetToolTip(SettingsButton, "Settings")
        ToolTipThingy.SetToolTip(NewWeekButton, "Create a New Week")

        Dim rubyname() As String = {"R", "u", "b", "y", "!"}
        Dim peppername() As String = {"P", "e", "p", "p", "e", "r", "!"}
        Dim xval As Integer = 25


    End Sub



    Private Sub AddRubyWkstCount() Handles Ruby_AddWorksheet.Click

        stats.RubyWorksheets += 1
        UpdateLabels()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddRubyBhvrCount() Handles Ruby_AddBehavior.Click

        stats.RubyBehavior += 1
        UpdateLabels()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddPepperWkstCount() Handles Button2.Click

        stats.PepperWorksheets += 1
        UpdateLabels()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddPepperBhvrCount() Handles Pepper_AddBehavior.Click

        stats.PepperBehavior += 1
        UpdateLabels()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Public Sub UpdateLabels()

        With stats

            Ruby_WorksheetCount.Text = "Worksheets: " + .RubyWorksheets.ToString
            Ruby_BehaviorCount.Text = "Behavior: " + .RubyBehavior.ToString
            Pepper_WorksheetCount.Text = "Worksheets: " + .PepperWorksheets.ToString
            Pepper_BehaviorCount.Text = "Behavior: " + .PepperBehavior.ToString

            stats.RubyAllowance = 1 + (.PricePerBehavior * .RubyBehavior) + (.PricePerWorksheet * .RubyWorksheets)
            stats.PepperAllowance = 1 + (.PricePerBehavior * .PepperBehavior) + (.PricePerWorksheet * .PepperWorksheets)

            Ruby_Allowance.Text = "$" + FormatNumber(.RubyAllowance, 2).ToString
            Pepper_Allowance.Text = "$" + FormatNumber(.PepperAllowance, 2).ToString

        End With

    End Sub


    Private Sub GetTheMondays()

        Dim DaysUntilNextMonday As Int32 = Math.Abs((DayOfWeek.Monday - Today.DayOfWeek + 7) Mod 7)
        Dim DaysFromLastMonday As Int32 = Math.Abs(Today.DayOfWeek - DayOfWeek.Monday)
        stats.NextMonday = Date.Today.AddDays(DaysUntilNextMonday)
        stats.LastMonday = Date.Today.AddDays(-DaysFromLastMonday)

    End Sub


    Private Sub FlashRainbowText(label As Label)

        For i = 0 To 5
            label.ForeColor = Color.Red
            Threading.Thread.Sleep(75)
            label.ForeColor = Color.Orange
            Threading.Thread.Sleep(75)
            label.ForeColor = Color.Yellow
            Threading.Thread.Sleep(75)
            label.ForeColor = Color.Green
            Threading.Thread.Sleep(75)
            label.ForeColor = Color.Blue
            Threading.Thread.Sleep(75)
            label.ForeColor = Color.Violet
            Threading.Thread.Sleep(75)
        Next
        label.ForeColor = Color.Black

    End Sub


    Private Sub ReportTheCSVData(Optional lastmonday As Boolean = True)

        If lastmonday = True Then
            Dim monday As Date = AllowanceTracker.stats.LastMonday
        Else
            Dim monday As Date = AllowanceTracker.stats.NextMonday
        End If

        Dim AllData As List(Of String) = ReadCSVFile(stats.SaveFile)
        Dim ConfigData As New List(Of String)
        Dim str() As String

        For i = 0 To AllData.Count - 1
            str = AllData(i).Split(","c)
            If str(0).Contains(AllowanceTracker.stats.LastMonday.ToShortDateString) Then
                AllowanceTracker.stats.RubyWorksheets = CInt(str(1))
                AllowanceTracker.stats.PepperWorksheets = CInt(str(2))
                AllowanceTracker.stats.RubyBehavior = CInt(str(3))
                AllowanceTracker.stats.PepperBehavior = CInt(str(4))
                AllowanceTracker.stats.RubyAllowance = CDbl(str(5))
                AllowanceTracker.stats.PepperAllowance = CDbl(str(6))

            ElseIf str(0).Contains("Behavior") Then
                AllowanceTracker.stats.PricePerBehavior = str(1)

            ElseIf str(0).Contains("Worksheet") Then
                AllowanceTracker.stats.PricePerWorksheet = str(1)

            End If

        Next

    End Sub


    Private Sub SaveData(sender As Object, e As EventArgs) Handles SaveButton.Click

        WriteToCSVFile(stats.SaveFile)
        SaveButton.Enabled = False
        LoadButton.Enabled = False

    End Sub


    Private Sub LoadData(sender As Object, e As EventArgs) Handles LoadButton.Click

        GetTheMondays()
        ReportTheCSVData()
        UpdateLabels()
        SaveButton.Enabled = False
        LoadButton.Enabled = False

    End Sub


    Private Sub OpenSettingsWindow(sender As Object, e As EventArgs) Handles SettingsButton.Click

        Dim Settingswindow As New Settings
        Settingswindow.Show()

    End Sub

    Private Sub BeginANewWeek(sender As Object, e As EventArgs) Handles NewWeekButton.Click

        Dim AllData As List(Of String) = ReadCSVFile(stats.SaveFile)
        Dim str() As String
        Dim HasLastMonday As Boolean = False

        For i = 0 To AllData.Count - 1
            str = AllData(i).Split(","c)
            If str(0).Contains(stats.LastMonday.ToShortDateString) Then
                HasLastMonday = True
                Exit For
            End If
        Next

        If HasLastMonday = True Then
            MessageBox.Show("It's not time for a new week yet!", "Error!")
            Exit Sub
        End If

        WriteToCSVFile(stats.SaveFile, True)
        ReportTheCSVData()

    End Sub

    Private Sub PepperRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PepperRainbowWorker.DoWork
        FlashRainbowText(Pepper_NameLabel)
    End Sub

    Private Sub RubyRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RubyRainbowWorker.DoWork
        FlashRainbowText(Ruby_NameLabel)
    End Sub

End Class
