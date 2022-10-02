<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tscore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lscore = New System.Windows.Forms.Label()
        Me.restartButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.leaderboard = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1007, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONGRATULATIONS YOU ESCAPED THE DUNGEON!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 526)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TIME ELAPSED:"
        '
        'Tscore
        '
        Me.Tscore.AutoSize = True
        Me.Tscore.BackColor = System.Drawing.Color.Transparent
        Me.Tscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tscore.Location = New System.Drawing.Point(370, 517)
        Me.Tscore.Name = "Tscore"
        Me.Tscore.Size = New System.Drawing.Size(40, 42)
        Me.Tscore.TabIndex = 2
        Me.Tscore.Text = "#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SCOREBOARD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "LIVES REMAINING:"
        '
        'Lscore
        '
        Me.Lscore.AutoSize = True
        Me.Lscore.BackColor = System.Drawing.Color.Transparent
        Me.Lscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lscore.Location = New System.Drawing.Point(370, 459)
        Me.Lscore.Name = "Lscore"
        Me.Lscore.Size = New System.Drawing.Size(40, 42)
        Me.Lscore.TabIndex = 5
        Me.Lscore.Text = "#"
        '
        'restartButton
        '
        Me.restartButton.BackColor = System.Drawing.Color.FloralWhite
        Me.restartButton.Font = New System.Drawing.Font("Modern No. 20", 11.25!)
        Me.restartButton.ForeColor = System.Drawing.Color.Black
        Me.restartButton.Location = New System.Drawing.Point(715, 596)
        Me.restartButton.Name = "restartButton"
        Me.restartButton.Size = New System.Drawing.Size(179, 32)
        Me.restartButton.TabIndex = 6
        Me.restartButton.Text = "Restart"
        Me.restartButton.UseVisualStyleBackColor = False
        '
        'quitButton
        '
        Me.quitButton.BackColor = System.Drawing.Color.FloralWhite
        Me.quitButton.Font = New System.Drawing.Font("Modern No. 20", 11.25!)
        Me.quitButton.ForeColor = System.Drawing.Color.Black
        Me.quitButton.Location = New System.Drawing.Point(933, 596)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(179, 32)
        Me.quitButton.TabIndex = 7
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(544, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "LEADERBOARD:"
        '
        'leaderboard
        '
        Me.leaderboard.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.leaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leaderboard.FormattingEnabled = True
        Me.leaderboard.ItemHeight = 24
        Me.leaderboard.Location = New System.Drawing.Point(873, 406)
        Me.leaderboard.Name = "leaderboard"
        Me.leaderboard.Size = New System.Drawing.Size(287, 124)
        Me.leaderboard.TabIndex = 15
        '
        'forest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FBLA_Game.My.Resources.Resources.forest
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1185, 662)
        Me.Controls.Add(Me.leaderboard)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.restartButton)
        Me.Controls.Add(Me.Lscore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tscore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tscore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lscore As Label
    Friend WithEvents restartButton As Button
    Friend WithEvents quitButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents leaderboard As ListBox
End Class
