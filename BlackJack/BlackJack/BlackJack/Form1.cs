﻿using System;
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
        public Form1(string nome)
        {
           
            InitializeComponent();
            lblutente.Text = nome.ToString();
        }
               
        Random mazzo = new Random();
        int mano=0,punteggioplayer,punteggiodelar;
        public int premiUt, premiPc;
        public int a1, a2, a3, a4;
        public int b1, b2, b3, b4;
        public int risultatoPlay, risultatoPc;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mano = 0;
            ResetValue(lblDealer1m);
            ResetValue(lblDealer2m);
            ResetValue(lblDealer3m);
            ResetValue(lblDealer4m);
            ResetValue(lblplayer1m);
            ResetValue(lblplayer2m);
            ResetValue(lblplayer3m);
            ResetValue(lblplayer4m);
            ResetValue(lblrisultatodelar);
            ResetValue(lblRisultato);
            button2.Enabled = true;

            pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\cartacoperta.PNG";

            pictureBox6.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\cartacoperta.PNG";
        }
        public void Cambioimmagine()
        {
            Random run = new Random();
            if (lblplayer1m.Text == "1"||lblplayer1m.Text=="11")
            {
                int f;
                f=run.Next(1,4);
                switch (f)
                {
                    case 1:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Cuori\1c.PNG";break;
                    case 2:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Picche\1p.PNG"; break;
                    case 3:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Cuori\1q.PNG"; break;
                    case 4:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi_Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Fiori\1f.PNG"; break;
                    default:break;
                }

            }
            if (lblplayer1m.Text == "2")
            {
                int f;
                f = run.Next(1, 4);
                switch (f)
                {
                    case 1:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Cuori\2c.PNG"; break;
                    case 2:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Picche\2p.PNG"; break;
                    case 3:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Cuori\2q.PNG"; break;
                    case 4:
                        pictureBox7.ImageLocation = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\Img\Fiori\2f.PNG"; break;
                    default: break;
                }



            }
            if (lblplayer1m.Text == "3")
            {

                
            }
            if (lblplayer1m.Text == "4")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\4c.png";
            }
            if (lblplayer1m.Text == "5")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\5c.png";
            }
            if (lblplayer1m.Text == "6")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\6c.png";
            }
            if (lblplayer1m.Text == "7")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\7c.png";
            }
            if (lblplayer1m.Text == "8")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\8c.png";
            }
            if (lblplayer1m.Text == "9")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\9c.png";
            }
            if (lblplayer1m.Text == "10")
            {

                pictureBox7.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\10c.png";
            }
            if (lblplayer2m.Text == "1")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\1c.png";
            }
            if (lblplayer2m.Text == "2")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\2c.png";
            }
            if (lblplayer2m.Text == "3")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\3c.png";
            }
            if (lblplayer2m.Text == "4")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\4c.png";
            }
            if (lblplayer2m.Text == "5")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\5c.png";
            }
            if (lblplayer2m.Text == "6")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\6c.png";
            }
            if (lblplayer2m.Text == "7")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\7c.png";
            }
            if (lblplayer2m.Text == "8")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\8c.png";
            }
            if (lblplayer2m.Text == "9")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\9c.png";
            }
            if (lblplayer2m.Text == "10")
            {

                pictureBox6.ImageLocation = @"BlackJack\BlackJack\Img\Cuori\10c.png";
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Landingpage a = new Landingpage();
            a.Show();
            this.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnrisult_Click(object sender, EventArgs e)
        {
           
            risultatoPlay = Convert.ToInt32(lblRisultato.Text);
            risultatoPc = Convert.ToInt32(lblrisultatodelar.Text);
            if(risultatoPlay>risultatoPc && risultatoPlay < 22)
            {
                MessageBox.Show(lblutente.Text + " Hai Vinto");
            }
            if (risultatoPc > risultatoPlay && risultatoPc < 22)
            {
                MessageBox.Show(lblutente.Text + " Hai Perso");

            }
            if (risultatoPc > 21 || risultatoPlay > 21)
            {
                MessageBox.Show(lblutente.Text + " Hai Perso");

            }
            if (risultatoPc == risultatoPlay && risultatoPc <= 21 && risultatoPlay >= 21)
            {
                MessageBox.Show("Pareggio");
            }
            
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Fava Tony");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\song\1.mp3";
            axWindowsMediaPlayer1.Visible = false;
            
        }
        public void Scommessa()
        {
            if (lblmontUT.Text == "0")
            {
                btnrisult.Enabled = true;
                btnChiama.Enabled = true;
                
            }

        }
        public void PrimaManoDelair()
        {
            b1 = mazzo.Next(1, 11);
            b2 = mazzo.Next(1, 11);
            punteggiodelar = b1 + b2;
            lblDealer1m.Text = b1.ToString();
            lblDealer2m.Text = b2.ToString();
            lblrisultatodelar.Text = punteggiodelar.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrimaManoDelair();
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
            Cambioimmagine();
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

            Cambioimmagine();
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
        public string ResetValue(Label a)
        {
            return a.Text="0";

        }
    }
}
