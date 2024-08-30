Imports System.Text.RegularExpressions

Public Class frmCalculadora

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmMain()

        'Muestra el destino'
        destination.Show()

        'Esconde el Form actual'
        Me.Hide()

    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        'Borra todos los datos que se encuentren en los controladores'
        txtResultado.Text = ""
        txtValor1.Text = ""
        txtValor2.Text = ""
        cboOperacion.Text = ""

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim operador As String
        Dim valor1 As Double, valor2 As Double, resultado As Double

        'Limpia los datos y los guarda en su respectiva variable'
        valor1 = Double.Parse(LimpiarDatos(txtValor1.Text))
        valor2 = Double.Parse(LimpiarDatos(txtValor2.Text))
        operador = cboOperacion.Text

        'Dependiendo del valor que se haya seleccionado en el comboBox se realizara...'
        Select Case operador
            Case "+"
                resultado = valor1 + valor2

            Case "-"
                resultado = valor1 - valor2

            Case "x"
                resultado = valor1 * valor2

            Case "/"
                If valor2 = 0 Then
                    resultado = 0
                Else
                    resultado = valor1 / valor2
                End If
            Case Else
                MessageBox.Show("Ha ocurrido un error")

        End Select

        'redondea el resultado obtenido y lo envia al TextBox que almacena el resultado'
        txtResultado.Text = Math.Round(resultado, 2).ToString()


    End Sub

    'Elimina todo que se haya ingresado que no sea un numero'
    Private Function LimpiarDatos(input As String) As String

        Return Regex.Replace(input, "[^\d.]", "")

    End Function
End Class