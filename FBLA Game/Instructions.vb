''' <summary>
''' This is the instructions page and it displays the user interface controls
''' </summary>

Public Class instructions
    Private Sub mainMenu_Click(sender As Object, e As EventArgs) Handles mainMenu.Click
        Main_form.Panel1.Controls.Remove(Me)
        Main_form.Panel1.Controls.Add(Main_form.start)
        Main_form.Panel1.Controls.Add(Main_form.instructButton)
        Main_form.Panel1.Controls.Add(Main_form.Label1)
        Main_form.Panel1.Controls.Add(Main_form.Label2)

    End Sub

    Private Sub instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class