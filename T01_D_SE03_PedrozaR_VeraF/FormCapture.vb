Imports System.IO

Public Class frmEntrada
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmMain()

        'Muestra el destino'
        destination.Show()

        'Esconde el Form actual'
        Me.Hide()

    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try

            If String.IsNullOrWhiteSpace(txtUserIn.Text) OrElse String.IsNullOrWhiteSpace(txtContrln.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Obtener el directorio del proyecto
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName

            ' Capturar la fecha y hora actual como una cadena
            Dim dateTime As String = Date.Now.ToString("yyyy/MM/dd HH:mm:ss")
            Dim filePath As String = Path.Combine(projectDirectory, "UserData.csv")

            Dim userName As String = txtUserIn.Text
            Dim password As String = txtContrln.Text

            ' Verificar si el archivo CSV ya existe
            Dim fileExists As Boolean = File.Exists(filePath)

            ' Preparar los datos para ser escritos
            Dim data As String = $"{userName},{password},{dateTime}"

            ' Escribir los datos en el archivo CSV
            Using writer As New StreamWriter(filePath, True)
                ' Escribir el encabezado si el archivo se está creando por primera vez
                If Not fileExists Then
                    writer.WriteLine("Usuario,Contraseña,Fecha")
                End If
                writer.WriteLine(data)
            End Using

            ' Limpiar los campos de entrada
            txtUserIn.Clear()
            txtContrln.Clear()

            ' Confirmar que los datos se han guardado
            MessageBox.Show("¡Datos guardados satisfactoriamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre una excepción
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub viewdata_btn_Click(sender As Object, e As EventArgs) Handles cmdVisual.Click
        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmInfo()

        'Muestra el destino'
        destination.Show()

        'Esconde el Form actual'
        Me.Hide()
    End Sub

    Private Sub erase_btn_Click(sender As Object, e As EventArgs) Handles erase_btn.Click

        ' Limpiar los campos de entrada
        txtUserIn.Clear()
        txtContrln.Clear()

    End Sub

    Private Sub FormCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrln.PasswordChar = "*"
    End Sub
End Class