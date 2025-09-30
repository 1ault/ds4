public class CuentaBancaria
{
    private decimal saldo = 0;

    public decimal Saldo
    {
        get { return saldo; }
        set 
        {
            if (value > 0)
            {
                this.saldo = value;
            } else {
                throw new ArgumentException("El saldo no puede ser negativo.");
            }
        }
    }
}
