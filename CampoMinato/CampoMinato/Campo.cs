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
				    b.Click +=(object sender , EventArgs e)=>
					{
						if(!timer.IsRunning)
						{
							timer.Start();
							
							timerthread=new Thread(() =>
							{
							      while(true)
							      {
							      	if(timerLabel.InvokeRequired)
							      	{
							      		timerLabel.BeginInvoke((Action)(()=>
							      		                                {
							      		                                	TimeSpan t=TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds);
							      		                                	timerLabel.Text=string.Format("{0}:{1}:{2}",
							      		                                	t.Minutes,
							      		                                	t.Seconds,
							      		                                	t.Milliseconds);
							      		                                	
							      		                                }));
							      	}
							      	else
							      	{
							      		TimeSpan t=TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds);
							      		timerLabel.Text=string.Format("{0}:{1}:{2}",
							      		t.Minutes,
							      	    t.Seconds,
							      		t.Milliseconds);
							      		                                	
							      		
							      		
							      	}
							      	Thread.Sleep(100);
							      		                                	
							      		                                
							      	}
				
							      
								});
							
                            
							timerthread.Start();
							}
						Button bottoni2 =sender as Button;
						Point posizione=(Point)bottoni2.Tag:
						Bottoni[posizione.X,posizione.Y].BackColor=Color.Yellow;
						int x=posizione.X;
						int y=posizione.Y;
						if(Bord[x,y])
						{
							timer.Stop();
							timerthread.Abort();
							MessageBox.Show("HAI PERSO !!");
							this.Close();
							
						 
						
							
						}
						List<int[]>ValoriC=new List<int[]>();
						List<int[]>ValoriCtemp=new List<int[]>();
						ValoriC.Add(nee int[]{x,y});
						do
						{
							foreach(int[] pos in ValoriC)
							{
								if(Bottoni[pos[0],pos[1]].Enabled)
								{
									foreach(int[] comb in combinazioni)
									{
										int riga=comb[0]+pos[0];
										int colon=comb[1]+pos[1];
										if(riga>=0&&colon>=0&&riga<dim.Y&&colon<dim.X&&Bombe[pos[0],pos[1]]==0)
										{
											ValoriCtemp.Add(new int []{riga,colon});
										}
									}
									Bottoni[pos[0],pos[1]].Enabled=false;
									Bottoni[pos[0],pos[1]].BackColor=Color.White;
									if(Bombe[pos[0],pos[1]]>0)
									{
										Bottoni[pos[0],pos[1]].Text=Bombe[pos[0],pos[1]].ToString();
										switch(Bombe[pos[0],pos[1]]-1)
										{
											case 0:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Green;
										          break;
										    case 1:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Red;
										          break;
										    case 2:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Orange;
										          break;
										    case 3:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.DarkBlue;
										          break;
										    case 4:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Brown;
										          break;
										    case 5:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Cyan;
										          break;
										    case 6:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Black;
										          break;
										    case 7:
										          Bottoni[pos[0],pos[1]].ForeColor=Color.Gray;
										          break;
										    default:
										          break;
										}
									}
								
								}
								
							}
							
							ValoriC=new List<int[]>(ValoriCtemp);
							ValoriCtemp.Clear();
						}
						while(ValoriC.Count > 0);
					};
				    b.MouseUp +=(object sender,MouseEventArgs e)=>
				    {
				    	if(e.Button==MouseButtons.Right)
				    	{
				    		if(((Button)sender).BackColor==null)
				    		{
				    			((Button)sender).BackgroundImage=bandiera;
				    			if(countBombe==0)
				    			{
				    				string min=Punteggio.ID(livello).Tempomin();
				    				string[] sar=min.Split(':');
				    				int[] arg=sar.Select(s=>int.TryParse(s)).ToArray();
				    				
				    				long T=timer.ElapsedMilliseconds;
				    				int x=arg[0]*60*1000+arg[1]*1000+arg[2]*10;
				    				bool tmp=true;
				    				for(int i=0;i<dim.Y;i++)
				    				{
				    					for(int j=0;j<dim.X;j++)
				    					{
				    						if(Bottoni[i,j].BackgroundImage!=null)
				    						{
				    							tmp=tmp&&Bord[i,j];
				    						}
				    					}
				    					
				    				}
				    				if(tmp && T > x)
				    				{
				    					this.Hide();
				    					timerthread.Abort();
				    					timer.Stop();
				    					var ts=TimeSpan.FromMilliseconds(T);
				    					string s =string.Format("{0):{1}:{2}",ts.Minutes,ts.Seconds,ts.Milliseconds);
				    					
				    					
				    				}
				    			}
				    		}
				    	}
				    }
				}
				
			}
			
		}
	}
}
