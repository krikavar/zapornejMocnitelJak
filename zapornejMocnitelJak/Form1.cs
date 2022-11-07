using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zapornejMocnitelJak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cislo = int.Parse(textBox1.Text);
            int mocnitel = int.Parse(textBox2.Text);
            double vysledek = 1;

            if(mocnitel < 0)
            {
                cislo = 1 / cislo;
                mocnitel *= -1;
            }
            
            for(int i = 0; i < mocnitel; i++)
            {
                   vysledek *= cislo;
            }
                MessageBox.Show(vysledek.ToString());
            
            
        }
    }
}
