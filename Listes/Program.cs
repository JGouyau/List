using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> maListeDeString = new List<string>();
            maListeDeString.Add("Machin");
            maListeDeString.Add("Truc");
            maListeDeString.Add("Bidulle");

            Console.WriteLine(" Avant modif ");
            Console.WriteLine(" ---------------");
            foreach (string s in maListeDeString)
            {
                Console.WriteLine("  "+s);
            }

            Console.WriteLine(  );

            maListeDeString.RemoveAt(0);
            maListeDeString.Remove("Bidulle");
            maListeDeString[0] = "Truc2";

            Console.WriteLine(" Après modif ");
            Console.WriteLine(" ---------------");

            foreach (string s in maListeDeString)
            {
                Console.WriteLine("  " + s);
            }

            Console.ReadLine();
        }
    }
}
