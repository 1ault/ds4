void Sumar(int a, int b) {
    int result = a + b;
    Console.WriteLine(result);
}


Sumar(33330, 32343);


Client client = new Client();

client.FirstName = "Su nombre";
client.LastName = "Su apellido";
client.Id = 1;
client.Age = 15;

Console.WriteLine(client.Id);
Console.WriteLine(client.GetFullName());


public class Client {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public ushort Age { get; set; }

    public string GetFullName() {
        return this.FirstName + " " + this.LastName;
    }
}
