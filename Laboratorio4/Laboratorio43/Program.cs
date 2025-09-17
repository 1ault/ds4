internal class Program {
    private static void Main(string[] args) {
        int suma = 0, cant = 0, valor = 0, promedio = 0;
        string linea;

        do {
            Console.Write("Ingrese un numero (0 para finalizar):");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            if (valor != 0) {
                suma = suma + valor;
                cant = cant + 1;
            }
        } while (valor != 0);

        if (cant != 0) {
            promedio = suma / cant;
            Console.Write("El promedio de los valores ingresados es:");
            Console.Write(promedio);
        } else {
            Console.Write("No se ingresaron valores");
        }
        Console.ReadLine();
        Console.WriteLine("");
        Console.ReadKey(); 
    }
}
