Imports TelefoniaEntidades

Module TestPersona


    Sub Main()
        Dim persona1 As New Persona("Nate", "Balanda", 357896321, 1)


        Console.WriteLine("Nombre: " & persona1.Nombre)
        Console.WriteLine("Persona: " & persona1.Apellido)
        Console.WriteLine("Persona: " & persona1.Dni)
        Console.WriteLine("Tostring: " & persona1.ToString)


    End Sub
End Module
