Public Class frmCreditos
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmMain

        'Muestra el destino'
        destination.Show()
        'Esconde el Form actual'
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblVBversion.Click

    End Sub
End Class