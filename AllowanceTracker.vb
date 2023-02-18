Imports System.Media
Imports Microsoft.VisualBasic.Devices

Public Class AllowanceTracker


#Region "Variables"

    Structure PricesStructure
        Dim Worksheet As Double
        Dim Behavior As Double
        Dim AGrades As Double
        Dim BGrades As Double
        Dim CGrades As Double
        Dim DGrades As Double
        Dim FGrades As Double
    End Structure


    Public Structure DataFileStructure
        Dim PricePer As PricesStructure
        Dim Ruby As PricesStructure
        Dim Pepper As PricesStructure

        Dim BaselinePay As Double

        Dim RubyBehavNote As String
        Dim PepperBehavNote As String

        Dim PepperAllowance As Double
        Dim RubyAllowance As Double

        Dim NextFriday As Date
        Dim LastFriday As Date

        Dim SaveFile As String
        Dim Password As String

        Dim NoExceptions As Boolean
        Dim PasswordLocked As Boolean

        Sub New(BlankString As String)
            BlankString = ""
            RubyBehavNote = BlankString
            PepperBehavNote = BlankString
        End Sub
    End Structure

    Public Shared Stats As DataFileStructure
    Dim Sound As New SoundPlayer

#End Region


#Region "Subroutines"

    Private Sub GetTheFridays()
        Dim DaysUntilNextFriday As Int32 = Math.Abs((DayOfWeek.Friday - Today.DayOfWeek + 7) Mod 7)
        Dim DaysFromLastFriday As Int32 = DaysUntilNextFriday - 7
        stats.NextFriday = Date.Today.AddDays(DaysUntilNextFriday)
        stats.LastFriday = Date.Today.AddDays(DaysFromLastFriday)
    End Sub


    Public Sub UpdateLabels()
        With Stats

            Ruby_WorksheetCount.Text = "Worksheets: " + .Ruby.Worksheet.ToString
            Ruby_BehaviorCount.Text = "Behavior: " + .Ruby.Behavior.ToString
            Pepper_WorksheetCount.Text = "Worksheets: " + .Pepper.Worksheet.ToString
            Pepper_BehaviorCount.Text = "Behavior: " + .Pepper.Behavior.ToString

            .RubyAllowance = CalculateAllowance(.Ruby, .PricePer, .BaselinePay)
            .PepperAllowance = CalculateAllowance(.Pepper, .PricePer, .BaselinePay)

            If .Ruby.AGrades + .Ruby.BGrades + .Ruby.CGrades + .Ruby.DGrades + .Ruby.FGrades > 0 Then
                RubyGradesCount.Text = UpdateGradesLabel(.Ruby)
                RubyGradesCount.ForeColor = Color.Black
                RubyGradesCount.Font = New Font("Segoe UI", 9)
                RubyGradesCount.Size = New Size(135, 32)
            Else
                RubyGradesCount.Text = "No Report Card"
                RubyGradesCount.ForeColor = Color.Silver
                RubyGradesCount.Font = New Font("Segoe UI", 11)
                RubyGradesCount.Size = New Size(135, 32)
            End If

            If .Pepper.AGrades + .Pepper.BGrades + .Pepper.CGrades + .Pepper.DGrades + .Pepper.FGrades > 0 Then
                PepperGradesCount.Text = UpdateGradesLabel(.Pepper)
                PepperGradesCount.ForeColor = Color.Black
                PepperGradesCount.Font = New Font("Segoe UI", 9)
                PepperGradesCount.Size = New Size(135, 32)
            Else
                PepperGradesCount.Text = "No Report Card"
                PepperGradesCount.ForeColor = Color.Silver
                PepperGradesCount.Font = New Font("Segoe UI", 11)
                PepperGradesCount.Size = New Size(135, 32)
            End If

            Ruby_Allowance.Text = "$" + FormatNumber(.RubyAllowance, 2).ToString
            Pepper_Allowance.Text = "$" + FormatNumber(.PepperAllowance, 2).ToString

            If Stats.RubyBehavNote.Split(";").Count < Stats.Ruby.Behavior Then
                Ruby_AddBehaviorNote.Visible = True
                Ruby_AddBehaviorNote.Enabled = True
            Else
                Ruby_AddBehaviorNote.Visible = False
                Ruby_AddBehaviorNote.Enabled = False
            End If

            If Stats.PepperBehavNote.Split(";").Count < Stats.Pepper.Behavior Then
                Pepper_AddBehaviorNote.Visible = True
                Pepper_AddBehaviorNote.Enabled = True
            Else
                Pepper_AddBehaviorNote.Visible = False
                Pepper_AddBehaviorNote.Enabled = False
            End If

            ToolTipThingy.SetToolTip(Ruby_BehaviorCount, Replace(Stats.RubyBehavNote, ";", vbCrLf))
            ToolTipThingy.SetToolTip(Pepper_BehaviorCount, Replace(Stats.PepperBehavNote, ";", vbCrLf))

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
            If str(0).Contains(Stats.LastFriday.ToShortDateString) Or str(0).Contains(Date.Today.ToShortDateString) Then
                FoundData = True
                Stats.Ruby.Worksheet = CInt(str(1))
                Stats.Ruby.Behavior = CInt(str(2))
                Stats.Ruby.AGrades = CInt(str(3))
                Stats.Ruby.BGrades = CInt(str(4))
                Stats.Ruby.CGrades = CInt(str(5))
                Stats.Ruby.DGrades = CInt(str(6))
                Stats.Ruby.FGrades = CInt(str(7))
                Stats.RubyAllowance = CDbl(str(8))
                Stats.RubyBehavNote = str(9)

                Stats.Pepper.Worksheet = CInt(str(10))
                Stats.Pepper.Behavior = CInt(str(11))
                Stats.Pepper.AGrades = CInt(str(12))
                Stats.Pepper.BGrades = CInt(str(13))
                Stats.Pepper.CGrades = CInt(str(14))
                Stats.Pepper.DGrades = CInt(str(15))
                Stats.Pepper.FGrades = CInt(str(16))
                Stats.PepperAllowance = CDbl(str(17))
                Stats.PepperBehavNote = str(18)

            ElseIf str(0).Contains("Behavior") Then
                AllowanceTracker.Stats.PricePer.Behavior = str(1)

            ElseIf str(0).Contains("Worksheet") Then
                AllowanceTracker.Stats.PricePer.Worksheet = str(1)

            ElseIf str(0).Contains("A's") Then
                AllowanceTracker.Stats.PricePer.AGrades = str(1)

            ElseIf str(0).Contains("B's") Then
                AllowanceTracker.Stats.PricePer.BGrades = str(1)

            ElseIf str(0).Contains("C's") Then
                AllowanceTracker.Stats.PricePer.CGrades = str(1)

            ElseIf str(0).Contains("D's") Then
                AllowanceTracker.Stats.PricePer.DGrades = str(1)

            ElseIf str(0).Contains("F's") Then
                AllowanceTracker.Stats.PricePer.FGrades = str(1)

            ElseIf str(0).Contains("Baseline") Then
                AllowanceTracker.Stats.BaselinePay = str(1)

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


    Private Function CalculateAllowance(Child As PricesStructure, Prices As PricesStructure, Baseline As Integer) As Double
        Dim Response As Double = 0

        Response += Baseline
        Response += Child.Worksheet * Prices.Worksheet
        Response += Child.Behavior * Prices.Behavior
        Response += Child.AGrades * Prices.AGrades
        Response += Child.BGrades * Prices.BGrades
        Response += Child.CGrades * Prices.CGrades
        Response += Child.DGrades * Prices.DGrades
        Response += Child.FGrades * Prices.FGrades

        Return Response
    End Function


    Private Function UpdateGradesLabel(Child As PricesStructure) As String
        Dim Response As String = "Grades: "

        For a = 1 To Child.AGrades
            Response += "A,"
        Next

        For b = 1 To Child.BGrades
            Response += "B,"
        Next

        For c = 1 To Child.CGrades
            Response += "C,"
        Next

        For d = 1 To Child.DGrades
            Response += "D,"
        Next

        For f = 1 To Child.FGrades
            Response += "F,"
        Next

        Response = Response.TrimEnd(",")

        Return Response
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
        ToolTipThingy.SetToolTip(Ruby_AddGrades, "Add a report card for Ruby")
        ToolTipThingy.SetToolTip(Pepper_AddGrades, "Add a report card for Pepper")
        ToolTipThingy.SetToolTip(Ruby_AddBehaviorNote, "Add a behavior note for Ruby")
        ToolTipThingy.SetToolTip(Pepper_AddBehaviorNote, "Add a behavior note for Pepper")

    End Sub


    Private Sub AddRubyWkstCount() Handles Ruby_AddWorksheet.Click
        Stats.Ruby.Worksheet += 1
        UpdateLabels()
        PlayRandomSound()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Sub AddRubyBhvrCount() Handles Ruby_AddBehavior.Click
        Stats.Ruby.Behavior += 1
        UpdateLabels()
        PlayRandomSound()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_AddBehaviorNote.Enabled = True
        Ruby_AddBehaviorNote.Visible = True
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Sub AddPepperWkstCount() Handles Pepper_AddWorksheet.Click
        Stats.Pepper.Worksheet += 1
        UpdateLabels()
        PlayRandomSound()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Sub AddPepperBhvrCount() Handles Pepper_AddBehavior.Click
        Stats.Pepper.Behavior += 1
        UpdateLabels()
        PlayRandomSound()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Pepper_AddBehaviorNote.Enabled = True
        Pepper_AddBehaviorNote.Visible = True
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Sub SaveData() Handles SaveButton.Click
        If stats.PasswordLocked = True Then
            If Not PasswordIsCorrect() Then Exit Sub
        End If
        WriteToCSVFile(stats.SaveFile)
        If stats.NoExceptions = False Then Me.Close()
        SaveButton.Enabled = False
        LoadButton.Enabled = False
        Ruby_WorksheetCount.Focus()
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
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Sub OpenSettingsWindow(sender As Object, e As EventArgs) Handles SettingsButton.Click
        If stats.PasswordLocked = True Then
            If Not PasswordIsCorrect() Then Exit Sub
        End If
        Dim Settingswindow As New Settings
        Settingswindow.ShowDialog()
        UpdateLabels()
        Ruby_WorksheetCount.Focus()
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
        Ruby_WorksheetCount.Focus()
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
        Stats.PasswordLocked = ckbtn_PasswordLock.Checked
        Ruby_WorksheetCount.Focus()
    End Sub

    Private Sub Ruby_AddGrades_Click(sender As Object, e As EventArgs) Handles Ruby_AddGrades.Click
        Dim RubyGradesForm As New GradesForm("Ruby")
        RubyGradesForm.ShowDialog()
        RubyGradesForm.Dispose()

        UpdateLabels()
        PlayRandomSound()
        If Not RubyRainbowWorker.IsBusy Then RubyRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub

    Private Sub Pepper_AddGrades_Click(sender As Object, e As EventArgs) Handles Pepper_AddGrades.Click
        Dim PepperGradesForm As New GradesForm("Pepper")
        PepperGradesForm.ShowDialog()
        PepperGradesForm.Dispose()

        UpdateLabels()
        PlayRandomSound()
        If Not PepperRainbowWorker.IsBusy Then PepperRainbowWorker.RunWorkerAsync()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub

    Private Sub Ruby_AddBehaviorNote_Click(sender As Object, e As EventArgs) Handles Ruby_AddBehaviorNote.Click
        Stats.RubyBehavNote = AddBehaviorNote(sender, Stats.RubyBehavNote, Stats.Ruby.Behavior, "Ruby")
        UpdateLabels()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub

    Private Sub Pepper_AddBehaviorNote_Click(sender As Object, e As EventArgs) Handles Pepper_AddBehaviorNote.Click
        Stats.PepperBehavNote = AddBehaviorNote(sender, Stats.PepperBehavNote, Stats.Pepper.Behavior, "Pepper")
        UpdateLabels()
        SaveButton.Enabled = True
        LoadButton.Enabled = True
        Ruby_WorksheetCount.Focus()
    End Sub


    Private Function AddBehaviorNote(sender As Object, notestring As String, behaviorcount As Integer, childname As String) As String
        notestring += ";"
        Dim tempstring() As String = notestring.Split(";")
        ReDim Preserve tempstring(behaviorcount - 1)

        For i = 1 To behaviorcount
            If Not tempstring(i - 1) = "" Then Continue For
            Dim newnote As String = InputBox("Please add a note about what " + childname + "'s good behavior was for point number " + i.ToString + ".", "Add Behavior Notes")
            If newnote = "" Then
                notestring += ";"
                Continue For
            End If
            notestring += Date.Today.ToShortDateString + ": "
            notestring += newnote
            notestring += ";"
        Next
        notestring = notestring.TrimEnd(";")

        tempstring = notestring.Split(";")
        Dim commentcount As Integer = 0
        For i = 0 To tempstring.Count - 1
            If Not tempstring(i) = "" Then commentcount += 1
        Next
        If commentcount = behaviorcount Then
            sender.Enabled = False
            sender.Visible = False
        End If
        Return notestring
    End Function

#End Region

End Class
