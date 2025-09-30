abstract class ClaseAbstracta
{
    // se fuerza la herencia de la clase para definir metodos
    abstract protected  string tomaValor();
    abstract public string prefixValor(string prefix);
    
    // metodo comun
    public void printOut()
    {
        System.Console.WriteLine(tomaValor());
    }
}


class ClaseConcreta1 : ClaseAbstracta 
{
    protected override string tomaValor()
    {
        return "ClaseConcreta1";
    }

    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta1";
    }
}


class ClaseConcreta2 : ClaseAbstracta 
{
    protected override string tomaValor()
    {
        return "ClaseConcreta2";
    }

    public override string prefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta2";
    }
}

internal class Program 
{
    private static void Main(string[] args) 
    {
        ClaseConcreta1 concreta1 = new ClaseConcreta1();
        concreta1.printOut();
        Console.WriteLine(concreta1.prefixValor("ES_"));

        ClaseConcreta2 concreta2 = new ClaseConcreta2();
        concreta2.printOut();
        System.Console.WriteLine(concreta2.prefixValor("ES_"));

    }
}
