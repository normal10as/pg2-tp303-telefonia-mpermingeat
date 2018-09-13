Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String

    Public Sub New(CodigoArea As UShort, Numero As UInteger)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
    End Sub

    '///////////////////Properties////////////////////

    Public Property CodigoArea() As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property

    Public Property Numero() As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Estado() As String
        Get
            Return _estado
        End Get

    End Property

    '///////////////////Metodos////////////////////
    Public Sub Suspender()
        _estado = "Linea Suspendida"

    End Sub

    Public Sub Reactivar()
        _estado = "Linea Activa"

    End Sub

    Public Function ToString() As String
        If _estado = "Linea Suspendida" Then
            Return CodigoArea & "+" & Numero & " " & Estado
        End If
        Return CodigoArea & "+" & Numero
    End Function

End Class
