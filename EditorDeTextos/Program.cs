public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Dictionary<string , int> contadorPalabras = new Dictionary<string , int>();  //palabras, cantidad de veces que aparece
        string[] palabras = texto.Split(" ");  //separar un string

        foreach (string palabra in palabras)
        {
            if(contadorPalabras.ContainsKey(palabra)) //el diccionario tiene la key buscada?
            {
                contadorPalabras[palabra]++;
            }
            else
            {
                contadorPalabras.Add(palabra, 1);
            }
            
        }
        Console.WriteLine("\n");
        Console.WriteLine("Frecuencias de palabras: ");
        foreach (var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }
    }
}
