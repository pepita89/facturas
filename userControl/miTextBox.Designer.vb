<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class miTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtContenido = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtContenido
        '
        Me.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContenido.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtContenido.Location = New System.Drawing.Point(1, 1)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(177, 13)
        Me.txtContenido.TabIndex = 0
        '
        'miTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.txtContenido)
        Me.Name = "miTextBox"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(179, 15)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox

End Class
