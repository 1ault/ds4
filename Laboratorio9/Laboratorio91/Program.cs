internal class Program 
{
    private static void Main(string[] args) 
    {
        while (true)
        {
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("[Tienda]");
            System.Console.WriteLine("Usuario intenta comprar:");
            System.Console.WriteLine("[Objeto] [$100]");
            System.Console.WriteLine("Usuario ingrese su forma de pago");
            System.Console.WriteLine("1: Efectivo");
            System.Console.WriteLine("2: Tarjeta");

            try
            {
                string? read_user = Console.ReadLine();

                if (read_user is null) { return; }

                int val = int.Parse(read_user);

                System.Console.WriteLine($"{val}");

                switch (val)
                {
                    case 1:
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Tu cantidad de effectivo:");
                        string? read_user_efectivo = Console.ReadLine();
                        if (read_user_efectivo is null ) { return; }
                        int efectivo = int.Parse(read_user_efectivo);

                        if (efectivo <= 0) {
                            System.Console.WriteLine("Tu saldo es negativo");
                            continue;
                        }

                        if (efectivo <= 100) {
                            System.Console.WriteLine("Saldo insuficiente");
                            continue;
                        }

                        System.Console.WriteLine($"Compra efectuada tu saldo es de {efectivo - 100}");
                        return;
                    case 2:
                        System.Console.WriteLine("Tu numero de cuenta:");
                        string? read_user_cuenta = Console.ReadLine();
                        if (read_user_cuenta is null ) { return; }
                        long cuenta = long.Parse(read_user_cuenta);
                        long cuenta_validation = 111_111_111_111_111_1;
                        long cuenta_invalid = 111_111_111_111_111_11;

                        if (cuenta < cuenta_validation || cuenta > cuenta_invalid)
                        {
                            System.Console.WriteLine($"16 digitos para validar");
                            System.Console.WriteLine($"{cuenta_validation}");
                            System.Console.WriteLine("Numero de cuenta invalido");
                            continue;
                        }

                        System.Console.WriteLine($"Compra efectuada");
                        return;
                    default:
                        System.Console.WriteLine("Numero invalido");
                        break;
                }
            }
            catch (FormatException ex) {
                System.Console.WriteLine($"{ex}");
            }

        }


    }
}
