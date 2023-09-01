using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio_1C
{
    internal class Flota
    {
        public List<Vehiculo> Vehiculos;

        public Flota (List<Vehiculo> vehiculos) { 
            Vehiculos= vehiculos;
        }
        public void MostrarFlota()
        {


            Vehiculos.ForEach(v =>
            {
                Console.WriteLine("Marca = " + v.Marca + ", Modelo = " + v.Modelo + ", Año = " + v.Año);
            });
                
            
        }
    }
}
