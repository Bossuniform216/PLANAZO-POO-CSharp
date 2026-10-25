using PLANAZO.Modelos;

namespace PLANAZO.Servicios;

public class GestorReservas
{
    public List<Evento> Eventos = new();
    public List<Reserva> Reservas = new();

    private int idReserva = 1;

    public void Reservar(string persona, int idEvento, int cantidad)
    {
        Evento? evento = Eventos.Find(e => e.Id == idEvento);

        if (evento == null)
            throw new Exception("Evento no encontrado");

        if (cantidad <= 0)
            throw new Exception("Cantidad inválida");

        if (cantidad > evento.CuposDisponibles)
            throw new Exception("No hay cupos suficientes");

        evento.CuposDisponibles -= cantidad;

        Reservas.Add(
            new Reserva(idReserva++, persona, evento, cantidad)
        );
    }

    public void Cancelar(int id)
    {
        Reserva? reserva = Reservas.Find(r => r.Id == id);

        if (reserva == null)
            throw new Exception("Reserva inexistente");

        if (!reserva.Activa)
            throw new Exception("La reserva ya fue cancelada");

        reserva.Activa = false;
        reserva.Evento.CuposDisponibles += reserva.CantidadEntradas;
    }
}