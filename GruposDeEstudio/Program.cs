class Estudiante
{
    public string Nombre { get; set; }

    public List<string> Materias = new List<string>();

    public Estudiante(string nombre, List<string> materias)
    {
        Nombre = nombre;
        Materias = materias;

    }

    public class GrupoEstudiante
    {
        public string NombreGrupo { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public GrupoEstudiante(string nombreGrupo)
        {
            NombreGrupo = nombreGrupo;
            Estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void MostrarEstudiantesPorMateria(string materia)
        {
            Console.WriteLine($"Estudiantes en ek grupo{NombreGrupo} que estan inscriptos en {materia}");
            foreach(var est in Estudiantes)
            {
                if (est.Materias.Contains(materia))
                {
                    Console.WriteLine($"- {est.Nombre}");
                }
            }
        }
    }


    public static class SistemaGrupos
    {
        static Dictionary<string, GrupoEstudiante> grupos = new Dictionary<string, GrupoEstudiante>();
        public static void CrearGrupo()
        {
            
            Console.Write("Ingrese el nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();

            grupos[nombreGrupo] = new GrupoEstudiante(nombreGrupo);
            Console.WriteLine($"Grupo de estudio '{nombreGrupo}' creado");

        }
        public static void AgregarEstudiante()
        {
            Console.WriteLine("Ingrese el nombre del grupo al que quiere agregar el estudiante: ");
            string nombreGrupo = Console.ReadLine();
            if (grupos.ContainsKey(nombreGrupo))
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                string nombreEstudiante = Console.ReadLine();

                Console.WriteLine("Ingrese las materias del estudiante, separadas por coma: ");
                string materiasInput = Console.ReadLine();
                List<string> materias = new List<string>(materiasInput.Split(","));

                Estudiante estudiante = new Estudiante(nombreEstudiante, materias);
                grupos[nombreGrupo].AgregarEstudiante(estudiante);

                Console.WriteLine($"Estudiante {nombreEstudiante} agregado al grupo {nombreGrupo}");
            }
            else
            {
                Console.WriteLine("El grupo no existe. ");
            }
        }
        public static void MostrarEstudiantesPorMateria()
        {
            Console.WriteLine("Ingrese el nombre del grupo: ");
            string nombreGrupo = Console.ReadLine();
            if (grupos.ContainsKey(nombreGrupo))
            {
                Console.WriteLine("Ingrese la materia para filtrar: ");
                string materia = Console.ReadLine();

                grupos[nombreGrupo].MostrarEstudiantesPorMateria(materia);
            }
            else
            {
                Console.WriteLine("El grupo no existe");
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            int opcion;
            

            do
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Crear grupo de estudio");
                Console.WriteLine("2. Agregar estudiante a un grupo");
                Console.WriteLine("3. Mostrar estudiantes por materia");
                Console.WriteLine("Salir...");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SistemaGrupos.CrearGrupo();
                        
                        break;
                    case 2:
                        SistemaGrupos.AgregarEstudiante();
                        break;
                    case 3:
                        SistemaGrupos.MostrarEstudiantesPorMateria();
                        break;
                    
                }
            }
             while (opcion != 4);
        }
    }
}