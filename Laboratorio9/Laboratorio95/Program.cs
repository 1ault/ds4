internal class Program 
{
    private static void Main(string[] args) 
    {
        Aleatorios aleatorio = new Aleatorios();

        aleatorio.min_max(12, 33);
        System.Console.WriteLine("");

        aleatorio.arreglo_min_max(1, 20, 10);
        System.Console.WriteLine("");

        aleatorio.arreglo_min_max_no_dupe(1, 20, 10);
        System.Console.WriteLine("");
    }
}


