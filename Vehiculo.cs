using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1C
{
    public class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int? Año { get; set; }

        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual void MostrarInformacion(Vehiculo a)
        {
            Marca = a.Marca;
            Modelo = a.Modelo;
            Año = a.Año;
            Console.WriteLine("Marca = " + Marca + ", Modelo = " + Modelo + ", Año = " + Año);
        }
    }
}
