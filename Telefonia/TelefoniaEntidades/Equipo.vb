Public Class Equipo

    Private _serie As String
    Private _fechaVenta As Date

    Public Sub New(marca As String, modelo As String, Serie As String)
        Me.Serie = Serie

    End Sub

    '//////////////Properties/////////////////////////
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 15 Then
                _serie = value
            End If
        End Set
    End Property

    Public ReadOnly Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    '//////////////Metodos/////////////////////////
    Public Overrides Function ToString() As String
        Return Serie
    End Function

    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub
End Class