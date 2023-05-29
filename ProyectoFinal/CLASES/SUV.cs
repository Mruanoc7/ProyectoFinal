using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASES
{
    public class SUV : VehiculoBase
    {
        public bool Es4x4 { get; set; }
        public SUV(string marca, string modelo, string color, int anio, string placa, bool es4x4, int velocidadMaxima)
    : base(marca, modelo, color, anio, placa, "SUV", velocidadMaxima)
        {
            Es4x4 = es4x4;
        }

        public void ActivarModoOffRoad()
        {
            Console.WriteLine("Modo off-road activado en el SUV.");
        }
    }
}
