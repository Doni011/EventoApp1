using NovoEventoApp1.Models;

namespace NovoEventoApp1.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public CadastroEventoPage()
        {
            InitializeComponent();

            Evento = new Evento
            {
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1)
            };

            BindingContext = Evento; 
        }

        private async void OnSalvarEventoClicked(object sender, EventArgs e)
        {
            // Validação de dados
            if (string.IsNullOrEmpty(Evento.Nome))
            {
                await DisplayAlert("Erro", "O nome do evento é obrigatório.", "OK");
                return;
            }

            if (Evento.DataTermino < Evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            if (Evento.NumeroParticipantes <= 0)
            {
                await DisplayAlert("Erro", "O número de participantes deve ser maior que zero.", "OK");
                return;
            }

            if (Evento.CustoPorParticipante <= 0)
            {
                await DisplayAlert("Erro", "O custo por participante deve ser maior que zero.", "OK");
                return;
            }

            
            await Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}