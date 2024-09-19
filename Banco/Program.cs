public class Cliente
{
    public string Nombre { get; private set; }
    public int NumeroDeCliente { get; private set; }

    public Cliente (string nombre, int numero)
    {
        Nombre = nombre;
        NumeroDeCliente = numero;
    }


}
public class Program
{
    static void Main()
    {
        Queue<Cliente> colaClientes = new Queue<Cliente>();
        int opcion;

        do
        {
            Console.WriteLine("1. agregar cliente a la cola");
            Console.WriteLine("2. atender a un cliente");
            Console.WriteLine("3. Mostrar clientes en cola");
            Console.WriteLine("4. Salir\n");
            opcion = int.Parse(Console.ReadLine());
            Console.Write("Opcion");

            switch (opcion)
            {
                case 1:
                    Console.Write("ingrese el nombre del cliente");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("ingrese el numero del cliente");
                    int numero = int.Parse(Console.ReadLine());

                    Cliente c = new Cliente(nombre, numero);
                    colaClientes.Enqueue(c);
                    Console.Write("\n");
                    break;
                case 2:
                    if (colaClientes.Count > 0)
                    {
                        Cliente clienteAtendido = colaClientes.Dequeue(); //saca de la lista y lo devuelve
                        Console.WriteLine($"atendiendo a: {clienteAtendido.Nombre}, {clienteAtendido.NumeroDeCliente} ");
                    }
                    else
                    {
                        Console.WriteLine("no hay clientes en la cola");
                    }

                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine("clientes en la cola : ");
                    foreach (var cliente in colaClientes)
                    {
                        Console.WriteLine($"{cliente.Nombre}, {cliente.NumeroDeCliente}");
                    }
                    Console.WriteLine("\n");
                    
                    break;
            }
        }
        while (opcion != 4);
    }
}