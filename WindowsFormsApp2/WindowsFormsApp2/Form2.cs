using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : WindowsFormsApp2.Form1
    {
        public string tx { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx = textBox1.Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Value
        }
    }
}
