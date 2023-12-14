using ShopApp.DataAccess;
using ShopApp.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ShopApp.Views;

public partial class HelpSupportPage : ContentPage
{
    public HelpSupportPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var dataObject = Resources["data"] as HelpSupportData;
        dataObject.VisitasPendientes = 30;
    }
}
