namespace Genericos
{
    public class Almacen<T> //clase generica
    {
        private T _item;  //puede ser cualquier cosa(inr, string,etc)

        public void Guardar(T nuevoItem)
        {
            _item = nuevoItem;
            Console.WriteLine($"Item guardado: {_item}");
        }

        public T Obtener()
        {
            return _item;
        }
        // T no es igual a Any
    }
    public class Utilidades
    {
        public static void Intercambiar<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    public delegate T Operacion<T>(T valor1, T valor2);  //delegado generico

    public class Calculadora
    {
        public static int Sumar(int a, int b) => a + b;
        public static string Concatenar(string a, string b)=>a+ b;
    }

    class Program
    {
        static void Main()
        {
            //Ejemplo1();
            //Ejemplo2();
            Ejemplo3();
        }

        static void Ejemplo1()
        {
            Almacen<int> almacenEnteros = new(); //se le pasa el tipo de datos a usar en <int>
            almacenEnteros.Guardar(42);
            Console.WriteLine($"Item recuperado: {almacenEnteros.Obtener()}");

            Almacen<string> almacenTexto = new(); //se le pasa el tipo de datos a usar en <string>
            almacenTexto.Guardar("Hola Generics");
            Console.WriteLine($"Item recuperado: {almacenTexto.Obtener()}");
        }

        static void Ejemplo2()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Antes de intercambiar: x = {x}, y = {y}");
            Utilidades.Intercambiar(ref x, ref y);  //parametros de referencia
            Console.WriteLine($"Despues de intercambiar: x = {x}, y = {y}");

            string str1 = "Hola";
            string str2 = "Mundo";

            Console.WriteLine($"Antes de intercambiar: str1 = {str1}, str2 = {str2}");
            Utilidades.Intercambiar(ref str1, ref str2);  //parametros de referencia
            Console.WriteLine($"Despues de intercambiar: str1 = {str1}, str2 = {str2}");
        }

        static void Ejemplo3()
        {
            Operacion<int> operacionSuma = Calculadora.Sumar;
            Console.WriteLine($"Suma de enteros: {operacionSuma(5, 11)}");

            Operacion<string> operacionConcatenar = Calculadora.Concatenar;
            Console.WriteLine($"Concatenacion de cadenas: {operacionConcatenar("Hola","Mundo")}");
        }
    }
}