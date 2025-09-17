internal class Program {
    private static void Main(string[] args) {
        int num1, num2, suma;

        Console.WriteLine("Introduce el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Introduce el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;

        Console.WriteLine("La suma de {0} y {1} es {2}", num1, num2, suma);
    }
}
