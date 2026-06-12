namespace Clase56
{
    internal class Bloque1
    {
        static void B1A()
        {
            int numero = 1;
            while (numero <= 100)
            {
                if (numero % 3 == 0)
                    Console.WriteLine(numero);
                numero = numero + 1;
            }
        }

        static void B1B()
        {
            bool key = false;
            int edad = 0;
            while (key == false)
            {
                Console.WriteLine("Ingrese su edad:");
                edad = Convert.ToInt16(Console.ReadLine());
                if (edad < 18)
                {
                    Console.Clear();
                    Console.WriteLine("Sos menor de edad.");
                    key = true;
                }
                else if (edad == 18)
                {
                    Console.Clear();
                    Console.WriteLine("Tenes justo 18 anios.");
                    key = true;
                }
                else if (edad > 18)
                {
                    Console.Clear();
                    Console.WriteLine("Sos mayor de edad.");
                    key = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido.");
                }
            }
        }

        static void B1C()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            Console.WriteLine("La palabra tiene " + palabra.Length + " letras.");
        }

        static void B1D()
        {
            string contrasena = "klumpen";
            int intentos = 0;
            string temp;
            while (intentos < 5)
            {
                Console.WriteLine("Ingrese la contrasena:");
                temp = Console.ReadLine();
                intentos = intentos + 1;
                if (temp == contrasena)
                {
                    Console.WriteLine("Contrasena correcta.");
                    intentos = 5;
                }
                else
                {
                    Console.WriteLine("Contrasena incorrecta.");
                    Console.WriteLine($"{5 - intentos} intentos restantes.");
                }
            }
        }

        static void B1E()
        {
            int masAlto = 0;
            int vuelta = 1;
            while (vuelta <= 10)
            {
                Console.WriteLine("Ingrese el numero " + vuelta + ":");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > masAlto)
                    masAlto = numero;
                vuelta = vuelta + 1;
            }
            Console.WriteLine("El numero mas alto fue: " + masAlto);
        }

        static void B1F()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            string resultado = "";
            bool primera = true;
            int i = 0;
            while (i < nombre.Length)
            {
                if (nombre[i] == ' ')
                {
                    resultado = resultado + ' ';
                    primera = true;
                }
                else if (primera == true)
                {
                    resultado = resultado + char.ToUpper(nombre[i]);
                    primera = false;
                }
                else
                {
                    resultado = resultado + nombre[i];
                }
                i = i + 1;
            }
            Console.WriteLine("Hola, " + resultado + "!");
        }

        static void B1G()
        {
            int numero = 1;
            while (numero <= 10)
            {
                Console.WriteLine("7 x " + numero + " = " + (7 * numero));
                numero = numero + 1;
            }
        }

        static void B1H()
        {
            int numero = 10;
            while (numero >= 1)
            {
                Console.WriteLine(numero);
                numero = numero - 1;
            }
            Console.WriteLine("Ya!");
        }

        static void B1I()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("par");
            else
                Console.WriteLine("impar");
        }

        static void B1J()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            int vocales = 0;
            int i = 0;
            while (i < frase.Length)
            {
                char l = char.ToLower(frase[i]);
                if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
                    vocales = vocales + 1;
                i = i + 1;
            }
            Console.WriteLine("La frase tiene " + vocales + " vocales.");
        }

        static void B1K()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int vuelta = 1;
            while (vuelta <= 12)
            {
                Console.WriteLine(numero + " x " + vuelta + " = " + (numero * vuelta));
                vuelta = vuelta + 1;
            }
        }

        static void B1L()
        {
            int total = 0;
            while (total <= 100)
            {
                Console.WriteLine("Ingrese un numero (total actual: " + total + "):");
                total = total + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total superado: " + total);
        }

        static void B1M()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            int i = 0;
            while (i < palabra.Length)
            {
                Console.WriteLine(palabra[i]);
                i = i + 1;
            }
        }

        static void B1N()
        {
            bool key = false;
            int edad = 0;
            while (key == false)
            {
                Console.WriteLine("Ingrese su edad:");
                edad = Convert.ToInt16(Console.ReadLine());
                if (edad >= 17)
                {
                    Console.Clear();
                    Console.WriteLine("Podes votar y manejar.");
                    key = true;
                }
                else if (edad == 16)
                {
                    Console.Clear();
                    Console.WriteLine("Podes votar, pero no manejar.");
                    key = true;
                }
                else if (edad < 16)
                {
                    Console.Clear();
                    Console.WriteLine("No podes votar ni manejar.");
                    key = true;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido.");
                }
            }
        }

        static void B1O()
        {
            int numero = 50;
            while (numero >= 0)
            {
                Console.WriteLine(numero);
                numero = numero - 5;
            }
        }

        static void B1P()
        {
            bool acceso = false;
            while (acceso == false)
            {
                Console.WriteLine("Ingrese una contrasena:");
                string c1 = Console.ReadLine();
                Console.WriteLine("Repita la contrasena:");
                string c2 = Console.ReadLine();
                if (c1 == c2)
                {
                    Console.WriteLine("Acceso permitido.");
                    acceso = true;
                }
                else
                {
                    Console.WriteLine("No coinciden. Intente nuevamente.");
                }
            }
        }

        static void B1Q()
        {
            bool seguir = true;
            while (seguir == true)
            {
                Console.WriteLine("Ingrese un nombre:");
                string nombre = Console.ReadLine();
                if (nombre.Length > 10)
                {
                    Console.WriteLine("Nombre demasido largo. Programa terminado.");
                    seguir = false;
                }
                else
                {
                    Console.WriteLine("Nombre registrado: " + nombre);
                }
            }
        }

        static void B1R()
        {
            Console.WriteLine("Ingrese una oracion:");
            string oracion = Console.ReadLine();
            int contador = 0;
            int i = 0;
            while (i < oracion.Length)
            {
                if (oracion[i] == 'a' || oracion[i] == 'A')
                    contador = contador + 1;
                i = i + 1;
            }
            Console.WriteLine("La oracion tiene " + contador + " letras 'a'.");
        }

        static void Main(string[] args)
        {
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("====== BLOQUE 1 ======");
                Console.WriteLine("1.  Multiplos de 3");
                Console.WriteLine("2.  Menor/mayor de edad");
                Console.WriteLine("3.  Longitud de palabra");
                Console.WriteLine("4.  Adivinar contrasena");
                Console.WriteLine("5.  Numero mas alto");
                Console.WriteLine("6.  Saludar con mayusculas");
                Console.WriteLine("7.  Tabla del 7");
                Console.WriteLine("8.  Cuenta regresiva");
                Console.WriteLine("9.  Par o impar");
                Console.WriteLine("10. Contar vocales");
                Console.WriteLine("11. Tabla de multiplicar");
                Console.WriteLine("12. Acumular hasta 100");
                Console.WriteLine("13. Letras de una palabra");
                Console.WriteLine("14. Votar y manejar");
                Console.WriteLine("15. Descender de 50 a 0");
                Console.WriteLine("16. Verificar contrasena");
                Console.WriteLine("17. Pedir nombres");
                Console.WriteLine("18. Contar la letra A");
                Console.WriteLine("0.  Salir");
                Console.WriteLine("======================");
                Console.WriteLine("Ingrese una opcion:");
                string op = Console.ReadLine();
                Console.Clear();
                if (op == "1") B1A();
                else if (op == "2") B1B();
                else if (op == "3") B1C();
                else if (op == "4") B1D();
                else if (op == "5") B1E();
                else if (op == "6") B1F();
                else if (op == "7") B1G();
                else if (op == "8") B1H();
                else if (op == "9") B1I();
                else if (op == "10") B1J();
                else if (op == "11") B1K();
                else if (op == "12") B1L();
                else if (op == "13") B1M();
                else if (op == "14") B1N();
                else if (op == "15") B1O();
                else if (op == "16") B1P();
                else if (op == "17") B1Q();
                else if (op == "18") B1R();
                else if (op == "0") salir = true;
                else Console.WriteLine("Opcion no valida.");
                if (salir == false)
                {
                    Console.WriteLine("\nPresione enter para continuar");
                    Console.ReadLine();
                }
            }
        }
    }
}
