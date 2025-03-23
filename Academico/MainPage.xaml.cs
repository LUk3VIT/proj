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

    }

}
