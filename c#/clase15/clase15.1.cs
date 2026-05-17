using System;

namespace clase16
{
    struct Alumno
    {
        public string nombre;
        public double edad;
        public double nota;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[3];
            double max = 0;
            string mejorAlumno = "";
            bool key = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno numero {i + 1}");
                alumnos[i].nombre = Console.ReadLine();

                while (key == false)
                {
                    Console.WriteLine($"Ingrese la nota del alumno numero {i + 1}");

                    if (double.TryParse(Console.ReadLine(), out alumnos[i].nota))
                    {
                        Console.WriteLine("Nota ingresada correctamente.");

                        if (alumnos[i].nota > max)
                        {
                            max = alumnos[i].nota;
                            mejorAlumno = alumnos[i].nombre;
                        }

                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una nota valida");
                    }
                }

                key = false;

                while (key == false)
                {
                    Console.WriteLine($"Ingrese la edad del alumno numero {i + 1}");

                    if (double.TryParse(Console.ReadLine(), out alumnos[i].edad))
                    {
                        Console.WriteLine("Edad ingresada correctamente.");
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una edad valida");
                    }
                }

                key = false;
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("Informacion cargada:");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Alumno {i + 1}");
                Console.WriteLine("Nombre: " + alumnos[i].nombre);
                Console.WriteLine("Edad: " + alumnos[i].edad);
                Console.WriteLine("Nota: " + alumnos[i].nota);
                Console.WriteLine();
            }

            Console.WriteLine("Alumno con mejor nota: " + mejorAlumno);
            Console.WriteLine("Nota mas alta: " + max);
        }
    }
}