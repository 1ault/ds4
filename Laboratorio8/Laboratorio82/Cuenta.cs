public class Cuenta
{
    public string idCuenta;

    public Cuenta(string id_cuenta)
    {
        this.idCuenta = id_cuenta;
        System.Console.WriteLine($"Constructor clase base para cuenta {id_cuenta}");
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine($"Cuenta.CalcularInterese() efectuado para la cuenta {this.idCuenta}");
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}
