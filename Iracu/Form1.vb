Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Language.SelectedItem = "ITALIA/Italian" Then
            Python.Show()
        ElseIf Language.SelectedItem = "ENGLISH" Then
            ENGpython.Show()
        Else MsgBox("ITALIAN: Non hai selezionato la lingua! ENGLISH: You don't have choosed the language!")
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Language.SelectedItem = "ITALIA/Italian" Then
            html.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Language.SelectedItem = "ITALIA/Italian" Then

        End If
        If Language.SelectedItem = "ENGLISH" Then
            Label2.Text = "Iracu, has been progetted for semplificating of all programs: In python, java and more!"
            Label4.Text = "Warning: The application isn't 100% completed, so if you found bugs, report to this link:"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
