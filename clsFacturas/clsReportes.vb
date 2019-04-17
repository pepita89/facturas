Public Class clsReportes
    Public arrReportes As New List(Of clsReporte)
    Public Function ObtenerReportes(ByVal cdReporte As Integer, ByVal cdTipoReporte As Integer) As DataSet
        Dim ds As New DataSet
        Dim oParam() As Data.SqlClient.SqlParameter = {New Data.SqlClient.SqlParameter("@Reporte", cdReporte), _
                                                       New Data.SqlClient.SqlParameter("@cdTipoReporte ", cdTipoReporte)}

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(CONN_STRING, Data.CommandType.StoredProcedure, "SP_OBTENER_REPORTE", oParam)
    End Function
    Public Class clsReporte
        Private _cdReporte As Integer
        Private _dsNombre As String
        'Private _dsRuta As String
        Private _dsDescripcion As String
        Public Property cdReporte() As Integer
            Get
                Return _cdReporte
            End Get
            Set(ByVal value As Integer)
                _cdReporte = value
            End Set
        End Property
        Public Property dsNombre() As String
            Get
                Return _dsNombre
            End Get
            Set(ByVal value As String)
                _dsNombre = value
            End Set
        End Property
        'Public Property dsRuta() As String
        '    Get
        '        Return _dsRuta
        '    End Get
        '    Set(ByVal value As String)
        '        _dsRuta = value
        '    End Set
        'End Property
        Public Property dsDescripcion() As String
            Get
                Return _dsDescripcion
            End Get
            Set(ByVal value As String)
                _dsDescripcion = value
            End Set
        End Property

    End Class

End Class
