class Trabajador : Persona 
{
    public int Sueldo;


    public Trabajador(string nombre, int edad, string nif, int sueldo) : base (nombre,edad, nif)
    {
        this.Sueldo = sueldo;
    }
}
