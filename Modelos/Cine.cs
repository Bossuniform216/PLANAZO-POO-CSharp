namespace PLANAZO.Modelos;

public class Cine : Evento
{
    public Cine(int id, string nombre, DateTime fecha,
        decimal precio, int capacidad)
        : base(id, nombre, fecha, precio, capacidad)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase;
    }
}