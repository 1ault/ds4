public class Banco 
{
    private Cliente cliente1, cliente2, cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Yhonas");
        cliente2 = new Cliente("Ana");
        cliente3 = new Cliente("Pedro");
    }

    public void Operar()
    {
        cliente1.Depositar(100);
        cliente2.Depositar(150);
        cliente3.Depositar(200);

        cliente3.Depositar(150);
    }

    public void DepositosTotales()
    {
        double t = cliente1.GetMonto() + cliente2.GetMonto() + cliente3.GetMonto();

        Console.WriteLine($"El total de dinero en: {t}]");

        cliente1.Imprimir();
        cliente2.Imprimir();
        cliente3.Imprimir();
    }

}
