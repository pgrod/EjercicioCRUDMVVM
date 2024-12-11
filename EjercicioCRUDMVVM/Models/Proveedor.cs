using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCRUDMVVM.Models
{
    public class Proveedor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public string Direccion { get; set; }
        [NotNull]
        public string Telefono { get; set; }
        [NotNull]
        public string Email { get; set; }
        [NotNull]
        public string Producto { get; set; }
    }
}
