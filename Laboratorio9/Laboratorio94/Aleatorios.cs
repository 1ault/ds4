public class Aleatorios
{
    Random random = new Random();

    public Aleatorios() {}

    public void min_max(int min, int max)
    {
        System.Console.WriteLine($"Random Num: [Min:{min}] [Max:{max}]");
        System.Console.WriteLine($"{this.random.Next(min, max)}");
    }

    public void arreglo_min_max(int min, int max, int size)
    {
        int[] arreglo = new int[size];
        for (int arrg = 0; arrg < arreglo.Length; arrg = arrg + 1)
        {
            arreglo[arrg] = this.random.Next(min, max);
        }


        System.Console.WriteLine($"El arreglo:");

        System.Console.Write("[");

        int i = 0;
        while (true) 
        { 
            if (i >= arreglo.Length) {
                break;
            }
            System.Console.Write($"{arreglo[i]}");

            if (i == arreglo.Length - 1) {
                break;
            }
            System.Console.Write(",");

            i = i + 1;
        }

        System.Console.Write("]");
        System.Console.WriteLine("");
    }
}
