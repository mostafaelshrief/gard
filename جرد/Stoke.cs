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
    public partial class Stoke : Form
    {
        public Stoke()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BarStoke barStoke=new BarStoke();
            barStoke.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BarStoke barStoke = new BarStoke();
            barStoke.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KetchenStokecs barStoke = new KetchenStokecs();
            barStoke.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            KetchenStokecs barStoke = new KetchenStokecs();
            barStoke.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HotelStoke barStoke = new HotelStoke();
            barStoke.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HotelStoke barStoke = new HotelStoke();
            barStoke.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            YachtStoke barStoke = new YachtStoke();
            barStoke.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            YachtStoke barStoke = new YachtStoke();
            barStoke.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
