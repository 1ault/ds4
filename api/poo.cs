public class Poo {
    private string _encapsulated;

    public string Encapsulated
    {
        get { return _encapsulated; }
        set { _encapsulated = value; }
    }

    public Poo(string text)
    {
        this._encapsulated = text;
        System.Console.WriteLine("Contructor");
    }

    public virtual void fn_virtual(string text)
    {
        System.Console.WriteLine($"Virtual {text}");
    }

}


public class PooInheritance : POO
{
    public PooInheritance(string text) : base(text) 
    {

    }

    public override void FnPolymorphism()
    {
        System.Console.WriteLine($"{text} Virtual poly");
    }
}


public abstract class PooAbstract
{
    public string Text { get; set; }

    public PooAbstract(string text)
    {
        this.Text = text;
    }

    public abstract FnAbstract();
}

public class PooInheritanceAbstract : PooAbstract
{
    public PooInheritanceAbstract(string text) : base(text)
    {

    }

    public override void FnAbstract()
    {}
}

internal class Program 
{
    private static void Main(string[] args) 
    {
        Poo poo_1 = new PooInheritance("text");
        poo_1.Text = "new Text";
        poo_1.FnPolymorphism();

        PooAbstract my_poo_abstract = new PooInheritanceAbstract("text");
        my_poo_abstract.FnAbstract();

    }
}
