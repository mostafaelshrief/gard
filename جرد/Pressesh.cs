using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace جرد
{
    public partial class Pressesh : Form
    {
        public Pressesh()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Ketchen_Stoke hotel_Stoke = new Ketchen_Stoke();
            hotel_Stoke.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hotel_Stoke hotel_Stoke = new Hotel_Stoke();
            hotel_Stoke.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Yacht_Stoke yacht_Stoke = new Yacht_Stoke();
            yacht_Stoke.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            Yacht_Stoke yacht_Stoke = new Yacht_Stoke();
            yacht_Stoke.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hotel_Stoke hotel_Stoke=new Hotel_Stoke();
            hotel_Stoke.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ketchen_Stoke hotel_Stoke = new Ketchen_Stoke();
            hotel_Stoke.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bar_Stoke bar_Stoke= new Bar_Stoke();
            bar_Stoke.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Bar_Stoke bar_Stoke = new Bar_Stoke();
            bar_Stoke.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
