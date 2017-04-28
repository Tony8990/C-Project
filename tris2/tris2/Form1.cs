using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tris2
{
    public partial class Form1 : Form
    {
        


        bool turn = true;
        int turn_count = 0;
        int win = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Tony Gioco del tris", "triss regole");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";


            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        private void checkForWinner()
        {
            bool theIsaWinner = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            
                theIsaWinner = true;
            
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            
                theIsaWinner = true;
            
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                theIsaWinner = true;
            

            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
             theIsaWinner = true; 
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
             theIsaWinner = true; 
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
             theIsaWinner = true; 

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            theIsaWinner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
             theIsaWinner = true; 
         


            if (theIsaWinner)
            {
                disablebutton();
                String winner = "";
                if (turn)
                {
                    /*Console.Beep(2352, 50);
                    Console.Beep(1256, 50);
                    Console.Beep(2654, 50);
                    Console.Beep(4569, 50);
                   */
                    winner = label1.Text;
                    win++;
                    label4.Text = win.ToString();
                }
                else
                {
                    /*Console.Beep(2352, 50);
                    Console.Beep(1256, 50);
                    Console.Beep(2654, 50);
                    Console.Beep(4569, 50);
                    
                     */winner = label2.Text;
                       win++;
                       label3.Text = win.ToString();
                }
                MessageBox.Show(  winner + "VITTORIA!!!");
            }
            else 
            {
                if(turn_count==9)
                    MessageBox.Show("PARITA'");
            
            }
        }
        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void nuovaPartitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            win = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
    }
