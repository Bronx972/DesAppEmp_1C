using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1C
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

     
        public Automovil(string marca, string modelo, int año, string combustible ) : base (marca, modelo, año)
        {
            Combustible = combustible;
        }

        public override void MostrarInformacion(Vehiculo a)
        {
            base.MostrarInformacion(a);
            Console.WriteLine("Combustible : " + Combustible);
        }

    }
}
