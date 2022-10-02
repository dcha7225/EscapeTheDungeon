<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.instructButton = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTimer
        '
        Me.mainTimer.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.FBLA_Game.My.Resources.Resources.Main_page
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.instructButton)
        Me.Panel1.Controls.Add(Me.start)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 662)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = Global.FBLA_Game.My.Resources.Resources.flame
        Me.Label1.Location = New System.Drawing.Point(1114, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 62)
        Me.Label1.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Image = Global.FBLA_Game.My.Resources.Resources.flame
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 62)
        Me.Label2.TabIndex = 189
        '
        'instructButton
        '
        Me.instructButton.BackColor = System.Drawing.Color.AliceBlue
        Me.instructButton.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructButton.Location = New System.Drawing.Point(748, 251)
        Me.instructButton.Name = "instructButton"
        Me.instructButton.Size = New System.Drawing.Size(265, 56)
        Me.instructButton.TabIndex = 5
        Me.instructButton.Text = "Instructions"
        Me.instructButton.UseVisualStyleBackColor = False
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.AliceBlue
        Me.start.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.Location = New System.Drawing.Point(154, 251)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(265, 56)
        Me.start.TabIndex = 4
        Me.start.Text = "start"
        Me.start.UseVisualStyleBackColor = False
        '
        'Main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main_form"
        Me.Text = "Escape the Dungeon"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents mainTimer As Timer
    Friend WithEvents instructButton As Button
    Friend WithEvents start As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
