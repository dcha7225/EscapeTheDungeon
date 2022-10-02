Imports System.Globalization 'import time/date

''' <summary>
''' This is the game end form, it displays the scoreboard and leaderboard, and contains options to restart or quit program
''' </summary>
Public Class Forest
    Dim fileNum As Integer
    Dim strElapsTime As String
    Dim arrPastTimes As List(Of String)
    Dim s As String
    Dim line As String



    ''' <summary>
    ''' On form load: update scoreboard(Lives remaining and time elapsed), 
    '''               store elapsTime(the Elapsed Time from current game) as string in strElapsTime variable,
    '''               add strElapsTime to arrPastTimes(list of past Elapsed Times),
    '''               convert objects in arrPastTimes from string to timespan and store in timeScores,
    '''               sort timeScores(list of timespans) in ascending order,
    '''               convert timeScores back to string and print in file(score.txt)
    '''               add converted timeScores to leaderboard(displayed listbox)               
    ''' </summary>
    Private Sub Forest_Load() Handles MyBase.Load
        strElapsTime = Main_form.elapsTime.ToString("mm\:ss\:ff")
        Lscore.Text = Main_form.lives
        Tscore.Text = strElapsTime
        arrPastTimes = Main_form.pastTimes
        arrPastTimes.Add(strElapsTime)
        Dim timeScores(0 To arrPastTimes.Count - 1) As TimeSpan

        'convert objects in arrPastTimes(list of strings) from string to timespan and store in timeScores(array of timeSpans)
        For x As Integer = 0 To arrPastTimes.Count - 1
            s = arrPastTimes(x)
            If Trim(s).CompareTo("00:00:00") > 0 Then
                timeScores(x) = TimeSpan.ParseExact(s, "mm\:ss\:ff", CultureInfo.InstalledUICulture)
            End If
        Next

        'sort timeScores(array of timespans) in ascending order
        Array.Sort(timeScores)

        fileNum = FreeFile()
        FileOpen(fileNum, Main_form.fileName, OpenMode.Output)

        'convert timeScores back to string and print in file(score.txt)
        'add converted timeScores to leaderboard(displayed listbox)    
        For x As Integer = 1 To timeScores.Length
            line = timeScores(x - 1).ToString("mm\:ss\:ff")
            If line <> Nothing Then
                PrintLine(fileNum, line)
                leaderboard.Items.Add(x.ToString + ": " + line)
            End If
        Next
        FileClose(fileNum)


    End Sub

    ''' <summary>
    ''' if restartButton clicked restart program
    ''' </summary>
    Private Sub RestartButton_Click() Handles restartButton.Click
        Application.Restart()
    End Sub

    ''' <summary>
    ''' if quitButton clicked end program
    ''' </summary>
    Private Sub QuitButton_Click() Handles quitButton.Click
        End
    End Sub


End Class