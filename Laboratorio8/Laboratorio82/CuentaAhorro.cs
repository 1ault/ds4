public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string IdCuenta) : base(IdCuenta) 
    {

    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine($"CuentaAhorro.CalcularIntereses() efectuado para {this.getIdCuenta()}");
    }
}
