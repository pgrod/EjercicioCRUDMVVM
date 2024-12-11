
using EjercicioCRUDMVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCRUDMVVM.Servicio
{
    public class ServicesProveedores
    {
        private readonly SQLiteConnection _connection;

        public ServicesProveedores()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Proveedor.db3");
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<Proveedor>();

            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = "Diunsa";
            proveedor.Direccion = "Miraflores";
            proveedor.Telefono = "12345";
            proveedor.Email = "Diunsa@gmail.com";
            proveedor.Producto = "Electrodomesticos";
            Insert(proveedor);
        }

        public List<Proveedor> GetAll()
        {
            var res = _connection.Table<Proveedor>().ToList();
            return res;
        }

        public int Insert(Proveedor proveedor)
        {
            return _connection.Insert(proveedor);
        }

        public int Update(Proveedor proveedor) 
        { 
            return _connection.Update(proveedor);
        }

        public int Delete(Proveedor proveedor)
        {
            return _connection.Delete(proveedor);
        }
    }
}
