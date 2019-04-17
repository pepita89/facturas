Public Class clsExpedientes
#Region "Variables y Propiedades"
    Public _cdComprobante, _cdExpediente, _cdProveedor, _cdBaja As Integer
    Public _dsExpediente As String
    Public _dtFecha As DateTime
    Public _cdTipoExpediente As Integer
    Public _dsObservacion As String
    Public _vlImporte As Decimal
    Public _cdAreaGasto As Integer
    Public _codProveedor As Integer
    Public _cdMoneda As Integer
    Public _vlCotizacion As Decimal
    Public _cdExpedienteRel As Integer
    Public ArrComp As New List(Of clsComprobante)
    Private _cdDesglosado As Integer
    Public Property cdDesglosado() As Integer
        Get
            Return _cdDesglosado
        End Get
        Set(ByVal value As Integer)
            _cdDesglosado = value
        End Set
    End Property
    Public Property _arrComp() As List(Of clsComprobante)
        Get
            Return ArrComp
        End Get
        Set(ByVal value As List(Of clsComprobante))
            ArrComp = value
        End Set
    End Property
    Public Property codProveedor() As Integer
        Get
            Return _codProveedor
        End Get
        Set(ByVal value As Integer)
            _codProveedor = value
        End Set
    End Property
    Public Property cdMoneda() As Integer
        Get
            Return _cdMoneda
        End Get
        Set(ByVal value As Integer)
            _cdMoneda = value
        End Set
    End Property
    Public Property vlCotizacion() As Decimal
        Get
            Return _vlCotizacion
        End Get
        Set(ByVal value As Decimal)
            _vlCotizacion = value
        End Set
    End Property

    Public Property cdAreaGasto() As Integer
        Get
            Return _cdAreaGasto
        End Get
        Set(ByVal value As Integer)
            _cdAreaGasto = value
        End Set
    End Property
    Public Property cdComprobante() As Integer
        Get
            Return _cdComprobante
        End Get
        Set(ByVal value As Integer)
            _cdComprobante = value
        End Set
    End Property
    Public Property cdExpediente() As Integer
        Get
            Return _cdExpediente
        End Get
        Set(ByVal value As Integer)
            _cdExpediente = value
        End Set
    End Property
    Public Property cdTipoExpediente() As Integer
        Get
            Return _cdTipoExpediente
        End Get
        Set(ByVal value As Integer)
            _cdTipoExpediente = value
        End Set
    End Property
    Public Property dsObservacion() As String
        Get
            Return _dsObservacion
        End Get
        Set(ByVal value As String)
            _dsObservacion = value
        End Set
    End Property
    Public Property cdProveedor() As Integer
        Get
            Return _cdProveedor
        End Get
        Set(ByVal value As Integer)
            _cdProveedor = value
        End Set
    End Property
    Public Property cdBaja() As Integer
        Get
            Return _cdBaja
        End Get
        Set(ByVal value As Integer)
            _cdBaja = value
        End Set
    End Property
    Public Property dtFecha() As DateTime
        Get
            Return _dtFecha
        End Get
        Set(ByVal value As DateTime)
            _dtFecha = value
        End Set
    End Property
    Public Property vlImporte() As Decimal
        Get
            Return _vlImporte
        End Get
        Set(ByVal value As Decimal)
            _vlImporte = value
        End Set
    End Property
    Public Property dsExpediente() As String
        Get
            Return _dsExpediente
        End Get
        Set(ByVal value As String)
            _dsExpediente = value
        End Set
    End Property
    Public Property cdExpedienteRel() As Integer
        Get
            Return _cdExpedienteRel
        End Get
        Set(ByVal value As Integer)
            _cdExpedienteRel = value
        End Set
    End Property
    Private _Arr As New List(Of clsExpedientes)
    Public Property ArraS() As List(Of clsExpedientes)
        Get
            Return _Arr
        End Get
        Set(ByVal value As List(Of clsExpedientes))
            _Arr = value
        End Set
    End Property
#End Region
    Public Function XmlDesglose() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><ExpedientesComprobantes/>")
        With CType(oXml.SelectSingleNode("ExpedientesComprobantes"), System.Xml.XmlElement)
            For Each obj As clsExpedientes In ArraS
                oXmlItem = oXml.CreateElement("ExpedientesComprobantes")
                oXmlItem.SetAttribute("cdExpediente", obj.cdExpediente)
                oXmlItem.SetAttribute("cdComprobante", obj.cdComprobante)
                oXmlItem.SetAttribute("cdDesglosado", obj.cdDesglosado)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function INSERT_DESGLOSE(ByVal strXml As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
                                                           New Data.SqlClient.SqlParameter("@LastError", 0)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "INSERT_DESGLOSE", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function VALIDAR_DESGLOSE(ByVal pdsNroExp As String) As DataSet


        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dsNroExpediente", pdsNroExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_Valida_Desglose", oParam)
        If (ds.Tables(0).Rows().Count > 0) Then
            Return ds
        End If
        Return ds


    End Function
    Public Function Obtener_TipoExpedientes(ByVal int As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdTipo", int)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_OBTENER_TIPOEXPEDIENTE", oParam)
        If (ds.Tables(0).Rows().Count > 0) Then
            Return ds
        End If
        Return ds
    End Function
    Public Function ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES(ByVal cdComprobante As Integer, ByVal cdExp As Integer, ByVal intError As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdComprobante", cdComprobante), _
                                                                    New Data.SqlClient.SqlParameter("@cdExpediente", cdExp), _
                                                                  New Data.SqlClient.SqlParameter("@lasterror", intError)}
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ELIMINAR_RELACION_EXPEDIENTESCOMPROBANTES", oParam)
        Return ds

    End Function
    Public Function VALIDAR_ANEXADO(ByVal pcdExpediente As Integer) As DataSet


        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExpediente)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "VALIDAR_ANEXADO", oParam)
        If (ds.Tables(0).Rows().Count > 0) Then
            Return ds
        End If
        Return ds


    End Function
    Public Function VALIDAR_INFORMANDOEXPEDIENTEANEXADO(ByVal pcdExpediente As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExpediente)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "VALIDAR_INFORMANDOEXPEDIENTESANEXADO", oParam)
        If (ds.Tables(0).Rows().Count > 0) Then
            Return ds
        End If
        Return ds

    End Function
    'Public Function INSERT_EXPEDIENTES(ByVal strXml As String, ByVal intError As Integer) As DataSet
    '    Try



    '        Dim ds As New DataSet
    '        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
    '                                                       New Data.SqlClient.SqlParameter("@LastError ", intError)}
    '        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_INSERT_EXPEDIENTES", oParam)
    '        Return ds
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    'Public Function UPDATE_EXPEDIENTES(ByVal strXml As String, ByVal intError As Integer) As DataSet
    '    Try

    '        Dim ds As New DataSet
    '        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml), _
    '                                                       New Data.SqlClient.SqlParameter("@LastError ", intError)}
    '        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "Expedientes_U", oParam)
    '        Return ds
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function3




    Public Function Obtener_cdExtediente(ByVal dsExpediente As String) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dsExpediente", dsExpediente)}
        'New Data.SqlClient.SqlParameter("@cdProveedor", cdProv)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "TRAER_cdExpediente", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_BusquedaComprobantes_Asociados(ByVal cdExpediente As Integer, ByVal cdAgrupado As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExpediente), _
                                                      New Data.SqlClient.SqlParameter("@cdAgrupado", cdAgrupado)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_BusquedaComprobantes_Asociados", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_Busqueda_ConvenioOtros(ByVal cdExpediente As Integer, ByVal cdAgrupado As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExpediente), _
                                                       New Data.SqlClient.SqlParameter("@cdAgrupado", cdAgrupado)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_Busqueda_ConvenioOtros", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function BusquedaExpedientes_filtros(ByVal pdsExp As String, ByVal pcdProveedor As Integer, ByVal dtDesde As DateTime, ByVal dthasta As DateTime, ByVal intEstado As Integer, ByVal cdClaseC As Integer, ByVal cdTipoC As Integer, ByVal dsNroComp As String, ByVal dsObservacion As String, ByVal pcdTipoExp As Integer, ByVal pcdNoLiq As Integer, ByVal pcdArea As Integer, ByVal pcdAreaMov As Integer, ByVal pcdSinRel As Integer, ByVal pcdEtapa As Integer) As DataSet
        ', ByVal intFecha As Integer
        '  New Data.SqlClient.SqlParameter("@intSinFecha", intFecha), _
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dsNroExpediente", pdsExp), _
                                                       New Data.SqlClient.SqlParameter("@cdProveedor", pcdProveedor), _
                                                       New Data.SqlClient.SqlParameter("@dtDesde", dtDesde), _
                                                       New Data.SqlClient.SqlParameter("@dtHasta", dthasta), _
                                                      New Data.SqlClient.SqlParameter("@cdEstado", intEstado), _
                                                      New Data.SqlClient.SqlParameter("@cdClaseC", cdClaseC), _
                                                      New Data.SqlClient.SqlParameter("@cdTipoC", cdTipoC), _
                                                      New Data.SqlClient.SqlParameter("@dsNroComprobante", dsNroComp), _
                                                      New Data.SqlClient.SqlParameter("@dsObservacion", dsObservacion), _
                                                      New Data.SqlClient.SqlParameter("@cdTipoExpediente", pcdTipoExp), _
                                                      New Data.SqlClient.SqlParameter("@cdSinLiquidar", pcdNoLiq), _
                                                      New Data.SqlClient.SqlParameter("@cdArea", pcdArea), _
                                                      New Data.SqlClient.SqlParameter("@cdAreaMov", pcdAreaMov), _
                                                      New Data.SqlClient.SqlParameter("@cdSinExpRelacion", pcdSinRel), _
                                                       New Data.SqlClient.SqlParameter("@cdEtapa", pcdEtapa)}
        ' ByVal pcdEtapa As Integer
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_EXPEDIENTES", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    'Public Function DELETE_EXPEDIENTES(ByVal pcdExp As Integer, ByVal pcdComp As Integer, ByVal intError As Integer) As DataSet
    '    Try
    '        Dim ds As New DataSet
    '        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp), _
    '                                                    New Data.SqlClient.SqlParameter("@cdCom", pcdComp), _
    '                                                       New Data.SqlClient.SqlParameter("@LastError ", intError)}
    '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "EXPEDIENTES_D", oParam)
    '        Return ds
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Public Function DELETE_EXPEDIENTE_RELACIONES(ByVal pcdExp As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "EXPEDIENTES_D", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ToXml() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            For Each obj As clsExpedientes In ArraS
                oXmlItem = oXml.CreateElement("row")
                oXmlItem.SetAttribute("cdExpediente", obj.cdExpediente)
                oXmlItem.SetAttribute("dsNroExpediente", obj.dsExpediente)
                oXmlItem.SetAttribute("cdTipoExpediente", obj.cdTipoExpediente)
                oXmlItem.SetAttribute("dtFecha", obj.dtFecha.ToString("yyyyMMdd"))
                oXmlItem.SetAttribute("cdProveedor", obj.cdProveedor)
                oXmlItem.SetAttribute("sObservacion", obj.dsObservacion)
                oXmlItem.SetAttribute("cdAreaGasto", obj.cdAreaGasto)
                oXmlItem.SetAttribute("cdBaja", obj.cdBaja)
                oXmlItem.SetAttribute("cdExpedienteRel", obj.cdExpedienteRel)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function INSERT_EXPEDIENTES(ByVal strXml As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "Expedientes_IU", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_TOOLTIP_OBSERVACION(ByVal cdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TOOLTIP_OBSERVACION", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function Obtener_dsExtedienteRel(ByVal pcdExpediente As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExpediente)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "select_dsNroExpedienteRel", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_BusquedaComprobantes_Rel(ByVal cdExp As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_BusquedaComprobantes_AsociadosRel", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_BusquedaComprobantes_Todos(ByVal cdExp As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", cdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_BusquedaComprobantes_Todos", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
End Class
