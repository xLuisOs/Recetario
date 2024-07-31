using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas3107
{
    internal class Receta
    {
        public string Nombre { get; set; }
        public List<string> Ingredientes { get; set; }
        public string Instrucciones { get; set; }
        public Receta(string nombre, List<string> ingredientes, string instrucciones)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Instrucciones = instrucciones;
        }

        public void MostrarReceta()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("Ingredientes: ");
            foreach (var ingredient in Ingredientes)
            {
                Console.WriteLine($"{ingredient}");
            }
            Console.WriteLine($"Instrucciones: {Instrucciones}");
        }
    }
   
}
