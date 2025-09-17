
internal class Program {
    private static void Main(string[] args) {
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.WriteLine("Calcula area circulo: ");
        Console.WriteLine("Introduce el Radio: ");
        calc.radio = float.Parse(Console.ReadLine());

        Console.WriteLine("Resultado {0}", calc.CalcularArea());
    }
}


public class CalculosMatematicos {
    public int a { get; set; }
    public int b { get; set; }
    public float radio {get; set; }

    public int Calcular() { return (a+b)*(a-b);}
    
    public float CalcularArea() {
        float radius = this.radio * this.radio;
        float pi = 3.14f;
        return pi * radius;
    }
}
