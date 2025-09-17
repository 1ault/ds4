internal class Program {
    private static void Main(string[] args) {
        int num = 1000;

        string nombre = "Juan Carlos";

        int valor1 = 28;
        int valor2 = valor1;
        valor2 = 30;

        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
        Console.WriteLine(num);
        Console.WriteLine(nombre);

        MyClass obj1 = new MyClass();
        obj1.Nombre = "Fulano";
        obj1.Edad = 28;

        MyClass obj2 = obj1;

        obj2.Nombre = "jose";

        Console.WriteLine(obj1.Nombre);
        Console.WriteLine(obj2.Nombre);


        sbyte sbyte_min = -128;
        sbyte sbyte_max = 127;
        Console.WriteLine(sbyte_min);
        Console.WriteLine(sbyte_max);

        byte byte_min = 0;
        byte byte_max = 255;
        Console.WriteLine(byte_min);
        Console.WriteLine(byte_max);

        ushort ushort_min = 0;
        ushort ushort_max = 65_535; 
        Console.WriteLine(ushort_min);
        Console.WriteLine(ushort_max);

        short short_min = -32_768; 
        short short_max = 32_767;
        Console.WriteLine(short_min);
        Console.WriteLine(short_max);


        int int_min = -2_147_483_648; 
        int int_max = 2_147_483_647;
        Console.WriteLine(int_min);
        Console.WriteLine(int_max);


        uint uint_min = 0; 
        uint uint_max = 4_294_967_295;
        Console.WriteLine(uint_min);
        Console.WriteLine(uint_max);

        long long_min = -9_223_372_036_854_755_808; 
        long long_max = 9_223_372_036_854_755_807;
        Console.WriteLine(long_min);
        Console.WriteLine(long_max);


        ulong ulong_min = 0; 
        ulong ulong_max = 18_446_744_073_709_551_615;
        Console.WriteLine(ulong_min);
        Console.WriteLine(ulong_max);

        char caracter = 'A';
        string cadena = "Cadena de caracteres";
        bool condicion = true;

        Console.WriteLine(caracter);
        Console.WriteLine(cadena);
        Console.WriteLine(condicion);
    }
}

public class MyClass {
        public string Nombre;
        public int Edad;
}
