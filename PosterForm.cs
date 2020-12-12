using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class PosterForm : Form
    {
        public PosterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }
    }
}
