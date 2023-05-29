using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASES
{
    public class PickUp : VehiculoBase
    {
        public string Carga { get; set; }

        public PickUp(string marca, string modelo, string color, int anio, string placa, string carga, int velocidadMaxima)
            : base(marca, modelo, color, anio, placa, "PickUp", velocidadMaxima)
        {
            Carga = carga;
        }

        public void Transportar()
        {
            Console.WriteLine("Transportando carga: " + Carga);
        }
    }
}
