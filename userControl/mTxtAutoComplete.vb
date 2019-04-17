Public Class mTxtAutoComplete
    Public Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Shadows Event Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Public Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Private ss As New Size()

    Private Tecla As Keys
    
    Public Overrides Property Text() As String
        Get
            Return txtTexto.TextBox.Text
        End Get
        Set(ByVal value As String)
            
            txtTexto.Text = value
        End Set
    End Property

    Private _codigo_anterior As String
    Public Property CodigoAnterior() As String
        Get
            Return _codigo_anterior
        End Get
        Set(ByVal value As String)
            _codigo_anterior = value
        End Set
    End Property
    Private _TipoOperacion As String
    Public Property TipoOperacion() As String
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property
    Public ReadOnly Property TextBox() As TextBox
        Get
            Return txtTexto.TextBox
        End Get
    End Property
    
   
    Private Sub mTxtAutoComplete_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        RaiseEvent Leave(sender, e)
    End Sub

    'Private Sub lsResultados_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    txtTexto.Text = Me.lsResultados.Text
    '    Me.lsResultados.Visible = False
    'End Sub

    Private Sub txtTexto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTexto.KeyDown
        If (e.KeyCode = Keys.Down) Then

            Me.lsResultados.Focus()
          
        End If
        If (e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete) Then
            Tecla = Keys.Back

        Else
            Tecla = Keys.A
        
        End If
        RaiseEvent KeyDown(sender, e)
    End Sub

   
    Private Sub txtTexto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTexto.TextChanged

        Me.lsResultados.Items.Clear()
        If (txtTexto.Text <> "" And Tecla <> Keys.Back) Then
            Dim oarrTexto As New List(Of clsPalabra)
            oarrTexto = SacarPuntos()
            'For Each str As String In Me.txtTexto.TextBox.AutoCompleteCustomSource

            '    If str.ToLower().IndexOf(txtTexto.Text.ToLower()) >= 0 Then
            '        Me.lsResultados.Items.Add(str)
            '    End If
            'Next
            For Each str As clsPalabra In oarrTexto
                If txtTexto.Text.ToLower().Contains(".") Then
                    If str.strPalabra.ToLower().IndexOf(txtTexto.Text.ToLower()) >= 0 Then
                        Me.lsResultados.Items.Add(str.strPalabra)
                    End If
                Else
                    If str.strPalabra_SinPuntos.ToLower().IndexOf(txtTexto.Text.ToLower()) >= 0 Then
                        Me.lsResultados.Items.Add(str.strPalabra)
                    End If
                End If

            Next
            If (Me.lsResultados.Items.Count > 0) Then
                If ((Me.lsResultados.Items.Count = 1) And (txtTexto.Text.ToLower() = Me.lsResultados.Items(0).ToString().ToLower()) Or (Me.lsResultados.Items.Count = 1) And (txtTexto.Text.ToLower() = Me.lsResultados.Items(0).ToString().ToLower().Replace(".", ""))) Then
                    Me.lsResultados.Visible = False
                    txtTexto.Text = Me.lsResultados.Items(0).ToString()
                    Me.lsResultados.Visible = False
                    Me.Height = ss.Height
                    Me.lsResultados.SendToBack()


                Else

                    If Me.CodigoAnterior <> 0 Then
                        Me.lsResultados.Visible = False
                        txtTexto.Text = Me.lsResultados.Items(0).ToString()
                        Me.lsResultados.Visible = False
                        Me.Height = ss.Height
                        Me.lsResultados.SendToBack()
                        Exit Sub
                    End If

                    Me.lsResultados.DrawMode = DrawMode.OwnerDrawVariable
                    Me.lsResultados.ItemHeight = 15
                    Me.lsResultados.Visible = True
                    Select Case Me.lsResultados.Items.Count
                        Case Is <= 2
                            Me.Height = ss.Height * 3
                        Case Is < 10
                            Me.Height = ss.Height * 6
                        Case Is >= 10
                            Me.Height = ss.Height * 10
                    End Select
                    '  Me.Height = ss.Height * IIf(Me.lsResultados.Items.Count < 10, 3, 10) 'ss.Height * 11
                    Me.lsResultados.BringToFront()
                    Me.BringToFront()




                End If

            Else

                Me.lsResultados.Visible = False
                Me.Height = ss.Height
                Me.lsResultados.SendToBack()
            End If

        Else
            Me.lsResultados.Visible = False
            Me.Height = ss.Height
            Me.lsResultados.SendToBack()

        End If


      




    End Sub

    Private Sub lsResultados_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lsResultados.DrawItem
        If (e.Index <> -1) Then


            Dim rectangulo As Rectangle = e.Bounds
            If (e.State And DrawItemState.Selected) Then
                e.Graphics.FillRectangle(SystemBrushes.Highlight, rectangulo)

            Else
                e.Graphics.FillRectangle(Brushes.White, rectangulo)

            End If

            Dim nombreColor As String = lsResultados.Items(e.Index)
            'rectangulo.Inflate(-16, -2)

            If (e.State And DrawItemState.Selected) Then
                e.Graphics.DrawString(nombreColor, e.Font, Brushes.White, rectangulo.X, rectangulo.Y)
            Else
                e.Graphics.DrawString(nombreColor, e.Font, Brushes.Gray, rectangulo.X, rectangulo.Y)

            End If
        End If
    End Sub

    Private Sub lsResultados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsResultados.KeyDown
        If (e.KeyData = Keys.Enter) Then
            txtTexto.Text = Me.lsResultados.Text
            Me.lsResultados.Visible = False
            Me.Height = ss.Height
            Me.lsResultados.SendToBack()
        End If
     
    End Sub

    Private Sub lsResultados_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsResultados.MouseClick

    End Sub

    Private Sub lsResultados_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsResultados.MouseDoubleClick
        txtTexto.Text = Me.lsResultados.Text
        Me.lsResultados.Visible = False
        Me.Height = ss.Height
        Me.lsResultados.SendToBack()
    End Sub
   

    
    Private Sub mTxtAutoComplete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub mTxtAutoComplete_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.lsResultados.Visible = False
        Me.Height = ss.Height
        Me.lsResultados.SendToBack()
    End Sub

    Private Sub mTxtAutoComplete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ss = Me.Size
    End Sub
    Private Function SacarPuntos() As List(Of clsPalabra)
        SacarPuntos = New List(Of clsPalabra)
        For Each str As String In Me.txtTexto.TextBox.AutoCompleteCustomSource
            Dim oclspalabra As New clsPalabra()
            oclspalabra.strPalabra = str
            Dim aux() As String = str.Split(".")
            For i As Integer = 0 To aux.Length - 1
                oclspalabra.strPalabra_SinPuntos = oclspalabra.strPalabra_SinPuntos & aux(i).Trim
            Next
            SacarPuntos.Add(oclspalabra)
        Next
        Return SacarPuntos
    End Function
End Class
Class clsPalabra
    Private _strPalabra As String
    Private _strPalabra_SinPuntos As String
    Public Property strPalabra() As String
        Get
            Return _strPalabra
        End Get
        Set(ByVal value As String)
            _strPalabra = value
        End Set
    End Property
    Public Property strPalabra_SinPuntos() As String
        Get
            Return _strPalabra_SinPuntos
        End Get
        Set(ByVal value As String)
            _strPalabra_SinPuntos = value
        End Set
    End Property
   
End Class
