using MarketSystem.Views;

namespace MarketSystem
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ProductRegisterPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductManager());
        }
    }

}
