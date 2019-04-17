Public Class miTextBox
    Public Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Public Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    Public Enum TipoDatoTexto
        Texto = 1
        Numero = 2
        Decimales = 3
        Moneda = 4
    End Enum
    Private _tipoDato As TipoDatoTexto = TipoDatoTexto.Texto
    Public Property TipoDato() As TipoDatoTexto
        Get
            Return _tipoDato
        End Get
        Set(ByVal value As TipoDatoTexto)
            _tipoDato = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return txtContenido.Text
        End Get
        Set(ByVal value As String)
            If _tipoDato = TipoDatoTexto.Moneda Or _
            _tipoDato = TipoDatoTexto.Decimales Then
                Me.txtContenido.TextAlign = HorizontalAlignment.Right
            End If
            txtContenido.Text = value
        End Set
    End Property
    Public Shadows Property MaxLength() As Integer
        Get
            Return txtContenido.MaxLength
        End Get
        Set(ByVal value As Integer)
            Me.txtContenido.MaxLength = value
        End Set
    End Property

    'Private _texto As Boolean
    'Public Property TodoTexto() As Boolean
    '    Get
    '        Return _texto
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _texto = value
    '    End Set
    'End Property
    'Private _number As Boolean
    'Public Property SoloNumero() As Boolean
    '    Get
    '        Return _number
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _number = value
    '    End Set
    'End Property
    'Private _decimal As Boolean
    'Public Property SoloDecimal() As Boolean
    '    Get
    '        Return _decimal
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _decimal = value
    '    End Set
    'End Property
    'Private _moneda As Boolean
    'Public Property SoloMoneda() As Boolean
    '    Get
    '        Return _moneda
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _moneda = value
    '    End Set
    'End Property
    Private _codigo_anterior As String
    Public Property CodigoAnterior() As String
        Get
            Return _codigo_anterior
        End Get
        Set(ByVal value As String)
            _codigo_anterior = value
        End Set
    End Property
    Public ReadOnly Property TextBox() As TextBox
        Get
            Return txtContenido
        End Get
    End Property

    Private Sub miTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        txtContenido.Focus()
        txtContenido.SelectAll()
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
    End Sub

    Private Sub miTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = txtContenido.Height + 3
    End Sub

    Private Sub txtContenido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContenido.Leave
        If Me.TipoDato = TipoDatoTexto.Decimales And txtContenido.Text <> "" Then
            If IsNumeric(txtContenido.Text) Then
                txtContenido.Text = FormatNumber(txtContenido.Text, 2)
            Else
                Dim vbResul As MsgBoxResult = MsgBox("Se esperaba un valor numérico, por favor intente nuevamente", MsgBoxStyle.Critical, "Error!!")
                If vbResul = MsgBoxResult.Ok Then
                    Me.txtContenido.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtContenido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContenido.KeyDown
        'If SoloNumero Then
        '    'If InStr("1234567890,.", (e.KeyChar)) = 1 Then
        '    RaiseEvent KeyDown(sender, e)
        '    'End If
        'Else
        RaiseEvent KeyDown(sender, e)
        'End If
    End Sub

    'Private Sub txtContenido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContenido.KeyPress
    '    If SoloNumero Then
    '        If InStr("1234567890,.", (e.KeyChar)) = 1 Then
    '            RaiseEvent KeyPress(sender, e)
    '        Else
    '            e.Handled = False
    '        End If
    '    Else

    '    End If
    '    'If Char.IsLetter(e.KeyChar) Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsControl(e.KeyChar) Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsSeparator(e.KeyChar) Then
    '    '    e.Handled = False
    '    'Else
    '    '    e.Handled = True
    '    'End If
    '    RaiseEvent KeyPress(sender, e)
    'End Sub

    Private Sub txtContenido_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContenido.MouseEnter
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(209, Byte), Integer))
    End Sub

    Private Sub txtContenido_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContenido.MouseLeave
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
    End Sub

    Private Sub txtContenido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContenido.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub

    Private Sub txtContenido_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtContenido.MouseDown
        Me.CodigoAnterior = Me.txtContenido.Text
    End Sub

    Private Sub txtContenido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContenido.KeyPress
        If Me.TipoDato = TipoDatoTexto.Moneda Then
            e.Handled = Numeros(txtContenido, System.Convert.ToInt16(Asc(e.KeyChar)))
        ElseIf Me.TipoDato = TipoDatoTexto.Numero Then
            e.Handled = NumerosEnteros(txtContenido, System.Convert.ToInt16(Asc(e.KeyChar)))
        ElseIf Me.TipoDato = TipoDatoTexto.Decimales Then
            e.Handled = NumerosDecimal(txtContenido, System.Convert.ToInt16(Asc(e.KeyChar)))
        Else
            RaiseEvent KeyPress(sender, e)
        End If
    End Sub
    Private Sub txtContenido_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContenido.KeyUp
        If Me.TipoDato = TipoDatoTexto.Moneda Then
            Me.txtContenido.Text = Mascara(txtContenido, e.KeyValue)
        End If
    End Sub
    'Private Function MascaraDecimal(ByVal txt As TextBox, ByVal tecla As Integer, Optional ByVal decimales As Integer = 2) As String
    '    If (tecla >= 48 And tecla <= 57) Or tecla = 8 Or tecla = 13 Or tecla = 190 Or tecla = 46 Or tecla = 44 Or tecla = 110 Then
    '        If Trim(txt.Text.Length) <= 0 Then
    '            Return Nothing
    '        End If
    '        Dim Posicion_Cursor As Integer = txt.SelectionStart

    '        txt.TextAlign = HorizontalAlignment.Right
    '        Dim SeparadorDecimal As String = My.Application.Culture.NumberFormat.NumberDecimalSeparator
    '        If SeparadorDecimal = "," And tecla = 46 Then
    '            txt.Text = txt.Text.Replace(".", SeparadorDecimal)
    '        ElseIf SeparadorDecimal = "." And tecla = 44 Then
    '            txt.Text = txt.Text.Replace(",", SeparadorDecimal)
    '        End If
    '        txt.Text = FormatNumberDec(txt.Text, 2)
    '        txt.SelectionStart = InStr(txt.Text, SeparadorDecimal) - 1
    '    End If
    '    Return txt.Text

    'End Function

    Private Shared Function NumerosDecimal(ByVal txt As TextBox, ByVal Kcode As Int16) As Boolean
        If (Kcode >= 48 And Kcode <= 57) Or Kcode = 8 Or Kcode = 13 Or Kcode = 190 Or Kcode = 46 Or Kcode = 44 Then

            Dim SeparadorDecimal As String = My.Application.Culture.NumberFormat.NumberDecimalSeparator

            If SeparadorDecimal = "." And Kcode = 44 Then
                If txt.Text.IndexOf(".") <> -1 Or txt.Text.IndexOf(",") <> -1 Then
                    Return True
                Else
                    txt.AppendText(".") 'Kcode = 46
                    Return True
                End If
                Return True
            ElseIf SeparadorDecimal = "," And Kcode = 46 Then
                If txt.Text.IndexOf(",") <> -1 Or txt.Text.IndexOf(".") <> -1 Then
                    Return True
                Else
                    txt.AppendText(",") 'Kcode = 44
                    Return True
                End If
                Return True
            End If
            If txt.Text.IndexOf(",") <> -1 And Kcode = 44 Or txt.Text.IndexOf(".") <> -1 And Kcode = 46 Then
                Return True
            End If
            Return False
        Else
            Return True
        End If
    End Function
    Private Shared Function Mascara(ByVal txt As TextBox, ByVal tecla As Integer, Optional ByVal decimales As Integer = 2) As String

        Dim SeparadorDecimal As String = My.Application.Culture.NumberFormat.NumberDecimalSeparator
        Dim SeparadorMillar As String = My.Application.Culture.NumberFormat.NumberGroupSeparator
        Dim ASCII As String = ""

        txt.TextAlign = HorizontalAlignment.Right
        If tecla >= 48 And tecla <= 57 Then
            ASCII = CStr(tecla - 48)
        End If
        Dim Posicion_Cursor As Integer = txt.SelectionStart
        If Trim(txt.Text.Length) <= 0 Then
            Return Nothing
        End If
        If txt.Text.Length >= 3 Then
            If Mid(txt.Text, Len(txt.Text) - 1) <> "00" Then
                If tecla >= 48 And tecla <= 57 Then
                    If ASCII.Length > 1 Then
                        ASCII = Mid(ASCII, 2, 1)
                    End If
                    txt.Text = Mid(txt.Text, 1, Len(txt.Text) - 1) + ASCII
                End If
            End If
        End If
        'If tecla = 109 Then 'signo menos 
        '    If txt.Text.Length >= 3 Then
        '        If Mid(txt.Text, 1, 1) <> "-" Then
        '            txt.Text = "-" + txt.Text
        '        Else
        '            txt.Text = txt.Text.Replace("-", "")
        '        End If
        '        SendKeys.Send("{END}")
        '    End If
        'End If
        If tecla = 190 Or tecla = 188 Then 'punto decimal (punto - coma) 
            If txt.Text.Length = 1 Then
                txt.Text = "0" + SeparadorDecimal + "00"
                txt.SelectionStart = InStr(txt.Text, SeparadorDecimal)
            Else
                If SeparadorDecimal = "," Then
                    txt.Text = txt.Text.Replace(".,", SeparadorDecimal)
                Else
                    txt.Text = txt.Text.Replace("..", SeparadorDecimal)
                End If
                txt.SelectionStart = InStr(txt.Text, SeparadorDecimal)
            End If
        Else
            If tecla = 46 Then
                If Posicion_Cursor = Trim(txt.Text).Length - 2 Then 'borra el caracter de la coma decimal 
                    txt.Text = Mid(txt.Text, 1, Posicion_Cursor) + SeparadorDecimal + Mid(txt.Text, Posicion_Cursor + 1, 2)
                End If
                If Mid(txt.Text, 1, 1) = SeparadorMillar Then 'borra el punto de unidades de mil 
                    txt.Text = Mid(txt.Text, 2, Len(txt.Text))
                End If
                SendKeys.Send("{DOWN}")
            End If
            If tecla = 8 Then
                If Posicion_Cursor = Trim(txt.Text).Length - 2 Then 'borra el caracter de la coma decimal 
                    txt.Text = Mid(txt.Text, 1, Posicion_Cursor) + SeparadorDecimal + Mid(txt.Text, Posicion_Cursor + 1, 2)
                End If
                If Mid(txt.Text, 1, 1) = SeparadorMillar Then 'borra el punto de unidades de mil 
                    txt.Text = Mid(txt.Text, 2, Len(txt.Text))
                End If
                SendKeys.Send("{DOWN}")
            End If
            If tecla <> 39 And tecla <> 37 And tecla <> 46 Then 'der,izq,del 
                txt.Text = FormatNumber(txt.Text, 2)
                txt.SelectionStart = InStr(txt.Text, SeparadorDecimal) - 1
            End If
        End If
        Return txt.Text
    End Function
    Private Shared Function Numeros(ByVal txt As TextBox, ByVal Kcode As Int16) As Boolean
        If (Kcode >= 48 And Kcode <= 57) Or Kcode = 8 Or Kcode = 13 Or Kcode = 190 Or Kcode = 46 Or Kcode = 44 Then
            If My.Application.Culture.NumberFormat.NumberDecimalSeparator = "." And Kcode = 44 Then
                Return True
            ElseIf My.Application.Culture.NumberFormat.NumberDecimalSeparator = "," And Kcode = 46 Then
                Return True
            End If
            If txt.Text.IndexOf(",") <> -1 And Kcode = 44 Then
                Return True
            End If
            If txt.Text.IndexOf(".") <> -1 And Kcode = 46 Then
                Return True
            End If

            Return False
        Else
            Return True
        End If
    End Function
    Private Shared Function NumerosEnteros(ByVal txt As TextBox, ByVal Kcode As Int16) As Boolean
        If (Kcode >= 48 And Kcode <= 57) Or Kcode = 8 Or Kcode = 13 Or Kcode = 190 Then 'Or Kcode = 46 Or Kcode = 44
            Return False
        Else
            Return True
        End If
    End Function
End Class
