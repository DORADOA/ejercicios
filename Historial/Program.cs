public class program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>(); //pila

        int opcion;

        do
        {
            Console.WriteLine("1. Visitar nueva página");
            Console.WriteLine("2. Retroceder página");
            Console.WriteLine("3. Mostrar historial");
            Console.WriteLine("4. Salir\n");
            opcion = int.Parse(Console.ReadLine());
            Console.Write("Opcion");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingrese la URL de la página");
                    string url = Console.ReadLine();
                    Console.Write("\n");
                    historial.Push(url);   //poner en la ultima posicion algo (en este caso de la pila)
                    Console.WriteLine($"visitando : {url}\n");
                    break;
                case 2:
                    if (historial.Count > 0) //comprobar que haya una pagina
                    {
                        string paginaAnterior = historial.Pop(); // modifica la ultima posicion
                        Console.WriteLine($"Retrocediendo desde {paginaAnterior}");
                    }
                    else
                    {
                        Console.WriteLine("No hay paginas en el historial.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Historial de navegacion:");
                    foreach (var pagina in historial)
                    {
                        Console.WriteLine(pagina);  //recorrer la pila para mostrar el historial
                    }
                    Console.WriteLine("\n");
                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir...");
        Console.ReadKey();
    }
}