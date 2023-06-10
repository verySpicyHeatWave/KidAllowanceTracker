Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Security.Principal

Module FileUtilities

    Public Function ReadCSVFile(savefile As String) As List(Of String)
        CheckIfFileExists(savefile)

        Dim resp As New List(Of String)
        Dim reader As New StreamReader(savefile)

        Try
            Do While Not Reader.EndOfStream
                resp.Add(Reader.ReadLine())
            Loop
            Reader.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.Stats.NoExceptions = False
            Reader.close()
        End Try

        Return resp
    End Function


    Public Sub CheckIfFileExists(savefile As String, Optional newweek As Boolean = True)
        If Not System.IO.File.Exists(savefile) Then
            Dim answer As DialogResult = MessageBox.Show("The save file was not found in the set location. Would you like to try and find it?", "Find the file?", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                Dim filesearch As New OpenFileDialog
                If filesearch.ShowDialog() = DialogResult.OK Then
                    My.Settings.SaveFile = filesearch.FileName
                    AllowanceTracker.Stats.SaveFile = My.Settings.SaveFile
                    savefile = My.Settings.SaveFile
                End If
            Else
                MessageBox.Show("A save file was not found. A new one will be generated.")
                CreateNewCSVFile(AllowanceTracker.Stats.SaveFile)
            End If
        End If
    End Sub


    Public Sub WriteToCSVFile(file As String, Optional AddNewWeek As Boolean = False)
        Dim alldata As List(Of String) = ReadCSVFile(file)
        If AllowanceTracker.stats.NoExceptions = False Then AllowanceTracker.Close()
        Dim csvdata As String = ""
        Dim str() As String
        Dim NewData As String = ""

        With AllowanceTracker.Stats
            NewData += .LastResetDay.ToShortDateString + ","
            NewData += .Ruby.Worksheet.ToString + ","
            NewData += .Ruby.Behavior.ToString + ","
            'ToAdd: NewData += .Ruby.Chores.ToString + ","
            NewData += .Ruby.AGrades.ToString + ","
            NewData += .Ruby.BGrades.ToString + ","
            NewData += .Ruby.CGrades.ToString + ","
            NewData += .Ruby.DGrades.ToString + ","
            NewData += .Ruby.FGrades.ToString + ","
            NewData += .RubyAllowance.ToString + ","
            NewData += .RubyBehavNote + ","
            NewData += .Pepper.Worksheet.ToString + ","
            NewData += .Pepper.Behavior.ToString + ","
            'ToAdd: NewData += .Pepper.Chores.ToString + ","
            NewData += .Pepper.AGrades.ToString + ","
            NewData += .Pepper.BGrades.ToString + ","
            NewData += .Pepper.CGrades.ToString + ","
            NewData += .Pepper.DGrades.ToString + ","
            NewData += .Pepper.FGrades.ToString + ","
            NewData += .PepperAllowance.ToString + ","
            NewData += .PepperBehavNote + ","
        End With

        Dim writer As New StreamWriter(file, False)

        Try
            For i = 0 To alldata.Count - 1
                str = alldata(i).Split(","c)
                If str(0).Contains(AllowanceTracker.Stats.LastResetDay.ToShortDateString) Then
                    writer.WriteLine(NewData)
                ElseIf str(0).Contains("Behavior") Then
                    writer.WriteLine("Behavior," + AllowanceTracker.Stats.PricePer.Behavior.ToString)
                ElseIf str(0).Contains("Worksheet") Then
                    writer.WriteLine("Worksheet," + AllowanceTracker.Stats.PricePer.Worksheet.ToString)
                ElseIf str(0).Contains("Chores") Then
                    writer.WriteLine("Chores," + AllowanceTracker.Stats.PricePer.Chores.ToString)
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
                ElseIf str(0).Contains("Reset") Then
                    writer.WriteLine("Reset Days," + CInt(AllowanceTracker.Stats.ResetDay).ToString)
                Else
                    writer.WriteLine(alldata(i))
                End If
            Next
            If AddNewWeek = True Then
                writer.Write(AllowanceTracker.Stats.LastResetDay.ToShortDateString + ",0,0,0,0,0,0,0,") 'Add a zero for chores
                writer.Write(AllowanceTracker.Stats.BaselinePay.ToString)
                writer.Write(",,0,0,0,0,0,0,0,") 'Add a zero for chores
                writer.Write(AllowanceTracker.Stats.BaselinePay.ToString + ",")
            End If
            writer.Close()
        Catch ex As Exception
            writer.Close()
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.stats.NoExceptions = False
        End Try
    End Sub


    Public Sub CreateNewCSVFile(savefile As String)
        Dim headerstring As String = GetHeaderString()
        Dim LastResetDay As String = AllowanceTracker.Stats.LastResetDay.ToShortDateString

        Dim filestream As FileStream = File.Create(savefile)
        filestream.Close()
        Dim writer As New StreamWriter(savefile)

        Try
            'Write the config settings
            writer.WriteLine("Prices")
            writer.WriteLine("Worksheets,0.5")
            writer.WriteLine("Behavior,1")
            writer.WriteLine("Chores,1")
            writer.WriteLine("Baseline,1")
            writer.WriteLine("A's,4")
            writer.WriteLine("B's,2")
            writer.WriteLine("C's,1")
            writer.WriteLine("D's,0")
            writer.WriteLine("F's,0")
            writer.WriteLine("Reset Day, 6")
            writer.WriteLine("")

            'Write the header string and first line of data
            writer.WriteLine(headerstring)
            'writer.WriteLine(LastResetDay + ",0,0,0,0,0,0,0,1,,0,0,0,0,0,0,0,1,") 'Add a zero before each "1" for chores
            writer.Close()
        Catch ex As Exception
            writer.Close()
            MessageBox.Show("There was a problem:" + vbCrLf + vbCrLf + ex.Message, "Error!")
            AllowanceTracker.Stats.NoExceptions = False
        End Try
    End Sub


    Public Function GetRandom(Min As Integer, Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Function GetHeaderString() As String
        Dim resp As String = ""
        resp += "Date,"
        resp += "Ruby Worksheets,"
        resp += "Ruby Behavior,"
        'Add resp += "Ruby Chores,
        resp += "Ruby A Grades,"
        resp += "Ruby B Grades,"
        resp += "Ruby C Grades,"
        resp += "Ruby D Grades,"
        resp += "Ruby F Grades,"
        resp += "Ruby Allowance,"
        resp += "Ruby Behavior Note,"
        resp += "Pepper Worksheets,"
        resp += "Pepper Behavior,"
        'Add resp += "Pepper Chores,
        resp += "Pepper A Grades,"
        resp += "Pepper B Grades,"
        resp += "Pepper C Grades,"
        resp += "Pepper D Grades,"
        resp += "Pepper F Grades,"
        resp += "Pepper Allowance,"
        resp += "Pepper Behavior Note"

        Return resp
    End Function

End Module
