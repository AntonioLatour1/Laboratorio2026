
namespace MatrizDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n < 3 || n > 5)
            {
                Console.Write("Ingrese el tamaño de la matriz cuadrada entre 3 y 5: ");

                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    n = 0;
                }
            }

            double[,] matriz = new double[n, n];

            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < n; columna++)
                {
                    double numero;
                    bool valido = false;

                    while (valido == false)
                    {
                        Console.Write("Ingrese un numero para la posicion [" + fila + "," + columna + "]: ");

                        if (double.TryParse(Console.ReadLine(), out numero))
                        {
                            matriz[fila, columna] = numero;
                            valido = true;
                        }
                    }
                }
            }

            Console.WriteLine("\nMatriz cargada:");

            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < n; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\n");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada fila:");

            for (int fila = 0; fila < n; fila++)
            {
                double sumaFila = 0;

                for (int columna = 0; columna < n; columna++)
                {
                    sumaFila += matriz[fila, columna];
                }

                Console.WriteLine("Fila " + fila + ": " + sumaFila);
            }

            Console.WriteLine("\nSuma de cada columna:");

            for (int columna = 0; columna < n; columna++)
            {
                double sumaColumna = 0;

                for (int fila = 0; fila < n; fila++)
                {
                    sumaColumna += matriz[fila, columna];
                }

                Console.WriteLine("columna " + columna + ": " + sumaColumna);
            }

            double sumaDiagonalPrincipal = 0;
            double sumaDiagonalSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
                sumaDiagonalSecundaria += matriz[i, n - 1 - i];
            }

            Console.WriteLine("\nSuma de diagonales:");
            Console.WriteLine("Diagonal principal: " + sumaDiagonalPrincipal);
            Console.WriteLine("Diagonal secundaria: " + sumaDiagonalSecundaria);
        }
    }
    
}
    

