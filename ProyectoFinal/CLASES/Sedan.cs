using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASES
{
    public class Sedan : VehiculoBase
    {
        public int NumeroPuertas { get; set; }
        public Sedan(string marca, string modelo, string color, int anio, string placa, int numeroPuertas, int velocidadMaxima)
    : base(marca, modelo, color, anio, placa, "Sedan", velocidadMaxima)
        {
            NumeroPuertas = numeroPuertas;
        }

        public void ReproducirMusica()
        {
            Console.WriteLine("Reproduciendo música en el sedán.");
        }
    }
}
