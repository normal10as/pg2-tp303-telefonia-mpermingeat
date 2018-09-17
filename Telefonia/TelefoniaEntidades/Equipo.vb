Public Class Equipo

    Private _serie As String
    Private _fechaVenta As Date
    Private _modelo As Modelo
    Private _marca As Marca


    Public Sub New(Marca As Marca, Modelo As Modelo, Serie As String)
        Me.Serie = Serie
        Me.Marca = Marca
        Me.Modelo = Modelo
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

    Public Property Modelo() As Modelo
        Get
            Return _modelo
        End Get
        Set(value As Modelo)
            _modelo = value
        End Set
    End Property

    Public Property Marca() As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property

    '//////////////Metodos/////////////////////////
    Public Overrides Function ToString() As String
        Return Marca.ToString & " " & Modelo.ToString & " " & Serie
    End Function

    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub
End Class