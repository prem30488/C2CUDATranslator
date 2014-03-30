using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C2CUDATranslator
{
    public partial class Form1 : Form
    {
        public string txtpattern;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = txtpattern;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
