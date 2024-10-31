using linq.Models;
using System.Xml.Serialization;

namespace linq
{


    public class Program
    {
        static void Main()
        {
            //Ejemplo1();
            //Ejemplo2();
            //Ejemplo3();
            Ejemplo4();

        }
        static void Ejemplo1()
        {
            List<Producto> productos = new List<Producto> { 
            new Producto{Id= 1, Nombre = "Camiseta", Precio = 25},
            new Producto{Id= 2, Nombre = "Pantalon", Precio = 55},
            new Producto{Id= 3, Nombre = "Zapatos", Precio = 75},
            new Producto{Id= 4, Nombre = "Sombrero", Precio = 30},
            
            };

            var productosFiltrados = from p in productos
                                     where p.Precio > 50
                                     orderby p.Nombre
                                     select p;

            var productosFiltrados2 = productos
                .Select(p => p)
                .Where(p=> p.Precio> 50)
                .OrderBy(p=>p.Nombre)
                .ToList();
                                    

            foreach (var prod in productosFiltrados2)
            {
                Console.WriteLine($"{prod.Nombre} - {prod.Precio:C}");
            }
        }

        static void Ejemplo2()
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante{Nombre = "Pedro", Calificacion = 100 },
                new Estudiante{Nombre = "Juan", Calificacion = 100 },
                new Estudiante { Nombre = "Luis", Calificacion = 88 },
                new Estudiante {Nombre = "Ana", Calificacion = 92 },
                new Estudiante{Nombre = "Maria", Calificacion = 74 },
                new Estudiante{Nombre = "Carlos", Calificacion = 50 }
            };

            var estPorCalificacion = from e in estudiantes
                                     group e by e.Calificacion into grupo
                                     select grupo;

            foreach (var grupo in estPorCalificacion)
            {
                Console.WriteLine($"Calificacion: {grupo.Key}");
                foreach (var e in grupo)
                {
                    Console.WriteLine($"- {e.Nombre}");
                }
            }
        }

        static void Ejemplo3() 
        {
            List<Cliente> clientes = new List<Cliente> 
            {
                new Cliente{Id = 1, Nombre = "Pedro"},
                new Cliente{Id = 2, Nombre = "Ana"},
                new Cliente{Id = 3, Nombre = "Julia"},
            };

            List<Pedido> pedidos = new List<Pedido>
            {
                new Pedido {Id = 1, ClienteId = 1, Producto = "Libro"},
                new Pedido {Id = 2, ClienteId = 2, Producto = "Pala"},
                new Pedido {Id = 3, ClienteId = 3, Producto = "Tablet"},
                new Pedido {Id = 4, ClienteId = 1, Producto = "Cuadernillo"},
            };

            var pedidosClientes = from c in clientes
                                  join p in pedidos on c.Id equals p.ClienteId
                                  select new { c.Nombre, p.Producto };

            foreach (var item in pedidosClientes)
            {
                Console.WriteLine($"{item.Nombre} ha comprado un(a) {item.Producto}");
            }

        }

        static void Ejemplo4()
        {
            List<string> nombres = new List<string>
            {
                "Ana", "Luis", "Carlos", "Luis", "Sofia", "Ana"
            };

            var nombresUnicos = (from nombre in nombres
                                 select nombre).Distinct();

            foreach (var nombre in nombresUnicos)
            {
                Console.WriteLine(nombre);
            }

        }
    }
}