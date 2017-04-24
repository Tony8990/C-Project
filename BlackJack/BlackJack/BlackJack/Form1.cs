using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random mazzo = new Random();
        int mano=0,punteggio;
        public int a1, a2, a3, a4;
        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Fava Tony");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnChiama_Click(object sender, EventArgs e)
        {
           
                mano++;
                if (mano == 1)
                {

                    a1 = mazzo.Next(1, 11);
                    a2 = mazzo.Next(1, 11);
                    punteggio = a1 + a2;
                    lblplayer1m.Text = a1.ToString();
                    lblplayer2m.Text = a2.ToString();
                    lblRisultato.Text = punteggio.ToString();
                }

                if (mano == 2)
                {

                    a3 = mazzo.Next(1, 11);
                    lblplayer3m.Text = a3.ToString();
                    punteggio = Convert.ToInt32(lblplayer1m.Text) + Convert.ToInt32(lblplayer2m.Text) + a3;
                    lblRisultato.Text = punteggio.ToString();

                }
                if (mano == 3)
                {

                    a4 = mazzo.Next(1, 11);
                    lblplayer4m.Text = a4.ToString();
                    punteggio = Convert.ToInt32(lblplayer1m.Text) + Convert.ToInt32(lblplayer2m.Text) + Convert.ToInt32(lblplayer3m.Text) + a4;
                    lblRisultato.Text = punteggio.ToString();

                }
            

        }

        private void lblPunteggio_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
