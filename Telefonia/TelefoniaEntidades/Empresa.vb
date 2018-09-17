Public Class Empresa
    Inherits Cliente

    Private _cuit As String
    Private _razonSocial As String

    Public Sub New(Cuit As String, RazonSocial As String, Cuenta As UInteger)
        MyBase.New(Cuenta)
        Me.Cuit = Cuit
        Me.RazonSocial = RazonSocial

    End Sub

    '///////////////Properties///////////////////
    Public Property Cuit() As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            If value.Length > 0 And value.Length <= 13 Then
                _cuit = value
            End If

        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return _razonSocial
        End Get
        Set(ByVal value As String)
            If value.Length > 0 And value.Length <= 80 Then
                _razonSocial = value
            End If

        End Set
    End Property

    '///////////////Metodos///////////////////
    Public Function ToString() As String
        Return RazonSocial & " " & Cuenta
    End Function
End Class
