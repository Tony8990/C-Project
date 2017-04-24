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
        int mano=0,punteggioplayer,punteggiodelar;
        public int a1, a2, a3, a4;
        public int b1, b2, b3, b4;
        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Fava Tony");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            b1 = mazzo.Next(1, 11);
            b2 = mazzo.Next(1, 11);
            punteggiodelar = b1 + b2;
            lblDealer1m.Text = b1.ToString();
            lblDealer2m.Text = b2.ToString();
            lblrisultatodelar.Text = punteggiodelar.ToString();
            if (punteggiodelar < 16)
            {
                b3 = mazzo.Next(1, 11);
                lblDealer3m.Text = b3.ToString();
                punteggiodelar += b3;
                lblrisultatodelar.Text = punteggiodelar.ToString();
            }
           if (punteggiodelar < 16)
           {
                    b4 = mazzo.Next(1, 11);
                    lblDealer4m.Text = b4.ToString();
                    punteggiodelar += b4;
                    lblrisultatodelar.Text = punteggiodelar.ToString();
           }
            
        }

        private void btnChiama_Click(object sender, EventArgs e)
        {
           
                mano++;
                if (mano == 1)
                {

                    a1 = mazzo.Next(1, 11);
                    a2 = mazzo.Next(1, 11);
                    punteggioplayer = a1 + a2;
                    lblplayer1m.Text = a1.ToString();
                    lblplayer2m.Text = a2.ToString();
                    lblRisultato.Text = punteggioplayer.ToString();
                }

                if (mano == 2)
                {

                    a3 = mazzo.Next(1, 11);
                    lblplayer3m.Text = a3.ToString();
                    punteggioplayer = Convert.ToInt32(lblplayer1m.Text) + Convert.ToInt32(lblplayer2m.Text) + a3;
                    lblRisultato.Text = punteggioplayer.ToString();

                }
                if (mano == 3)
                {

                    a4 = mazzo.Next(1, 11);
                    lblplayer4m.Text = a4.ToString();
                    punteggioplayer = Convert.ToInt32(lblplayer1m.Text) + Convert.ToInt32(lblplayer2m.Text) + Convert.ToInt32(lblplayer3m.Text) + a4;
                    lblRisultato.Text = punteggioplayer.ToString();

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
