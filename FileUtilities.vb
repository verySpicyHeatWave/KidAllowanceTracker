Imports System.IO
Imports System.Security.Principal

Module FileUtilities

    Public Function ReadCSVFile(savefile As String) As List(Of String)

        If Not System.IO.File.Exists(savefile) Then
            CreateNewCSVFile()
        End If

        Dim reader As New StreamReader(savefile)
        Dim resp As New List(Of String)

        Do While Not reader.EndOfStream
            resp.Add(reader.ReadLine())
        Loop

        reader.Close()

        Return resp

    End Function


    Public Sub WriteToCSVFile(file As String, Optional AddNewWeek As Boolean = False)

        Dim alldata As List(Of String) = ReadCSVFile(file)
        Dim csvdata As String = ""
        Dim str() As String
        Dim NewData As String = ""

        With AllowanceTracker.stats

            NewData += .LastMonday.ToShortDateString + ","
            NewData += .RubyWorksheets.ToString + ","
            NewData += .PepperWorksheets.ToString + ","
            NewData += .RubyBehavior.ToString + ","
            NewData += .PepperBehavior.ToString + ","
            NewData += .RubyAllowance.ToString + ","
            NewData += .PepperAllowance.ToString

        End With

        Dim writer As New StreamWriter(file, False)

        For i = 0 To alldata.Count - 1
            str = alldata(i).Split(","c)
            If str(0).Contains(AllowanceTracker.stats.LastMonday.ToShortDateString) Then
                writer.WriteLine(NewData)
            ElseIf str(0).Contains("Behavior") Then
                writer.WriteLine("Behavior," + AllowanceTracker.stats.PricePerBehavior.ToString)
            ElseIf str(0).Contains("Worksheet") Then
                writer.WriteLine("Worksheet," + AllowanceTracker.stats.PricePerWorksheet.ToString)
            Else
                writer.WriteLine(alldata(i))
            End If
        Next

        If AddNewWeek = True Then writer.WriteLine(AllowanceTracker.stats.NextMonday.ToShortDateString + ",0,0,0,0,1,1")

        writer.Close()

    End Sub

    Public Sub CreateNewCSVFile()

        Dim headerstring As String = "Date (Monday),RubyWorksheets,PepperWorksheets,RubyBehavior,PepperBehavior,RubyAllowance,PepperAllowance"
        Dim lastmon As String = AllowanceTracker.stats.LastMonday


        Dim filestream As FileStream = File.Create(AllowanceTracker.stats.SaveFile)
        filestream.Close()


        Dim writer As New StreamWriter(AllowanceTracker.stats.SaveFile)

        writer.WriteLine("Prices")
        writer.WriteLine("Worksheets,0.5")
        writer.WriteLine("Behavior,1")
        writer.WriteLine("Baseline,1")
        writer.WriteLine("")
        writer.WriteLine(headerstring)
        writer.WriteLine(lastmon + ",0,0,0,0,1,1")

        writer.Close()

    End Sub


    Public Function GetRandom(Min As Integer, Max As Integer) As Integer

        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)

    End Function

End Module
