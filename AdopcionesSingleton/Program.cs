using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionesSingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Datos datos1 = Datos.GetInstancia();
            datos1.listaperros.Add(new Perro() { Id = 1,Nombre = "Perro#1" });
            datos1.listaperros.Add(new Perro() { Id = 2, Nombre = "Perro#2" });
            datos1.listaperros.Add(new Perro() { Id = 3, Nombre = "Perro#3" });
            datos1.listaperros.Add(new Perro() { Id = 4, Nombre = "Perro#4" });
            datos1.listaperros.Add(new Perro() { Id = 5, Nombre = "Perro#5" });

            foreach (Perro perro in datos1.listaperros)
            {
                Console.WriteLine("Id= " + perro.Id + " Nombre: " + perro.Nombre + " Edad: " + perro.Edad);

            }
            Console.Read();
        }

        public static void agregarnuevo()
        {
            Datos datos2 = Datos.GetInstancia();
            datos2.listaperros.Add(new Perro() { Id = 1, Nombre = "firulays"});
            datos2.listaperros.Add(new Perro() { Id = 2, Nombre = "Queso"});
            datos2.listaperros.Add(new Perro() { Id = 3, Nombre = "Coffy" });

        }
    }
}
