using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                Console.WriteLine("==============");
                Console.WriteLine("Menu");
                Console.WriteLine("==============");
                Console.WriteLine("1 - Calcular Perimetro");
                Console.WriteLine("2 - Calcular Porcentaje");
                Console.WriteLine("3 - Calcular Presion Objeto");
                Console.WriteLine("4 - Calcular resistencias serie");
                Console.WriteLine("5 - 8va parte numero");
                Console.WriteLine("6 - Descubrir mayor 2 numeros");
                Console.WriteLine("7 - Calcular Promocion");
                Console.WriteLine("8 - Empleados categoria");
                Console.WriteLine("9 - Empleados hijos");
                Console.WriteLine("10 - Empleados hijos");


                opcion = Convert.ToInt16(Console.ReadLine());


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






            } while (opcion != 0);

            


        }

        static void Ej1()
        {
            Console.Clear();

            double numA;
            double numB;
            char op;
            
            Console.WriteLine("Elija");
            Console.WriteLine("A | Area");
            Console.WriteLine("B | Perimetro");
            op = Convert.ToChar(Console.ReadLine());

            if (op == 'A' || op == 'a')
            {
                Console.WriteLine("Ingresa el valor de el primer lado");
                numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ahora ingrese el valor de segundo lado");
                numB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El resultado es {numA*numB}");
                Console.WriteLine("================");

            }
            if (op == 'B' || op == 'b')
            {
                Console.WriteLine("Ingresa el valor del primer lado");
                numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el valor del segundo lado");
                numB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("================");
                Console.WriteLine($"El resultado es {2*numA + 2*numB}");
                Console.WriteLine("================");


            }
            else
            { Console.WriteLine("Ingrese UNA OPCION VALIDA"); }
        }

        static void Ej2()
        {

            Console.Clear();

            int mujeres;
            int hombres;
            float total;

            Console.WriteLine("Ingrese la cantidad de hombres");
            hombres = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Ingrese la cantidad de mujeres");
            mujeres = Convert.ToInt16(Console.ReadLine());

            total = mujeres + hombres;
            float porcentajeM = (mujeres * 100) / total;
            float porcentajeH = (hombres * 100) / total;

            Console.WriteLine($"Hubieron {total} cantidad de aplicados y fueron {porcentajeH}% hombres y {porcentajeM}% mujeres");

        }

        static void Ej3()
        {
            Console.Clear();
            double fuerza;
            double area;

            Console.WriteLine("Ingrese la supeficie del objeto:");
            area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la fuerza en la equacion:");
            fuerza = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"La presion de el objeto es de {fuerza / area}");
        }

        static void Ej4()
        {
            Console.Clear();
            double res;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresa el valor de la resistencia numero {i}");
                res =+ Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El valor de las resistencias en serie es de {res} ohms");

            }

        }

        static void Ej5()
        {
            Console.Clear();
            int num;
            Console.WriteLine("Ingrese un valor entero");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"La octava parte de {num} es {num/8}");
        }

        static void Ej6()
        {
            Console.Clear();
            double num1;
            double num2;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El primer numero ({num1}) es mas alto que el segundo ({num2})");
            }
            else if (num2 > num1)
            {

                Console.WriteLine($"El segundo numero ({num2}) es mas alto que el primero ({num1})");
            }
            else if (num2 == num1)
            {

                Console.WriteLine($"Los dos numeros son iguales");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }

        static void Ej7()
        {
            Console.Clear();

            int opcion;
            double impuesto;
            int horas;

            Console.WriteLine("Ingrese su cantidad de horas");
            horas = Convert.ToInt16(Console.ReadLine());

            if (horas >= 20)
            {
                Console.WriteLine("Ingrese su categoria");
                Console.WriteLine("[1] +70 Años");
                Console.WriteLine("[2] +60 Años");
                Console.WriteLine("[3] +50 Años");
                opcion = Convert.ToInt16(Console.ReadLine());

                double bruto = horas * 50;

                impuesto = (bruto * 33) / 100;

                if (opcion == 1)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto + impuesto ) - ((bruto * 50)/100)}");
                    Console.WriteLine("================");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto+ impuesto) - ((bruto * 30 )/ 100 )}");
                    Console.WriteLine("================");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("================");
                    Console.WriteLine($"El precio sin impuestos/descuentos seria {bruto}");
                    Console.WriteLine($"El precio final seria {(bruto + impuesto) - ((bruto * 20) / 100)}");
                    Console.WriteLine("================");
                }
            }
            else
            {
                Console.WriteLine("El descuento es para minimo 20hs");
            }

            
        }   

        static void Ej8()
        {
            Console.Clear();
            int categoria;
            double horas;

            Console.WriteLine("Ingrese su categoria de empleado:");
            Console.WriteLine("[1] A");
            Console.WriteLine("[2] B");
            Console.WriteLine("[3] C");

            categoria = Convert.ToInt16(Console.ReadLine());

            if (categoria == 1)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 200}");
            }
            else if (categoria == 2)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 180}");
            }
            else if (categoria == 3)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                horas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("================");
                Console.WriteLine($"El sueldo final seria {horas * 150}");
            }
            else
            { 
                Console.WriteLine("NO PERTENECE A NINGUNA CATEGORIA, VALOR DE LAS HORAS $0");
            }

        }

        static void Ej9()
        {
            Console.Clear();
            int categoria;
            int hijos;
            double bruto;
            double final;

            Console.WriteLine("Ingrese su sueldo en bruto");
            bruto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su cantidad de hijos");
            hijos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su categoria");
            Console.WriteLine("[1] A");
            Console.WriteLine("[2] B");
            Console.WriteLine("[3] C");
            categoria = Convert.ToInt16(Console.ReadLine());

            if (categoria == 1)
            {
                final = bruto + ((bruto * 10) / 100);

                if (hijos > 4)
                { 
                    final += 1100 ;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");
                
            

            }
            else if (categoria == 2)
            {
                final = bruto + ((bruto * 20) / 100);

                if (hijos > 4)
                {
                    final += 1100 ;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");

            }
            else if (categoria == 3)
            {

                final = bruto;

                if (hijos > 4)
                {
                    final += 1100 ;
                }
                else if (hijos < 4 && hijos > 0)
                {
                    final += (hijos * 300);
                }

                Console.WriteLine($"El sueldo final seria {final}");    
            }
        }

        static void Ej10()
        {
            double peso;
            double altura;

            Console.WriteLine("Ingrese su altura en Metros");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en KG");
            peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            if (imc < 20)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene bajo peso"); }
            else if (imc > 20 && imc < 25)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene un peso ideal"); }
            else if (imc > 25)
            { Console.WriteLine($"Su imc es de {imc} Eso significa que tiene sobre peso"); }

        }



    }
}
