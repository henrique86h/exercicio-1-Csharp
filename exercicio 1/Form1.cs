using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            label1.Text = "Meu primeiro programa C#";
        }

        private void btnOiTudoBem_Click(object sender, EventArgs e)
        {
            lblOi.Text = "Oi!";
            lblTudoBem.Text = "Tudo Bem?";
        }
    }
}
