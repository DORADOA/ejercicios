class Program
{
    static void Main()
    {
        IDictionary<string, int> calificacionEstudiante = new Dictionary<string, int>();
        int opcion;


        do
        {
            Console.WriteLine($"\n Menu: ");
            Console.WriteLine("1. Agregar estudiante y calificacion");
            Console.WriteLine("2. Mostrar calificacion");
            Console.WriteLine("3. Mostrar calificaciones de los estudiantes");
            Console.WriteLine("4. Agregar estudiante y calificacion");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el Apellido del estudiante:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese la calificacion del alumno:");
                    int calificacion = int.Parse(Console.ReadLine());

                    if (calificacionEstudiante.ContainsKey(nombre))
                    {
                        Console.WriteLine("El estudiante ya existe...");
                    }
                    else
                    {
                        calificacionEstudiante.Add(nombre, calificacion);
                        Console.WriteLine("Estudiante agregado...");
                    }


                    break;
                case 2:
                    if (calificacionEstudiante.Count > 0)
                    {
                        Console.WriteLine("\n calificacion de los estudiantes: ");
                        foreach (var estudiante in calificacionEstudiante)
                        {
                            Console.WriteLine($" {estudiante.Key} : {estudiante.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay estudiantes en la lista...");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese el nombre del estudiante para modificar calificacion: ");
                    string nombreBuscado = Console.ReadLine();

                    if (calificacionEstudiante.ContainsKey(nombreBuscado))
                    {
                        Console.WriteLine("Ingrese la nueva calificacion: ");
                        int nuevaCalificacion = int.Parse(Console.ReadLine());
                        calificacionEstudiante[nombreBuscado] = nuevaCalificacion;
                        Console.WriteLine("calificacion modificada...");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }
        } while (opcion != 0);
    }
}