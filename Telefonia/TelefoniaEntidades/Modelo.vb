Public Class Modelo
    Inherits Marca
    Private _modelo As String


    Public Sub New(Marca As String, Nombre As String)
        MyBase.New(Marca)
        Me.Modelo = Nombre
    End Sub

    '//////////////Properties/////////////////////////
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    '//////////////////Metodos///////////////////////////
    Public Overrides Function ToString() As String
        Return Marca & " " & Modelo
    End Function



End Class
