Public Class Modelo

    Private _modelo As String


    Public Sub New(Nombre As String)

        Me.Modelo = Nombre
    End Sub

    '//////////////Properties/////////////////////////
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _modelo = value
            End If
        End Set
    End Property

    '//////////////////Metodos///////////////////////////
    Public Overrides Function ToString() As String
        Return Modelo
    End Function



End Class
