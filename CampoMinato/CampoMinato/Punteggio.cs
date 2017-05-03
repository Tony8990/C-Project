/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 01/05/2017
 * Ora: 15:29
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CampoMinato
{
	/// <summary>
	/// Description of Punteggio.
	/// </summary>
	/// 
	public class Punteggio
	{
		int puntegioentri=10;
		static Punteggio pri;
		public static Punteggio Principianti
		{
			get
			{
				if(pri==null)
				{
					pri=new Punteggio(0);
				}
				return pri;
				
			}
			
		}
		static Punteggio norm;
		public static Punteggio Normale
		{
			get
			{
				if(norm==null)
				{
					norm=new Punteggio(1);
				}
				return norm;
			}
		}
		
		static Punteggio expert;
		public static Punteggio Expert
		{
			get
			{
				if(expert==null)
				{
					expert=new Punteggio(1);
				}
				return expert;
			}
		}
		public static Punteggio ID(int id)
		{
			switch(id)
			{
				case 0:
					return Punteggio.Principianti;
				case 1:
					return Punteggio.Normale;
				case 2:
					return Punteggio.Expert;
			}
			return null;
		}
		class Record
		{
			public string Nome;
			public string Tempo;
			public Record(string n,string t)
			{
			 	Nome=n;
			 	Tempo=t;
			}
			
			public string UnRecord()
			{
				return string.Format("{0};{1};"+Environment.NewLine,Nome,Tempo)
			}
			public string AsString()
			{
				return string.Format("{0} {1} "+Environment.NewLine,Nome,Tempo)
			}
			public static Record Carica(string n)
			{
				string[] rec = n.Split(';')
					return new Record(rec[0],rec[1]);
			}
		}
		List<Record> Record;
		string Livello;
		public Punteggio(int lvl)
		{
			switch(lvl)
			{
				case 0:
					Livello="Principiante";
					break;
					
				case 1:
					Livello="Normale";
					break;
				
				case 2:
					Livello="Esperto";
					break;
				default:
					break;
					
					
			}
			if(!Directory.Exists("./Punteggio"))
				Directory.CreateDirectory("./Punteggio");
			
			if(!File.Exists("./Punteggio/"+Livello))
				File.Create("./Punteggio/"+Livello).Close();
			
			Record=File.ReadAllLines("Punteggio/"+Livello).Select(line => Record.Carica(line)).Take(puntegioentri).ToList();
			
			
		}
		public bool Controlla()
		{
			return Record.Count > 0;
		}
		public string Ordina()
		{
			return string.Join("",Record.OrderBy(min =>
		   {
		    int [] arg = min.Tempo.Split(':').Select(s=>int.TryParse(s)).ToArray();
		    return arg[0]*60*1000+arg[1]*1000+arg[2]*10;
			                                     }).Take(puntegioentri).Select((min,ind)=>string.Format("{0} {1,15} {2}"+Environment.NewLine,ind,min.Nome,min.Tempo)));
			
			
		}
		public string Tempomin()
		{
			return Record.Count>=puntegioentri ? Record.Last().Tempo:"60:60:99";
			
		}
		public void Add(string nome,string tempo)
		{
			Record.Add(new Record(nome,tempo));
			
			Record=Record.OrderBy(record=>{
			                      	int[] arg = record.Tempo.Split(':').Select(s=> int.TryParse(s)).ToArray();
			                      	return arg[0]*60*1000+arg[1]*1000+arg[2]*10;
			                      	
			                      }).Take(puntegioentri).ToList();
		}
		
	}
}
