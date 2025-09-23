internal class Program {
    private static void Main(string[] args) {

        int[] valores;
        valores = new int[100];
        valores = new int[20];


        int[] array_1d = new int[10];
        int[,] array_2d = new int[1, 2];
        int[,,] array_3d = new int[1, 2, 3];


        int[][] array_matriz = new int[1][];

        for (int i = 0; i < array_matriz.Length; i = i + 1) 
        {
                array_matriz[i] = new int[4];
        }

        PruebaVectorial1 pv = new PruebaVectorial1();
        pv.Cargar();
        pv.Imprimir();


    }

}



public class PruebaVectorial1 {
    private int[] sueldos;

    public void Cargar() {
        sueldos = new int[6]; 

        for (int f = 1; f <= 5; f = f + 1) 
        {
            Console.Write("Ingrese sueldo del operatario {0}:", f);
            String linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir() 
    {
        Console.Write("Los 5 sueldos de los operarios \n");

        for (int f = 1; f <= 5; f = f + 1) 
        {
            Console.Write("[{0}]", sueldos[f]);
        }
        Console.WriteLine("");
        Console.ReadKey();
    }
}
