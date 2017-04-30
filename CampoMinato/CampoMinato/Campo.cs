/*
 * Creato da SharpDevelop.
 * Utente: Tony
 * Data: 30/04/2017
 * Ora: 18:00
 * 
 * Per modificare questo modello usa Strumenti | Opzioni | Codice | Modifica Intestazioni Standard
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CampoMinato
{
	/// <summary>
	/// Description of Campo.
	/// </summary>
	/// 
	
	public partial class Campo : Form
	{
		//Pixel per la creazione dei bottoni
		#region Crezioni bottoni e pixel
		int spazioattorno = 5;
		int spaziotraiBtn= -2;
		int DimBottoni = 21;
		int probBombe = 10;
		int mossaO=0;
		int mossaV=50;
		#endregion
		#region Variabili del gioco [bombe,bottoni,campo]
		int[,] Bombe;
		bool[,] Bord;
		Button[,] Bottoni;
		int countBombe;
		Stopwatch timer = new Stopwatch();
		Thread timerthread;
		Label timerLabel;
		Label BombeRimaste;
		#endregion
		
	    int livello;
		public Campo(Point dim)
		{
			
			InitializeComponent();
			Bord=new bool[dim.X,dim.Y];
			Bombe=new int[dim.X,dim.Y];
			Bottoni=new Button[dim.X,dim.Y];
			
			switch(dim.X*dim.Y)
			{
					case 81 :
						 livello =0;
						 break;
					case 256:
						 livello =1;
						 break;
					case 480:
						 livello =2;
						 break;
						default:
						 break;
						 
			}
			this.Size=new Size(
			2*spazioattorno+dim.X*DimBottoni+dim.Y*spaziotraiBtn+DimBottoni+mossaO,
			2*spazioattorno+dim.Y*DimBottoni+dim.Y*spaziotraiBtn+DimBottoni*2+mossaV);
			this.FormBorderStyle= FormBorderStyle.Fixed3D;
			this.MaximizeBox=false;
			//oggetto da aggiungere
			//Image Sfondobottoni=Image.FromFile();
			for(int i=0;i<dim.Y;i++)
			{
				for(int j=0;i<dim.X;j++){
					Button b = new Button()
					{
						Tag=new Point(i,j),
						Location=new Point(spazioattorno+i*DimBottoni+i*spaziotraiBtn+mossaO,spazioattorno+j*DimBottoni+j*spaziotraiBtn+mossaV),
						Size=new Size(DimBottoni,DimBottoni),
						BackColor=Color.Blue,
					};
					this.Controls.Add(b);
					Bottoni[i,j]=b;
					//Delegato per la creazione dell evento
					//b.Click +=
				}
				
			}
			
		}
	}
}
