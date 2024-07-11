// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// ejercicio 9

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Definir las dos listas
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();

        // Pedir al usuario la cantidad de datos a ingresar
        Console.Write("Ingrese la cantidad de datos a manejar: ");
        int cantidadDatos = int.Parse(Console.ReadLine());

        // Ciclo de carga para la primera lista
        Console.WriteLine("Cargando datos para la primera lista:");
        for (int i = 0; i < cantidadDatos; i++)
        {
            Console.Write($"Ingrese dato {i + 1}: ");
            int dato = int.Parse(Console.ReadLine());
            lista1.Add(dato);
        }

        // Ciclo de carga para la segunda lista
        Console.WriteLine("Cargando datos para la segunda lista:");
        for (int i = 0; i < cantidadDatos; i++)
        {
            Console.Write($"Ingrese dato {i + 1}: ");
            int dato = int.Parse(Console.ReadLine());
            lista2.Add(dato);
        }

        // Comparar las listas
        if (CompararListas(lista1, lista2))
        {
            Console.WriteLine("a. Las listas son iguales en tamaño y contenido.");
        }
        else if (lista1.Count == lista2.Count)
        {
            Console.WriteLine("b. Las listas son iguales en tamaño pero no en contenido.");
        }
        else
        {
            Console.WriteLine("c. No tienen el mismo tamaño ni contenido.");
        }
    }

    // Método para comparar listas
    static bool CompararListas(List<int> lista1, List<int> lista2)
    {
        if (lista1.Count != lista2.Count)
        {
            return false;
        }

        for (int i = 0; i < lista1.Count; i++)
        {
            if (lista1[i] != lista2[i])
            {
                return false;
            }
        }

        return true;
    }
}



// Ejercicio 8
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> datosPrincipales = new List<double>();
        List<double> datosMenoresOIguales = new List<double>();
        List<double> datosMayores = new List<double>();

        // Ingreso de datos
        Console.WriteLine("Ingrese los datos (ingrese 'fin' para terminar):");
        string input;
        while ((input = Console.ReadLine()) != "fin")
        {
            if (double.TryParse(input, out double dato))
            {
                datosPrincipales.Add(dato);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número real válido o 'fin' para terminar.");
            }
        }

        if (datosPrincipales.Count > 0)
        {
            // Calcular el promedio
            double promedio = datosPrincipales.Average();

            // Separar los datos en las listas correspondientes
            foreach (var dato in datosPrincipales)
            {
                if (dato <= promedio)
                {
                    datosMenoresOIguales.Add(dato);
                }
                else
                {
                    datosMayores.Add(dato);
                }
            }

            // Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine("a. Datos cargados en la lista principal:");
            ImprimirLista(datosPrincipales);

            Console.WriteLine($"\nb. El promedio de los datos cargados es: {promedio}");

            Console.WriteLine("\nc. Datos menores o iguales al promedio:");
            ImprimirLista(datosMenoresOIguales);

            Console.WriteLine("\nd. Datos mayores al promedio:");
            ImprimirLista(datosMayores);
        }
        else
        {
            Console.WriteLine("No se ingresaron datos.");
        }
    }

    static void ImprimirLista(List<double> lista)
    {
        foreach (var dato in lista)
        {
            Console.Write($"{dato} ");
        }
        Console.WriteLine();
    }
}
