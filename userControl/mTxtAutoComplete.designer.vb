<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mTxtAutoComplete
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
        Me.lsResultados = New System.Windows.Forms.ListBox
        Me.txtTexto = New Facturas.miTextBox
        Me.SuspendLayout()
        '
        'lsResultados
        '
        Me.lsResultados.BackColor = System.Drawing.Color.White
        Me.lsResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsResultados.FormattingEnabled = True
        Me.lsResultados.HorizontalScrollbar = True
        Me.lsResultados.Location = New System.Drawing.Point(0, 16)
        Me.lsResultados.Name = "lsResultados"
        Me.lsResultados.Size = New System.Drawing.Size(180, 2)
        Me.lsResultados.TabIndex = 3
        Me.lsResultados.Visible = False
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTexto.CodigoAnterior = Nothing
        Me.txtTexto.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTexto.Location = New System.Drawing.Point(0, 0)
        Me.txtTexto.MaxLength = 32767
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Padding = New System.Windows.Forms.Padding(1)
        Me.txtTexto.Size = New System.Drawing.Size(180, 16)
        Me.txtTexto.TabIndex = 2
        Me.txtTexto.TipoDato = Facturas.miTextBox.TipoDatoTexto.Texto
        '
        'mTxtAutoComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lsResultados)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "mTxtAutoComplete"
        Me.Size = New System.Drawing.Size(180, 29)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTexto As Facturas.miTextBox
    Friend WithEvents lsResultados As System.Windows.Forms.ListBox

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

  
End Class
