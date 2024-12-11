using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EjercicioCRUDMVVM.Models;
using EjercicioCRUDMVVM.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCRUDMVVM.ViewModel
{
    public partial class ProveedorFormViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string direccion;

        [ObservableProperty]
        private string telefono;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string producto;

        private readonly ServicesProveedores service;

        public ProveedorFormViewModel()
        {
            service = new ServicesProveedores();
        }

        public ProveedorFormViewModel(Proveedor proveedor)
        {
            service = new ServicesProveedores();
            id = proveedor.Id;
            nombre = proveedor.Nombre;
            direccion = proveedor.Direccion;
            telefono = proveedor.Telefono;
            email = proveedor.Email;
            producto = proveedor.Producto;
        }

        private void Alerta(string Titulo, string Mensaje)

        {

            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));

        }

        [RelayCommand]
        private async Task AddUpdate()
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Id = id;
                proveedor.Nombre = nombre;
                proveedor.Direccion = direccion;
                proveedor.Telefono = telefono;
                proveedor.Email = email;
                proveedor.Producto = producto;
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
            }
        private bool Validar(Proveedor proveedor)
        {
            if(proveedor.Nombre == null || proveedor.Nombre == "")
            {
                Alerta("Advertencia", "Ingrese el nombre del proveedor");
                return false;
            }else if(proveedor.Producto == null || proveedor.Producto == "")
            {
                Alerta("Advertencia", "Ingrese el producto del proveedor");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
