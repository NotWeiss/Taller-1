<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        visualizarTitle = New Label()
        infoOutLabel = New Label()
        infoUltiLabel = New Label()
        btnSalir = New Button()
        txtInfoOut = New TextBox()
        txtInfUltima = New TextBox()
        SuspendLayout()
        ' 
        ' visualizarTitle
        ' 
        visualizarTitle.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        visualizarTitle.Location = New Point(34, 37)
        visualizarTitle.Name = "visualizarTitle"
        visualizarTitle.Size = New Size(412, 63)
        visualizarTitle.TabIndex = 2
        visualizarTitle.Text = "LEER DATOS"
        visualizarTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' infoOutLabel
        ' 
        infoOutLabel.AutoSize = True
        infoOutLabel.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        infoOutLabel.Location = New Point(124, 132)
        infoOutLabel.Name = "infoOutLabel"
        infoOutLabel.Size = New Size(233, 25)
        infoOutLabel.TabIndex = 10
        infoOutLabel.Text = "Información Registrada"
        ' 
        ' infoUltiLabel
        ' 
        infoUltiLabel.AutoSize = True
        infoUltiLabel.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        infoUltiLabel.Location = New Point(161, 326)
        infoUltiLabel.Name = "infoUltiLabel"
        infoUltiLabel.Size = New Size(154, 25)
        infoUltiLabel.TabIndex = 11
        infoUltiLabel.Text = "Ultima Captura"
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
        ' txtInfoOut
        ' 
        txtInfoOut.BackColor = SystemColors.Window
        txtInfoOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfoOut.Location = New Point(100, 160)
        txtInfoOut.Multiline = True
        txtInfoOut.Name = "txtInfoOut"
        txtInfoOut.ReadOnly = True
        txtInfoOut.Size = New Size(275, 140)
        txtInfoOut.TabIndex = 20
        ' 
        ' txtInfUltima
        ' 
        txtInfUltima.BackColor = SystemColors.Window
        txtInfUltima.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInfUltima.Location = New Point(100, 354)
        txtInfUltima.Multiline = True
        txtInfUltima.Name = "txtInfUltima"
        txtInfUltima.ReadOnly = True
        txtInfUltima.Size = New Size(275, 48)
        txtInfUltima.TabIndex = 21
        ' 
        ' frmInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 600)
        Controls.Add(txtInfUltima)
        Controls.Add(txtInfoOut)
        Controls.Add(btnSalir)
        Controls.Add(infoUltiLabel)
        Controls.Add(infoOutLabel)
        Controls.Add(visualizarTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLeer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents visualizarTitle As Label
    Friend WithEvents infoOutLabel As Label
    Friend WithEvents infoUltiLabel As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtInfoOut As TextBox
    Friend WithEvents txtInfUltima As TextBox
End Class
