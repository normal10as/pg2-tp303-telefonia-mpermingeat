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
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Overridable Function ToString() As String
        Return Marca
    End Function

End Class
