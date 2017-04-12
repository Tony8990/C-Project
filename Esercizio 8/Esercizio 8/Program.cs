using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Esercizio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            List<string> mylist = new List<string> { "a", "b", "c" };
            /*foreach (string elem in mylist)
                Console.WriteLine("Gli elementi della lista sono :[{0}]", elem);
           */
            List<string> seclist = new List<string> { };
           
           
        /*for (i = 0; i<mylist.Count; i++)
            {
               
                Console.WriteLine("Gli elementi nella lista sono {0}",mylist[i]);
            }
            seclist.Add("a");
           /*    
            while (mylist.Capacity >seclist.Capacity)
            {
                Console.WriteLine("Gli elementi nella lista sono : {0} + {1}",lista.ToString(),lista2.ToString());
                seclist.Add("t");
            }
            * 
    */
            i = mylist.Count;
            while (i==0) 
            {
                Console.WriteLine("Gli elementi nella lista sono {0}", mylist[i]);
                i--;
            }              
            Console.ReadLine();
        }

      }
}
