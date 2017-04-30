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
    public partial class Partita : Form
    {
        public Partita(string nome)
        {
            InitializeComponent();
            lblutente.Text = nome.ToString();
        }

        private void Partita_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Tony\Desktop\Esercizi Scuola\C-Project\BlackJack\BlackJack\BlackJack\song\1.mp3";
            axWindowsMediaPlayer1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuovaPartitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Landingpage a = new Landingpage();
            a.Show();
            this.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
