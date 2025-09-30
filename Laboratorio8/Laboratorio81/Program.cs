internal class Program {
    private static void Main(string[] args) 
    {
        Trabajador trabajador = new Trabajador("Josan", 22, "77588260-Z", 100000);
        Console.WriteLine($"Nombre: {trabajador.Nombre}\nEdad: {trabajador.Edad},\nNIF: {trabajador.NIF}\nSueldo: {trabajador.Sueldo}");
        Console.WriteLine("");
        Console.ReadKey();

    }
}
