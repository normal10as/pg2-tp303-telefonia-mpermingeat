Public Class Persona
    Inherits Cliente

    Private _nombre As String
    Private _apellido As String
    Private _dni As UInteger

    Public Sub New(Nombre As String, Apellido As String, dni As UInteger, Cuenta As UInteger)
        MyBase.New(Cuenta)
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Dni = dni
    End Sub

    '///////////////Properties///////////////////
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property Dni() As UInteger
        Get
            Return _dni
        End Get
        Set(ByVal value As UInteger)
            _dni = value
        End Set
    End Property

    '///////////////Metodos///////////////////
    Public Function ToString() As String
        Return Apellido & " " & Nombre & " " & Cuenta
    End Function

End Class

