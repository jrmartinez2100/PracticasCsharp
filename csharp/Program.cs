using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            String Linea;
            Console.WriteLine("Ingrese el primer valor :");
            Linea = Console.ReadLine();
            num1 = int.Parse(Linea);
            Console.WriteLine("Ingrese el segundo valor :");
            Linea = Console.ReadLine();
            num2 = int.Parse(Linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine("La suma de los dos valores es :");
            Console.WriteLine(suma);
            Console.WriteLine("El producto de los dos valores es :");
            Console.WriteLine(producto);
        }
    }
}
