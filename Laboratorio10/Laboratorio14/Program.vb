Imports System

Module Program
    Sub Main(args As String())
        Dim perrito As Perro = new Perro()
            perrito.nombre = "Chizu"
            perrito.raza = "Pastor Aleman"
            perrito.altura = "0.70cm"

        Console.WriteLine(perrito.comer("Carne"))

        Dim perrito2 As Perro = new Perro()
            perrito2.nombre = "Lasy"
            perrito2.altura = "0.60cm"

            Console.WriteLine(perrito2.comer("Pollo"))

        Dim perrito3 As Perro = new Perro("Peluchin", "Poodle", "0.50")
        Console.WriteLine(perrito3.comer("Pan"))
    End Sub
End Module
