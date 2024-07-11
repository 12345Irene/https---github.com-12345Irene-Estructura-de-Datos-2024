// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ejercicio 8
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> principalList = new List<double>();
        
        Console.Write("Ingrese la cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el dato {i + 1}: ");
            double data = double.Parse(Console.ReadLine());
            principalList.Add(data);
        }
        
        // Calcular el promedio
        double average = principalList.Average();
        
        // Crear listas secundarias
        List<double> lessThanOrEqualToAverage = new List<double>();
        List<double> greaterThanAverage = new List<double>();
        
        foreach (double data in principalList)
        {
            if (data <= average)
            {
                lessThanOrEqualToAverage.Add(data);
            }
            else
            {
                greaterThanAverage.Add(data);
            }
        }
        
        // Mostrar resultados
        Console.WriteLine("\nDatos en la lista principal:");
        foreach (double data in principalList)
        {
            Console.WriteLine(data);
        }
        
        Console.WriteLine($"\nPromedio: {average}");
        
        Console.WriteLine("\nDatos iguales o menores al promedio:");
        foreach (double data in lessThanOrEqualToAverage)
        {
            Console.WriteLine(data);
        }
        
        Console.WriteLine("\nDatos mayores al promedio:");
        foreach (double data in greaterThanAverage)
        {
            Console.WriteLine(data);
        }
    }
}

// Ejercicio 9

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
