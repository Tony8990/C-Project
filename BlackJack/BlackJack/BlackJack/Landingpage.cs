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
    
    public partial class Landingpage : Form
    {
        public string nome;
        public Landingpage()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            //Partita a = new Partita(nome);
            Form1 b = new Form1(nome);
            b.Show();
            //Song();
            //a.Show();
            this.Hide();           
            
            
           
        }
        public void Song()
        {
            Console.Beep(2000, 100);
            Console.Beep(6800, 100);
            Console.Beep(5800, 100);
            Console.Beep(2580, 100);
            Console.Beep(3000, 100);
            Console.Beep(2360, 100);

        }

        private void Landingpage_Load(object sender, EventArgs e)
        {

        }
    }
}



