internal class Program {
    private static void Main(string[] args) 
    {
        // identifique el patron
        
        System.Console.WriteLine("Imprima un numero par");
        string user_input = Console.ReadLine();
        try 
        {
            int user_input_int = int.Parse(user_input);

            if(user_input_int % 2 == 0) 
            {
                int n = user_input_int;
                Patron patron = new Patron(1, 101, n, n * n);
                patron.print();
            }
            else 
            {
                System.Console.WriteLine("Tu numero debe ser par");
            }
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine($"{ex}");
        }
        catch (OverflowException ex)
        {

            System.Console.WriteLine($"{ex}");
        }
        catch (Exception ex)
        {

            System.Console.WriteLine($"{ex}");
        }
    }
}


public class Patron
{
    int size;
    int[] arrays_patron;
    Random random = new Random();
    int min;
    int max;
    int n;
    int count;

    int patron;
    long mul_patron = 1;

    public Patron(int min, int max, int n, int count)
    {
        this.min = min;
        this.max = max;
        this.n = n; 
        this.size = count;
    }

    public void print() 
    {

        this.arrays_patron = new int[this.size];


        for (int i = 0; i < this.arrays_patron.Length; i += 1) {
            this.arrays_patron[i] = 0; 
        }
        System.Console.WriteLine(""); 
        
        int iter = 0;
        for (int i = 0; i < this.arrays_patron.Length; i += 1) {
            iter += 1;
            if (i == 0) {
                this.arrays_patron[i] = this.random.Next(this.min, this.max);
                System.Console.Write($"{this.arrays_patron[i]}, ");
                continue;
            }

            if (i == this.n - 1) {
                this.arrays_patron[i] = this.random.Next(this.min, this.max);
                System.Console.Write($"{this.arrays_patron[i]}, ");
                continue;
            }

            if (i == this.arrays_patron.Length - 1) {
                this.arrays_patron[i] = this.random.Next(this.min, this.max);
                System.Console.Write($"{this.arrays_patron[i]}, ");
                continue;
            }

            if (i == this.arrays_patron.Length - this.n) {
                this.arrays_patron[i] = this.random.Next(this.min, this.max);
                System.Console.Write($"{this.arrays_patron[i]}, ");
                continue;
            }
            
            System.Console.Write($"{this.arrays_patron[i]}, ");
        }
        System.Console.WriteLine("");
        
        for (int i = 0; i < this.arrays_patron.Length; i += 1) {
            System.Console.WriteLine($"Array {i + 1}: {this.mul_patron * this.arrays_patron[i]}");
        }

        System.Console.WriteLine("");
        for (int i = 0; i < this.arrays_patron.Length; i += 1) {
            if (this.arrays_patron[i] % this.n == 0) {
                System.Console.WriteLine($"Es div {this.n}: {this.arrays_patron[i]}");  
            }
        }

        for (int i = 0; i < this.arrays_patron.Length; i += 1) {
            if (this.arrays_patron[i] == 0) {
                continue;
            } else { this.mul_patron = this.mul_patron * this.arrays_patron[i];
            }
        }

        System.Console.WriteLine($"y:");
        System.Console.WriteLine($"Patron:");
        System.Console.WriteLine($"1: x:0 y: 0");
        System.Console.WriteLine($"2: x:{this.n - 1} y:0");
        System.Console.WriteLine($"3: x:0 y:{this.arrays_patron.Length - 1}");
        System.Console.WriteLine($"4: x:0 y:{this.arrays_patron.Length - this.n}");

        System.Console.WriteLine($"Mul: {this.mul_patron}");

    }
}
