Imports TelefoniaEntidades

Module TestLinea
    Sub Main()
        Dim linea1 As New Linea(376, 4826174)


        Console.WriteLine("Cod Area: " & linea1.CodigoArea)
        Console.WriteLine("Numero: " & linea1.Numero)
        Console.WriteLine("Tostring suspendido: " & linea1.ToString)
        Console.WriteLine("/////////////////////////////////////////////")
        linea1.Suspender()
        Console.WriteLine("Tostring suspendido: " & linea1.ToString)
        Console.WriteLine("/////////////////////////////////////////////")
        linea1.Reactivar()
        Console.WriteLine("ToString Activo: " & linea1.ToString)

    End Sub
End Module
