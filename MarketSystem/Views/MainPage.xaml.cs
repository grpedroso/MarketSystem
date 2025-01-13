using MarketSystem.Views;

namespace MarketSystem
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ProductManagerPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductManager());
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
