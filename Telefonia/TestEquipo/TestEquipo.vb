Imports TelefoniaEntidades

Module TestEquipo

    Sub Main()
        Dim equipo1 As New Equipo("Samsung", "Galaxy Ace", "0001")
        equipo1.Vender(Now)


        Console.WriteLine("Serie: " & equipo1.Serie)
        Console.WriteLine("Fecha de Venta: " & equipo1.FechaVenta)
        Console.WriteLine("ToString: " & equipo1.ToString())

    End Sub

End Module
