namespace PLANAZO.Modelos;

public class Concierto : Evento
{
    public Concierto(int id, string nombre, DateTime fecha,
        decimal precio, int capacidad)
        : base(id, nombre, fecha, precio, capacidad)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase * 1.15m;
    }
}