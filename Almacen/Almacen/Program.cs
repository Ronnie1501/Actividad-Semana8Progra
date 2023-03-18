using Microsoft.EntityFrameworkCore;
using Almacen.Models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la descripción del producto:");
            string descripcionProducto = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de producto");
            int StockProducto = int.Parse(Console.ReadLine());

            // Crea una nueva instancia 
            using (var context = new AlmacenContext())
            {
                // Crea una nueva instancia 
                var nuevoProducto = new Producto
                {
                    Nombre = nombreProducto,
                    Precio = precioProducto,
                    Descripción = descripcionProducto,
                    Stock = StockProducto,
                };

                // Agrega el nuevo objeto a la base de datos
                context.Productos.Add(nuevoProducto);

                // Guarda los cambios en la base de datos
                context.SaveChanges();

                Console.WriteLine("El producto ha sido agregado a la base de datos.");


                // Consulta los datos de la base de datos y los muestra en la consola
                var productos = context.Productos.ToList();
                Console.WriteLine("\nLista de productos registrados en la base de datos:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Descripción: {producto.Descripción}, Stock: {producto.Stock}");
                }
            }
        }
    }
}