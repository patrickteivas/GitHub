using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage text");
            var text = Console.ReadLine();
            text = text.Replace(" ", ""); //Samuti sõnade ja tähtedega

            Console.WriteLine("ALGUS " + text.Trim() + " LÕPP");
        }
    }
}
