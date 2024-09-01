<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblCreditos = New Label()
        btnRegresar = New Button()
        lblCurso = New Label()
        lblGrupo = New Label()
        lblAsignacion = New Label()
        lblProfe = New Label()
        lblIntegrantes = New Label()
        lblIntegrante1 = New Label()
        lblIntegrante2 = New Label()
        txtDescripcion = New TextBox()
        lblVBversion = New Label()
        lblCopyright = New Label()
        SuspendLayout()
        ' 
        ' lblCreditos
        ' 
        lblCreditos.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblCreditos.Location = New Point(45, 38)
        lblCreditos.Name = "lblCreditos"
        lblCreditos.Size = New Size(384, 60)
        lblCreditos.TabIndex = 1
        lblCreditos.Text = "CREDITOS"
        lblCreditos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.AllowDrop = True
        btnRegresar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnRegresar.BackColor = Color.DarkSalmon
        btnRegresar.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegresar.Location = New Point(45, 490)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(384, 45)
        btnRegresar.TabIndex = 4
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' lblCurso
        ' 
        lblCurso.AutoSize = True
        lblCurso.Font = New Font("Segoe UI", 12F)
        lblCurso.Location = New Point(140, 119)
        lblCurso.Name = "lblCurso"
        lblCurso.Size = New Size(195, 21)
        lblCurso.TabIndex = 5
        lblCurso.Text = "Desarrollo de Software VIII"
        ' 
        ' lblGrupo
        ' 
        lblGrupo.AutoSize = True
        lblGrupo.Font = New Font("Segoe UI", 12F)
        lblGrupo.Location = New Point(177, 200)
        lblGrupo.Name = "lblGrupo"
        lblGrupo.Size = New Size(120, 21)
        lblGrupo.TabIndex = 6
        lblGrupo.Text = "Grupo: 1LS-132"
        ' 
        ' lblAsignacion
        ' 
        lblAsignacion.AutoSize = True
        lblAsignacion.Font = New Font("Segoe UI", 12F)
        lblAsignacion.Location = New Point(162, 173)
        lblAsignacion.Name = "lblAsignacion"
        lblAsignacion.Size = New Size(151, 21)
        lblAsignacion.TabIndex = 7
        lblAsignacion.Text = "Asignacion: Taller #1"
        ' 
        ' lblProfe
        ' 
        lblProfe.AutoSize = True
        lblProfe.Font = New Font("Segoe UI", 12F)
        lblProfe.Location = New Point(155, 146)
        lblProfe.Name = "lblProfe"
        lblProfe.Size = New Size(165, 21)
        lblProfe.TabIndex = 8
        lblProfe.Text = "Profesora: Anna Araba"
        ' 
        ' lblIntegrantes
        ' 
        lblIntegrantes.AutoSize = True
        lblIntegrantes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIntegrantes.Location = New Point(187, 266)
        lblIntegrantes.Name = "lblIntegrantes"
        lblIntegrantes.Size = New Size(101, 21)
        lblIntegrantes.TabIndex = 9
        lblIntegrantes.Text = "Integrantes:"
        ' 
        ' lblIntegrante1
        ' 
        lblIntegrante1.AutoSize = True
        lblIntegrante1.Font = New Font("Segoe UI", 12F)
        lblIntegrante1.Location = New Point(126, 293)
        lblIntegrante1.Name = "lblIntegrante1"
        lblIntegrante1.Size = New Size(223, 21)
        lblIntegrante1.TabIndex = 10
        lblIntegrante1.Text = "Reynaldo Pedroza (8-964-809)"
        ' 
        ' lblIntegrante2
        ' 
        lblIntegrante2.AutoSize = True
        lblIntegrante2.Font = New Font("Segoe UI", 12F)
        lblIntegrante2.Location = New Point(189, 320)
        lblIntegrante2.Name = "lblIntegrante2"
        lblIntegrante2.Size = New Size(97, 21)
        lblIntegrante2.TabIndex = 11
        lblIntegrante2.Text = "Franz Vera ()"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BackColor = SystemColors.Control
        txtDescripcion.BorderStyle = BorderStyle.None
        txtDescripcion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDescripcion.Location = New Point(45, 361)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(384, 87)
        txtDescripcion.TabIndex = 12
        txtDescripcion.Text = "Descripcion:" & vbCrLf & "Aplicacion con el objetivo de realizar calculos matematicos basicos; capturar y mostrar datos guardados."
        txtDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblVBversion
        ' 
        lblVBversion.AutoSize = True
        lblVBversion.Font = New Font("Segoe UI", 12F)
        lblVBversion.Location = New Point(172, 227)
        lblVBversion.Name = "lblVBversion"
        lblVBversion.Size = New Size(131, 21)
        lblVBversion.TabIndex = 13
        lblVBversion.Text = "Visual Basic 2022"
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.Font = New Font("Segoe UI", 12F)
        lblCopyright.Location = New Point(231, 570)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(237, 21)
        lblCopyright.TabIndex = 14
        lblCopyright.Text = "©Reynaldo Pedroza y Franz Vera"
        ' 
        ' frmCreditos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(lblCopyright)
        Controls.Add(lblVBversion)
        Controls.Add(txtDescripcion)
        Controls.Add(lblIntegrante2)
        Controls.Add(lblIntegrante1)
        Controls.Add(lblIntegrantes)
        Controls.Add(lblProfe)
        Controls.Add(lblAsignacion)
        Controls.Add(lblGrupo)
        Controls.Add(lblCurso)
        Controls.Add(btnRegresar)
        Controls.Add(lblCreditos)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCreditos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCreditos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCreditos As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lblCurso As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblAsignacion As Label
    Friend WithEvents lblProfe As Label
    Friend WithEvents lblIntegrantes As Label
    Friend WithEvents lblIntegrante1 As Label
    Friend WithEvents lblIntegrante2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblVBversion As Label
    Friend WithEvents lblCopyright As Label
End Class
