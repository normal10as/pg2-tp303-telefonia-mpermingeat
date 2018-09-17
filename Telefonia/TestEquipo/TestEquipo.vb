Imports TelefoniaEntidades

Module TestEquipo

    Sub Main()
        Dim marca1 As New Marca("Samsung")
        Dim modelo1 As New Modelo("GalaxyAce")
        Dim equipo1 As New Equipo(marca1, modelo1, "0001")
        equipo1.Vender(Now)

        Console.WriteLine("Serie: " & equipo1.Serie)
        Console.WriteLine("Fecha de Venta: " & equipo1.FechaVenta)
        Console.WriteLine("ToString: " & equipo1.ToString())

    End Sub

End Module
