using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERRORE: nessun parametro.");
                return;
            }

            string nome = String.Empty;
            string testo = String.Empty;
            DateTime day = DateTime.Now;

            int _messaggio = Array.IndexOf(args, "-m");
            if (_messaggio < 0)
                _messaggio = Array.IndexOf(args, "--message");
            if (_messaggio >= 0)
            {
                testo = string.Copy(args[_messaggio + 1]);
            }

            int _data = Array.IndexOf(args, "-d");
            if (_data < 0)
                _data = Array.IndexOf(args, "--date");
            if (_data >= 0)
            {
                switch (args[_data + 1])
                {
                    case "today":
                        break;
                    case "yesterday":
                        day = day.AddDays(-1);
                        break;
                    case "tomorrow":
                        day = day.AddDays(1);
                        break;
                    case "nextweek":
                        day = day.AddDays(7);
                        break;
                    default:
                        Console.WriteLine("ERRORE: parametro -d/--date non valido.");
                        return;
                }
            }

            int _author = Array.IndexOf(args, "-a");
            if (_author < 0)
                _author = Array.IndexOf(args, "--author");
            if (_author >= 0)
            {
                nome = string.Copy(args[_author + 1]);
            }

            Console.WriteLine(nome + "@" + day.ToString("d") + ": " + testo);

            Console.ReadLine();
        }
    }
}
