namespace clase66
{
    internal class Bloque1
    {
        static void Main()
        {
            int opcion; 

            do
            {
                Console.WriteLine("Menu de Ejercicios");
                Console.WriteLine("====================");                
                Console.WriteLine("Ejercicio 1 [1]");
                Console.WriteLine("Ejercicio 2 [2]");
                Console.WriteLine("Ejercicio 3 [3]");
                Console.WriteLine("Ejercicio 4 [4]");
                Console.WriteLine("Ejercicio 5 [5]");
                Console.WriteLine("Ejercicio 6 [6]");
                Console.WriteLine("Ejercicio 7 [7]");
                Console.WriteLine("Ejercicio 8 [8]");
                Console.WriteLine("Ejercicio 9 [9]");
                Console.WriteLine("Ejercicio 10 [10]");
                Console.WriteLine("Ejercicio 11 [11]");
                Console.WriteLine("Ejercicio 12 [12]");
                Console.WriteLine("Ejercicio 13 [13]");
                Console.WriteLine("Ejercicio 14 [14]");
                Console.WriteLine("====================");
                Console.WriteLine("Salir [0]");
                
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

                
                if (opcion == 11)
                {
                    Ej11();
                }

                
                if (opcion == 12)
                {
                    Ej12();
                }

                
                if (opcion == 13)
                {
                    Ej13();
                }

                
                if (opcion == 14)
                {
                    Ej14();
                }


            }
            while (opcion != 0);
        }


        static void Ej1()
        {
            string cadena;

            Console.Clear();
            Console.WriteLine("Ingrese una frase");
            cadena = Console.ReadLine(); 
            
            Console.WriteLine($"La cadena de caracteres tiene {cadena.Length} caracteres");

        }
        static void Ej2()
        {
            string cadena;
            
            Console.Clear();
            Console.WriteLine("Ingrese una frase");
            cadena = Console.ReadLine(); 
            
            Console.WriteLine($"La cadena de caracteres tiene {cadena.Length} caracteres");
            Console.WriteLine($"La cadena en mayuscula quedaria {cadena.ToUpper()}");
            Console.WriteLine($"La cadena en minuscula quedaria {cadena.ToLower()}");


        }

        static void Ej3()
        {
            string frase;
            int contvoc = 0;
            Console.Clear();
            Console.WriteLine("Ingrese una frase");

            frase = Console.ReadLine();
            frase = frase.ToLower();
            
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    contvoc++;
                }
            }

            Console.WriteLine($"La frase tiene {contvoc} vocales");
        }

        static void Ej4()
        {
            string frase;
            Console.Clear();
            Console.WriteLine("Ingrese su frase");
            frase = Console.ReadLine();

            try
            {
                Console.WriteLine($"Su frase inicia con {frase[0]}");
                Console.WriteLine($"Su frase termina con {frase[frase.Length - 1]}");
            }
            catch
            {
                Console.WriteLine("Ingrese una cadena de caracteres valida");            
            }

        }

        static void Ej5()
        {
            string entrada1;
            string entrada2;
            int num1 = 0;
            int num2 = 0;
    
            Console.Clear();
            Console.WriteLine("Ingrese el numero a dividir");
            entrada1 = Console.ReadLine();
            Console.WriteLine($"Ingrese el numero por el que sera dividido el {entrada1}");
            entrada2 = Console.ReadLine();


            try
            {
                num1 = int.Parse(entrada1);
                num2 = int.Parse(entrada2);

                try
                {
                    Console.WriteLine($"El resultado de la division es {num1/num2}");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Error: No puede dividir por 0");
                }

            }
            
            catch(FormatException)
            { Console.WriteLine("Error: ingrese solo numeros enteros.");}
            
            
        }

        static void Ej6()
        {
            int pos = 0;
            string cadena;

            Console.Clear();
            Console.WriteLine("Ingrese una cadena de texto");
            cadena = Console.ReadLine();
            Console.WriteLine("Ahora ingrese el numero de la posicion que quiere ver dentro de la cadena");

            try
            {
                pos = int.Parse(Console.ReadLine());
                char letra = cadena[pos];
                if (letra == ' ')
                {Console.WriteLine($"La letra en la posicion {pos} es: (espacio)");}
                else
                {Console.WriteLine($"La letra en la posicion {pos} es: {letra}");}
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un numero en la posicion");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Ingrese un numero valido en la posicion");
            }
        }

        static void Ej7()
        {
            string cadena;
            string buscar;
            
            Console.Clear();
            Console.WriteLine("Ingrese una frase");
            cadena = Console.ReadLine();
            Console.WriteLine("Ahora ingrese lo que quiere buscar dentro de la frase anterior");
            buscar = Console.ReadLine();

            if (cadena.Contains(buscar))
            {
                Console.WriteLine($"La frase contiene '{buscar}'");
            }
            else
            {
                Console.WriteLine($"La frase no contiene '{buscar}'");
            }
        }

        static void Ej8()
        {
            string cadena;
            string[] partes;
            int suma = 0;

            Console.Clear();
            Console.WriteLine("Ingrese numeros separados por comas (ej: 10,20,30)");
            cadena = Console.ReadLine();

            partes = cadena.Split(',');

            try
            {
                for (int i = 0; i < partes.Length; i++)
                {
                    suma += int.Parse(partes[i]);
                }
                Console.WriteLine($"La suma total es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: solo ingrese numeros enteros separados por comas.");
            }
        }
        
        static void Ej9()
        {
            string palabra;
            string invertida = "";

            Console.Clear();
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida += palabra[i];
            }

            Console.WriteLine($"La palabra invertida es: {invertida}");
        }

        static void Ej10()
        {
            string contrasena;

            Console.Clear();
            Console.WriteLine("Ingrese una contrasena");
            contrasena = Console.ReadLine();

            try
            {
                bool tieneNumero = false;

                for (int i = 0; i < contrasena.Length; i++)
                {
                    if (contrasena[i] >= '0' && contrasena[i] <= '9')
                    {
                        tieneNumero = true;
                    }
                }

                if (contrasena.Length < 8)
                {
                    throw new ArgumentException("Error: la contrasena debe tener al menos 8 caracteres.");
                }

                if (!tieneNumero)
                {
                    throw new ArgumentException("Error: la contrasena debe contener al menos un numero.");
                }

                Console.WriteLine("Contrasena valida.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Ej11()
        {
            string entrada;
            int edad;

            Console.Clear();
            Console.WriteLine("Ingrese su edad");
            entrada = Console.ReadLine();

            try
            {
                edad = int.Parse(entrada);

                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("Error: la edad debe estar entre 1 y 120.");
                }
                else
                {
                    Console.WriteLine($"Edad valida: {edad}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un numero entero.");
            }
        }

        static void Ej12()
        {
            string cadena = null;

            Console.Clear();

            try
            {
                Console.WriteLine(cadena.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: la variable es null, no se puede acceder a sus propiedades.");
            }
        }

        static void Ej13()
        {
            string entrada1;
            string entrada2;
            int num1;
            int num2;

            Console.Clear();
            Console.WriteLine("Ingrese el primer numero");
            entrada1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            entrada2 = Console.ReadLine();

            try
            {
                num1 = int.Parse(entrada1);
                num2 = int.Parse(entrada2);

                int resultado = checked(num1 + num2);
                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese solo numeros enteros.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: los numeros son demasiado grandes, se produjo un overflow.");
            }
        }

        static void Ej14()
        {
            string frase;
            int contvoc = 0;
            int contpal = 0;
            string[] palabras;

            Console.Clear();
            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                char c = frase[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    contvoc++;
                }
            }

            palabras = frase.Split(' ');
            contpal = palabras.Length;

            Console.WriteLine($"Cantidad de caracteres: {frase.Length}");
            Console.WriteLine($"Cantidad de palabras: {contpal}");
            Console.WriteLine($"Cantidad de vocales: {contvoc}");

            Console.WriteLine("Ingrese una posicion");

            try
            {
                int pos = int.Parse(Console.ReadLine());
                Console.WriteLine($"El caracter en la posicion {pos} es: {frase[pos]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un numero entero.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: la posicion ingresada no existe en la frase.");
            }

            Console.WriteLine("Ingrese un numero para dividir 100");

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine($"100 / {divisor} = {100 / divisor}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese un numero entero.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: no se puede dividir por cero.");
            }
        }
    }
}
