Imports System.Media
Imports Microsoft.VisualBasic.Devices

Public Class AllowanceTracker


#Region "Variables"

    Public Structure DataStructure

        Dim PepperWorksheets As Integer
        Dim RubyWorksheets As Integer
        Dim PepperBehavior As Integer
        Dim RubyBehavior As Integer

        Dim PepperAllowance As Double
        Dim RubyAllowance As Double

        Dim NextFriday As Date
        Dim LastFriday As Date

        Dim PricePerWorksheet As Double
        Dim PricePerBehavior As Double
        Dim PriceBaseline As Double

        Dim SaveFile As String
        Dim Password As String

        Dim NoExceptions As Boolean
        Dim PasswordLocked As Boolean

    End Structure

    Public Shared stats As DataStructure
    Dim Sound As New SoundPlayer

#End Region


#Region "Subroutines"

    Private Sub GetTheFridays()
        Dim DaysUntilNextFriday As Int32 = Math.Abs((DayOfWeek.Friday - Today.DayOfWeek + 7) Mod 7)
        Dim DaysFromLastFriday As Int32 = Math.Abs(Today.DayOfWeek - DayOfWeek.Friday + 7)
        stats.NextFriday = Date.Today.AddDays(DaysUntilNextFriday)
        stats.LastFriday = Date.Today.AddDays(-DaysFromLastFriday)
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


    Private Sub ReportTheCSVData(Optional lastFriday As Boolean = True)
        If lastFriday = True Then
            Dim Friday As Date = AllowanceTracker.stats.LastFriday
        Else
            Dim Friday As Date = AllowanceTracker.stats.NextFriday
        End If

        Dim AllData As List(Of String) = ReadCSVFile(stats.SaveFile)
        If stats.NoExceptions = False Then Me.Close()
        Dim FoundData As Boolean = False
        Dim str() As String

        For i = 0 To AllData.Count - 1
            str = AllData(i).Split(","c)
            If str(0).Contains(AllowanceTracker.stats.LastFriday.ToShortDateString) Or str(0).Contains(Date.Today.ToShortDateString) Then
                FoundData = True
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

        If FoundData = True Then Exit Sub
        WriteToCSVFile(stats.SaveFile, True)
        MessageBox.Show("A new week has been generated.", "New Week")
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

#End Region


#Region "Functions"
    Public Function PasswordIsCorrect() As Boolean
        Dim PasswordCheck As New PasswordForm
        PasswordCheck.ShowDialog()
        If PasswordCheck.AccessGranted = False Then Return False
        Return True
    End Function

#End Region


#Region "Event Handlers"

    Private Sub FormLoad() Handles Me.Load
        With stats
            .PepperAllowance = 1
            .RubyAllowance = 1
            .Password = My.Settings.Password
            .NoExceptions = True
            .PasswordLocked = True

            If My.Settings.SaveFile = "nothing" Then
                .SaveFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\KidBehaviorLog.csv"
                My.Settings.SaveFile = .SaveFile
            Else
                .SaveFile = My.Settings.SaveFile
            End If
        End With

        GetTheFridays()
        ReportTheCSVData()
        UpdateLabels()

        Me.Icon = My.Resources.Balloon_Heart

        SaveButton.Enabled = False
        LoadButton.Enabled = False

        ToolTipThingy.SetToolTip(SaveButton, "Save")
        ToolTipThingy.SetToolTip(LoadButton, "Load")
        ToolTipThingy.SetToolTip(SettingsButton, "Settings")
        ToolTipThingy.SetToolTip(CloseButton, "Close")
        ToolTipThingy.SetToolTip(ckbtn_PasswordLock, "Unlock Password Protection")
        ToolTipThingy.SetToolTip(Ruby_AddBehavior, "Add a Behavior Point for Ruby")
        ToolTipThingy.SetToolTip(Ruby_AddWorksheet, "Add a Worksheet Point for Ruby")
        ToolTipThingy.SetToolTip(Pepper_AddBehavior, "Add a Behavior Point for Pepper")
        ToolTipThingy.SetToolTip(Pepper_AddWorksheet, "Add a Worksheet Point for Pepper")
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


    Private Sub AddPepperWkstCount() Handles Pepper_AddWorksheet.Click
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


    Private Sub SaveData() Handles SaveButton.Click
        If stats.PasswordLocked = True Then
            If Not PasswordIsCorrect() Then Exit Sub
        End If
        WriteToCSVFile(stats.SaveFile)
        If stats.NoExceptions = False Then Me.Close()
        SaveButton.Enabled = False
        LoadButton.Enabled = False
    End Sub


    Private Sub LoadData(sender As Object, e As EventArgs) Handles LoadButton.Click
        If stats.PasswordLocked = True Then
            If Not PasswordIsCorrect() Then Exit Sub
        End If
        GetTheFridays()
        ReportTheCSVData()
        UpdateLabels()
        SaveButton.Enabled = False
        LoadButton.Enabled = False
    End Sub


    Private Sub OpenSettingsWindow(sender As Object, e As EventArgs) Handles SettingsButton.Click
        If stats.PasswordLocked = True Then
            If Not PasswordIsCorrect() Then Exit Sub
        End If
        Dim Settingswindow As New Settings
        Settingswindow.ShowDialog()
        UpdateLabels()
    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim answer As DialogResult
        If SaveButton.Enabled = False Then
            answer = MessageBox.Show("Are you sure you want to close?", "Close Me?", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then Me.Close()
        Else
            answer = MessageBox.Show("Would you like to save first?", "Close Me?", MessageBoxButtons.YesNoCancel)
            If answer = DialogResult.Yes Then SaveData()
            If answer = DialogResult.No Then Me.Close()
        End If
    End Sub


    Private Sub PepperRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PepperRainbowWorker.DoWork
        FlashRainbowText(Pepper_NameLabel)
    End Sub


    Private Sub RubyRainbowWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RubyRainbowWorker.DoWork
        FlashRainbowText(Ruby_NameLabel)
    End Sub


    Private Sub ckbtn_PasswordLock_CheckedChanged(sender As Object, e As EventArgs) Handles ckbtn_PasswordLock.CheckedChanged
        If ckbtn_PasswordLock.Checked = False Then
            If Not PasswordIsCorrect() Then
                ckbtn_PasswordLock.Checked = True
                Exit Sub
            End If
            ckbtn_PasswordLock.Image = My.Resources.UnlockButton
            ToolTipThingy.SetToolTip(ckbtn_PasswordLock, "Lock Password Protection")
        End If
        If ckbtn_PasswordLock.Checked = True Then
            ckbtn_PasswordLock.Image = My.Resources.LockButton
            ToolTipThingy.SetToolTip(ckbtn_PasswordLock, "Unlock Password Protection")
        End If
        stats.PasswordLocked = ckbtn_PasswordLock.Checked
    End Sub

#End Region


End Class
