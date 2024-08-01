using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas3107
{
    internal class ColeccionReceta
    {
        private List<Receta> recetas = new List<Receta>();

        public void AgregarReceta(Receta receta)
        {
            recetas.Add(receta);
        }
        public Receta BuscarReceta(string nombre)
        {
            foreach (Receta receta in recetas)
            {
                if (receta.Nombre.ToLower() == nombre.ToLower())
                {
                    return receta;
                }
            }
            return null;
        }
        public void MostrarTodasLasRecetas()
        {
            foreach (Receta receta in recetas)
            {
                receta.MostrarReceta();
            }
        }
    }
}
