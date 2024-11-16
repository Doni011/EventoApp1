using NovoEventoApp1.Models;

namespace NovoEventoApp1.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento; // Associando os dados do evento ao BindingContext
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Volta para a página anterior (CadastroEventoPage)
            await Navigation.PopAsync();
        }
    }
}