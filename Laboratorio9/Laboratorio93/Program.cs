internal class Program 
{
    private static void Main(string[] args) 
    {
        try 
        {

            System.Console.WriteLine("Imprima su triangulo");
            System.Console.WriteLine("A");
            string? user_A = Console.ReadLine();

            System.Console.WriteLine("B");
            string? user_B = Console.ReadLine();

            System.Console.WriteLine("C");
            string? user_C = Console.ReadLine();

            if (user_A == null || user_B == null || user_C == null)
            {
                System.Console.WriteLine("Val null");
                return; 
            }


            int val_A = int.Parse(user_A);
            int val_B = int.Parse(user_B);
            int val_C = int.Parse(user_C);


            if (val_A + val_B + val_C == 180 && val_C == 90) {
                System.Console.WriteLine("Triangulo rectangulo");
                return;
            }

            if (val_A + val_B + val_C == 180 && val_A < 90 && val_B < 90 && val_C < 90) 
            {
                System.Console.WriteLine("Triangulo agudo");
                return;
            }

            if (val_A + val_B + val_C == 180) {
                int more_90 = 0;

                if (val_A > 90) {
                    more_90 = more_90 + 1;
                }

                if (val_B > 90) {
                    more_90 = more_90 + 1;
                }

                if (val_C > 90) {
                    more_90 = more_90 + 1;
                }

                if (more_90 != 1) {
                    System.Console.WriteLine("Usdknown triangulo");
                    return;
                }

                System.Console.WriteLine("Triangulo obtuso");
                return;
            }

            System.Console.WriteLine("Unknown triangulo");

        }
        catch (FormatException ex)
        {
            System.Console.WriteLine($"Format: {ex}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Exception: {ex}");
        }
        finally {
        }


    }
}
