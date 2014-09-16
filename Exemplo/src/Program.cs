using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            string texto = Console.ReadLine();
            int x = texto.ToInt();//Convert.ToInt32(texto);
            Console.Write("O dobro do valor {0} é {1}", x, x * 2);
            Console.ReadKey();  
        }
    }
}
