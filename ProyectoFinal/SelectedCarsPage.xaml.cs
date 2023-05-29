using ProyectoFinal.CLASES;
using ProyectoFinal.INTEFACES;
using System.Collections.Generic;

namespace ProyectoFinal
{
    public partial class SelectedCarsPage : ContentPage
    {
        public SelectedCarsPage(List<VehiculoBase> selectedCars)
        {
            InitializeComponent();
            selectedCarsListView.ItemsSource = selectedCars;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Obt�n el carro seleccionado
            VehiculoBase selectedCar = (VehiculoBase)e.SelectedItem;

            // Redirige a la p�gina de detalles del carro y pasa el carro seleccionado como par�metro
            await Navigation.PushAsync(new CarDetailsPage(selectedCar));

            // Desmarca el elemento seleccionado para permitir selecciones futuras
            selectedCarsListView.SelectedItem = null;
        }
    }
}
