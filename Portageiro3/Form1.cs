using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portageiro3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botaoCircular2_Click(object sender, EventArgs e)
        {
            senha.Text = "";
            username.Text = "";
        }

        private void botaoCircular1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;

            Visible = false;
        }
    }
}
