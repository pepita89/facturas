Public Class clsSeguimientoExpedientes

    Public _codSeguimiento As Integer
    Public _codExpediente As Integer
    Public _cdEstado As Integer
    Public _dsEstado As String
    Public _dtFecha As DateTime
    Public _cdArea As Integer
    Public _dsArea As String
    Public _cdBaja As Integer
    Public _sObservaciones As String
    Public _cdEtapa As Integer
    Public _dsEtapa As String

    Private _Arr As New List(Of clsSeguimientoExpedientes)

    Public Property ArraS() As List(Of clsSeguimientoExpedientes)
        Get
            Return _Arr
        End Get
        Set(ByVal value As List(Of clsSeguimientoExpedientes))
            _Arr = value
        End Set
    End Property


    Public Property codSeguimiento() As Integer
        Get
            Return _codSeguimiento
        End Get
        Set(ByVal value As Integer)
            _codSeguimiento = value
        End Set
    End Property
    Public Property codExpediente() As Integer
        Get
            Return _codExpediente
        End Get
        Set(ByVal value As Integer)
            _codExpediente = value
        End Set
    End Property
    Public Property cdEstado() As Integer
        Get
            Return _cdEstado
        End Get
        Set(ByVal value As Integer)
            _cdEstado = value
        End Set
    End Property
    Public Property dsEstado() As String
        Get
            Return _dsEstado
        End Get
        Set(ByVal value As String)
            _dsEstado = value
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

    Public Property cdArea() As Integer
        Get
            Return _cdArea
        End Get
        Set(ByVal value As Integer)
            _cdArea = value
        End Set
    End Property
    Public Property dsArea() As String
        Get
            Return _dsArea
        End Get
        Set(ByVal value As String)
            _dsArea = value
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
    Public Property sObservaciones() As String
        Get
            Return _sObservaciones
        End Get
        Set(ByVal value As String)
            _sObservaciones = value
        End Set
    End Property
    Public Property cdEtapa() As Integer
        Get
            Return _cdEtapa
        End Get
        Set(ByVal value As Integer)
            _cdEtapa = value
        End Set
    End Property
    Public Property dsEtapa() As String
        Get
            Return _dsEtapa
        End Get
        Set(ByVal value As String)
            _dsEtapa = value
        End Set
    End Property
    'SELECT_ULTIMO_ESTADO 
    ' UpdateSeguimiento
    Public Function UpdateSeguimiento(ByVal pcdSeg As Integer, ByVal sObs As String) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdSeguimiento", pcdSeg), _
                                                        New Data.SqlClient.SqlParameter("@sObservaciones", sObs)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "UpdateSeguimiento", oParam)
        Return ds

    End Function
    Public Function SP_OBTENER_ULTIMO_ESTADO(ByVal pcdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SELECT_ULTIMO_ESTADO", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_UltimaEtapa(ByVal pcdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "Select_UltimaEtapa", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_ESTADOS_ByEXPEDIENTE(ByVal pcdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "OBTENER_ESTADOS_BycdExpediente", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function SP_ToolTip_MovimientoDelExpediente(ByVal pcdSeg As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdSeguimiento", pcdSeg)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TOOLTIP_MOVIMIENTOS", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ToXml() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            For Each obj As clsSeguimientoExpedientes In ArraS
                oXmlItem = oXml.CreateElement("row")
                oXmlItem.SetAttribute("cdSeguimiento", obj.codSeguimiento)
                oXmlItem.SetAttribute("cdExpediente", obj.codExpediente)
                oXmlItem.SetAttribute("cdEstado", obj.cdEstado)
                oXmlItem.SetAttribute("dtFecha", obj.dtFecha.ToString("yyyyMMdd"))
                oXmlItem.SetAttribute("cdArea", obj.cdArea)
                oXmlItem.SetAttribute("cdBaja", obj.cdBaja)
                oXmlItem.SetAttribute("sObservaciones", obj.sObservaciones)
                oXmlItem.SetAttribute("cdEtapa", obj.cdEtapa)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function INSERT_SEGUIMIENTO_ESTADO(ByVal strXml As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ExpedientesSeguimiento_IU", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'SELECT_ULTIMO_ESTADO 
    Public Function DELETE_MOVIMIENTOS(ByVal pcdSeg As Integer, ByVal pcdExp As Integer) As DataSet
        Try
            Dim ds As New DataSet()
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdSeguimiento", pcdSeg), _
                                                           New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "DELETE_MOVIENTOS", oParam)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Public Function OBTENER_ETAPA(ByVal pcdValor As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdValor", pcdValor)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_ETAPA", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
End Class
Public Class ClsSolicitudes

    Public _cdSolicitud As Integer
    Public _cdSolicitudEstado As Integer
    Public _dsEstado As String
    Public _dtSolicitud As DateTime
    Public _dsSolicitud As String
    Public _dsNroExpSolicitud As String
    Public _dsObservaciones As String
    Private _ArraSol As New List(Of ClsSolicitudes)
    Public Property ArraSol() As List(Of ClsSolicitudes)
        Get
            Return _ArraSol
        End Get
        Set(ByVal value As List(Of ClsSolicitudes))
            _ArraSol = value
        End Set
    End Property

    Public Property cdSolicitud() As Integer
        Get
            Return _cdSolicitud
        End Get
        Set(ByVal value As Integer)
            _cdSolicitud = value
        End Set
    End Property
    Public Property cdSolicitudEstado() As Integer
        Get
            Return _cdSolicitudEstado
        End Get
        Set(ByVal value As Integer)
            _cdSolicitudEstado = value
        End Set
    End Property
    Public Property dsEstado() As String
        Get
            Return _dsEstado
        End Get
        Set(ByVal value As String)
            _dsEstado = value
        End Set
    End Property
    Public Property dsSolicitud() As String
        Get
            Return _dsSolicitud
        End Get
        Set(ByVal value As String)
            _dsSolicitud = value
        End Set
    End Property
    Public Property dsNroExpSolicitud() As String
        Get
            Return _dsNroExpSolicitud
        End Get
        Set(ByVal value As String)
            _dsNroExpSolicitud = value
        End Set
    End Property
    Public Property dsObservaciones() As String
        Get
            Return _dsObservaciones
        End Get
        Set(ByVal value As String)
            _dsObservaciones = value
        End Set
    End Property
    Public Property dtSolicitud() As DateTime
        Get
            Return _dtSolicitud
        End Get
        Set(ByVal value As DateTime)
            _dtSolicitud = value
        End Set
    End Property

End Class