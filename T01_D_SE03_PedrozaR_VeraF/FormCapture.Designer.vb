<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCapture
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
        capture_title = New Label()
        user_label = New Label()
        password_label = New Label()
        user_txtbox = New TextBox()
        TextBox2 = New TextBox()
        pass_txtbox = New TextBox()
        erase_btn = New Button()
        save_btn = New Button()
        btnSalir = New Button()
        viewdata_btn = New Button()
        SuspendLayout()
        ' 
        ' capture_title
        ' 
        capture_title.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        capture_title.Location = New Point(45, 32)
        capture_title.Name = "capture_title"
        capture_title.Size = New Size(412, 63)
        capture_title.TabIndex = 1
        capture_title.Text = "CAPTURA DE DATOS"
        capture_title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' user_label
        ' 
        user_label.AutoSize = True
        user_label.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        user_label.Location = New Point(194, 118)
        user_label.Name = "user_label"
        user_label.Size = New Size(84, 25)
        user_label.TabIndex = 9
        user_label.Text = "Usuario"
        ' 
        ' password_label
        ' 
        password_label.AutoSize = True
        password_label.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password_label.Location = New Point(176, 228)
        password_label.Name = "password_label"
        password_label.Size = New Size(120, 25)
        password_label.TabIndex = 10
        password_label.Text = "Contraseña"
        ' 
        ' user_txtbox
        ' 
        user_txtbox.BorderStyle = BorderStyle.FixedSingle
        user_txtbox.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        user_txtbox.Location = New Point(100, 146)
        user_txtbox.Multiline = True
        user_txtbox.Name = "user_txtbox"
        user_txtbox.Size = New Size(275, 48)
        user_txtbox.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(140, 253)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(0, 0)
        TextBox2.TabIndex = 12
        ' 
        ' pass_txtbox
        ' 
        pass_txtbox.BorderStyle = BorderStyle.FixedSingle
        pass_txtbox.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pass_txtbox.Location = New Point(100, 259)
        pass_txtbox.Multiline = True
        pass_txtbox.Name = "pass_txtbox"
        pass_txtbox.Size = New Size(275, 48)
        pass_txtbox.TabIndex = 13
        ' 
        ' erase_btn
        ' 
        erase_btn.AllowDrop = True
        erase_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        erase_btn.BackColor = Color.PaleVioletRed
        erase_btn.FlatAppearance.BorderSize = 0
        erase_btn.FlatStyle = FlatStyle.Flat
        erase_btn.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        erase_btn.Location = New Point(100, 334)
        erase_btn.Name = "erase_btn"
        erase_btn.Size = New Size(100, 40)
        erase_btn.TabIndex = 16
        erase_btn.Text = "BORRAR"
        erase_btn.UseVisualStyleBackColor = False
        ' 
        ' save_btn
        ' 
        save_btn.AllowDrop = True
        save_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        save_btn.BackColor = Color.SkyBlue
        save_btn.FlatAppearance.BorderSize = 0
        save_btn.FlatStyle = FlatStyle.Flat
        save_btn.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        save_btn.Location = New Point(205, 334)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(170, 40)
        save_btn.TabIndex = 17
        save_btn.Text = "GUARDAR"
        save_btn.UseVisualStyleBackColor = False
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
        ' viewdata_btn
        ' 
        viewdata_btn.AllowDrop = True
        viewdata_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewdata_btn.BackColor = Color.FromArgb(CByte(143), CByte(209), CByte(79))
        viewdata_btn.FlatAppearance.BorderSize = 0
        viewdata_btn.FlatStyle = FlatStyle.Flat
        viewdata_btn.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewdata_btn.Location = New Point(45, 439)
        viewdata_btn.Name = "viewdata_btn"
        viewdata_btn.Size = New Size(384, 45)
        viewdata_btn.TabIndex = 19
        viewdata_btn.Text = "Leer Datos Guardados"
        viewdata_btn.UseVisualStyleBackColor = False
        ' 
        ' FormCapture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(viewdata_btn)
        Controls.Add(btnSalir)
        Controls.Add(save_btn)
        Controls.Add(erase_btn)
        Controls.Add(pass_txtbox)
        Controls.Add(TextBox2)
        Controls.Add(user_txtbox)
        Controls.Add(password_label)
        Controls.Add(user_label)
        Controls.Add(capture_title)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormCapture"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCapture"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents capture_title As Label
    Friend WithEvents user_label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents user_txtbox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents pass_txtbox As TextBox
    Friend WithEvents erase_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents viewdata_btn As Button
End Class
