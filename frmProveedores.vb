Imports clsFacturas
Public Class frmProveedores
    Public cdModo As Integer
    Private ArrProveedor As New ArrayList
    Public codproveedor As Integer
    Public _cdExterior As Integer
    Public oclsProv As New clsProveedores
    Public _TipoProv As Integer
    Sub AutoCompletarProveedores_Organismo(ByVal Exterior As Integer)
        Try
            ArrProveedor = New ArrayList()
            Me.txtRazonSocial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource
            Me.txtRazonSocial.AutoCompleteCustomSource.Clear()
            Dim i As Integer
            Dim DatRubro As System.Data.DataSet
            DatRubro = WS.Obtener_Proveedores_Organismos(Exterior, 0)
            For i = 0 To DatRubro.Tables(0).Rows.Count - 1
                Dim obj As New clsProveedor
                obj.cdProveedor = DatRubro.Tables(0).Rows(i).Item("cdProveedor").ToString()
                obj.dsProveedor = DatRubro.Tables(0).Rows(i).Item("dsProveedor").ToString()
                obj.dsCuit = DatRubro.Tables(0).Rows(i).Item("dsCuit").ToString()
                obj.cdEsExterior = DatRubro.Tables(0).Rows(i).Item("cdEsExterior").ToString()
                obj.dsNroBeneficiario = DatRubro.Tables(0).Rows(i).Item("dsNroBeneficiario").ToString()
                Me.txtRazonSocial.AutoCompleteCustomSource.Add(obj.dsProveedor)
                ArrProveedor.Add(obj)
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function AutoCompletarProveedor(ByVal dsNombre As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsProveedor.ToUpper() = dsNombre.ToUpper() Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = obj.dsCuit
                oProveedor.cdProveedor = obj.cdProveedor
                oProveedor.dsNroBeneficiario = obj.dsNroBeneficiario
                oProveedor.cdEsExterior = obj.cdEsExterior
            End If
        Next
        Return oProveedor
    End Function
    Function AutoCompletarPorCuit(ByVal Cuit As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsCuit = Cuit Or obj.dsProveedor = Cuit Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = Cuit
                oProveedor.cdProveedor = obj.cdProveedor
            End If
        Next
        Return oProveedor
    End Function
    Sub CompletarRazonSocial(ByVal txtCuit As String, ByVal txtNombre As String, ByVal txtCod As Integer, ByVal txtBeneficiario As String)
        If Me.txtCuit.Text.Length <> 0 Then
            Dim org As clsProveedor = AutoCompletarPorCuit(txtCuit)
            If org.dsProveedor <> "" Then
                Me.txtCuit.Text = org.dsCuit
                txtCod = org.cdProveedor
                Me.txtRazonSocial.Text = org.dsProveedor
                txtBeneficiario = org.dsNroBeneficiario
            End If
        End If

    End Sub
    Sub CompletarCuit(ByVal txtProve As TextBox, ByVal txtcuit As TextBox)
        If txtProve.Text.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve.Text) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                txtProve.Text = Prov.dsProveedor
                txtcuit.Text = Prov.dsCuit
                codproveedor = Prov.cdProveedor

            End If
        End If
    End Sub
    Sub CompletarCuit(ByVal txtProve As String, ByVal txtcuit As String)
        If txtProve.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtProve) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                Me.txtRazonSocial.Text = Prov.dsProveedor
                Me.txtCuit.Text = Prov.dsCuit
                If (Prov.cdEsExterior = 0) Then
                    Me.chkExterior.Checked = False
                Else
                    Me.chkExterior.Checked = True
                End If
                Me.txtCuit.Enabled = False
                codproveedor = Prov.cdProveedor
                Me.txtNroBeneficiario.Text = Prov.dsNroBeneficiario
                Me.txtRazonSocial.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
                Me.chkExterior.Enabled = False
                Me.cmdModificar.Enabled = True
                Me.cmdAgregar.Enabled = False
            End If
        End If
    End Sub
    Public Function verifica_cuit(ByVal CUIT As String) As String
        Dim coeficiente(0 To 10) As Integer
        Dim i, sumador, veri_nro, resultado As Integer
        Dim cuit_rearmado As String
        coeficiente(1) = 5
        coeficiente(2) = 4
        coeficiente(3) = 3
        coeficiente(4) = 2
        coeficiente(5) = 7
        coeficiente(6) = 6
        coeficiente(7) = 5
        coeficiente(8) = 4
        coeficiente(9) = 3
        coeficiente(10) = 2
        CUIT = Trim(CUIT)
        cuit_rearmado = ""
        For i = 1 To Len(CUIT)      'separo cualquier caracter que no tenga que ver con numeros
            If Asc(Mid(CUIT, i, 1)) >= 48 And Asc(Mid(CUIT, i, 1)) <= 57 Then
                cuit_rearmado = cuit_rearmado & Mid(CUIT, i, 1)
            End If
        Next
        cuit_rearmado = Trim(cuit_rearmado)
        If Len(cuit_rearmado) <> 11 Then            ' si to estan todos los digitos

            MsgBox("El CUIT no tiene el formato válido", vbDefaultButton1, "Error en el C.U.I.T.")
        Else
            sumador = 0
            veri_nro = Val(Mid(cuit_rearmado, 11, 1)) 'tomo el digito verificador
            For i = 1 To 10
                sumador = sumador + Val(Mid(cuit_rearmado, i, 1)) * coeficiente(i)
                'separo cada digito y lo multiplico por el coeficiente
            Next
            resultado = sumador Mod 11
            resultado = 11 - resultado  'saco el digito verificador
            If (resultado = 11) Then resultado = 0
            veri_nro = Val(veri_nro)
            If veri_nro <> resultado Then
                MsgBox("No coincide el dígito verificador. " & str(veri_nro), vbDefaultButton1, "Error en el C.U.I.T.")
            Else
                cuit_rearmado = Mid(cuit_rearmado, 1, 2) & "-" & Mid(cuit_rearmado, 3, 8) & "-" & Mid(cuit_rearmado, 11, 1)
            End If
        End If
        verifica_cuit = cuit_rearmado
    End Function
    Public Sub CargarInicio(ByVal pcdModo As Integer)
        If (pcdModo = 0) Then
            ' modo 0 Insertar Proveedor
            Me.cmdModificar.Enabled = False
            Me.codproveedor = 0

        End If
        If (pcdModo = 1) Then
            If (Me._cdExterior = 1) Then
                Me.chkExterior.Checked = True
            Else
                Me.chkExterior.Checked = False
            End If
            ' modo 1 modificar Proveedor
            Me.txtCuit.Enabled = False
            Me.txtRazonSocial.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
            Me.cmdModificar.Enabled = True
            Me.cmdAgregar.Enabled = False
            Me.AutoCompletarProveedores_Organismo(-1)
        End If

    End Sub
    Public Sub CargarProveedor()
        Try
            Dim arrProv As New List(Of clsProveedores)
            If (cdModo = 0) Then
                oclsProv.cdProveedor = 0
            Else
                oclsProv.cdProveedor = txtcodProv.Text
            End If
            Dim ofrm As New frmIngresarExpedientes()
            oclsProv.dsNroDocumento = Me.txtCuit.Text
            oclsProv.dsRazonSocial = Me.txtRazonSocial.Text
            oclsProv.dsNroBeneficiario = Me.txtNroBeneficiario.Text
            If (Me.chkExterior.Checked = True) Then
                _cdExterior = 1
            Else
                _cdExterior = 0
            End If
            oclsProv.cdExterior = _cdExterior
            arrProv.Add(oclsProv)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarInicio(cdModo)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.cmdAgregar.Enabled = True
        Me.cmdModificar.Enabled = False
        Me.txtCuit.Enabled = True
        Me.txtRazonSocial.Enabled = True
        Me.txtNroBeneficiario.Enabled = True
    End Sub
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Try

            If (Me.txtRazonSocial.Text <> "") Then

                Me.CargarProveedor()
                WS.Proveedor_IU(oclsProv.ToXml)
                _codProv = codproveedor
                MessageBox.Show("El proveedor se agrego con exito")
                Me.Close()
            Else

                MessageBox.Show("Debe ingresar el nombre del proveedor")
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtRazonSocial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Leave
        Try
            CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtNroBeneficiario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroBeneficiario.Leave
        If (Me.txtNroBeneficiario.Text = "" And Me.txtRazonSocial.Text = "") Then
            codproveedor = 0
        ElseIf (Me.txtRazonSocial.Text = "") Then
            Dim ds As New DataSet
            ds = WS.Obtener_Proveedores_Bycuit("", Me.txtNroBeneficiario.Text)
            Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
            Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor")
            Me.txtRazonSocial.Enabled = False
            Me.txtCuit.Enabled = False
            Me.txtNroBeneficiario.Enabled = False
        End If
    End Sub
    Private Sub txtCuit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuit.Leave
        Try
            If (Me.txtCuit.Text = "" Or Me.txtRazonSocial.Text = "") Then
                Me.codproveedor = 0
            ElseIf (Me.txtRazonSocial.Text = "") Then
                If (Me.chkExterior.Checked = True) Then
                Else
                    verifica_cuit(txtCuit.Text)
                End If
                Dim ds As New DataSet
                ds = WS.Obtener_Proveedores_Bycuit(Me.txtCuit.Text, "")
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
                Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor")
                Me.txtRazonSocial.Enabled = False
                Me.txtCuit.Enabled = False
                Me.txtNroBeneficiario.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chkExterior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExterior.CheckedChanged
        Try
            If (Me.chkExterior.Checked = True) Then
                Me._cdExterior = 1
            Else
                Me._cdExterior = 0
            End If
            AutoCompletarProveedores_Organismo(_cdExterior)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class