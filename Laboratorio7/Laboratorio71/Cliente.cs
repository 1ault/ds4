public class Cliente 
{
    private string nombre;
    private double monto;

    public Cliente(string nombre) 
    {
        this.nombre = nombre;
        this.monto = 0;
    }

    public void Depositar(double monto)
    {
        this.monto = this.monto + monto;
    }

    public void Extraer(double monto)
    {
        this.monto = this.monto - monto;
    }

    public double GetMonto() 
    {
        return this.monto;
    }

    public void Imprimir()
    {
        Console.WriteLine($"{this.nombre} tiene depositado la suma de {this.monto}");
    }
}
