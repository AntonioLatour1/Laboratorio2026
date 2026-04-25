namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una lista de mails separados por coma:");
            string entrada = Console.ReadLine();
            int validos = 0;    
            int invalidos = 0;  
            
            string[] mails = entrada.Split(',');
            for (int i = 0; i < mails.Length; i++)
            {
                mails[i] = mails[i].Replace(" ", "");
            }

            for (int i = 0; i < mails.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {mails[i]}");
            }

            for (int i = 0; i < mails.Length; i++)
            {
                if (mails[i].Contains('@'))
                    validos++;
                else
                    invalidos++;
            }

            Console.WriteLine();
            Console.WriteLine("===============");
            Console.WriteLine($"Hay {validos} mails validos y {invalidos} mails invalidos.");
            Console.WriteLine("===============");

            Console.WriteLine("");
            Console.WriteLine("Nombres de Usuario:");
            for (int i = 0; i < mails.Length; i++)  // 
            {
                if (mails[i].Contains('@'))
                    Console.WriteLine(mails[i].Split('@')[0]);
            }

            Console.WriteLine("===============");
            Console.WriteLine("Dominios en el mismo orden que los usuarios:");
            for (int i = 0; i < mails.Length; i++)  
            {
                if (mails[i].Contains('@'))
                    Console.WriteLine(mails[i].Split('@')[1]);
            }
        }
    }
}
