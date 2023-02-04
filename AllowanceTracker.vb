Imports System.Media
Imports Microsoft.VisualBasic.Devices

Public Class AllowanceTracker

    Public Structure DataStructure

        Dim PepperWorksheets As Integer
        Dim RubyWorksheets As Integer
        Dim PepperBehavior As Integer
        Dim RubyBehavior As Integer


        Dim PepperAllowance As Double
        Dim RubyAllowance As Double

        Dim SaveFile As String

        Dim NextMonday As Date
        Dim LastMonday As Date

        Dim PricePerWorksheet As Double
        Dim PricePerBehavior As Double
        Dim PriceBaseline As Double

        Dim Password As String

    End Structure

    Public Shared stats As DataStructure
    Dim Sound As New SoundPlayer

    Private Sub FormLoad() Handles Me.Load

        stats.PepperAllowance = 1
        stats.RubyAllowance = 1
        stats.Password = "coolcoolcool"

        stats.SaveFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\KidBehaviorLog.csv"

        GetTheMondays()
        ReportTheCSVData()
        UpdateLabels()

        SaveButton.Enabled = False
        LoadButton.Enabled = False

        ToolTipThingy.SetToolTip(SaveButton, "Save")
        ToolTipThingy.SetToolTip(LoadButton, "Load")
        ToolTipThingy.SetToolTip(SettingsButton, "Settings")
        ToolTipThingy.SetToolTip(NewWeekButton, "Create a New Week")

    End Sub



    Private Sub AddRubyWkstCount() Handles Ruby_AddWorksheet.Click

        stats.RubyWorksheets += 1
        UpdateLabels()
        PlayRandomSound()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddRubyBhvrCount() Handles Ruby_AddBehavior.Click

        stats.RubyBehavior += 1
        UpdateLabels()
        PlayRandomSound()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddPepperWkstCount() Handles Button2.Click

        stats.PepperWorksheets += 1
        UpdateLabels()
        PlayRandomSound()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True

    End Sub

    Private Sub AddPepperBhvrCount() Handles Pepper_AddBehavior.Click

        stats.PepperBehavior += 1
        UpdateLabels()
        PlayRandomSound()
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

            stats.RubyAllowance = .PriceBaseline + (.PricePerBehavior * .RubyBehavior) + (.PricePerWorksheet * .RubyWorksheets)
            stats.PepperAllowance = .PriceBaseline + (.PricePerBehavior * .PepperBehavior) + (.PricePerWorksheet * .PepperWorksheets)

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

            ElseIf str(0).Contains("Baseline") Then
                AllowanceTracker.stats.PriceBaseline = str(1)

            End If

        Next

    End Sub


    Private Sub SaveData(sender As Object, e As EventArgs) Handles SaveButton.Click

        If Not PasswordIsCorrect() Then Exit Sub
        WriteToCSVFile(stats.SaveFile)
        SaveButton.Enabled = False
        LoadButton.Enabled = False

    End Sub


    Private Sub LoadData(sender As Object, e As EventArgs) Handles LoadButton.Click

        If Not PasswordIsCorrect() Then Exit Sub
        GetTheMondays()
        ReportTheCSVData()
        UpdateLabels()
        SaveButton.Enabled = False
        LoadButton.Enabled = False

    End Sub


    Private Sub PlayRandomSound()

        Dim value As Integer = GetRandom(1, 26)

        If value < 5 Then
            My.Computer.Audio.Play(My.Resources.Applause1, AudioPlayMode.Background)
        ElseIf value < 9 Then
            My.Computer.Audio.Play(My.Resources.Fireworks, AudioPlayMode.Background)
        ElseIf value < 13 Then
            My.Computer.Audio.Play(My.Resources.GameSound, AudioPlayMode.Background)
        ElseIf value < 17 Then
            My.Computer.Audio.Play(My.Resources.LightSpell, AudioPlayMode.Background)
        ElseIf value < 21 Then
            My.Computer.Audio.Play(My.Resources.MonkeyApplause, AudioPlayMode.Background)
        ElseIf value < 25 Then
            My.Computer.Audio.Play(My.Resources.PartyTrumpet, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.Fart, AudioPlayMode.Background)
        End If

    End Sub


    Private Sub OpenSettingsWindow(sender As Object, e As EventArgs) Handles SettingsButton.Click

        If Not PasswordIsCorrect() Then Exit Sub
        Dim Settingswindow As New Settings
        Settingswindow.ShowDialog()
        UpdateLabels()

    End Sub

    Private Sub BeginANewWeek(sender As Object, e As EventArgs) Handles NewWeekButton.Click

        If Not PasswordIsCorrect() Then Exit Sub
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

    Public Function PasswordIsCorrect() As Boolean

        Dim PasswordCheck As New PasswordForm
        PasswordCheck.ShowDialog()
        If PasswordCheck.AccessGranted = False Then Return False
        Return True

    End Function

    Private Sub PepperRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PepperRainbowWorker.DoWork
        FlashRainbowText(Pepper_NameLabel)
    End Sub

    Private Sub RubyRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RubyRainbowWorker.DoWork
        FlashRainbowText(Ruby_NameLabel)
    End Sub

End Class
