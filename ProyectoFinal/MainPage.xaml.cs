using ProyectoFinal.CLASES;


namespace ProyectoFinal
{
    public partial class MainPage : ContentPage
    {
        private User currentUser;
        private VehiculoBase selectedCar;
        private List<VehiculoBase> selectedCars = new List<VehiculoBase>();
      
        public MainPage()
        {
            InitializeComponent();

            // Simulación de inicio de sesión
            currentUser = new User { Name = "John Doe" };
        }


        private void OnCarButtonClicked(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string carType = button.CommandParameter.ToString();

            CarCustomizationPage customizationPage;
            if (carType == "pickup")
            {
                PickUp pickup = new PickUp("Ford", "Ranger", "Rojo", 2022, "ABC123", "Cajas", 180);
                pickup.Carga = "Herramientas";
                selectedCar = pickup;
            }
            else if (carType == "sedan")
            {
                Sedan sedan = new Sedan("Toyota", "Corolla", "Blanco", 2023, "DEF456", 4, 200);
                sedan.NumeroPuertas = 4;
                selectedCar = sedan;
            }
            else if (carType == "suv")
            {
                SUV suv = new SUV("Jeep", "Wrangler", "Negro", 2023, "GHI789", true, 220);
                selectedCar = suv;
            }
            else
            {
                return;
            }
            selectedCars.Add(selectedCar);

            customizationPage = new CarCustomizationPage(selectedCar, currentUser);
            customizationPage.Disappearing += CustomizationPage_Disappearing;
            Navigation.PushAsync(customizationPage);
        }

        private void CustomizationPage_Disappearing(object sender, EventArgs e)
        {
            CarCustomizationPage customizationPage = (CarCustomizationPage)sender;
            if (customizationPage.BindingContext is VehiculoBase customizedCar)
            {
                // Actualizar la información del carro después de personalizarlo
                selectedCar.Marca = customizedCar.Marca;
                selectedCar.Modelo = customizedCar.Modelo;
                selectedCar.Color = customizedCar.Color;
                selectedCar.Propietario = currentUser.Name; // Asignar el nombre del usuario activo

                // Aquí puedes realizar cualquier otra lógica con el carro personalizado, como guardar los cambios en una base de datos, etc.

                // Reiniciar la selección del carro para evitar conflictos si se selecciona otro carro sin personalizar
                selectedCar = null;
            }
        }
        private async void OnViewSelectedCarsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectedCarsPage(selectedCars));
        }



    }
}
