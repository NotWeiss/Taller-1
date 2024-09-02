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
        txtResultado.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
        cboOperacion.Text = ""

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try

            Dim operador As String
            Dim valor1 As Double, valor2 As Double, resultado As Double

            'Limpia los datos y los guarda en su respectiva variable'
            valor1 = Double.Parse(LimpiarDatos(txtValor1.Text))
            valor2 = Double.Parse(LimpiarDatos(txtValor2.Text))
            txtValor1.Text = valor1
            txtValor2.Text = valor2
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
                    MessageBox.Show("Recuerde seleccionar una operacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Select

            'redondea el resultado obtenido y lo envia al TextBox que almacena el resultado'
            txtResultado.Text = Math.Round(resultado, 2).ToString()

        Catch ex As Exception
            'Mostrar Mensaje de Error
            MessageBox.Show("Ha ocurrido un error. Asegurese de que los datos sean los correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtResultado.Text = ""
        End Try



    End Sub

    'Sanitiza la entrada de datos'
    Private Function LimpiarDatos(input As String) As String

        'Elimina todos los caracteres que no sean numeros (0-9) o puntos(".")'
        Dim result As String = Regex.Replace(input, "[^\d.]", "")

        'Elimina todos los puntos de mas que se encuentren en la cadena, solo conserva el primero'
        result = Regex.Replace(result, "(?<=\..*?)\.", "")

        Return result

    End Function

    Private Sub frmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class