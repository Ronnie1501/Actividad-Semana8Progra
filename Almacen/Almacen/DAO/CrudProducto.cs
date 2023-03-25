using Almacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.DAO
{
    internal class CrudProducto
    {
        public void AgregarProducto(Producto ParametroProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = ParametroProducto.Nombre;
                producto.Descripción = ParametroProducto.Descripción;
                producto.Precio = ParametroProducto.Precio;
                producto.Stock = ParametroProducto.Stock;
                db.Add(producto);
                db.SaveChanges();

            }
        }
    }
}
