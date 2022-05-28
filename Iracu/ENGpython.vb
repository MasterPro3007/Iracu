Public Class ENGpython
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "print('Hello World!')"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stringprint As String = InputBox("What do you want to print it in the terminal?")
        TextBox1.Text = "print('" + stringprint + "');"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Work in progress...")
    End Sub
End Class