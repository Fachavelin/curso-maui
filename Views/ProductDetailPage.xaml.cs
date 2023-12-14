
using ShopApp.DataAccess;

namespace ShopApp.Views;

public partial class ProductDetailPage : ContentPage , IQueryAttributable
{
	public ProductDetailPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
		var dbContext = new ShopDbContext();
		var id = int.Parse(query["id"].ToString());
		var product =  dbContext.Products.FirstOrDefault(x => x.Id == id);

		container.Children.Add(new Label { Text = product.Nombre });
        container.Children.Add(new Label { Text = product.Decription });
        container.Children.Add(new Label { Text = product.Precio.ToString() });


    }
}