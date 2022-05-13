Public Class HTMLtest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inzio = InputBox("SFIDA INIZIATA!!! Come si crea un header? ( <tag>Contenuto</tag> )")
        If inzio = "<h1>Contenuto</h1>" Then
            MsgBox("Prima sfida superata! Grandioso!")
        Else
            MsgBox("Hai fallito la prima sfida... NON HAI IMPARATO! - Voto: 0")
            MsgBox("La risposta era: <h1>Contenuto</h1>")
            Me.Close()
        End If
        Dim second = InputBox("Come si crea il titolo del sito? ( <tag>Titolo</tag> )")
        If second = "<title>Titolo</title>" Then
            MsgBox("Seconda sfida superata! Sei un mostro! - Test Finito! Voto: 10")
        Else
            MsgBox("Hai fallito la seconda sfida... NON HAI IMPARATO! - Voto: 2")
            MsgBox("La risposta era: <title>Titolo</title>")
            Me.Close()
        End If
    End Sub
End Class