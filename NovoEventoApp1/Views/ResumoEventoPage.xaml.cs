using NovoEventoApp1.Models;

namespace NovoEventoApp1.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento; 
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PopAsync();
        }
    }
}