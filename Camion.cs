using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1C
{
    public class Camion : Vehiculo
    {

        public double? CapacidadCarga { get; set; }

        
        public Camion(string marca, string modelo, int año, double capacidadCarga) : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override void MostrarInformacion(Vehiculo a)
        {
            base.MostrarInformacion(a);
            Console.WriteLine("Capacidad Carga : " + CapacidadCarga);
        }
    }
}
