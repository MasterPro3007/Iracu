Public Class html
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "<html>
<head>
<title>Titolo del sito</title>
</head>
<body>
<h1>Questo è un header!</h1>
<p>Questo è un paragraffo!</p>
</body>
</html>"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HTMLtest.Show()
    End Sub
End Class