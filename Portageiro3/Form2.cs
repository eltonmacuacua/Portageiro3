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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void painelCircula2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoCircular6_Click(object sender, EventArgs e)
        {

        }

        private void botaoCircular8_Click(object sender, EventArgs e)
        {
            tipo_isencao.Visible = true;
        }

        private void botaoCircular13_Click(object sender, EventArgs e)
        {
            tipo_isencao.Visible = false;
        }

        private void botaoCircular12_Click(object sender, EventArgs e)
        {
            tipo_isencao.Visible = false;
        }
    }
}
