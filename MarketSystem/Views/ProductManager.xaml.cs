namespace MarketSystem.Views;

public partial class ProductManager : ContentPage
{
	public ProductManager()
	{
		InitializeComponent();
	}

    private async void ProductRegisterPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductRegister());
    }

}