using MarketSystem.Models;
using Stripe;
using System.Xml.Linq;

namespace MarketSystem.Views;

public partial class ProductRegister : ContentPage
{
	public ProductRegister()
	{
		InitializeComponent();
	}


    private void ProductRegisterClicked(object sender, EventArgs e)
    {
        Models.Product product = new Models.Product(txtnombre.Text, txtdescrip.Text, double.Parse(txtprice.Text), int.Parse(txtcantidad.Text), txtcategoria.Text) ;
      product.RegisterProduct(product);
    }

}