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

        With AllowanceTracker.stats
            NewData += .LastFriday.ToShortDateString + ","
            NewData += .RubyWorksheets.ToString + ","
            NewData += .PepperWorksheets.ToString + ","
            NewData += .RubyBehavior.ToString + ","
            NewData += .PepperBehavior.ToString + ","
            NewData += .RubyAllowance.ToString + ","
            NewData += .PepperAllowance.ToString
        End With

        Try
            Dim writer As New StreamWriter(file, False)
            For i = 0 To alldata.Count - 1
                str = alldata(i).Split(","c)
                If str(0).Contains(AllowanceTracker.stats.LastFriday.ToShortDateString) Then
                    writer.WriteLine(NewData)
                ElseIf str(0).Contains("Behavior") Then
                    writer.WriteLine("Behavior," + AllowanceTracker.stats.PricePerBehavior.ToString)
                ElseIf str(0).Contains("Worksheet") Then
                    writer.WriteLine("Worksheet," + AllowanceTracker.stats.PricePerWorksheet.ToString)
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
            writer.WriteLine("")
            writer.WriteLine(headerstring)
            writer.WriteLine(lastmon + ",0,0,0,0,1,1")
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
