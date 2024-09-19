public class Tarea
{
    public string Descripcion { get; private set; }

    public bool Completada { get; private set; }

    public Tarea(string descripcion)
    {
        Descripcion = descripcion;
        Completada = false;
    }


    public class program
    {
        static void Main()
        {
            List<Tarea> listatareas = new List<Tarea>();
            int opcion;
            do
            {

                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Marcar tarea completada");
                Console.WriteLine("3. Mostrar tareas pendientes");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la descripcion de la tarea");
                        string descripcion = Console.ReadLine();
                        Tarea tarea = new Tarea(descripcion);
                        listatareas.Add(tarea);
                        break;
                    case 2:
                        Console.Write("Ingrese el nro de tarea a completar");
                        int numero = int.Parse(Console.ReadLine()) - 1; //los array comienzan en 0
                        if (numero >= 0 && numero < listatareas.Count)
                        {
                            listatareas[numero].Completada = true;  //pasamos a true para marcar como completada
                            Console.WriteLine("Tarea completada.");
                        }
                        else
                        {
                            Console.WriteLine("numero de tarea invalido");
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Tareas pendientes :");
                        for (int i = 0; i < listatareas.Count; i++)
                        {
                            if (!listatareas[i].Completada)
                            {
                                Console.WriteLine($" {i + 1}. {listatareas[i].Descripcion}");
                            }
                        }
                        Console.WriteLine("\n");
                        break;
                }
            }
            while (opcion != 4);
        }
    }
}
//mostrar todas las tareas, tareas completada y editar tareas