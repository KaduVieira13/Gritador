using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(" Olá usuário! \n Como está se sentindo hoje?");
            string Texto = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(  Texto.ToUpper());
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" Nossa!!! \n Por que você está bravo?");
            
            
        
        }
    }
}
