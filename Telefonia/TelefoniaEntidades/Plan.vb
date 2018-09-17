Public MustInherit Class Plan
    Private _credito As UInteger
    Private _precio As Decimal


    Public Property Credito() As UInteger
        Get
            Return _credito
        End Get
        Set(ByVal value As UInteger)
            _credito = value
        End Set
    End Property

    Public Property Precio() As UInteger
        Get
            Return _precio
        End Get
        Set(ByVal value As UInteger)
            _precio = value
        End Set
    End Property

    Public MustOverride Sub NuevoConsumo()

    Public MustOverride Function GetDisponible() As UInteger



End Class
