using ShopApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopApp.ViewModels;


public class HelpSupportDetailData : BindingUtilObject
{

    public HelpSupportDetailData()
    {
        var database = new ShopDbContext();
        Products = new ObservableCollection<Product>(database.Products);
        AddCommand = new Command(() =>
        {
            var compra = new Compra(ClientId, ProductoSeleccionado.Id, Cantidad);
            Compras.Add(compra);
        },
        () => true
        );
    }

    public ICommand AddCommand { get; set; }

    private ObservableCollection<Compra> _compras = new ObservableCollection<Compra>();

    public ObservableCollection<Compra> Compras
    {
        get { return _compras; }
        set
        {
            if (Compras != value)
            {
                _compras = value;
                RaisePropertyChanged();
            }

        }
    }


    private int _ClientId;

    public int ClientId
    {
        get { return _ClientId; }
        set { _ClientId = value; }
    }


    private ObservableCollection<Product> _products;

    public ObservableCollection<Product> Products
    {
        get { return _products; }
        set
        {
            if (_products != value)
            {
                _products = value;
                RaisePropertyChanged();
            }
        }
    }

    private Product _productoSeleccionado;

    public Product ProductoSeleccionado
    {
        get { return _productoSeleccionado; }
        set
        {
            if (_productoSeleccionado != value)
            {
                _productoSeleccionado = value;
                RaisePropertyChanged();
            }

        }
    }

    private int _cantidad;

    public int Cantidad
    {
        get { return _cantidad; }
        set
        {
            if (_cantidad != value)
            {
                _cantidad = value;
                RaisePropertyChanged();
            }

        }
    }



}