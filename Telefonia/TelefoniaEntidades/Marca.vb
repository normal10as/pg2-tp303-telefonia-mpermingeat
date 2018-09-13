Public Class Marca
    Private _nombre As String

    Public Sub New(Nombre As String)
        Me.Marca = Nombre
    End Sub

    Public Property Marca() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overridable Function ToString() As String
        Return Marca
    End Function

End Class
