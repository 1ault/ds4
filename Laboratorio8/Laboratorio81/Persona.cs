class Persona
{
    public string Nombre;
    public int Edad;
    public string NIF;

    void cumpleanos()
    {
        Edad = Edad + 1;
    }

    public Persona(string nombre, int edad, string nif) 
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.NIF = nif;
    }
}
