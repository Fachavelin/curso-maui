using ShopApp.DataAccess;
using ShopApp.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ShopApp.Views;

public partial class HelpSupportDetailPage : ContentPage, IQueryAttributable
{
    public HelpSupportDetailPage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Title = $"Cliente: {query["id"]}";
        var clientId = int.Parse(query["id"].ToString());
        (BindingContext as HelpSupportDetailData).ClientId = clientId;
    }


}
