using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace esercizio_6_7
{
    class Program
    {




         
        static void Main(string[] args)
        {
           
            
           string path = @"c:\temp\exercises\HelloWorld.txt";
           if (!File.Exists(path)) 
           {

           
            using (StreamWriter sw = File.AppendText(path)) 
            {


                  sw.WriteLine();

       
}


Console.ReadLine();

            }	
        }

      
        }
    }

