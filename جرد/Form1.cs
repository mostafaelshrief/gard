namespace جرد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            Hotel hotel = new Hotel();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ketchen hotel = new Ketchen();
            hotel.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Ketchen hotel = new Ketchen();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bar hotel = new Bar();
            hotel.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Bar hotel = new Bar();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Yacht hotel = new Yacht();
            hotel.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Yacht hotel = new Yacht();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Pressesh hotel = new Pressesh();
            hotel.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Pressesh hotel = new Pressesh();
            hotel.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Stoke hotel = new Stoke();
            hotel.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Stoke hotel = new Stoke();
            hotel.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}