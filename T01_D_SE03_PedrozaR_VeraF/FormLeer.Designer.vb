<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLeer
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
        info_label = New Label()
        lastdata_label = New Label()
        btnSalir = New Button()
        data_txtbox = New TextBox()
        lastdata_txtbox = New TextBox()
        SuspendLayout()
        ' 
        ' capture_title
        ' 
        capture_title.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        capture_title.Location = New Point(34, 37)
        capture_title.Name = "capture_title"
        capture_title.Size = New Size(412, 63)
        capture_title.TabIndex = 2
        capture_title.Text = "LEER DATOS"
        capture_title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' info_label
        ' 
        info_label.AutoSize = True
        info_label.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        info_label.Location = New Point(124, 132)
        info_label.Name = "info_label"
        info_label.Size = New Size(230, 25)
        info_label.TabIndex = 10
        info_label.Text = "Información Registrada"
        ' 
        ' lastdata_label
        ' 
        lastdata_label.AutoSize = True
        lastdata_label.Font = New Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lastdata_label.Location = New Point(161, 326)
        lastdata_label.Name = "lastdata_label"
        lastdata_label.Size = New Size(151, 25)
        lastdata_label.TabIndex = 11
        lastdata_label.Text = "Ultima Captura"
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
        btnSalir.TabIndex = 19
        btnSalir.Text = "REGRESAR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' data_txtbox
        ' 
        data_txtbox.BorderStyle = BorderStyle.FixedSingle
        data_txtbox.Location = New Point(100, 160)
        data_txtbox.Multiline = True
        data_txtbox.Name = "data_txtbox"
        data_txtbox.ReadOnly = True
        data_txtbox.Size = New Size(275, 140)
        data_txtbox.TabIndex = 20
        ' 
        ' lastdata_txtbox
        ' 
        lastdata_txtbox.BorderStyle = BorderStyle.FixedSingle
        lastdata_txtbox.Location = New Point(100, 354)
        lastdata_txtbox.Multiline = True
        lastdata_txtbox.Name = "lastdata_txtbox"
        lastdata_txtbox.ReadOnly = True
        lastdata_txtbox.Size = New Size(275, 48)
        lastdata_txtbox.TabIndex = 21
        ' 
        ' FormLeer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(lastdata_txtbox)
        Controls.Add(data_txtbox)
        Controls.Add(btnSalir)
        Controls.Add(lastdata_label)
        Controls.Add(info_label)
        Controls.Add(capture_title)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLeer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLeer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents capture_title As Label
    Friend WithEvents info_label As Label
    Friend WithEvents lastdata_label As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents data_txtbox As TextBox
    Friend WithEvents lastdata_txtbox As TextBox
End Class
