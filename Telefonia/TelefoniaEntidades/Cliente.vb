Public Class Cliente
    Private _cuenta As UInteger

    Public Sub New(Cuenta As UInteger)
        Me._cuenta = Cuenta
    End Sub


    Public Property Cuenta() As UInteger
        Get
            Return _cuenta
        End Get
        Set(ByVal value As UInteger)
            _cuenta = value
        End Set
    End Property
End Class
