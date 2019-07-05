using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionesSingleton
{
    class Datos
    {
        private static Datos Instancia;
        public List<Perro> listaperros = new List<Perro>();
        private Datos() { }

        public static Datos GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Datos();
            }

            return Instancia;
        }
    }
}
