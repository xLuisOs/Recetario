using Recetas3107;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ColeccionReceta coleccionReceta = new ColeccionReceta();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar receta");
            Console.WriteLine("2. Buscar receta por nombre");
            Console.WriteLine("3. Mostrar todas las recetas");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción:");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    AgregarReceta(coleccionReceta);
                    break;
                case "2":
                    Console.Clear();
                    BuscarReceta(coleccionReceta);
                    break;
                case "3":
                    Console.Clear();
                    MostrarTodasLasRecetas(coleccionReceta);
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarReceta(ColeccionReceta coleccionReceta)
    {
        Console.WriteLine("Ingrese el nombre de la receta:");
        string nombre = Console.ReadLine();

        List<string> ingredientes = new List<string>();
        string respuesta;
        do
        {
            Console.WriteLine("Ingrese un ingrediente:");
            ingredientes.Add(Console.ReadLine());

            Console.WriteLine("¿Desea seguir agregando ingredientes? (s/n)");
            respuesta = Console.ReadLine().ToLower();
        } while (respuesta == "s");

        Console.Clear();

        Console.WriteLine("Ingrese las instrucciones:");
        string instrucciones = Console.ReadLine();

        coleccionReceta.AgregarReceta(new Receta(nombre, ingredientes, instrucciones));
        Console.WriteLine("Receta agregada exitosamente.\n");

        Console.WriteLine("Presione Enter para regresar al menú principal.");
        Console.ReadLine();
        Console.Clear();
    }

    static void BuscarReceta(ColeccionReceta coleccionReceta)
    {
        Console.WriteLine("Ingrese el nombre de la receta a buscar:");
        string nombreBusqueda = Console.ReadLine();

        Receta recetaBuscada = coleccionReceta.BuscarReceta(nombreBusqueda);
        if (recetaBuscada != null)
        {
            Console.WriteLine("Receta encontrada:");
            recetaBuscada.MostrarReceta();
        }
        else
        {
            Console.WriteLine("Receta no encontrada.");
        }

        Console.WriteLine("Presione Enter para regresar al menú principal.");
        Console.ReadLine();
        Console.Clear();
    }

    static void MostrarTodasLasRecetas(ColeccionReceta coleccionReceta)
    {
        Console.WriteLine("Todas las recetas:");
        coleccionReceta.MostrarTodasLasRecetas();

        Console.WriteLine("Presione Enter para regresar al menú principal.");
        Console.ReadLine();
        Console.Clear();
    }
}
