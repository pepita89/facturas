Public Class clsConcepto
    Private _cdExp As Integer
    Private _cdSubConcepto As Integer
    Private _dsconcepto As String
    Private _dsSubConcepto As String
    Private _dsObservacion As String



    Public Property cdExp() As Integer
        Get
            Return _cdExp
        End Get
        Set(ByVal value As Integer)
            _cdExp = value
        End Set
    End Property

    Public Property cdSubConcepto() As Integer
        Get
            Return _cdSubConcepto
        End Get
        Set(ByVal value As Integer)
            _cdSubConcepto = value
        End Set
    End Property
    Public Property dsConcepto() As String
        Get
            Return _dsConcepto
        End Get
        Set(ByVal value As String)
            _dsConcepto = value
        End Set
    End Property
    Public Property dsSubConcepto() As String
        Get
            Return _dsSubconcepto
        End Get
        Set(ByVal value As String)
            _dsSubconcepto = value
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
    
  
End Class
Public Class clsConceptos
#Region "Variables y Propiedades"
    Private _cdExp As Integer
    Private _cdPadre As Integer
    Private _dsConcepto As String
    Private _dsObservaciones As String
    Private _dsSubconcepto As String
    Private _cdconcepto As Integer
    Private _cdNivel As Integer

    Public Property cdExp() As Integer
        Get
            Return _cdExp
        End Get
        Set(ByVal value As Integer)
            _cdExp = value
        End Set
    End Property
    Public Property cdPadre() As Integer
        Get
            Return _cdPadre
        End Get
        Set(ByVal value As Integer)
            _cdPadre = value
        End Set
    End Property
    Public Property dsConcepto() As String
        Get
            Return _dsConcepto
        End Get
        Set(ByVal value As String)
            _dsConcepto = value
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
    Public Property dsSubconcepto() As String
        Get
            Return _dsSubconcepto
        End Get
        Set(ByVal value As String)
            _dsSubconcepto = value
        End Set
    End Property
    Public Property cdConcepto() As Integer
        Get
            Return _cdconcepto
        End Get
        Set(ByVal value As Integer)
            _cdconcepto = value
        End Set
    End Property
    Public Property cdNivel() As Integer
        Get
            Return _cdNivel
        End Get
        Set(ByVal value As Integer)
            _cdNivel = value
        End Set
    End Property
    Private _Array As List(Of clsConceptos)
    Public Property Array() As List(Of clsConceptos)
        Get
            Return _Array
        End Get
        Set(ByVal value As List(Of clsConceptos))
            _Array = value
        End Set
    End Property
    Private _Array1 As List(Of clsConceptos)
    Public Property Array1() As List(Of clsConceptos)
        Get
            Return _Array1
        End Get
        Set(ByVal value As List(Of clsConceptos))
            _Array1 = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function SP_TRAERDATOS_ByConceptos(ByVal pcdExp As Integer) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExp", pcdExp)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_TRAERDATOS_ByConceptos", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function DELETE_Conceptos(ByVal pcdExp As Integer, ByVal pcdConcepto As Integer) As DataSet
        Try
            Dim ds As New DataSet
            Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdExpediente", pcdExp), _
                                                           New Data.SqlClient.SqlParameter("@cdConcepto", pcdConcepto)}
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ExpedientesConceptos_D", oParam)
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'dsNroComprobante
    Public Function ObtenerSubConceptos(ByVal cdPadre As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdPadre", cdPadre)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SelectSubConceptos", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ObtenerConceptos(ByVal cdConcepto As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdConcepto", cdConcepto)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_CONCEPTOS", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
    Public Function ExpedientesConceptos_IU(ByVal pToXml As String) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", pToXml), _
                                                       New Data.SqlClient.SqlParameter("@LastError", 0)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_INSERT_EXPEDIENTESCONCEPTOS", oParam)
        Return ds
    End Function
    Public Function ToXmlConcepto() As String
        Dim oXml As New System.Xml.XmlDocument
        Dim oXmlItem As System.Xml.XmlElement
        Dim intBaja As Integer = 0
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><TbConcepto/>")
        With CType(oXml.SelectSingleNode("TbConcepto"), System.Xml.XmlElement)
            For Each obj As clsConceptos In Array
                oXmlItem = oXml.CreateElement("TbConcepto")
                oXmlItem.SetAttribute("cdConcepto", obj.cdConcepto)
                oXmlItem.SetAttribute("dsConcepto", obj.dsConcepto)
                oXmlItem.SetAttribute("cdNivel", obj.cdNivel)
                oXmlItem.SetAttribute("cdPadre", obj.cdPadre)
                oXmlItem.SetAttribute("cdBaja", 0)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function ValidarConcepto(ByVal dsConcepto As String, ByVal cdNivel As Integer) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@dsConcepto", dsConcepto), _
                                                       New Data.SqlClient.SqlParameter("@cdNivel", cdNivel)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "ValidarConcepto", oParam)
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
        oXml.LoadXml("<?xml version=""1.0"" encoding=""windows-1252""?><TbConcepto/>")
        With CType(oXml.SelectSingleNode("TbConcepto"), System.Xml.XmlElement)
            For Each obj As clsConceptos In Array1
                oXmlItem = oXml.CreateElement("TbConcepto")
                oXmlItem.SetAttribute("cdExpediente", obj.cdExp)
                oXmlItem.SetAttribute("cdConcepto", obj.cdConcepto)
                oXmlItem.SetAttribute("sObservacion", obj.dsObservaciones)
                oXml.ChildNodes(1).AppendChild(oXmlItem)
            Next
        End With
        Return oXml.OuterXml
    End Function
    Public Function Conceptos_I(ByVal pToXml As String) As DataSet
        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@doc", pToXml), _
                                                       New Data.SqlClient.SqlParameter("@LastError", 0)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_INSERT_CONCEPTOS_SUBCONCEPTOS", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then
            Return ds
        Else
            Return ds
        End If
    End Function
#End Region
End Class
