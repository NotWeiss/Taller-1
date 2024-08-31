Imports System.IO

Public Class FormLeer
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Guarda como destino el form al que se quiere ir al hacer click'
        Dim destination As New frmMain()

        'Muestra el destino'
        destination.Show()

        'Esconde el Form actual'
        Me.Hide()

    End Sub

    Private Sub FormLeer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Obtener el directorio del proyecto
            Dim projectDirectory As String = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName

            ' Definir la ruta del archivo CSV
            Dim filePath As String = Path.Combine(projectDirectory, "UserData.csv")

            ' Verificar si el archivo CSV existe
            If File.Exists(filePath) Then
                ' Leer todas las líneas del archivo CSV
                Dim lines As String() = File.ReadAllLines(filePath)

                ' Crear una tabla simple en el TextBox de datos
                Dim tableText As New Text.StringBuilder()
                tableText.AppendLine("Usuario" & vbTab & "Contraseña") ' No incluir DateTime en el encabezado
                For Each line In lines.Skip(1) ' Omitir el encabezado
                    Dim columns As String() = line.Split(","c)
                    ' Solo incluir Username y Password en el TextBox
                    tableText.AppendLine(String.Join(vbTab, columns.Take(2)))
                Next

                ' Mostrar la tabla en el TextBox de datos
                data_txtbox.Text = tableText.ToString()

                ' Obtener la última línea y extraer la fecha
                Dim lastLine As String = lines.Last()
                Dim lastDate As String = lastLine

                ' Mostrar solo la fecha en el TextBox de fecha
                lastdata_txtbox.Text = lastDate
            Else
                ' Mostrar mensaje si el archivo no existe
                MessageBox.Show("El archivo CSV no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre una excepción
            MessageBox.Show("Error al mostrar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class