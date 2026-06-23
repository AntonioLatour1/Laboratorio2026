namespace clase23
{
    internal class Bloque
    {
        static void Main()
        {
            int opcion;

            do
            {

                Console.WriteLine("============================");
                Console.WriteLine("Menu de ejercicios clase 23/6/26");
                Console.WriteLine("============================");
                Console.WriteLine("Ejercicio 1");
                Console.WriteLine("Ejercicio 2");
                Console.WriteLine("Ejercicio 3");
                Console.WriteLine("Ejercicio 4");
                Console.WriteLine("Ejercicio 5");
                Console.WriteLine("Ejercicio 6");
                Console.WriteLine("Ejercicio 7");
                Console.WriteLine("Ejercicio 8");
                Console.WriteLine("Ejercicio 9");
                Console.WriteLine("Ejercicio 10");

                Console.WriteLine("============================");

                int.TryParse(Console.ReadLine(), out opcion);

                if (opcion == 1)
                {
                    Ej1();
                }

                 if (opcion == 2)
                {
                    Ej2();
                }

                 if (opcion == 3)
                {
                    Ej3();
                }

                 if (opcion == 4)
                {
                    Ej4();
                }

                 if (opcion == 5)
                {
                    Ej5();
                }


                 if (opcion == 6)
                {
                    Ej6();
                }

                 if (opcion == 7)
                {
                    Ej7();
                }

                 if (opcion == 8)
                {
                    Ej8();
                }

                 if (opcion == 9)
                {
                    Ej9();
                }

                 if (opcion == 10)
                {
                    Ej10();
                }

                
            }
            while (opcion != 0);

        }


        static void Ej1()
        {
            Console.Clear();

            string[] cadena = new string[5];

            Console.WriteLine("Ingrese los 5 nombres de sus peliculas favoritas:");
            for(int i = 0; i < 5;i++)
            {
                cadena[i] = Console.ReadLine();
            }

            foreach(string nombres in cadena)
            {
                Console.WriteLine("============================");
                Console.WriteLine(nombres);
            }
        }

        static void Ej2()
        {
            int[] numeros = new int[6];
            int contadorPares = 0;
            int contadorImpares = 0;

            Console.Clear();
            Console.WriteLine("Ingrese 6 numeros enteros.");

            for(int i = 0; i < 6;i++)
            {
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            
            foreach(int n in numeros)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"El numero {n} es par");
                    contadorPares = contadorPares + 1;
                }

                if (n % 2 != 0)
                {
                    Console.WriteLine($"El numero {n} es inpar");
                    contadorImpares = contadorImpares + 1;
                }
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Cantidad de numeros pares: {contadorPares}");
            Console.WriteLine($"Cantidad de numeros impares: {contadorImpares}");

        }


            static void Ej3()
            {
                string[] ciudades = {"buenos aires", "madrid", "bagadad","lima", "cologne"};

                Console.Clear();
                Console.WriteLine("Ingrese el nombre de una ciudad");

                string query = Console.ReadLine().ToLower();
                bool encontrada = false;

                for(int i = 0; i < 5; i++)
                {
                    if(query == ciudades[i])
                    {
                        Console.WriteLine($"La ciudad se encuentra en la posicion {i+1}");
                        encontrada = true;
                        break;
                    }
                }

                if (encontrada == false)
                {
                    Console.WriteLine("Ciudad no encontrada");
                }
            }


        static void Ej4()
        {
            double promedio = 0;
            double[] notas = new double[5];
            
            Console.Clear();

            for(int i = 0;i < 5;i++)
            {
                Console.WriteLine($"Ingresa la nota del alumno {i}");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                promedio = promedio + notas[i];
                
            }
           
           Console.WriteLine("------------");
           promedio = promedio/5;
           Console.WriteLine($"El promedio de las notas de los 5 estudiantes es {promedio}");

           if (promedio >= 6)
           {
               Console.WriteLine("Aprobado");
           }
           else
           {
               Console.WriteLine("Reprobado");
           }

        }

        static void Ej5()
        {
            double[] arreglo = {10,20,30,40,50,0};

            Console.WriteLine("Ingrese un numero para poner en el arreglo");
            double num = Convert.ToDouble(Console.ReadLine());

            for(int i = arreglo.Length - 1; i > 2;i--)
            {
                arreglo[i] = arreglo[i-1];
            }
            
            arreglo[1] = num;


            Console.WriteLine("El arreglo final quedaria tal que asi:");
            for(int i = 0; i < 6;i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            

        }

        static void Ej6()
        {
            string[] colores = {"Rojo", "Verde", "Azul", "Amarillo", "Negro"};

            Console.WriteLine("Ingrese un indice del 0 al 4 para eliminar");
            int indice = Convert.ToInt16(Console.ReadLine());

            for(int i = indice; i < colores.Length - 1; i++)
            {
                colores[i] = colores[i+1];
            }
            colores[colores.Length - 1] = "";

            Console.WriteLine("El arreglo actualizado quedaria tal que asi:");
            for(int i = 0; i < colores.Length; i++)
            {
                Console.WriteLine(colores[i]);
            }
        }

        static void Ej7()
        {
            int[] numeros = {1,2,3,4,5,6,7,8,9,10};
            int[] subVector = numeros[3..8];

            Console.WriteLine("El subvector es el siguiente:");
            foreach(int n in subVector)
            {
                Console.WriteLine(n);
            }
        }

        static void Ej8()
        {
            int[] numeros = new int[8];

            Console.WriteLine("Ingrese 8 numeros enteros.");
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }

            int mayor = numeros[0];
            int posicion = 0;

            for(int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicion = i;
                }
            }

            Console.WriteLine($"El numero mas grande es {mayor} y se encuentra en la posicion {posicion}");
        }

        static void Ej9()
        {
            string[] palabras = new string[5];

            Console.WriteLine("Ingrese 5 palabras al azar");
            for(int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = Console.ReadLine();
            }

            string resultado = "";
            foreach(string palabra in palabras)
            {
                if (palabra.Length > 4)
                {
                    resultado = resultado + palabra;
                }
            }

            Console.WriteLine("Las palabras con mas de 4 letras concatenadas son:");
            Console.WriteLine(resultado);
        }

        static void Ej10()
        {
            int[] vector = new int[5];
            int opcion10;

            do
            {
                Console.WriteLine("============================");
                Console.WriteLine("1. Cargar el vector");
                Console.WriteLine("2. Mostrar el vector");
                Console.WriteLine("3. Buscar un numero");
                Console.WriteLine("4. Sumar todos los elementos");
                Console.WriteLine("5. Salir");
                Console.WriteLine("============================");

                opcion10 = Convert.ToInt16(Console.ReadLine());

                if (opcion10 == 1)
                {
                    for(int i = 0; i < vector.Length; i++)
                    {
                        Console.WriteLine($"Ingrese el valor para la posicion {i}");
                        vector[i] = Convert.ToInt16(Console.ReadLine());
                    }
                }

                if (opcion10 == 2)
                {
                    foreach(int n in vector)
                    {
                        Console.WriteLine(n);
                    }
                }

                if (opcion10 == 3)
                {
                    Console.WriteLine("Ingrese el numero a buscar");
                    int buscado = Convert.ToInt16(Console.ReadLine());
                    bool encontrado = false;

                    for(int i = 0; i < vector.Length; i++)
                    {
                        if (vector[i] == buscado)
                        {
                            Console.WriteLine($"El numero se encuentra en la posicion {i}");
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado == false)
                    {
                        Console.WriteLine("Numero no encontrado");
                    }
                }

                if (opcion10 == 4)
                {
                    int suma = 0;
                    for(int i = 0; i < vector.Length; i++)
                    {
                        suma = suma + vector[i];
                    }
                    Console.WriteLine($"La suma de todos los elementos es {suma}");
                }

            }
            while (opcion10 != 5);
        }


    }

}