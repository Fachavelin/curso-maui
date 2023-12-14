using ShopApp.DataAccess;

namespace ShopApp.Views;

public partial class ClientsPage : ContentPage
{
	public ClientsPage()
	{
		InitializeComponent();

        var dbContext = new ShopDbContext();

        foreach (var client in dbContext.Client)
        {
            container.Children.Add(new Label() { Text = client.Nombre });
        }
    }
}