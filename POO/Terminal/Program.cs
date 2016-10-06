using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensagem que vei para o terminal");
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha!=null)
            {
                linha = leitor.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
