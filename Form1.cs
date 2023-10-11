using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._3._RafaelB
{
    public partial class Form1 : Form
    {
        

        public int brojac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = imageList1.Images[brojac];
            brojac++;

            if(brojac == 3) { brojac = 0; }
        
        }
    }
}
