''' <summary>
''' This is the second level of the dungeon, escaping from here leads to the 3rd level
''' </summary>
Public Class level2
    Dim dx, dy As Integer


    ''' <summary>
    ''' On level2 form load, enable timer.
    ''' </summary>
    Private Sub Level3_Load() Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    ''' <summary>
    ''' constantly update scoreboard, and check if player is intersecting with stairs.
    ''' </summary>
    Private Sub Timer1_Tick() Handles Timer1.Tick
        lifecount.Text = Main_form.lives
        timeElapsed.Text = Main_form.elapsTime.ToString("mm\:ss\:ff")

        If Player.Bounds.IntersectsWith(stairs.Bounds) Then
            Main_form.Switchpanel(level3)
            Player.Left = Player.Left + 4
        End If

    End Sub

    ''' <summary>
    ''' On key press, checks if player is intersecting with any boundaries, if not, player is moved in a specified direction. If "o" key pressed 
    ''' and player is intersecting with boundaries of interactable objects, intersected object is "opened".
    ''' </summary>
    ''' <param name="e"> stores which key has been pressed </param>
    Private Sub Level3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        'player movement:
        If Not Player.Bounds.IntersectsWith(rwall1.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall2.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall3.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall4.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall5.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall6.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall7.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall8.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall9.Bounds) And
               Not Player.Bounds.IntersectsWith(rwall10.Bounds) And
               Not Player.Bounds.IntersectsWith(robstacle1.Bounds) And
               Not Player.Bounds.IntersectsWith(robstacle2.Bounds) And
               Not Player.Bounds.IntersectsWith(robstacle3.Bounds) And
               Not Player.Bounds.IntersectsWith(robstacle4.Bounds) And
               Not Player.Bounds.IntersectsWith(robstacle5.Bounds) And
               e.KeyChar = "d" Then

            dx = 5
            Player.Image = My.Resources.playerR
            Player.Left = Player.Left + dx

        End If

        If Not Player.Bounds.IntersectsWith(lwall1.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall2.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall3.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall4.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall5.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall6.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall7.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall8.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall9.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall10.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall11.Bounds) And
                Not Player.Bounds.IntersectsWith(lwall12.Bounds) And
                Not Player.Bounds.IntersectsWith(lobstacle1.Bounds) And
                Not Player.Bounds.IntersectsWith(lobstacle2.Bounds) And
                Not Player.Bounds.IntersectsWith(lobstacle3.Bounds) And
                e.KeyChar = "a" Then

            dx = -5
            Player.Image = My.Resources.playerL
            Player.Left = Player.Left + dx

        End If

        If Not Player.Bounds.IntersectsWith(dwall1.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall2.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall3.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall4.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall5.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall6.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall7.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall8.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall9.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall10.Bounds) And
                Not Player.Bounds.IntersectsWith(dwall11.Bounds) And
                Not Player.Bounds.IntersectsWith(dobstacle1.Bounds) And
                Not Player.Bounds.IntersectsWith(dobstacle2.Bounds) And
                Not Player.Bounds.IntersectsWith(dobstacle3.Bounds) And
                Not Player.Bounds.IntersectsWith(lockwall1.Bounds) And
                e.KeyChar = "s" Then

            dy = 5
            Player.Image = My.Resources.playerD
            Player.Top = Player.Top + dy

        End If

        If Not Player.Bounds.IntersectsWith(uwall1.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall2.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall3.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall4.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall5.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall6.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall7.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall8.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall9.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall10.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall11.Bounds) And
                Not Player.Bounds.IntersectsWith(uwall12.Bounds) And
                Not Player.Bounds.IntersectsWith(uobstacle1.Bounds) And
                Not Player.Bounds.IntersectsWith(uobstacle2.Bounds) And
                Not Player.Bounds.IntersectsWith(uobstacle3.Bounds) And
                Not Player.Bounds.IntersectsWith(uobstacle4.Bounds) And
                Not Player.Bounds.IntersectsWith(chest1.Bounds) And
                Not Player.Bounds.IntersectsWith(chest2.Bounds) And
                e.KeyChar = "w" Then

            dy = -5
            Player.Image = My.Resources.playerU
            Player.Top = Player.Top + dy

        End If


        'interactable items

        If e.KeyChar = "o" And Player.Bounds.IntersectsWith(lockwall1.Bounds) Then
            Dim answer = InputBox("Bridge 1" & vbCrLf & vbCrLf & "Enter numerical code:")
            Trim(answer)

            'check if submitted anwser is correct or not
            If answer = "5" Then
                lock1.Visible = False
                lockwall1.Left = lockwall1.Left + 100

            ElseIf Not answer = "" Then
                Main_form.lives = Main_form.lives - 1

                If Main_form.lives = 0 Then
                    'if out of lives, user has option to restart program or quit
                    Dim endgame = MsgBox("You lost all your lives :(" & vbCrLf & "do you wish to restart?", MsgBoxStyle.YesNo)
                    If endgame = MsgBoxResult.Yes Then
                        Application.Restart()
                    ElseIf endgame = MsgBoxResult.No Then
                        End
                    End If

                End If
            End If

        End If

        'the following are hints/problems given from interactable items found on map:

        If e.KeyChar = "o" And Player.Bounds.IntersectsWith(chest1.Bounds) Then
            MsgBox("I'm unusal, people tell me that I'm not the brightest, which I find rude:( Find me and I will lead you out!")

        End If

        If e.KeyChar = "o" And Player.Bounds.IntersectsWith(chest2.Bounds) Then
            MsgBox("things are not always what they seem")

        End If

        If e.KeyChar = "o" And Player.Bounds.IntersectsWith(torch1.Bounds) Then
            MsgBox("Nice, you actually found me! Here's your first question to unlock the first bridge:" & vbCrLf & vbCrLf &
                   "What is the range in this list of numbers? 1, 6, 3, 5, 6, 5, 6")

        End If

        If e.KeyChar = Chr(27) Then
            Dim anwser = MsgBox("do you wish to quit?", MsgBoxStyle.YesNo)
            If anwser = MsgBoxResult.Yes Then
                End

            End If
        End If
    End Sub


End Class
