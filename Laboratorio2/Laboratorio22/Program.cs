namespace Laboratorio22 {
    class Program {
        static void Main(string[] args) {
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }

    }

    class MyClass {
        public static int Valor;
    }

}
