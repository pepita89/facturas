Public Class clsExpedientesConvenioOtros
    Private _intcdExp As Integer
    Private _sObjeto As String
    Private _dsObservacion As String
    Private _dsNroConvenio As String
    Private _cdTipoPerio As Integer
    Private _dsPerio As String
    Private _dtFechaD As Nullable(Of Date)
    Private _dtFechaH As Nullable(Of Date)
    Private _vlImpor As Decimal
    Private _cdMoneda As Integer
    Private _vlCotizacion As Decimal
    Private _cdAreaRequi As Integer
    Private _dtFecha As DateTime
    Private _Arr As List(Of clsExpedientesConvenioOtros)

    Public Property intcdExp() As Integer
        Get
            Return _intcdExp
        End Get
        Set(ByVal value As Integer)
            _intcdExp = value
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
    Public Property cdAreaRequi() As Integer
        Get
            Return _cdAreaRequi
        End Get
        Set(ByVal value As Integer)
            _cdAreaRequi = value
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
    Public Property sObjeto() As String
        Get
            Return _sObjeto
        End Get
        Set(ByVal value As String)
            _sObjeto = value
        End Set
    End Property
    Public Property dsNroConvenio() As String
        Get
            Return _dsNroConvenio
        End Get
        Set(ByVal value As String)
            _dsNroConvenio = value
        End Set
    End Property
    Public Property cdTipoPerio() As Integer
        Get
            Return _cdTipoPerio
        End Get
        Set(ByVal value As Integer)
            _cdTipoPerio = value
        End Set
    End Property
    Public Property dsPerio() As String
        Get
            Return _dsPerio
        End Get
        Set(ByVal value As String)
            _dsPerio = value
        End Set
    End Property
    Public Property dtFechaD() As Nullable(Of Date)
        Get
            Return _dtFechaD
        End Get
        Set(ByVal value As Nullable(Of Date))
            _dtFechaD = value
        End Set
    End Property
    Public Property dtFechaH() As Nullable(Of Date)
        Get
            Return _dtFechaH
        End Get
        Set(ByVal value As Nullable(Of Date))
            _dtFechaH = value
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
            Return _vlImpor
        End Get
        Set(ByVal value As Decimal)
            _vlImpor = value
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
    Public Property ArraS() As List(Of clsExpedientesConvenioOtros)
        Get
            Return _Arr
        End Get
        Set(ByVal value As List(Of clsExpedientesConvenioOtros))
            _Arr = value
        End Set
    End Property
    Public Function ToXml() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><rowset/>")
        With CType(oXml.SelectSingleNode("rowset"), System.Xml.XmlElement)
            For Each obj As clsExpedientesConvenioOtros In ArraS
                oXmlItem = oXml.CreateElement("row")
                oXmlItem.SetAttribute("cdExpediente", obj.intcdExp)
                oXmlItem.SetAttribute("sObjetoConvenio", obj.sObjeto)
                oXmlItem.SetAttribute("sObservacion", obj.dsObservacion)
                oXmlItem.SetAttribute("dsNroConvenio", obj.dsNroConvenio)
                oXmlItem.SetAttribute("cdTipoPeriodicidad", obj.cdTipoPerio)
                oXmlItem.SetAttribute("dsPeriodicidad", obj.dsPerio)
                If obj.dtFechaD.HasValue Then
                    oXmlItem.SetAttribute("dtFechaDesde", obj.dtFechaD.Value.ToString("yyyyMMdd"))
                End If
                If obj.dtFechaH.HasValue Then
                    oXmlItem.SetAttribute("dtFechaHasta", obj.dtFechaH.Value.ToString("yyyyMMdd"))
                End If
                oXmlItem.SetAttribute("vlimporte", obj.vlImporte.ToString().Replace(",", "."))
                oXmlItem.SetAttribute("cdMoneda", obj.cdMoneda)
                oXmlItem.SetAttribute("vlCotizacion", obj.vlCotizacion.ToString().Replace(",", "."))
                oXmlItem.SetAttribute("cdUnidadReq", obj.cdAreaRequi)
                oXmlItem.SetAttribute("dtFechaConvenio", obj.dtFecha.ToString("yyyyMMdd"))
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function ExpedientesConveniosOtros_IU(ByVal strXml As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", strXml)}
            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ExpedientesConveniosOtros_IU", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
