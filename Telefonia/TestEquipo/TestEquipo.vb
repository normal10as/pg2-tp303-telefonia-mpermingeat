Imports TelefoniaEntidades

Module TestEquipo

    Sub Main()
        Dim equipo1 As New Equipo("samsumg", "s7", "0001")
        equipo1.Vender()

        Console.WriteLine("Marca: " & equipo1.Marca)
        Console.WriteLine("Modelo: " & equipo1.Modelo)
        Console.WriteLine("Serie: " & equipo1.Serie)
        Console.WriteLine("Fecha de Venta: " & equipo1.FechaVenta)
        Console.WriteLine("ToString: " & equipo1.ToString)

    End Sub

End Module
