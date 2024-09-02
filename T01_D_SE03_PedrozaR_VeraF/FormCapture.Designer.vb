<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
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
        entradaTitle = New Label()
        usernameLabel = New Label()
        contrLabel = New Label()
        txtUserIn = New TextBox()
        TextBox2 = New TextBox()
        txtContrln = New TextBox()
        erase_btn = New Button()
        cmdGuardar = New Button()
        btnSalir = New Button()
        cmdVisual = New Button()
        lblCopyright = New Label()
        SuspendLayout()
        ' 
        ' entradaTitle
        ' 
        entradaTitle.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        entradaTitle.Location = New Point(45, 38)
        entradaTitle.Name = "entradaTitle"
        entradaTitle.Size = New Size(384, 60)
        entradaTitle.TabIndex = 1
        entradaTitle.Text = "CAPTURA DE DATOS"
        entradaTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameLabel.Location = New Point(194, 118)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(86, 25)
        usernameLabel.TabIndex = 9
        usernameLabel.Text = "Usuario"
        ' 
        ' contrLabel
        ' 
        contrLabel.AutoSize = True
        contrLabel.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contrLabel.Location = New Point(176, 228)
        contrLabel.Name = "contrLabel"
        contrLabel.Size = New Size(123, 25)
        contrLabel.TabIndex = 10
        contrLabel.Text = "Contraseña"
        ' 
        ' txtUserIn
        ' 
        txtUserIn.BorderStyle = BorderStyle.FixedSingle
        txtUserIn.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUserIn.Location = New Point(100, 146)
        txtUserIn.Multiline = True
        txtUserIn.Name = "txtUserIn"
        txtUserIn.Size = New Size(275, 39)
        txtUserIn.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(140, 253)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(0, 0)
        TextBox2.TabIndex = 12
        ' 
        ' txtContrln
        ' 
        txtContrln.BorderStyle = BorderStyle.FixedSingle
        txtContrln.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContrln.Location = New Point(100, 259)
        txtContrln.Multiline = True
        txtContrln.Name = "txtContrln"
        txtContrln.Size = New Size(275, 39)
        txtContrln.TabIndex = 13
        ' 
        ' erase_btn
        ' 
        erase_btn.AllowDrop = True
        erase_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        erase_btn.BackColor = Color.PaleVioletRed
        erase_btn.FlatAppearance.BorderSize = 0
        erase_btn.FlatStyle = FlatStyle.Flat
        erase_btn.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        erase_btn.Location = New Point(100, 313)
        erase_btn.Name = "erase_btn"
        erase_btn.Size = New Size(100, 38)
        erase_btn.TabIndex = 16
        erase_btn.Text = "BORRAR"
        erase_btn.UseVisualStyleBackColor = False
        ' 
        ' cmdGuardar
        ' 
        cmdGuardar.AllowDrop = True
        cmdGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmdGuardar.BackColor = Color.SkyBlue
        cmdGuardar.FlatAppearance.BorderSize = 0
        cmdGuardar.FlatStyle = FlatStyle.Flat
        cmdGuardar.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdGuardar.Location = New Point(205, 313)
        cmdGuardar.Name = "cmdGuardar"
        cmdGuardar.Size = New Size(170, 38)
        cmdGuardar.TabIndex = 17
        cmdGuardar.Text = "GUARDAR"
        cmdGuardar.UseVisualStyleBackColor = False
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
        btnSalir.TabIndex = 18
        btnSalir.Text = "REGRESAR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' cmdVisual
        ' 
        cmdVisual.AllowDrop = True
        cmdVisual.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmdVisual.BackColor = Color.FromArgb(CByte(143), CByte(209), CByte(79))
        cmdVisual.FlatAppearance.BorderSize = 0
        cmdVisual.FlatStyle = FlatStyle.Flat
        cmdVisual.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdVisual.Location = New Point(45, 439)
        cmdVisual.Name = "cmdVisual"
        cmdVisual.Size = New Size(384, 45)
        cmdVisual.TabIndex = 19
        cmdVisual.Text = "Leer Datos Guardados"
        cmdVisual.UseVisualStyleBackColor = False
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.BackColor = Color.Transparent
        lblCopyright.Font = New Font("Segoe UI", 12F)
        lblCopyright.Location = New Point(231, 570)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(237, 21)
        lblCopyright.TabIndex = 20
        lblCopyright.Text = "©Reynaldo Pedroza y Franz Vera"
        ' 
        ' frmEntrada
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(lblCopyright)
        Controls.Add(cmdVisual)
        Controls.Add(btnSalir)
        Controls.Add(cmdGuardar)
        Controls.Add(erase_btn)
        Controls.Add(txtContrln)
        Controls.Add(TextBox2)
        Controls.Add(txtUserIn)
        Controls.Add(contrLabel)
        Controls.Add(usernameLabel)
        Controls.Add(entradaTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEntrada"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCapture"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents entradaTitle As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents contrLabel As Label
    Friend WithEvents txtUserIn As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtContrln As TextBox
    Friend WithEvents erase_btn As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmdVisual As Button
    Friend WithEvents lblCopyright As Label
End Class
