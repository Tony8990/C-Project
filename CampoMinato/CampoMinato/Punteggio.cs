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
		public Punteggio()
		{
		}
	}
}
