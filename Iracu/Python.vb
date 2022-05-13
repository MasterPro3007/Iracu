Public Class Python
    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "print('Hello World!')"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CosaStampare = InputBox("Che cosa vuoi stampare in questa riga?")
        TextBox1.Text = "print('" + CosaStampare + "');"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CosaContenere = InputBox("Che cosa Vuoi contenere nella varibaile - Scelte disponibili: Riga | Numero | Bollean(true / false)")
        If CosaContenere = "Riga" Then
            Dim riga = InputBox("cosa vuoi contenere in questa riga?")
            TextBox1.Text = "String NomeVariabile = '" + riga + "';"
        ElseIf CosaContenere = "Numero" Then
            Dim numero As Integer = InputBox("Che numero vuoi contenere?")
            TextBox1.Text = "Int NomeVariabile = '" + numero + "';"
        ElseIf CosaContenere = "Boolean" Then
            Dim TrueOfalse As Boolean = InputBox("Inserire True (vero) o False (falso)?")
            TextBox1.Text = "Boolean NomeVariabile = " + TrueOfalse + ";"
        Else
            MsgBox("Valore Non Valido! Se hai digitato tutto MAIUSCOLO o minuscolo, ricordati che va sempre con la lettera primaria Maiuscola.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Tipo = InputBox("Che tipo di operazione fare - Addizione | Moltiplicazione | Sottrazione | Divisione")
        If Tipo = "Addizione" Then
            Dim a As Integer = InputBox("Numero da Addizionare")
            Dim b As Integer = InputBox("Numero per eseguire l'addizione")
            MsgBox("Shhh... Non dirlo a nessuno ma il risultato è " & a + b)
            TextBox1.Text = "print(" & a & "+" & b & ");"
        ElseIf Tipo = "Moltiplicazione" Then
            Dim a As Integer = InputBox("Numero da Moltiplicare")
            Dim b As Integer = InputBox("Numero per eseguire la moltiplicazione")
            MsgBox("Shhh... Non dirlo a nessuno ma il risultato è " & a * b)
            TextBox1.Text = "print(" & a & "x" & b & ");"
        ElseIf Tipo = "Sottrazione" Then
            Dim a As Integer = InputBox("Numero da Sottrarre")
            Dim b As Integer = InputBox("Numero per eseguire la sottrazione")
            MsgBox("Shhh... Non dirlo a nessuno ma il risultato è " & a - b)
            TextBox1.Text = "print(" & a & "-" & b & ");"
        ElseIf Tipo = "Divisione" Then
            Dim a As Integer = InputBox("Numero da Dividere")
            Dim b As Integer = InputBox("Numero per eseguire la divisione")
            MsgBox("Shhh... Non dirlo a nessuno ma il risultato è " & a / b)
            TextBox1.Text = "print(" & a & "/" & b & ");"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PythonTest.Show()
    End Sub
End Class