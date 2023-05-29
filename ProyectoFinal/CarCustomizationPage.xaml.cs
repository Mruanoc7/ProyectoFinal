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

            // Puedes realizar cualquier otra l�gica aqu�, como guardar los cambios en una base de datos, etc.

            DisplayAlert("�xito", "La personalizaci�n del carro ha sido guardada.", "OK");
        }
    }
}
