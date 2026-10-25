namespace PLANAZO.Modelos;

public class Reserva
{
    public int Id { get; set; }
    public string Persona { get; set; }
    public Evento Evento { get; set; }
    public int CantidadEntradas { get; set; }
    public decimal ValorTotal { get; set; }
    public bool Activa { get; set; }

    public Reserva(int id, string persona,
        Evento evento, int cantidad)
    {
        Id = id;
        Persona = persona;
        Evento = evento;
        CantidadEntradas = cantidad;
        ValorTotal = cantidad * evento.CalcularPrecioFinal();
        Activa = true;
    }
}