using System.ComponentModel.DataAnnotations.Schema;

class Ticket
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public Ticket(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
   
    class SistemaTickets
    {
       private Queue<Ticket> cola = new Queue<Ticket>();

       private int siguienteId= 0;
       
        public void AgregarTicket(string descripcion)
        {
            Ticket nuevoTicket = new Ticket(++siguienteId, descripcion);
            cola.Enqueue(nuevoTicket);
            Console.WriteLine($"Ticket #{nuevoTicket.Id} agregado: {nuevoTicket.Descripcion}");

        }

        public void ProcesarTicket()
        {
            if(cola.Count == 0)
            {
                Console.WriteLine("No hay tickets para procesar");
                return;
            }

            Ticket ticket = cola.Dequeue(); // funciona igual que la funcion pop
            Console.WriteLine($"Procesando ticket #{ticket.Id}: {ticket.Descripcion}");
        }

        public void MostrarTickets()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay tickets para procesar");
                return;
            }
            Console.WriteLine("Tickets Pendientes: ");
            foreach(var ticket in cola)
            {
                Console.WriteLine($"ticket #{ticket.Id} descripcion {ticket.Descripcion}");
            }

        }


 
    }

    class program
    {
        static void Main()
        {
            SistemaTickets sistema = new SistemaTickets();
            int opcion;
            do
            {
                Console.WriteLine($"=== Menu de opciones ===");
                Console.WriteLine("1. Agregar nuevo ticket");
                Console.WriteLine("2. Mostrar Ticket");
                Console.WriteLine("3. Procesar Ticket");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion = int.Parse( Console.ReadLine() );


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la descripcion del Ticket: ");
                        string descripcion = Console.ReadLine();
                        sistema.AgregarTicket(descripcion);

                        break;
                    case 2:
                        sistema.ProcesarTicket();
                        break;
                    case 3:
                        sistema.MostrarTickets();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo");
                        break;
                    
                }

            } while (opcion != 4);
        }
    }
}