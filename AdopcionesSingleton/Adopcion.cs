using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdopcionesSingleton
{
    class Adopcion
    {
        public Persona PersonaAdoptar { set; get; }
        public Perro PerroAdoptaddo { set; get; }
        public DateTime FechaAdopcion
        {
            get
            {
                return DateTime.Now;    
            }
        }
    }
}
