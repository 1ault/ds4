internal class Program {
    private static void Main(string[] args) {
        CalculosMatematicos calc = new CalculosMatematicos();


        Console.WriteLine("Introduce el primer numero: ");
        calc.a = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Introduce el segundo numero: ");
        calc.b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Resultado {0}", calc.Calcular());
    }
}


public class CalculosMatematicos {
    public int a { get; set; }
    public int b { get; set; }

    public int Calcular() {
        return (a+b)*(a-b);
    }
}
