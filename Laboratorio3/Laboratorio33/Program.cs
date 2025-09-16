
internal class Program {
    private static void Main(string[] args) {
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.WriteLine("Calcula area circulo: ");
        Console.WriteLine("Introduce el primer numero: ");
        calc.a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero: ");
        calc.b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Resultado {0}", calc.CalcularArea());
    }
}


public class CalculosMatematicos {
    public int a { get; set; }
    public int b { get; set; }

    public int Calcular() { return (a+b)*(a-b);}
    public float CalcularArea() { return 3.14 * *;}

}
//public int CalcularPerimetroRectanculo() { return; }
