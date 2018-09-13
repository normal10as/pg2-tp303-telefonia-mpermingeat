Public Class Equipo
    Inherits Modelo

    Private _serie As String
    Private _fechaVenta As Date

    Public Sub New(Marca As String, Modelo As String, Serie As String)
        MyBase.New(Marca, Modelo)
        Me.Serie = Serie
    End Sub

    '//////////////Properties/////////////////////////
    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property

    Public ReadOnly Property FechaVenta() As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    '//////////////Metodos/////////////////////////
    Public Overrides Function ToString() As String
        Return Marca & " " & Modelo & " " & Serie
    End Function

    Public Sub Vender()
        _fechaVenta = Date.Now
    End Sub
End Class