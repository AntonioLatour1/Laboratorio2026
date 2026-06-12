namespace Clase56
{
    internal class Bloque2
    {
        static void B2A()
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1, 11);
            bool adivinado = false;
            while (adivinado == false)
            {
                Console.WriteLine("Adivina el numero (1-10):");
                int intento = Convert.ToInt32(Console.ReadLine());
                if (intento == secreto)
                {
                    Console.WriteLine("Correcto!");
                    adivinado = true;
                }
                else if (intento < secreto)
                    Console.WriteLine("El numero es mayor.");
                else
                    Console.WriteLine("El numero es menor.");
            }
        }

        static void B2B()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int divisor = 1;
            while (divisor <= numero)
            {
                if (numero % divisor == 0)
                    Console.WriteLine(divisor);
                divisor = divisor + 1;
            }
        }

        static void B2C()
        {
            int a = 0;
            int b = 1;
            int contador = 0;
            while (contador < 20)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
                contador = contador + 1;
            }
        }

        static void B2D()
        {
            Console.WriteLine("Operaciones: 1-Suma  2-Resta  3-Multiplicacion  4-Division");
            Console.WriteLine("Elija una opcion:");
            string op = Console.ReadLine();
            Console.WriteLine("Ingrese el primer numero:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            if (op == "1")
                Console.WriteLine("Resultado: " + (n1 + n2));
            else if (op == "2")
                Console.WriteLine("Resultado: " + (n1 - n2));
            else if (op == "3")
                Console.WriteLine("Resultado: " + (n1 * n2));
            else if (op == "4")
            {
                if (n2 == 0)
                    Console.WriteLine("No se puede dividir por cero.");
                else
                    Console.WriteLine("Resultado: " + (n1 / n2));
            }
            else
                Console.WriteLine("Opcion no valida.");
        }

        static void B2E()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i = 1;
            while (i <= numero)
            {
                factorial = factorial * i;
                i = i + 1;
            }
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }

        static void B2F()
        {
            string[] nombres = new string[100];
            int cantidad = 0;
            bool seguir = true;
            while (seguir == true)
            {
                Console.WriteLine("Ingrese un nombre (o 'fin'):");
                string nombre = Console.ReadLine();
                if (nombre == "fin")
                    seguir = false;
                else
                {
                    nombres[cantidad] = nombre;
                    cantidad = cantidad + 1;
                    Console.WriteLine("Turno asignado: " + cantidad);
                }
            }
            int i = 0;
            while (i < cantidad)
            {
                Console.WriteLine("Turno " + (i + 1) + ": " + nombres[i]);
                i = i + 1;
            }
        }

        static void B2G()
        {
            int numero = 1;
            int pares = 0;
            while (numero <= 100)
            {
                if (numero % 2 == 0)
                    pares = pares + 1;
                numero = numero + 1;
            }
            Console.WriteLine("Numeros pares entre 1 y 100: " + pares);
        }

        static void B2H()
        {
            bool salir = false;
            while (salir == false)
            {
                Console.WriteLine("Ingrese temperatura en Celsius (o 'salir'):");
                string entrada = Console.ReadLine();
                if (entrada == "salir")
                    salir = true;
                else
                {
                    double celsius = Convert.ToDouble(entrada);
                    Console.WriteLine(celsius + "C = " + ((celsius * 9 / 5) + 32) + "F");
                }
            }
        }

        static void B2I()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool esPrimo = true;
            int divisor = 2;
            if (numero < 2)
                esPrimo = false;
            while (divisor < numero && esPrimo == true)
            {
                if (numero % divisor == 0)
                    esPrimo = false;
                divisor = divisor + 1;
            }
            if (esPrimo == true)
                Console.WriteLine(numero + " es primo.");
            else
                Console.WriteLine(numero + " no es primo.");
        }

        static void B2J()
        {
            string[] nombres = new string[100];
            int cantidad = 0;
            bool seguir = true;
            while (seguir == true)
            {
                Console.WriteLine("Ingrese un nombre (o 'fin'):");
                string nombre = Console.ReadLine();
                if (nombre == "fin")
                    seguir = false;
                else
                {
                    nombres[cantidad] = nombre;
                    cantidad = cantidad + 1;
                }
            }
            int i = 0;
            while (i < cantidad)
            {
                Console.WriteLine("Hola, " + nombres[i] + "!");
                i = i + 1;
            }
        }

        static void B2K()
        {
            string[] nombres = new string[100];
            int cantidad = 0;
            bool duplicado = false;
            while (duplicado == false)
            {
                Console.WriteLine("Ingrese un nombre:");
                string nombre = Console.ReadLine();
                int i = 0;
                while (i < cantidad && duplicado == false)
                {
                    if (nombres[i] == nombre)
                        duplicado = true;
                    i = i + 1;
                }
                if (duplicado == false)
                {
                    nombres[cantidad] = nombre;
                    cantidad = cantidad + 1;
                }
            }
            Console.WriteLine("Nombre duplicado. Nombres ingresados antes: " + cantidad);
        }

        static void B2L()
        {
            int numero = 100;
            while (numero <= 200)
            {
                if (numero % 7 == 0 && numero % 10 == 3)
                    Console.WriteLine(numero);
                numero = numero + 1;
            }
        }

        static void B2M()
        {
            double total = 0;
            int cantidad = 0;
            while (total <= 1000)
            {
                Console.WriteLine("Ingrese un precio (total: $" + total + "):");
                total = total + Convert.ToDouble(Console.ReadLine());
                cantidad = cantidad + 1;
            }
            Console.WriteLine("Total superado. Productos cargados: " + cantidad);
        }

        static void B2N()
        {
            bool nombreOk = false;
            bool edadOk = false;
            bool mailOk = false;
            string nombre = "";
            string edad = "";
            string mail = "";

            while (nombreOk == false)
            {
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();
                if (nombre.Length > 0)
                    nombreOk = true;
                else
                    Console.WriteLine("El nombre no puede estar vacio.");
            }

            while (edadOk == false)
            {
                Console.WriteLine("Ingrese su edad:");
                edad = Console.ReadLine();
                bool soloNumeros = true;
                int i = 0;
                while (i < edad.Length)
                {
                    if (edad[i] < '0' || edad[i] > '9')
                        soloNumeros = false;
                    i = i + 1;
                }
                if (soloNumeros == true && edad.Length > 0)
                    edadOk = true;
                else
                    Console.WriteLine("La edad debe ser un numero.");
            }

            while (mailOk == false)
            {
                Console.WriteLine("Ingrese su mail:");
                mail = Console.ReadLine();
                bool tieneArroba = false;
                int i = 0;
                while (i < mail.Length)
                {
                    if (mail[i] == '@')
                        tieneArroba = true;
                    i = i + 1;
                }
                if (tieneArroba == true)
                    mailOk = true;
                else
                    Console.WriteLine("El mail debe contener '@'.");
            }

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Mail: " + mail);
        }

        static void B2O()
        {
            Console.WriteLine("Ingrese un numero:");
            string numero = Console.ReadLine();
            int i = 0;
            while (i < numero.Length)
            {
                if (numero[i] != '-')
                    Console.WriteLine(numero[i]);
                i = i + 1;
            }
        }

        static void B2P()
        {
            string[] opciones = { "piedra", "papel", "tijera" };
            Random rnd = new Random();
            int ganasVos = 0;
            int ganaMaquina = 0;
            int ronda = 1;
            while (ronda <= 3)
            {
                Console.WriteLine("Ronda " + ronda + "  elija: piedra, papel o tijera:");
                string jugada = Console.ReadLine();
                string maquina = opciones[rnd.Next(0, 3)];
                Console.WriteLine("La maquina eligio: " + maquina);
                if (jugada == maquina)
                    Console.WriteLine("Empate.");
                else if (
                    (jugada == "piedra" && maquina == "tijera") ||
                    (jugada == "papel" && maquina == "piedra") ||
                    (jugada == "tijera" && maquina == "papel"))
                {
                    Console.WriteLine("Ganaste esta ronda.");
                    ganasVos = ganasVos + 1;
                }
                else
                {
                    Console.WriteLine("Gano la maquina.");
                    ganaMaquina = ganaMaquina + 1;
                }
                ronda = ronda + 1;
            }
            if (ganasVos > ganaMaquina)
                Console.WriteLine("Ganaste!");
            else if (ganaMaquina > ganasVos)
                Console.WriteLine("Gano la maquina.");
            else
                Console.WriteLine("Empate.");
        }

        static void B2Q()
        {
            Random rnd = new Random();
            int mayores = 0;
            int i = 0;
            while (i < 10)
            {
                int numero = rnd.Next(1, 101);
                Console.WriteLine(numero);
                if (numero > 50)
                    mayores = mayores + 1;
                i = i + 1;
            }
            Console.WriteLine("Mayores a 50: " + mayores);
        }

        static void B2R()
        {
            string[] nombres = new string[5];
            double[] notas = new double[5];
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Ingrese el nombre " + (i + 1) + ":");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota de " + nombres[i] + ":");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                i = i + 1;
            }
            double suma = 0;
            double mejorNota = notas[0];
            string mejorNombre = nombres[0];
            i = 0;
            while (i < 5)
            {
                suma = suma + notas[i];
                if (notas[i] > mejorNota)
                {
                    mejorNota = notas[i];
                    mejorNombre = nombres[i];
                }
                i = i + 1;
            }
            Console.WriteLine("Promedio: " + (suma / 5));
            Console.WriteLine("Mejor nota: " + mejorNombre + " con " + mejorNota);
        }

        static void B2S()
        {
            char letra = 'Z';
            while (letra >= 'A')
            {
                Console.WriteLine(letra);
                letra = (char)(letra - 1);
            }
        }

        static void Main(string[] args)
        {
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("====== BLOQUE 2 ======");
                Console.WriteLine("1.  Adivinar numero");
                Console.WriteLine("2.  Divisores");
                Console.WriteLine("3.  Fibonacci");
                Console.WriteLine("4.  Calculadora");
                Console.WriteLine("5.  Factorial");
                Console.WriteLine("6.  Sistema de turnos");
                Console.WriteLine("7.  Pares entre 1 y 100");
                Console.WriteLine("8.  Celsius a Fahrenheit");
                Console.WriteLine("9.  Numero primo");
                Console.WriteLine("10. Lista de nombres");
                Console.WriteLine("11. Detectar duplicado");
                Console.WriteLine("12. Multiplos de 7 que terminan en 3");
                Console.WriteLine("13. Precios hasta $1000");
                Console.WriteLine("14. Formulario validado");
                Console.WriteLine("15. Digitos por separado");
                Console.WriteLine("16. Piedra papel tijera");
                Console.WriteLine("17. Numeros aleatorios");
                Console.WriteLine("18. Notas y promedio");
                Console.WriteLine("19. Abecedario inverso");
                Console.WriteLine("0.  Salir");
                Console.WriteLine("======================");
                Console.WriteLine("Ingrese una opcion:");
                string op = Console.ReadLine();
                Console.Clear();
                if (op == "1") B2A();
                else if (op == "2") B2B();
                else if (op == "3") B2C();
                else if (op == "4") B2D();
                else if (op == "5") B2E();
                else if (op == "6") B2F();
                else if (op == "7") B2G();
                else if (op == "8") B2H();
                else if (op == "9") B2I();
                else if (op == "10") B2J();
                else if (op == "11") B2K();
                else if (op == "12") B2L();
                else if (op == "13") B2M();
                else if (op == "14") B2N();
                else if (op == "15") B2O();
                else if (op == "16") B2P();
                else if (op == "17") B2Q();
                else if (op == "18") B2R();
                else if (op == "19") B2S();
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
