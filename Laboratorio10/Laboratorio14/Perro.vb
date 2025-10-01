Public class Perro
    Public nombre As String
    Public raza As String
    Public altura As String

    public Function comer(carne As String) As String
        return nombre + " mide " + altura + " y comera " + carne
    End Function
    Public Sub dormir()

    End Sub
    Public Sub ladrar()

    End Sub
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double
        preciototal = costo + (costo * impuesto)
        return preciototal
    End Function

    public Sub New()

    End sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class
