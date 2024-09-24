class program
{
    static void Main()
    {
        Stack<char> pila = new Stack<char>();

        Console.WriteLine("Escriba la frase:");
        string frase = Console.ReadLine();

        foreach (var cadaLetra in frase)
        {
            pila.Push(cadaLetra); //agregar al final de la fila
        }

        Console.WriteLine("Frase invertida: ");

        while (pila.Count > 0)
        {
            Console.Write(pila.Pop()); //elimina el ultimo elemento de la pila
        }

    }
}