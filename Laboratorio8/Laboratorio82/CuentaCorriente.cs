public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string IdCuenta): base(IdCuenta) 
    {

    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine($"CuentaCorriente.CalcularIntereses() efectuados para la cuenta {getIdCuenta()}");
    }
}
