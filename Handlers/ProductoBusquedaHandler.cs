using ShopApp.DataAccess;
using ShopApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Handlers;

public class ProductoBusquedaHandler : SearchHandler
{

    ShopDbContext dbContext;

    public ProductoBusquedaHandler()
    {
        this.dbContext = new ShopDbContext();
    }

    protected override void OnQueryChanged(string oldValue, string newValue)
    {
        if (string.IsNullOrEmpty(newValue))
        {
            ItemsSource = null;

            return;
        }

        var res = dbContext.Products
            .Where(p => p.Nombre.ToLowerInvariant()
            .Contains(newValue.ToLowerInvariant())).ToList();

        ItemsSource = res;  
    }

    protected override async void OnItemSelected(object item)
    {
       await Shell.Current.
             GoToAsync($"{nameof(ProductDetailPage)}?id={((Product)item).Id}");
    }
}
