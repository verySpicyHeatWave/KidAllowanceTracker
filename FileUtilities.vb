Imports System.IO
Imports System.Security.Principal

Module FileUtilities

    Public Function ReadCSVFile(savefile As String) As List(Of String)
        If Not System.IO.File.Exists(savefile) Then
            Dim answer As DialogResult = MessageBox.Show("The save file was not found in the set location. Would you like to try and find it?", "Find the file?", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                Dim filesearch As New OpenFileDialog
                If filesearch.ShowDialog() = DialogResult.OK Then
                    My.Settings.SaveFile = filesearch.FileName
                    AllowanceTracker.stats.SaveFile = My.Settings.SaveFile
                End If
            Else
                MessageBox.Show("A save file was not found. A new one will be generated.")
                CreateNewCSVFile(AllowanceTracker.stats.SaveFile)
            End If
        End If

        Dim resp As New List(Of String)

        Try
            Dim reader As New StreamReader(savefile)
            Do While Not reader.EndOfStream
                resp.Add(reader.ReadLine())
            Loop
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.stats.NoExceptions = False
        End Try

        Return resp
    End Function


    Public Sub WriteToCSVFile(file As String, Optional AddNewWeek As Boolean = False)
        Dim alldata As List(Of String) = ReadCSVFile(file)
        If AllowanceTracker.stats.NoExceptions = False Then AllowanceTracker.Close()
        Dim csvdata As String = ""
        Dim str() As String
        Dim NewData As String = ""

        With AllowanceTracker.Stats
            NewData += .LastFriday.ToShortDateString + ","
            NewData += .Ruby.Worksheet.ToString + ","
            NewData += .Ruby.Behavior.ToString + ","
            NewData += .Ruby.AGrades.ToString + ","
            NewData += .Ruby.BGrades.ToString + ","
            NewData += .Ruby.CGrades.ToString + ","
            NewData += .Ruby.DGrades.ToString + ","
            NewData += .Ruby.FGrades.ToString + ","
            NewData += .RubyAllowance.ToString + ","
            NewData += .RubyBehavNote + ","
            NewData += .Pepper.Worksheet.ToString + ","
            NewData += .Pepper.Behavior.ToString + ","
            NewData += .Pepper.AGrades.ToString + ","
            NewData += .Pepper.BGrades.ToString + ","
            NewData += .Pepper.CGrades.ToString + ","
            NewData += .Pepper.DGrades.ToString + ","
            NewData += .Pepper.FGrades.ToString + ","
            NewData += .PepperAllowance.ToString + ","
            NewData += .PepperBehavNote + ","
        End With

        Try
            Dim writer As New StreamWriter(file, False)
            For i = 0 To alldata.Count - 1
                str = alldata(i).Split(","c)
                If str(0).Contains(AllowanceTracker.stats.LastFriday.ToShortDateString) Then
                    writer.WriteLine(NewData)
                ElseIf str(0).Contains("Behavior") Then
                    writer.WriteLine("Behavior," + AllowanceTracker.Stats.PricePer.Behavior.ToString)
                ElseIf str(0).Contains("Worksheet") Then
                    writer.WriteLine("Worksheet," + AllowanceTracker.Stats.PricePer.Worksheet.ToString)
                ElseIf str(0).Contains("A's") Then
                    writer.WriteLine("A's," + AllowanceTracker.Stats.PricePer.AGrades.ToString)
                ElseIf str(0).Contains("B's") Then
                    writer.WriteLine("B's," + AllowanceTracker.Stats.PricePer.BGrades.ToString)
                ElseIf str(0).Contains("C's") Then
                    writer.WriteLine("C's," + AllowanceTracker.Stats.PricePer.CGrades.ToString)
                ElseIf str(0).Contains("D's") Then
                    writer.WriteLine("D's," + AllowanceTracker.Stats.PricePer.DGrades.ToString)
                ElseIf str(0).Contains("F's") Then
                    writer.WriteLine("F's," + AllowanceTracker.Stats.PricePer.FGrades.ToString)
                Else
                    writer.WriteLine(alldata(i))
                End If
            Next
            If AddNewWeek = True Then writer.WriteLine(AllowanceTracker.stats.LastFriday.ToShortDateString + ",0,0,0,0,1,1")
            writer.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.stats.NoExceptions = False
        End Try
    End Sub


    Public Sub CreateNewCSVFile(savefile As String)
        Dim headerstring As String = "Date (Friday),RubyWorksheets,PepperWorksheets,RubyBehavior,PepperBehavior,RubyAllowance,PepperAllowance"
        Dim lastmon As String = AllowanceTracker.stats.LastFriday

        Dim filestream As FileStream = File.Create(savefile)
        filestream.Close()

        Try
            Dim writer As New StreamWriter(savefile)
            writer.WriteLine("Prices")
            writer.WriteLine("Worksheets,0.5")
            writer.WriteLine("Behavior,1")
            writer.WriteLine("Baseline,1")
            writer.WriteLine("A's,4")
            writer.WriteLine("B's,2")
            writer.WriteLine("C's,1")
            writer.WriteLine("D's,0")
            writer.WriteLine("F's,0")
            writer.WriteLine("")
            writer.Write("Date (Friday),")
            writer.Write("Ruby Worksheets,")
            writer.Write("Ruby Behavior,")
            writer.Write("Ruby A Grades,")
            writer.Write("Ruby B Grades,")
            writer.Write("Ruby C Grades,")
            writer.Write("Ruby D Grades,")
            writer.Write("Ruby F Grades,")
            writer.Write("Ruby Allowance,")
            writer.Write("Ruby Behavior Notes,")
            writer.Write("Pepper Worksheets,")
            writer.Write("Pepper Behavior,")
            writer.Write("Pepper A Grades,")
            writer.Write("Pepper B Grades,")
            writer.Write("Pepper C Grades,")
            writer.Write("Pepper D Grades,")
            writer.Write("Pepper F Grades,")
            writer.Write("Pepper Allowance,")
            writer.Write("Pepper Behavior Notes,")
            writer.WriteLine(lastmon + ",0,0,0,0,0,0,0,1,,0,0,0,0,0,0,0,1,")
            writer.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.stats.NoExceptions = False
        End Try
    End Sub


    Public Function GetRandom(Min As Integer, Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

End Module
