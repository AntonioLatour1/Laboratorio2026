namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1;
            char cadena2;
            int num;
            bool verdadero = false;
            bool encontrado = false;
            string invertida = "";
            int i;

            Console.WriteLine("Ingrese su cadena de texto: ");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese un caracter:");
            cadena2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese un numero entre 3 y 5:");
            num = Convert.ToInt16(Console.ReadLine());

            if (num > 3 && num < 5)
            {
                verdadero = true;
            }
            else
            {
                Console.WriteLine("Ingrese un numero entre 3 y 5");
            }

            string punto1 = cadena1 + cadena2;
            Console.WriteLine("----------------------");
            Console.WriteLine($"Concatenacion de las cadenas: {punto1}");
            Console.WriteLine("----------------------");
            Console.WriteLine("Este es el string en mayusculas y minusculas:");
            Console.WriteLine($"{cadena1.ToUpper()} {cadena1.ToLower()}");
            Console.WriteLine("----------------------");
            Console.WriteLine("Esta es la cadena dividida dependiendo del numero ingresado:");
            Console.WriteLine($"{cadena1.Substring(0, num)}");
            Console.WriteLine($"{cadena1.Substring(num)}");
            Console.WriteLine("----------------------");
            string resultado = cadena1[3] + " " + cadena1[9] + " " + cadena1[cadena1.Length - 1];
            Console.WriteLine($"Estos son los caracteres en la posicion 3, 9 y el ultimo: {resultado}");

            for (i = cadena1.Length - 1; i >= 0; i--)
            {
                invertida += cadena1[i];
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Esta es la cadena invertida: {invertida}");
            Console.WriteLine("----------------------");

            for (i = 0; i < cadena1.Length && !encontrado; i++)
            {
                if (cadena1[i] == cadena2)
                {
                    encontrado = true;
                    Console.WriteLine($"La primera ocurrencia de '{cadena2}' esta en la posicion {i+1} de la cadena '{cadena1}'");
                }
            }

            if (cadena1.Length > 0)
            {
                int vascii = Convert.ToInt16(cadena1[0]);
                Console.WriteLine("----------------------");
                Console.WriteLine($"El valor ascii del primer caracter de la cadena es: {vascii}");
                Console.WriteLine("----------------------");
            }
            else
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("La cadena esta vacia.");
                Console.WriteLine("----------------------");
            }
        }
    }
}
