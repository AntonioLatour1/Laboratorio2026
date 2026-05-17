using System;

namespace clase152
{
    struct Producto
    {
        public string nombre;
        public double precio;
        public int stock;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos = new Producto[5];
            double max = 0;
            double totalstock = 0;
            bool key = false;
            string maxnombre = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre del producto numero {i + 1}");
                productos[i].nombre = Console.ReadLine();

                while (key == false)
                {
                    Console.WriteLine($"Ingrese el precio de el producto numero {i + 1}");

                    if (double.TryParse(Console.ReadLine(), out productos[i].precio))
                    {
                        Console.WriteLine("Precio ingresado correctamente.");

                        if (productos[i].precio > max)
                        {
                            max = productos[i].precio;
                            maxnombre = productos[i].nombre;
                        }

                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un precio valido");
                    }
                }

                key = false;

                while (key == false)
                {
                    Console.WriteLine($"Ingrese el stock del producto numero {i + 1}");

                    if (int.TryParse(Console.ReadLine(), out productos[i].stock))
                    {
                        Console.WriteLine("Stock ingresado correctamente.");
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un stock valido");
                    }
                }

                totalstock = totalstock + productos[i].precio * productos[i].stock;

                key = false;
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("Informacion cargada:");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Producto {i + 1}");
                Console.WriteLine("Nombre: " + productos[i].nombre);
                Console.WriteLine("Precio: " + productos[i].precio);
                Console.WriteLine("Stock: " + productos[i].stock);
                Console.WriteLine("Valor total del stock: " + productos[i].precio * productos[i].stock);
                Console.WriteLine();
            }

            Console.WriteLine($"El producto mas caro es {maxnombre} y sale {max}");
            Console.WriteLine("El valor total de todos los productos es " + totalstock);
        }
    }
}