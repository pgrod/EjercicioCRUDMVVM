using EjercicioCRUDMVVM.Models;
using EjercicioCRUDMVVM.ViewModel;

namespace EjercicioCRUDMVVM.ProveedorFormView;

public partial class ProveedorFormView : ContentPage
{
    ProveedorFormViewModel ViewModel = new ProveedorFormViewModel();
    public ProveedorFormView()
    {
        InitializeComponent();
        ViewModel = new ProveedorFormViewModel();
        BindingContext = ViewModel;
    }

    public ProveedorFormView(Proveedor proveedor)
    {
        InitializeComponent();
        ViewModel = new ProveedorFormViewModel();
        BindingContext = ViewModel;
    }
}