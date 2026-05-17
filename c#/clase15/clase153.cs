using System;

namespace clase153
{
    struct Punto
    {
        public double x;
        public double y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Punto[] puntos = new Punto[4];
            bool key = false;

            for (int i = 0; i < 4; i++)
            {
                while (key == false)
                {
                    Console.WriteLine($"Ingrese la coordenada X del punto {i + 1}");

                    if (double.TryParse(Console.ReadLine(), out puntos[i].x))
                    {
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una coordenada valida");
                    }
                }

                key = false;

                while (key == false)
                {
                    Console.WriteLine($"Ingrese la coordenada Y del punto {i + 1}");

                    if (double.TryParse(Console.ReadLine(), out puntos[i].y))
                    {
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una coordenada valida");
                    }
                }

                key = false;
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("Puntos ingresados:");
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Punto {i + 1}: ({puntos[i].x},{puntos[i].y})");

                if (puntos[i].x == 0 && puntos[i].y == 0)
                {
                    Console.WriteLine("Esta en el origen");
                }
                else if (puntos[i].y == 0)
                {
                    Console.WriteLine("Esta sobre el eje X");
                }
                else if (puntos[i].x == 0)
                {
                    Console.WriteLine("Esta sobre el eje Y");
                }

                Console.WriteLine();
            }
        }
    }
}