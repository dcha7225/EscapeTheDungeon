''' <summary>
''' This is main menu form it contains shortcuts to Level1 and the Instructions page and establishes public variables. 
''' </summary>>
Public Class Main_form
    Public lives As Integer
    Public elapsTime As TimeSpan
    Public startTime As Date
    Public pastTimes As New List(Of String)
    Public fileName As String
    Dim line As String

    ''' <summuary>
    ''' On load, read the score.txt file and assign the initial lives and setup timer.
    ''' </summuary>
    Private Sub Main_form_Load() Handles MyBase.Load
        Dim fileNum As Integer
        lives = 5
        mainTimer.Enabled = True
        fileName = "score.txt"

        fileNum = FreeFile()
        FileOpen(fileNum, fileName, OpenMode.Input)

        'EOF = end of file
        'read lines of score.txt and store in pastTimes(list of strings)
        Do While Not EOF(fileNum)
            line = LineInput(fileNum)
            If line.Length > 0 And line.CompareTo("00:00:00") > 0 Then
                pastTimes.Add(line)
            End If
        Loop


        FileClose(fileNum)


    End Sub

    ''' <summary>
    ''' This switches the panel to display the specified form
    ''' </summary>
    ''' <param name="panel"> is the form which will be displayed on panel1 </param>
    Sub Switchpanel(panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
        panel.Focus()
    End Sub

    ''' <summary>
    ''' When start button is clicked, switch the panel to display level1, which is the start of the game.
    ''' </summary>
    Private Sub Start_Click() Handles start.Click
        Switchpanel(level1)
        startTime = Now
        Panel1.BackgroundImage = Nothing
    End Sub

    ''' <summary>
    ''' keeps track of elapsed time as public variable
    ''' </summary>
    Private Sub MainTimer_Tick() Handles mainTimer.Tick
        elapsTime = Now - startTime
    End Sub

    ''' <summary>
    ''' When instructions button is clicked, switch the panel to display instructions.
    ''' </summary>
    Private Sub InstructButton_Click() Handles instructButton.Click
        Switchpanel(instructions)
    End Sub


End Class