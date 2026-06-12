namespace Clase56
{
    internal class Program
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

        static void B3A()
        {
            int votoA = 0;
            int votoB = 0;
            int votoC = 0;
            bool seguir = true;
            while (seguir == true)
            {
                Console.WriteLine("Opciones: A, B, C (o 'terminar'):");
                string voto = Console.ReadLine();
                if (voto == "terminar")
                    seguir = false;
                else if (voto == "A" || voto == "a")
                    votoA = votoA + 1;
                else if (voto == "B" || voto == "b")
                    votoB = votoB + 1;
                else if (voto == "C" || voto == "c")
                    votoC = votoC + 1;
                else
                    Console.WriteLine("Opcion no valida.");
            }
            Console.WriteLine("A: " + votoA + "  B: " + votoB + "  C: " + votoC);
            if (votoA >= votoB && votoA >= votoC)
                Console.WriteLine("Gano la opcion A.");
            else if (votoB >= votoA && votoB >= votoC)
                Console.WriteLine("Gano la opcion B.");
            else
                Console.WriteLine("Gano la opcion C.");
        }

        static void B3B()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 1)
            {
                Console.WriteLine("El numero debe ser mayor que 0.");
            }
            else
            {
                int i = 1;
                while (i < numero)
                {
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                    i = i + 1;
                }
            }
        }

        static void B3C()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            Console.WriteLine("Ingrese una letra:");
            string letraStr = Console.ReadLine();
            char letra = letraStr[0];
            int contador = 0;
            int i = 0;
            while (i < palabra.Length)
            {
                if (palabra[i] == letra)
                    contador = contador + 1;
                i = i + 1;
            }
            Console.WriteLine("La letra '" + letra + "' aparece " + contador + " veces.");
        }

        static void B3D()
        {
            double saldo = 1000;
            bool salir = false;
            while (salir == false)
            {
                Console.WriteLine("Saldo: $" + saldo);
                Console.WriteLine("1-Depositar  2-Retirar  3-Salir");
                string op = Console.ReadLine();
                if (op == "1")
                {
                    Console.WriteLine("Monto a depositar:");
                    double monto = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo + monto;
                }
                else if (op == "2")
                {
                    Console.WriteLine("Monto a retirar:");
                    double monto = Convert.ToDouble(Console.ReadLine());
                    if (monto > saldo)
                        Console.WriteLine("Saldo insuficiente.");
                    else
                        saldo = saldo - monto;
                }
                else if (op == "3")
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }
            }
            Console.WriteLine("Saldo final: $" + saldo);
        }

        static void B3E()
        {
            int encontrados = 0;
            int numero = 1;
            while (encontrados < 50)
            {
                bool divPor2 = numero % 2 == 0;
                bool divPor5 = numero % 5 == 0;
                if ((divPor2 || divPor5) && !(divPor2 && divPor5))
                {
                    Console.WriteLine(numero);
                    encontrados = encontrados + 1;
                }
                numero = numero + 1;
            }
        }

        static void B3F()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            int i = 0;
            while (i < palabra.Length)
            {
                char c = char.ToLower(palabra[i]);
                if (c >= 'a' && c <= 'z')
                {
                    int posicion = c - 'a' + 1;
                    Console.Write(posicion + " ");
                }
                i = i + 1;
            }
            Console.WriteLine();
        }

        static void B3G()
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1, 101);
            int intentos = 0;
            bool adivinado = false;
            while (adivinado == false)
            {
                Console.WriteLine("Adivina el numero (1-100):");
                int intento = Convert.ToInt32(Console.ReadLine());
                intentos = intentos + 1;
                if (intento == secreto)
                {
                    Console.WriteLine("Correcto! Lo adivinaste en " + intentos + " intentos.");
                    adivinado = true;
                }
                else if (intento < secreto)
                    Console.WriteLine("Mas grande.");
                else
                    Console.WriteLine("Mas chico.");
            }
        }

        static void B3H()
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();
            string resultado = "";
            string palabraActual = "";
            int i = 0;
            while (i <= frase.Length)
            {
                if (i == frase.Length || frase[i] == ' ')
                {
                    string invertida = "";
                    int j = palabraActual.Length - 1;
                    while (j >= 0)
                    {
                        invertida = invertida + palabraActual[j];
                        j = j - 1;
                    }
                    if (resultado.Length > 0)
                        resultado = resultado + " ";
                    resultado = resultado + invertida;
                    palabraActual = "";
                }
                else
                {
                    palabraActual = palabraActual + frase[i];
                }
                i = i + 1;
            }
            Console.WriteLine(resultado);
        }

        static void B3I()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            int[] conteos = new int[100];
            char[] letrasUnicas = new char[100];
            int totalUnicas = 0;
            int i = 0;
            while (i < palabra.Length)
            {
                char c = char.ToLower(palabra[i]);
                bool yaVista = false;
                int j = 0;
                while (j < totalUnicas)
                {
                    if (letrasUnicas[j] == c)
                    {
                        conteos[j] = conteos[j] + 1;
                        yaVista = true;
                    }
                    j = j + 1;
                }
                if (yaVista == false)
                {
                    letrasUnicas[totalUnicas] = c;
                    conteos[totalUnicas] = 1;
                    totalUnicas = totalUnicas + 1;
                }
                i = i + 1;
            }
            int k = 0;
            while (k < totalUnicas)
            {
                Console.WriteLine(letrasUnicas[k] + ": " + conteos[k]);
                k = k + 1;
            }
        }

        static void B3J()
        {
            string usuario = "admin";
            string contrasena = "1234";
            int intentos = 0;
            bool acceso = false;
            while (intentos < 3 && acceso == false)
            {
                Console.WriteLine("Usuario:");
                string u = Console.ReadLine();
                Console.WriteLine("Contrasena:");
                string c = Console.ReadLine();
                intentos = intentos + 1;
                if (u == usuario && c == contrasena)
                {
                    Console.WriteLine("Bienvenido, " + usuario + "!");
                    acceso = true;
                }
                else
                {
                    Console.WriteLine("Incorrecto. Intentos restantes: " + (3 - intentos));
                }
            }
            if (acceso == false)
                Console.WriteLine("Acceso bloqueado.");
        }

        static void B3K()
        {
            Console.WriteLine("Ingrese un numero (0-100):");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 0 && numero <= 25)
                Console.WriteLine("Rango: 0-25");
            else if (numero >= 26 && numero <= 50)
                Console.WriteLine("Rango: 26-50");
            else if (numero >= 51 && numero <= 75)
                Console.WriteLine("Rango: 51-75");
            else if (numero >= 76 && numero <= 100)
                Console.WriteLine("Rango: 76-100");
            else
                Console.WriteLine("Fuera de rango.");
        }

        static void B3L()
        {
            Console.WriteLine("Ingrese su peso en kg:");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en metros:");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura * altura);
            Console.WriteLine("IMC: " + imc.ToString("F2"));
            if (imc < 18.5)
                Console.WriteLine("Bajo peso.");
            else if (imc < 25)
                Console.WriteLine("Peso normal.");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso.");
            else
                Console.WriteLine("Obesidad.");
        }

        static void B3M()
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            int i = 1;
            while (i <= palabra.Length)
            {
                int j = 0;
                while (j < i)
                {
                    Console.Write(palabra[j]);
                    j = j + 1;
                }
                Console.WriteLine();
                i = i + 1;
            }
        }

        static void B3N()
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int turno = 0;
            bool salir = false;
            while (salir == false)
            {
                Console.WriteLine("Ingrese una frase (o 'agusfortnite2008' para salir):");
                string frase = Console.ReadLine();
                if (frase == "agusfortnite2008")
                {
                    salir = true;
                }
                else
                {
                    char vocal = vocales[turno % 5];
                    string resultado = "";
                    int i = 0;
                    while (i < frase.Length)
                    {
                        char c = char.ToLower(frase[i]);
                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                            resultado = resultado + vocal;
                        else
                            resultado = resultado + frase[i];
                        i = i + 1;
                    }
                    Console.WriteLine(resultado);
                    turno = turno + 1;
                }
            }
        }

        static void MenuBloque1()
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
                Console.WriteLine("0.  Volver");
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

        static void MenuBloque2()
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
                Console.WriteLine("0.  Volver");
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

        static void MenuBloque3()
        {
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("====== BLOQUE 3 ======");
                Console.WriteLine("1.  Votacion");
                Console.WriteLine("2.  Impares anteriores");
                Console.WriteLine("3.  Contar letra en palabra");
                Console.WriteLine("4.  Cuenta bancaria");
                Console.WriteLine("5.  Divisibles por 2 o 5");
                Console.WriteLine("6.  Posicion en abecedario");
                Console.WriteLine("7.  Adivinanza con intentos");
                Console.WriteLine("8.  Palabras invertidas");
                Console.WriteLine("9.  Frecuencia de letras");
                Console.WriteLine("10. Sistema de ingreso");
                Console.WriteLine("11. Rangos numericos");
                Console.WriteLine("12. Calculadora de IMC");
                Console.WriteLine("13. Piramide de letras");
                Console.WriteLine("14. Reemplazar vocales");
                Console.WriteLine("0.  Volver");
                Console.WriteLine("======================");
                Console.WriteLine("Ingrese una opcion:");
                string op = Console.ReadLine();
                Console.Clear();
                if (op == "1") B3A();
                else if (op == "2") B3B();
                else if (op == "3") B3C();
                else if (op == "4") B3D();
                else if (op == "5") B3E();
                else if (op == "6") B3F();
                else if (op == "7") B3G();
                else if (op == "8") B3H();
                else if (op == "9") B3I();
                else if (op == "10") B3J();
                else if (op == "11") B3K();
                else if (op == "12") B3L();
                else if (op == "13") B3M();
                else if (op == "14") B3N();
                else if (op == "0") salir = true;
                else Console.WriteLine("Opcion no valida.");
                if (salir == false)
                {
                    Console.WriteLine("\nPresione enter para continuar");
                    Console.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            bool salir = false;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("     MENU PRINCIPAL   ");
                Console.WriteLine("  1. Bloque 1         ");
                Console.WriteLine("  2. Bloque 2         ");
                Console.WriteLine("  3. Bloque 3         ");
                Console.WriteLine("  0. Salir            ");
                Console.WriteLine("Ingrese una opcion:");
                string op = Console.ReadLine();
                Console.Clear();
                if (op == "1") MenuBloque1();
                else if (op == "2") MenuBloque2();
                else if (op == "3") MenuBloque3();
                else if (op == "0") salir = true;
                else Console.WriteLine("Opcion no valida.");
            }
        }
    }
}
