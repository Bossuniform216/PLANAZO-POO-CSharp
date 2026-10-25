namespace PLANAZO.Modelos;

public abstract class Evento
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public decimal PrecioBase { get; set; }
    public int CapacidadMaxima { get; set; }
    public int CuposDisponibles { get; set; }

    public Evento(int id, string nombre, DateTime fecha,
        decimal precioBase, int capacidad)
    {
        Id = id;
        Nombre = nombre;
        Fecha = fecha;
        PrecioBase = precioBase;
        CapacidadMaxima = capacidad;
        CuposDisponibles = capacidad;
    }

    public abstract decimal CalcularPrecioFinal();
}