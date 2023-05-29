using ProyectoFinal.CLASES;


namespace ProyectoFinal
{
    public partial class Funciones : ContentPage
    {
        private VehiculoBase selectedCar;

        public Funciones(VehiculoBase car)
        {
            InitializeComponent();
            selectedCar = car;
            BindingContext = selectedCar;
        }

        private void OnEncenderClicked(object sender, EventArgs e)
        {
            // L�gica para encender el carro
            selectedCar.Encender();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            // L�gica para apagar el carro
            selectedCar.Apagar();
        }

        private void OnAcelerarClicked(object sender, EventArgs e)
        {
            // L�gica para acelerar el carro
            selectedCar.Acelerar(10);
        }

        private void OnFrenarClicked(object sender, EventArgs e)
        {
            // L�gica para frenar el carro
            selectedCar.Frenar(10);
        }
    }
}
