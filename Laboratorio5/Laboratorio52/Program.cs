internal class Program {
    private static void Main(string[] args) {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}

public class Matriz  {
    private int[,] mat;

    public void Ingresar() 
    {
        mat = new int[3, 4];
        for (int f = 0; f < 3; f = f + 1)
        {
            for (int c = 0; c < 4; c = c + 1)
            {
                Console.Write("Ingrese posicion [{0},{1}]: ", f+1, c+1);
                string linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);

            }
            
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 3; f = f + 1)
        {
            for (int c = 0; c < 4; c = c + 1)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

}
