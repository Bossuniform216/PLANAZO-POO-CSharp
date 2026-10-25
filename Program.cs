using PLANAZO.Modelos;
using PLANAZO.Servicios;

GestorReservas gestor = new();

gestor.Eventos.Add(new Cine(1, "Deadpool", DateTime.Now, 20000, 50));
gestor.Eventos.Add(new Cine(2, "Minecraft", DateTime.Now, 25000, 50));

gestor.Eventos.Add(new Concierto(3, "Shakira", DateTime.Now, 50000, 100));
gestor.Eventos.Add(new Concierto(4, "Karol G", DateTime.Now, 60000, 100));

gestor.Eventos.Add(new Taller(5, "C#", DateTime.Now, 40000, 30));
gestor.Eventos.Add(new Taller(6, "SQL", DateTime.Now, 30000, 30));

bool salir = false;

while (!salir)
{
    Console.WriteLine("\nPLANAZO");
    Console.WriteLine("1. Ver eventos");
    Console.WriteLine("2. Reservar");
    Console.WriteLine("3. Ver reservas");
    Console.WriteLine("4. Cancelar reserva");
    Console.WriteLine("0. Salir");

    string opcion = Console.ReadLine()!;

    try
    {
        switch (opcion)
        {
            case "1":

                foreach (var e in gestor.Eventos)
                {
                    Console.WriteLine(
                        $"{e.Id} - {e.Nombre} - ${e.CalcularPrecioFinal()} - Cupos:{e.CuposDisponibles}"
                    );
                }

                break;

            case "2":

                Console.Write("Nombre: ");
                string persona = Console.ReadLine()!;

                Console.Write("Id evento: ");
                int idEvento = int.Parse(Console.ReadLine()!);

                Console.Write("Entradas: ");
                int cantidad = int.Parse(Console.ReadLine()!);

                gestor.Reservar(persona, idEvento, cantidad);

                Console.WriteLine("Reserva realizada");
                break;

            case "3":

                foreach (var r in gestor.Reservas)
                {
                    Console.WriteLine(
                        $"{r.Id} - {r.Persona} - {r.Evento.Nombre} - ${r.ValorTotal} - {(r.Activa ? "Activa" : "Cancelada")}"
                    );
                }

                break;

            case "4":

                Console.Write("Id reserva: ");
                int idR = int.Parse(Console.ReadLine()!);

                gestor.Cancelar(idR);

                Console.WriteLine("Reserva cancelada");
                break;

            case "0":
                salir = true;
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}