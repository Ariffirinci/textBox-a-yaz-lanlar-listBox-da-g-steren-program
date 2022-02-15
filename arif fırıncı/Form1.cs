using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arif_fırıncı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int sayı;

            while (i < Convert.ToInt32(textBox2.Text))
            {
             //   listBox1.Items.Add("");
                listBox1.Items.Add(textBox1.Text);
                sayı = Convert.ToInt32(textBox2.Text);
                i++;
            }
             
            
                
            
           
               
               
           
        }
    }
}
