using ProyectoFinal.CLASES;


namespace ProyectoFinal
{
    public partial class CarCustomizationPage : ContentPage
    {
        private VehiculoBase selectedCar;
        private User currentUser;

        public CarCustomizationPage(VehiculoBase car, User user)
        {
            InitializeComponent();
            selectedCar = car;
            currentUser = user;
            usuarioLabel.Text = user.Name;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            string color = colorEntry.Text;
            string modelo = modeloEntry.Text;

            selectedCar.Color = color;
            selectedCar.Modelo = modelo;
            selectedCar.Propietario = currentUser.Name;

            // Puedes realizar cualquier otra lógica aquí, como guardar los cambios en una base de datos, etc.

            DisplayAlert("Éxito", "La personalización del carro ha sido guardada.", "OK");
        }
    }
}
