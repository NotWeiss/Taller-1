<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNombreApp = New Label()
        lblCopyright = New Label()
        btnSalir = New Button()
        btnCalculadora = New Button()
        btnTextos = New Button()
        btnCreditos = New Button()
        SuspendLayout()
        ' 
        ' lblNombreApp
        ' 
        lblNombreApp.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblNombreApp.Location = New Point(45, 38)
        lblNombreApp.Name = "lblNombreApp"
        lblNombreApp.Size = New Size(384, 60)
        lblNombreApp.TabIndex = 0
        lblNombreApp.Text = "miniFORMATTER"
        lblNombreApp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.Font = New Font("Segoe UI", 12F)
        lblCopyright.Location = New Point(231, 570)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(237, 21)
        lblCopyright.TabIndex = 1
        lblCopyright.Text = "©Reynaldo Pedroza y Franz Vera"
        ' 
        ' btnSalir
        ' 
        btnSalir.AllowDrop = True
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnSalir.BackColor = Color.DarkSalmon
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(45, 490)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(384, 45)
        btnSalir.TabIndex = 3
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnCalculadora
        ' 
        btnCalculadora.AllowDrop = True
        btnCalculadora.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCalculadora.BackColor = Color.SkyBlue
        btnCalculadora.FlatAppearance.BorderSize = 0
        btnCalculadora.FlatStyle = FlatStyle.Flat
        btnCalculadora.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculadora.Location = New Point(45, 226)
        btnCalculadora.Name = "btnCalculadora"
        btnCalculadora.Size = New Size(384, 45)
        btnCalculadora.TabIndex = 4
        btnCalculadora.Text = "CALCULADORA"
        btnCalculadora.UseVisualStyleBackColor = False
        ' 
        ' btnTextos
        ' 
        btnTextos.AllowDrop = True
        btnTextos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTextos.BackColor = Color.SkyBlue
        btnTextos.FlatAppearance.BorderSize = 0
        btnTextos.FlatStyle = FlatStyle.Flat
        btnTextos.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTextos.Location = New Point(45, 289)
        btnTextos.Name = "btnTextos"
        btnTextos.Size = New Size(384, 45)
        btnTextos.TabIndex = 5
        btnTextos.Text = "MANEJO DE TEXTOS"
        btnTextos.UseVisualStyleBackColor = False
        ' 
        ' btnCreditos
        ' 
        btnCreditos.AllowDrop = True
        btnCreditos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCreditos.BackColor = Color.SkyBlue
        btnCreditos.FlatAppearance.BorderSize = 0
        btnCreditos.FlatStyle = FlatStyle.Flat
        btnCreditos.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreditos.Location = New Point(45, 352)
        btnCreditos.Name = "btnCreditos"
        btnCreditos.Size = New Size(384, 45)
        btnCreditos.TabIndex = 7
        btnCreditos.Text = "CREDITOS"
        btnCreditos.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(btnCreditos)
        Controls.Add(btnTextos)
        Controls.Add(btnCalculadora)
        Controls.Add(btnSalir)
        Controls.Add(lblCopyright)
        Controls.Add(lblNombreApp)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMain"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombreApp As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnTextos As Button
    Friend WithEvents btnCreditos As Button

End Class
