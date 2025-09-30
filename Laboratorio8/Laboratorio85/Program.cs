public partial class Coordenadas 
{
    public void VerCordenadas()
    {
        Console.WriteLine($"Codenadas: {this.x} {this.y}");
    }
}

internal class Program {
    private static void Main(string[] args) {
        Coordenadas misCoords = new Coordenadas(10, 15);
        misCoords.VerCordenadas();
    }
}
