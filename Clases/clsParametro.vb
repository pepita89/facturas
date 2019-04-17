Public Class clsParametro
    Private _cdValor As String
    Private _dsValor As String
    Public Sub New()

    End Sub

    Public Sub New(ByVal cdvalor As String, ByVal dsvalor As String)

        _cdValor = cdvalor
        _dsValor = dsvalor
    End Sub
    Public Property cdValor() As String
        Get
            Return _cdValor
        End Get
        Set(ByVal value As String)
            _cdValor = value
        End Set
    End Property
    Public Property dsValor() As String
        Get
            Return _dsValor
        End Get
        Set(ByVal value As String)
            _dsValor = value
        End Set
    End Property
End Class
