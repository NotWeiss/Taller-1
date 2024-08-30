<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        lblCalculadora = New Label()
        txtValor1 = New TextBox()
        cboOperacion = New ComboBox()
        txtValor2 = New TextBox()
        txtResultado = New TextBox()
        btnSalir = New Button()
        lblValor1 = New Label()
        lblValor2 = New Label()
        lblOperacion = New Label()
        lblResultado = New Label()
        btnCalcular = New Button()
        btnBorrar = New Button()
        lblCopyright = New Label()
        SuspendLayout()
        ' 
        ' lblCalculadora
        ' 
        lblCalculadora.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        lblCalculadora.Location = New Point(45, 38)
        lblCalculadora.Name = "lblCalculadora"
        lblCalculadora.Size = New Size(384, 60)
        lblCalculadora.TabIndex = 0
        lblCalculadora.Text = "CALCULADORA"
        lblCalculadora.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtValor1
        ' 
        txtValor1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtValor1.Location = New Point(45, 183)
        txtValor1.Name = "txtValor1"
        txtValor1.Size = New Size(141, 39)
        txtValor1.TabIndex = 1
        txtValor1.TextAlign = HorizontalAlignment.Center
        ' 
        ' cboOperacion
        ' 
        cboOperacion.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboOperacion.FormattingEnabled = True
        cboOperacion.Items.AddRange(New Object() {"+", "-", "x", "/"})
        cboOperacion.Location = New Point(208, 183)
        cboOperacion.Name = "cboOperacion"
        cboOperacion.Size = New Size(58, 40)
        cboOperacion.TabIndex = 2
        ' 
        ' txtValor2
        ' 
        txtValor2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtValor2.Location = New Point(288, 183)
        txtValor2.Name = "txtValor2"
        txtValor2.Size = New Size(141, 39)
        txtValor2.TabIndex = 3
        txtValor2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtResultado
        ' 
        txtResultado.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtResultado.Location = New Point(100, 275)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(275, 93)
        txtResultado.TabIndex = 4
        txtResultado.TextAlign = HorizontalAlignment.Center
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
        btnSalir.TabIndex = 5
        btnSalir.Text = "REGRESAR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblValor1
        ' 
        lblValor1.AutoSize = True
        lblValor1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblValor1.Location = New Point(82, 155)
        lblValor1.Name = "lblValor1"
        lblValor1.Size = New Size(69, 25)
        lblValor1.TabIndex = 6
        lblValor1.Text = "Valor 1"
        ' 
        ' lblValor2
        ' 
        lblValor2.AutoSize = True
        lblValor2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblValor2.Location = New Point(323, 155)
        lblValor2.Name = "lblValor2"
        lblValor2.Size = New Size(72, 25)
        lblValor2.TabIndex = 7
        lblValor2.Text = "Valor 2"
        ' 
        ' lblOperacion
        ' 
        lblOperacion.AutoSize = True
        lblOperacion.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOperacion.Location = New Point(187, 155)
        lblOperacion.Name = "lblOperacion"
        lblOperacion.Size = New Size(100, 25)
        lblOperacion.TabIndex = 8
        lblOperacion.Text = "Operacion"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultado.Location = New Point(187, 247)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(96, 25)
        lblResultado.TabIndex = 9
        lblResultado.Text = "Resultado"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.AllowDrop = True
        btnCalcular.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCalcular.BackColor = Color.SkyBlue
        btnCalcular.FlatAppearance.BorderSize = 0
        btnCalcular.FlatStyle = FlatStyle.Flat
        btnCalcular.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalcular.Location = New Point(205, 379)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(170, 40)
        btnCalcular.TabIndex = 10
        btnCalcular.Text = "CALCULAR"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.AllowDrop = True
        btnBorrar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBorrar.BackColor = Color.PaleVioletRed
        btnBorrar.FlatAppearance.BorderSize = 0
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrar.Location = New Point(100, 379)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(100, 40)
        btnBorrar.TabIndex = 11
        btnBorrar.Text = "BORRAR"
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.Font = New Font("Segoe UI", 12F)
        lblCopyright.Location = New Point(231, 570)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(237, 21)
        lblCopyright.TabIndex = 12
        lblCopyright.Text = "©Reynaldo Pedroza y Franz Vera"
        ' 
        ' frmCalculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(lblCopyright)
        Controls.Add(btnBorrar)
        Controls.Add(btnCalcular)
        Controls.Add(lblResultado)
        Controls.Add(lblOperacion)
        Controls.Add(lblValor2)
        Controls.Add(lblValor1)
        Controls.Add(btnSalir)
        Controls.Add(txtResultado)
        Controls.Add(txtValor2)
        Controls.Add(cboOperacion)
        Controls.Add(txtValor1)
        Controls.Add(lblCalculadora)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmCalculadora"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCalculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCalculadora As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents cboOperacion As ComboBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblValor1 As Label
    Friend WithEvents lblValor2 As Label
    Friend WithEvents lblOperacion As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblCopyright As Label
End Class
