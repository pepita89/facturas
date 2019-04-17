
Public Class clsAreas
#Region "Variables y propiedades"
    Private _cdArea As Integer
    Private _dsArea As String
    Private _monto As Decimal
    Public Property dsArea() As String
        Get
            Return _dsArea
        End Get
        Set(ByVal value As String)
            _dsArea = value
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
    Public Property monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property
#End Region
#Region "Metodos"
    '
    Public Function ObtenerAreas(ByVal cdArea As Integer, ByVal dsNombre As String) As DataSet

        Dim ds As New DataSet()
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@cdArea", cdArea), _
                                                       New Data.SqlClient.SqlParameter("@dsArea", dsNombre)}
        '  New Data.SqlClient.SqlParameter("@cdBaja", cdBaja)}
        ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_SELECT_UNIDAD_REQUIRENTE", oParam)
        If (ds.Tables(0).Rows.Count > 0) Then

            Return ds
        Else
            Return ds
        End If
        Return ds
    End Function
#End Region
End Class
