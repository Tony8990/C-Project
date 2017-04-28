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
    public partial class Inizio : Form
    {
        private string g1;
        private string g2;

        public Inizio()
        {
            InitializeComponent();
        }

        private void Inizio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(2000, 150);
            Console.Beep(2520, 150);
            Console.Beep(2231, 150);
            Console.Beep(1234, 150);
            Console.Beep(9654, 150);
            Console.Beep(2231, 150);
            Console.Beep(2352, 150);
            Console.Beep(1256, 150);
            Console.Beep(2654, 150);
            Console.Beep(4569, 150);
            
            g1 = textBox1.Text;
            g2 = textBox2.Text;
            Form1 a = new Form1();
            this.Hide();
        
            a.Show();
        
        }
    }
}
