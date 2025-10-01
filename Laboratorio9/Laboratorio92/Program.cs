internal class Program 
{
    private static void Main(string[] args) 
    {
        foreach (int i in Enumerable.Range(0, 100))
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine($"Numero div 2 [par]: {i}");
                continue;
            }

            if (i % 3 == 0)
            {
                System.Console.WriteLine($"Numero div 3 [tre]: {i}");
                continue;
            }


        }

    }
}
