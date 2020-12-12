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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Mohtava_Click(object sender, EventArgs e)
        {
            
            var form2 = new MohtavaAmozeshiForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void Poster_Click(object sender, EventArgs e)
        {
            var form2 = new PosterForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Korikolom_Click(object sender, EventArgs e)
        {

        }

        private void marja_Click(object sender, EventArgs e)
        {

        }

        private void NarmNiyaz_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void MoarefiKetab_Click(object sender, EventArgs e)
        {

        }

        private void MorefiNarmAfzar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
