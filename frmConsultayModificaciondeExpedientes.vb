Imports clsFacturas
Imports System.Text.RegularExpressions
Public Class frmConsultayModificaciondeExpedientes
    Public intFecha As Integer
    Public _EsExterior As Integer
    Public codArea As Integer
    Public codAreaM As Integer
    Private ArrAreas As New ArrayList
    Private ArrAreasM As New ArrayList
    Public strArea As String = ""
    Public Property EsExterior()
        Get
            Return _EsExterior
        End Get
        Set(ByVal value)
            _EsExterior = value
        End Set
    End Property
#Region "Variables y Propiedades"
    Private _codproveedor As Integer
    Public _codExpediente As Integer
    Private ArrProveedor As New ArrayList
    Public Property codproveedor() As Integer
        Get
            Return _codproveedor
        End Get
        Set(ByVal value As Integer)
            _codproveedor = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub CargarEtapa()
        Try
            Dim dt As New DataTable()
            Dim dtColum As New DataColumn("cdValor")
            Dim dtColum2 As New DataColumn("dsValor")
            dt.Columns.Add(dtColum)
            dt.Columns.Add(dtColum2)
            Dim dr As DataRow = dt.NewRow()
            dr("dsValor") = "Todos"
            dr("cdValor") = "-1"
            dt.Rows.Add(dr)
            Dim ds As New DataSet
            ds = WS.Obtener_Etapa(-1)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim dr2 As DataRow = dt.NewRow()
                dr2("dsValor") = ds.Tables(0).Rows(d).Item("dsValor").ToString()
                dr2("cdValor") = ds.Tables(0).Rows(d).Item("cdValor").ToString()
                dt.Rows.Add(dr2)
            Next d

            Me.cboEtapa.DisplayMember = "dsValor"
            Me.cboEtapa.ValueMember = "cdValor"
            Me.cboEtapa.DataSource = dt
            Me.cboEtapa.SelectedValue = -1

        Catch ex As Exception
        End Try
    End Sub
    Sub CargarTipoExpediente()
        Try
            Dim dt As New DataTable()
            Dim dtColum As New DataColumn("cdValor")
            Dim dtColum2 As New DataColumn("dsValor")
            dt.Columns.Add(dtColum)
            dt.Columns.Add(dtColum2)
            Dim dr As DataRow = dt.NewRow()
            dr("dsValor") = "Todos"
            dr("cdValor") = "-1"
            dt.Rows.Add(dr)
            Dim ds As New DataSet
            ds = WS.Obtener_TipoExpediente(1)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim dr2 As DataRow = dt.NewRow()
                dr2("dsValor") = ds.Tables(0).Rows(d).Item("dsValor").ToString()
                dr2("cdValor") = ds.Tables(0).Rows(d).Item("cdValor").ToString()
                dt.Rows.Add(dr2)
            Next d
            Me.cboTipoExpediente.DisplayMember = "dsValor"
            Me.cboTipoExpediente.ValueMember = "cdValor"
            Me.cboTipoExpediente.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub AutoCompletarProveedores_Organismo(ByVal Exterior As Integer)

        Me.txtRazonSocial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim i As Integer
        Dim DatRubro As System.Data.DataSet
        DatRubro = WS.Obtener_Proveedores_Organismos(Exterior, 0)
        For i = 0 To DatRubro.Tables(0).Rows.Count - 1
            Dim obj As New clsFacturas.clsProveedor
            obj.cdProveedor = DatRubro.Tables(0).Rows(i).Item("cdProveedor")
            obj.dsProveedor = DatRubro.Tables(0).Rows(i).Item("dsProveedor")
            obj.dsCuit = DatRubro.Tables(0).Rows(i).Item("dsCuit")
            Me.txtRazonSocial.AutoCompleteCustomSource.Add(obj.dsProveedor)
            ArrProveedor.Add(obj)

        Next i

    End Sub
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
    Function AutoCompletarProveedor(ByVal dsNombre As String) As clsProveedor
        Dim oProveedor As New clsProveedor
        For Each obj As clsProveedor In ArrProveedor
            If obj.dsProveedor.ToUpper() = dsNombre.ToUpper() Then
                oProveedor.dsProveedor = obj.dsProveedor
                oProveedor.dsCuit = obj.dsCuit
                oProveedor.cdProveedor = obj.cdProveedor
            End If
        Next
        Return oProveedor
    End Function
    Sub CompletarRazonSocial(ByVal txtCuit As String, ByVal txtNombre As String, ByVal txtCod As Integer)
        If Me.txtCuit.Text.Length <> 0 Then
            Dim org As clsProveedor = AutoCompletarPorCuit(txtCuit)
            If org.dsProveedor <> "" Then
                Me.txtCuit.Text = org.dsCuit
                txtCod = org.cdProveedor
                Me.txtRazonSocial.Text = org.dsProveedor

            End If
        End If

    End Sub
    Sub CompletarCuit(ByVal txtProve As String, ByVal txtcuit As String)
        If Me.txtRazonSocial.Text.Length <> 0 Then
            Dim Prov As clsProveedor = AutoCompletarProveedor(txtRazonSocial.Text) 'AutoCompletarPorCuit(Me.txtCuitProveedor.TextBox.Text)
            If Prov.dsProveedor <> "" Then
                txtRazonSocial.Text = Prov.dsProveedor
                If (Prov.dsCuit = " ") Then
                Else
                    Me.txtCuit.Text = Prov.dsCuit
                End If
                codproveedor = Prov.cdProveedor
            End If
        End If
    End Sub
    Sub CargarEstados()
        Try
            Dim dt As New DataTable()
            Dim dtColum As New DataColumn("cdEstado")
            Dim dtColum2 As New DataColumn("dsEstado")
            dt.Columns.Add(dtColum)
            dt.Columns.Add(dtColum2)
            Dim dr As DataRow = dt.NewRow()
            dr("dsEstado") = "Todos"
            dr("cdEstado") = "-1"
            dt.Rows.Add(dr)
            Dim ds As New DataSet
            ds = WS.Obtener_Estados(-1)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim dr2 As DataRow = dt.NewRow()
                dr2("dsEstado") = ds.Tables(0).Rows(d).Item("dsEstado").ToString()
                dr2("cdEstado") = ds.Tables(0).Rows(d).Item("cdEstado").ToString()
                dt.Rows.Add(dr2)
            Next d
            Me.cboEstadoE.DisplayMember = "dsEstado"
            Me.cboEstadoE.ValueMember = "cdEstado"
            Me.cboEstadoE.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public  Sub BUSCARCOMPROBANTES()
        Try
            If (Me.txtCuit.Text = "" And Me.txtRazonSocial.Text = "") Then
                codproveedor = -1
            End If

            If (Me._codExpediente = 0) Then
                _codExpediente = -1
            End If
            Dim ds As New DataSet()
            Dim intNoPendientes As Integer = -1
            If (Me.CheckBox1.Checked = True) Then
                intNoPendientes = -2
            Else
                intNoPendientes = -1
            End If
            If (Me.mtxtAreaE.Text = "") Then
                Me.codArea = -1
            End If
            If (Me.MtxtAreaMovimiento.Text = "") Then
                Me.codAreaM = -1
            End If
            Dim cdSinExpRelacion As Integer
            If (Me.ckbSinExpRel.Checked = True) Then
                cdSinExpRelacion = -1
            Else
                cdSinExpRelacion = -2
            End If
            Dim etapa As Integer
            If (cboEtapa.Text = "Todos") Then
                etapa = -1
            Else
                etapa = Me.cboEtapa.SelectedValue
            End If

            'ds = WS.BusquedaFiltradaExpedientes(Me.txtExpediente.Text, codproveedor, Me.dtDesde.Value.Date, Me.dtHasta.Value.Date, Me.cboClaseC.SelectedValue, Me.cboTipoC.SelectedValue, Me.txtNroComprobante.Text, Me.txtObservacion.Text, Me.cboTipoExpediente.SelectedValue, intNoPendientes, Me.codArea, Me.codAreaM, cdSinExpRelacion, etapa)
            ds = WS.BusquedaFiltradaExpedientes(Me.txtExpediente.Text, codproveedor, Me.dtDesde.Value.Date, Me.dtHasta.Value.Date, Me.cboEstadoE.SelectedValue, Me.cboClaseC.SelectedValue, Me.cboTipoC.SelectedValue, Me.txtNroComprobante.Text, Me.txtObservacion.Text, Me.cboTipoExpediente.SelectedValue, intNoPendientes, Me.codArea, Me.codAreaM, cdSinExpRelacion, etapa)
            Dim ocls As New clsProveedores
            If ds.Tables(0).Rows.Count > 0 Then
                Dim int As Integer
                int = ds.Tables(0).Rows.Count.ToString()
                Me.dgvlistadoExpedientes.DataSource = ds.Tables(0)
                Me.lblCantExp.Text = "Se encontraron " + int.ToString() + " Expedientes"
                Me.dgvlistadoExpedientes.DefaultCellStyle.ForeColor = Color.Black
            Else
                Me.lblCantExp.Text = "Se encontraron 0 Expedientes"
                Me.dgvlistadoExpedientes.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarClaseComprobante(ByVal cdComp As Integer)
        Try
            Dim dt As New DataTable()
            Dim dtColum As New DataColumn("cdClaseComprobante")
            Dim dtColum2 As New DataColumn("dsClaseComprobante")
            dt.Columns.Add(dtColum)
            dt.Columns.Add(dtColum2)
            Dim dr As DataRow = dt.NewRow()
            dr("dsClaseComprobante") = "Todos"
            dr("cdClaseComprobante") = "-1"
            dt.Rows.Add(dr)
            Dim ds As New DataSet
            ds = WS.Obtener_ClaseComprobantes(cdComp)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.txtGrupo.Text = ds.Tables(0).Rows(d).Item("cdGrupo")
                Dim dr2 As DataRow = dt.NewRow()
                dr2("dsClaseComprobante") = ds.Tables(0).Rows(d).Item("dsClaseComprobante").ToString()
                dr2("cdClaseComprobante") = ds.Tables(0).Rows(d).Item("cdClaseComprobante").ToString()
                dt.Rows.Add(dr2)
            Next d
            Me.cboClaseC.DisplayMember = "dsClaseComprobante"
            Me.cboClaseC.ValueMember = "cdClaseComprobante"
            Me.cboClaseC.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarTipoComprobante(ByVal cdGrupo As Integer)
        Try

            Dim dt As New DataTable()
            Dim dtColum As New DataColumn("cdTipoComprobante")
            Dim dtColum2 As New DataColumn("dsTipoComprobante")
            dt.Columns.Add(dtColum)
            dt.Columns.Add(dtColum2)
            Dim dr As DataRow = dt.NewRow()
            dr("dsTipoComprobante") = "Todos"
            dr("cdTipoComprobante") = "-1"
            dt.Rows.Add(dr)
            Dim ds As New DataSet
            ds = WS.Obtener_TipoComprobantes(cdGrupo)
            For d As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim dr2 As DataRow = dt.NewRow()
                dr2("dsTipoComprobante") = ds.Tables(0).Rows(d).Item("dsTipoComprobante").ToString()
                dr2("cdTipoComprobante") = ds.Tables(0).Rows(d).Item("cdTipoComprobante").ToString()
                dt.Rows.Add(dr2)
            Next d
            Me.cboTipoC.DisplayMember = "dsTipoComprobante"
            Me.cboTipoC.ValueMember = "cdTipoComprobante"
            Me.cboTipoC.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function getCodArea(ByVal pNombreArea As String) As Integer
        Try
            Dim ds As System.Data.DataSet
            Dim i As Integer
            ds = WS.Obtener_Areas(-1, pNombreArea)
            If (ds.Tables(0).Rows().Count > 0) Then
                Return ds.Tables(0).Rows(i).Item("cdArea")
            End If
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Public Sub CargarAreasNombre()
        Dim ds As System.Data.DataSet
        Dim i As Integer
        mtxtAreaE.TextBox.AutoCompleteCustomSource.Clear()
        ArrAreas.Clear()
        Me.MtxtAreaMovimiento.TextBox.AutoCompleteCustomSource.Clear()
        ArrAreasM.Clear()

        ds = WS.Obtener_Areas(-1, "")
        If Not IsNothing(ds.Tables(0)) Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim ocls As New clsAreas
                ocls.cdArea = ds.Tables(0).Rows(i).Item("cdArea")
                ocls.dsArea = ds.Tables(0).Rows(i).Item("dsArea")
                mtxtAreaE.TextBox.AutoCompleteCustomSource.Add(ocls.dsArea)
                Me.MtxtAreaMovimiento.TextBox.AutoCompleteCustomSource.Add(ocls.dsArea)
                ArrAreas.Add(ocls)
                ArrAreasM.Add(ocls)
                strArea = Me.mtxtAreaE.Text
                strArea = MtxtAreaMovimiento.Text
            Next i
        End If
    End Sub
#End Region
    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        _Modo = 0
        Me.Close()
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
            MsgBox("No están todos los dígitos. ", vbDefaultButton1, "Error en el C.U.I.T.")
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
                MsgBox("No coincide el dígito verificador. " & Str(veri_nro), vbDefaultButton1, "Error en el C.U.I.T.")
            Else
                cuit_rearmado = Mid(cuit_rearmado, 1, 2) & "-" & Mid(cuit_rearmado, 3, 8) & "-" & Mid(cuit_rearmado, 11, 1)
            End If
        End If
        verifica_cuit = cuit_rearmado
    End Function
    Private Sub txtCuit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuit.Leave
        Try
            If (txtCuit.Text <> "" And Me.txtRazonSocial.Text = "") Then
                Dim ds As New DataSet
                ds = WS.Obtener_Proveedores_Bycuit(Me.txtCuit.Text, "")
                Me.txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("dsRazonSocial")
                Me.codproveedor = ds.Tables(0).Rows(0).Item("cdProveedor")
            ElseIf (Me.txtRazonSocial.Text = "" And txtCuit.Text = "") Then
                Me.codproveedor = -1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmConsultayModificaciondeExpedientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ckbSinExpRel.Checked = True
            _Formulario = 4
            CargarEstados()
            CargarClaseComprobante(-1)
            CargarTipoComprobante(1)
            CargarTipoExpediente()
            Me.dtDesde.Value = DateTime.Today.AddDays(-30)
            dtHasta.Value = DateTime.Today
            AutoCompletarProveedores_Organismo(-1)
            CargarAreasNombre()
            CargarEtapa()
            BUSCARCOMPROBANTES()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function ValidarFormatoComprobante(ByVal dsClaseComprobante As String, ByVal strNroComp As String) As String
        ValidarFormatoComprobante = ""
        If strNroComp <> " " Then
            Select Case dsClaseComprobante
                Case "FC"
                    If EsExterior <> 0 Then
                        Dim rx As New Regex("[0-9]{1,4}(-)[0-9]{1,8}")
                        If Not (rx.IsMatch(strNroComp)) Then
                            ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf

                        End If
                    End If
                Case "TK"
                    If EsExterior <> 0 Then
                        Dim rx As New Regex("[0-9]{1,4}(-)[0-9]{1,8}")
                        If Not (rx.IsMatch(strNroComp)) Then
                            ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf

                        End If
                    End If
                Case "ND"
                    Dim rx As New Regex("[0-9]{1,4}(-)[0-9]{1,8}")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf

                    End If
                Case "NC"
                    If EsExterior <> 0 Then
                        Dim rx As New Regex("[0-9]{1,4}(-)[0-9]{1,8}")
                        If Not (rx.IsMatch(strNroComp)) Then
                            ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 9999-99999999 , Ejemplo : 0001-12345678" & vbCrLf

                        End If
                    End If
                Case "RE"
                    Dim rx As New Regex("[0-9]{1,8}")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato 99999999, Ejemplo: 456" & vbCrLf

                    End If
                Case "LE"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If


                Case "DE"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "AA"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "OC"
                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{2,4}")

                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El Nro.Comprobante debe tener el siguiente formato NNNN/YYYY , Ejemplo : 95/2009" & vbCrLf
                    Else
                        Dim arrnrocomp As String() = strNroComp.Split("/")
                        Dim nro As Integer = arrnrocomp.GetValue(1).ToString()
                        Dim dtnro As Date = Date.Parse("01/01/" & nro)
                        If Not ((dtnro.Year > 1900) And (dtnro.Year < 2100)) Then
                            ValidarFormatoComprobante = ValidarFormatoComprobante & "El Año del Nro. de Comprobante debe esta comprendido entre 1900 y 2100 "
                        End If
                    End If
                Case "ME"
                Case "CC"

                    Dim rx As New Regex("[0-9]{1,5}(/)[0-9]{1,2}(-C.)[0-9]{1,5}")
                    If Not (rx.IsMatch(strNroComp)) Then
                        ValidarFormatoComprobante = "El formato debe ser [Nro Caja Chica]/[Año]-C.[Nro. Orden del Comprobante], Ejemplo: 24/09-C.3" & vbCrLf
                    End If



            End Select

        End If






        Return ValidarFormatoComprobante

    End Function
    Public Function AutoFormatoComprobante(ByVal dsClaseComprobante As String, ByVal strNroComp As String) As String
        AutoFormatoComprobante = strNroComp
        Select Case dsClaseComprobante
            Case "FC"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                        AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(1).Length = 8, arrnrocomp(1), arrnrocomp(1).PadLeft(8, "0"))
                    End If
                End If
            Case "TK"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                        AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(1).Length = 8, arrnrocomp(1), arrnrocomp(1).PadLeft(8, "0"))
                    End If
                End If
            Case "ND"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                        AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(1).Length = 8, arrnrocomp(1), arrnrocomp(1).PadLeft(8, "0"))
                    End If
                End If
            Case "NC"
                If EsExterior = 0 Then
                    Dim arrnrocomp As String() = strNroComp.Split("-")
                    If arrnrocomp.Length = 2 Then
                        AutoFormatoComprobante = IIf(arrnrocomp(0).Length = 4, arrnrocomp(0), arrnrocomp(0).PadLeft(4, "0"))
                        AutoFormatoComprobante = AutoFormatoComprobante & "-" & IIf(arrnrocomp(1).Length = 8, arrnrocomp(1), arrnrocomp(1).PadLeft(8, "0"))
                    End If
                End If
            Case "RE"

            Case "LE"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If
            Case "DE"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If
            Case "AA"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)


                        End If

                    End If
                End If
            Case "OC"
                Dim arrnrocomp As String() = strNroComp.Split("/")
                If arrnrocomp.Length = 2 Then
                    AutoFormatoComprobante = arrnrocomp(0)
                    If arrnrocomp(1).Length = 4 Then
                        AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1).Substring(2, 2)
                    Else
                        If arrnrocomp(1).Length = 4 Or arrnrocomp(1).Length = 2 Then
                            AutoFormatoComprobante = AutoFormatoComprobante & "/" & arrnrocomp(1)
                        End If

                    End If
                End If


            Case "ME"
            Case "CC"
                AutoFormatoComprobante = strNroComp.ToUpper()

        End Select
        Return AutoFormatoComprobante
    End Function
    Private Sub txtRazonSocial_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRazonSocial.Leave
        Try
            CompletarCuit(Me.txtRazonSocial.Text, Me.txtCuit.Text)
            'If (Me.txtExpediente.Text <> "" And Me.txtRazonSocial.Text <> "") Then
            '    Dim ds As New DataSet()
            '    ds = WS.Obtener_codExpediente(Me.txtExpediente.Text, Me.codproveedor)
            '    If ds.Tables(0).Rows.Count > 0 Then
            '        _codExpediente = ds.Tables(0).Rows(0).Item("cdExpediente")
            '    End If
            'ElseIf (Me.txtRazonSocial.Text = "" And Me.txtCuit.Text = "") Then
            '    Me.codproveedor = -1
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub cmdbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbuscar.Click
        Try
            BUSCARCOMPROBANTES()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvlistadoExpedientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlistadoExpedientes.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case Me.colEdit.Index
                    Dim ofrm As New frmIngresarExpedientes
                    If (Me.dgvlistadoExpedientes.DataSource.Rows().Count > 0) Then
                        _Modo = 2
                        ofrm.txtNroExpediente.Text = dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsNroExpediente").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                        ofrm._cdExpediente = dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                        ofrm._cdTipo = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdTipoExpediente").Value.ToString() 'dt.Rows(0).Item("dsNroComprobante")

                        ofrm.codproveedor = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdProveedor").Value 'dt.Rows(0).Item("dsRazonSocial")
                            ofrm.txtCuit.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsCuit").Value
                            ofrm.txtRazonSocial.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsRazonSocial").Value.ToString()
                            ofrm._Chk = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEsExterior").Value()
                            ofrm.fecha = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dtFecha").Value()
                            ofrm.txtNroBeneficiario.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsNroBeneficiario").Value.ToString()
                            ofrm.codAreaE = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdArea").Value.ToString()
                            ofrm.mtxtAreaE.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsArea").Value.ToString()
                            If (Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString() = "") Then
                                ofrm.txtcdNroExpedienteRel.Text = 0
                                ofrm._cdExpRel = 0
                            Else
                                ofrm.txtcdNroExpedienteRel.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString()
                                ofrm.txtNroExpedienteRel.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsExpedienteRel").Value.ToString()
                                ofrm.dsNroRel = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsExpedienteRel").Value.ToString()
                                ofrm._cdExpRel = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString()
                            End If
                            ofrm.MdiParent = frmMenu
                            '_Formulario = 4
                            ofrm.StartPosition = FormStartPosition.Manual
                            Me.AutoScroll = False
                            ' Me.Close()
                            ofrm.Show()
                        End If
                        Case Me.colEliminar.Index
                    Dim ofrm As New frmIngresarExpedientes
                    If (Me.dgvlistadoExpedientes.DataSource.Rows().Count > 0) Then
                        _Modo = 3
                        Dim cdEsta As Integer
                        If (Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEstado").Value.ToString() <> Nothing) Then
                            cdEsta = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEstado").Value.ToString()

                        Else
                            cdEsta = 1
                        End If

                        If (cdEsta = 1) Then
                            ofrm.txtNroExpediente.Text = dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsNroExpediente").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                            ofrm._cdExpediente = dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value.ToString() 'dgvlistado.Rows().Item("cdComprobante")
                            ofrm._cdTipo = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdTipoExpediente").Value.ToString() 'dt.Rows(0).Item("dsNroComprobante")
                            ofrm.codproveedor = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdProveedor").Value 'dt.Rows(0).Item("dsRazonSocial")
                            ofrm.txtCuit.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsCuit").Value
                                ofrm.txtRazonSocial.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsRazonSocial").Value.ToString()
                                ofrm._Chk = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEsExterior").Value()




                                ofrm.fecha = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dtFecha").Value()
                                ofrm.codAreaE = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdArea").Value.ToString()
                                ofrm.mtxtAreaE.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsArea").Value.ToString()
                                ofrm.txtNroBeneficiario.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsNroBeneficiario").Value.ToString()
                                If (Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString() = "") Then
                                    ofrm.txtcdNroExpedienteRel.Text = 0
                                    ofrm._cdExpRel = 0
                                Else
                                    ofrm.txtcdNroExpedienteRel.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString()
                                    ofrm.txtNroExpedienteRel.Text = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsExpedienteRel").Value.ToString()
                                    ofrm.dsNroRel = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsExpedienteRel").Value.ToString()
                                    ofrm._cdExpRel = Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpedienteRel").Value.ToString()
                                End If
                                ofrm.MdiParent = frmMenu
                                ofrm.StartPosition = FormStartPosition.Manual
                                Me.AutoScroll = False
                                ofrm.Show()
                                '  Me.Close()
                            Else
                                MessageBox.Show("No se puede eliminar el expediente seleccionado, ya que su seguimiento supera el estado ingresado")
                        End If

                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtRazonSocial.Text = ""
        Me.txtCuit.Text = ""
        Me.codproveedor = 0
        Me.txtNroComprobante.Text = ""
        Me.CheckBox1.Checked = False
        Me.txtObservacion.Text = ""
        Me.txtExpediente.Text = ""
        Me.dtDesde.Value = Today
        Me.dtDesde.Checked = False
        Me.dtHasta.Value = Today
        Me.dtHasta.Checked = False
        AutoCompletarProveedores_Organismo(-1)
        CargarEstados()
        CargarClaseComprobante(-1)
        CargarTipoComprobante(-1)
        BUSCARCOMPROBANTES()
    End Sub
    Private Sub cboEstadoE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoE.SelectedIndexChanged

    End Sub
    Private Sub cboClaseC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClaseC.SelectedIndexChanged
        Try
            Dim ds As DataSet
            ds = WS.Obtener_ClaseComprobantes(Me.cboClaseC.SelectedValue)
            '
            Dim i As Integer
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Me.txtGrupo.Text = ds.Tables(0).Rows(i).Item("cdGrupo")
                Next
            End If
            If (Me.txtGrupo.Text <> "") Then
                Me.CargarTipoComprobante(Me.txtGrupo.Text)
                '  Me.CargarTipoComprobante(1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboTipoC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoC.SelectedIndexChanged

    End Sub
    Private Sub dtDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDesde.ValueChanged

    End Sub
    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroComprobante.Leave
        Try
            If (Me.txtNroComprobante.Text <> "" And Me.cboClaseC.SelectedValue <> -1 And Me.cboTipoC.SelectedValue <> -1) Then
                Dim strComp As String = Me.AutoFormatoComprobante(Me.cboClaseC.Text, Me.txtNroComprobante.Text)
                Dim str As String = ValidarFormatoComprobante(Me.cboClaseC.Text, strComp)
                If str <> "" Then
                    MessageBox.Show(str)
                    txtNroComprobante.Text = ""
                    txtNroComprobante.Focus()
                Else
                    txtNroComprobante.Text = strComp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmConsultayModificaciondeExpedientes_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.dtDesde.Value = DateTime.Today.AddDays(-30)
        dtHasta.Value = DateTime.Today

        ' Me.intFecha = 1
    End Sub

    Private Sub mtxtAreaE_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtxtAreaE.Leave
        Try
            codArea = getCodArea(mtxtAreaE.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvlistadoExpedientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvlistadoExpedientes.CellFormatting
        Try
            If (Me.dgvlistadoExpedientes.Rows.Count > 0) Then
                For Each fila As DataGridViewRow In dgvlistadoExpedientes.Rows

                    Select Case dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEstado").Value
                        Case 4
                            e.CellStyle.BackColor = Color.Plum
                        Case 5
                            e.CellStyle.BackColor = Color.LightBlue
                    End Select

                Next

                '    Select Case dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdEstado").Value
                '        Case 4
                '            e.CellStyle.BackColor = Color.Plum
                '        Case 5
                '            e.CellStyle.BackColor = Color.LightBlue
                '    End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MtxtAreaMovimiento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MtxtAreaMovimiento.Leave
        codAreaM = getCodArea(Me.MtxtAreaMovimiento.Text)
    End Sub
    Private Sub dgvlistadoExpedientes_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlistadoExpedientes.CellMouseEnter
        Try

            If (e.RowIndex > -1 And e.ColumnIndex > -1) Then
                If (dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value <> Nothing) Then

                    With Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("dsComprobantes")
                        If .ToolTipText = "" Then
                            Dim ds As DataSet

                            ds = WS.SP_TOOLTIP_COMPROBANTES(dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value)
                            .ToolTipText = ds.Tables(0).Rows(0).Item("valores").ToString()
                        End If
                    End With
                End If
                Dim i As Integer

                If (dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdSeguimiento").Value <> 0) Then

                    With Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdMovExpediente")

                        If .ToolTipText = "" Then
                            Dim ds As New DataSet
                            ds = WS.SP_TOOLTIP_MovimientosDelExpediente(dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdSeguimiento").Value)
                            .ToolTipText = ds.Tables(0).Rows(0).Item("cdMovExpediente").ToString()
                        End If
                    End With
                End If
                If (dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value) Then
                    With Me.dgvlistadoExpedientes.Rows(e.RowIndex).Cells("sObservacion")
                        If .ToolTipText = "" Then
                            Dim ds As New DataSet
                            ds = WS.SP_TOOLTIP_OBSERVACION(dgvlistadoExpedientes.Rows(e.RowIndex).Cells("cdExpediente").Value)
                            .ToolTipText = ds.Tables(0).Rows(0).Item("sObservacion").ToString()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tsMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMenu.Click
        Me.txtRazonSocial.Text = ""
        Me.txtGrupo.Text = ""
        _Formulario = 4
        Me.txtNroComprobante.Text = ""
        Me.CheckBox1.Checked = False
        Me.txtObservacion.Text = ""
        Me.MtxtAreaMovimiento.Text = ""
        Me.mtxtAreaE.Text = ""
        Me.txtCuit.Text = ""
        Me.txtExpediente.Text = ""
        CargarEstados()
        CargarClaseComprobante(-1)
        CargarTipoComprobante(1)
        CargarTipoExpediente()
        Me.dtDesde.Value = DateTime.Today.AddDays(-30)
        dtHasta.Value = DateTime.Today
        AutoCompletarProveedores_Organismo(-1)
        CargarAreasNombre()
        BUSCARCOMPROBANTES()
    End Sub


    Public Sub cambiocolortabla()
        Try
            Dim ds As New DataTable
            ds = dgvlistadoExpedientes.DataSource

            Select Case ds.Rows(0).Item("cdEstado").Value


                Case 4
                    MessageBox.Show(4)
                Case 5

            End Select





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
