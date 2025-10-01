Imports System

Module peso
    Sub Main(args As String())
        'Declaracion de variables
        DIM M As Double
        DIM G As Double
        DIM P As Double

        'Ingresa valores para las variables
        G = 9.8
        Console.Write("Ingrese la masa del objeto: ")
        M = Console.Readline()

        'Realizar los procesos
        p = M * G

        'Mostrar resultados
        Console.WriteLine("Peso del objeto: {0}", P)
        Console.ReadKey() 
    End Sub
End Module
