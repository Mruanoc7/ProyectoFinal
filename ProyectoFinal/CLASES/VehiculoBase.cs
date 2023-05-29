using ProyectoFinal.INTEFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASES
{
    public class VehiculoBase : IVehiculo
    {
        private int velocidadActual;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; private set; }
        public int VelocidadActual
        {
            get { return velocidadActual; }
            private set { velocidadActual = value; }
        }

        public string Propietario { get; internal set; }
        public string CarName => $"{Marca} {Modelo} {Color} {Anio}";
        public VehiculoBase(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Anio = anio;
            Placa = placa;
            Tipo = tipo;
            VelocidadMaxima = velocidadMaxima;
        }

        public void Bocina()
        {
            Console.WriteLine("Beep beep!");
        }

        public void Acelerar(int cuanto)
        {
            if (VelocidadActual + cuanto > VelocidadMaxima)
                VelocidadActual = VelocidadMaxima;
            else
                VelocidadActual += cuanto;
        }

        public void Encender()
        {
            Console.WriteLine("El vehículo está encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine("El vehículo está apagado.");
            VelocidadActual = 0;
        }

        public void Frenar(int cuanto)
        {
            if (VelocidadActual - cuanto < 0)
                VelocidadActual = 0;
            else
                VelocidadActual -= cuanto;
        }
    }
}
