using ProyectoFinal.CLASES;
using ProyectoFinal.INTEFACES;
using System.ComponentModel;
using System.Threading.Tasks;


namespace ProyectoFinal
{
    public partial class CarDetailsPage : ContentPage
    {
        public IVehiculo Car { get; set; }

        public CarDetailsPage(IVehiculo car)
        {
            InitializeComponent();
            Car = car;
            BindingContext = this;

          
        }

        public string CarName => $"{Car.Marca} {Car.Modelo} {Car.Color} {Car.Anio}";
        public string CarDetails => $"Placa: {Car.Placa}\nVelocidad actual: {Car.VelocidadActual}";

       
        private async void OnEncenderClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Acción realizada", "El carro ha sido encendido", "Aceptar");
        }

        private async void OnApagarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Acción realizada", "El carro ha sido apagado", "Aceptar");
        }

        private async void OnAcelerarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Acción realizada", "El carro ha acelerado", "Aceptar");
        }

        private async void OnFrenarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Acción realizada", "El carro ha frenado", "Aceptar");
        }
    }
}
