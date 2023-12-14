using Microsoft.Maui.Controls.Shapes;
using ShopApp.DataAccess;

namespace ShopApp.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        var dbcontext = new ShopDbContext();
        category.Text = dbcontext.Categories.Count().ToString();
        client.Text = dbcontext.Client.Count().ToString();
        product.Text = dbcontext.Products.Count().ToString();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        (sender as Rectangle)?.ScaleTo(2);

        (sender as Rectangle)?.TranslateTo(200,200);
    }
}