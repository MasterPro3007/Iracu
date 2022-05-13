Public Class PythonTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inzio = InputBox("TEST INIZIATO!!! Come si stampa una riga nel python? ( commando('contenuto') )")
        If inzio = "print('contenuto');" Then
            MsgBox("Prima sfida superata! Grande! - Test finito, voto: 10")
        Else
            MsgBox("Hai fallito la prima sfida... NON HAI IMPARATO! - Voto: 0")
            MsgBox("La risposta era: print('contenuto');")
            Me.Close()
        End If
    End Sub
End Class