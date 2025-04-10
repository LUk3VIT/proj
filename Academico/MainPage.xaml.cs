namespace Academico
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnAddOnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Add());
        }

        private async void btnUpOnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new up());
        }

        private async void btnDeletOnClick(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Excluir", "Tem certeza que deseja Excluir: ", "Sim", "Não");
        }

    }

}
