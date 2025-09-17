internal class Program {
    private static void Main(string[] args) {
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.WriteLine("Calcula perimetro rectangulo: ");
        Console.WriteLine("Introduce el largo: ");
        calc.length = float.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el ancho: ");
        calc.width = float.Parse(Console.ReadLine());
        Console.WriteLine("Resultado {0}", calc.PerimetroRectangulo());
    }
}


public class CalculosMatematicos {
    public int a { get; set; }
    public int b { get; set; }
    public float radio { get; set; }
    public float length { get; set; }
    public float width { get; set; }

    public int Calcular() { return (a+b)*(a-b);}
    
    public float CalcularArea() {
        float radius = this.radio * this.radio;
        float pi = 3.14f;
        return pi * radius;
    }

    public float PerimetroRectangulo() {
        return 2 * (this.length + this.width);
    }
}
