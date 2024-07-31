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
        public string Ingredientes { get; set; }
        public string Procedimiento { get; set; }
        public Receta(string nombre, string ingredientes, string procedimiento)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Procedimiento = procedimiento;
        }
    }
}
