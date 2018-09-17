Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As Boolean

    Public Sub New(CodigoArea As UShort, Numero As UInteger)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
        _estado = True
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
            Return If(_estado, "Activa", "Suspendida")
        End Get

    End Property

    '///////////////////Metodos////////////////////
    Public Sub Suspender()
        _estado = False

    End Sub

    Public Sub Reactivar()
        _estado = True

    End Sub

    Public Function ToString() As String
        Dim value As String = CodigoArea & " " & Numero
        If Not _estado Then
            value = value & " " & "Suspendida"
        End If
        Return value
    End Function

End Class
