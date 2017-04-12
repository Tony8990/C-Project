using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caratteri
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            char car;
            Console.WriteLine("Inserire il carattere decimale");
            string temp = Console.ReadLine();
            char.TryParse(temp, out car);
            
            val = 0;

            
            while (car < '0' || car > '9')
            {
                Console.WriteLine("======   ERRORE IL CARATTERE NON E' DECIMALE===== ");
                Console.ReadLine();
            }
            val = car;
            Console.WriteLine("Il valore in codice ascii ---->" + val);
            Console.ReadLine();
        }
    }
}
