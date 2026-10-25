namespace PLANAZO.Modelos;

public class Taller : Evento
{
    public Taller(int id, string nombre, DateTime fecha,
        decimal precio, int capacidad)
        : base(id, nombre, fecha, precio, capacidad)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase * 0.90m;
    }
}