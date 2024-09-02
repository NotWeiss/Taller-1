Public Class frmCreditos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmMain

        'Muestra el destino'
        destination.Show()
        'Esconde el Form actual'
        Me.Hide()
    End Sub
End Class