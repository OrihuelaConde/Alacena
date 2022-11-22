using System;
using System.Collections.Generic;
using System.Linq;

namespace Alacena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            List<Producto> productos = new List<Producto>();
            do
            {
                MostrarProductos();
                Console.WriteLine();
                Console.WriteLine("1- Agregar producto");
                Console.WriteLine("2- Eliminar producto");
                Console.WriteLine("3- Mostrar productos vencidos");
                Console.WriteLine("4- Exportar productos vencidos");
                Console.WriteLine("0- Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Producto nuevoProducto = new Producto();
                        if(productos.Any())
                            nuevoProducto.id = productos.Max(p => p.id) + 1;
                        else
                            nuevoProducto.id = 1;
                        Console.Write("Nombre: ");
                        nuevoProducto.nombre = Console.ReadLine();
                        Console.Write("Marca: ");
                        nuevoProducto.marca = Console.ReadLine();
                        Console.Write("Cantidad: ");
                        nuevoProducto.cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Fecha de vencimiento (DD/MM/YY): ");
                        nuevoProducto.fechaDeVencimiento = DateTime.Parse(Console.ReadLine());
                        productos.Add(nuevoProducto);
                        break;
                    case 2:
                        // Implementar
                        break;
                    case 3:
                        // Implementar
                        break;
                    case 4:
                        // Implementar
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);

            void MostrarProductos()
            {
                foreach (Producto producto in productos)
                {
                    Console.Write("ID: " + producto.id);
                    Console.Write(" - " + producto.nombre);
                    Console.Write(" " + producto.marca);
                    Console.Write(" (" + producto.cantidad + ")");
                    Console.WriteLine(" - " + producto.fechaDeVencimiento.ToShortDateString());                    
                }                
            }
        }
    }
}
