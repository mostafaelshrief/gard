using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace جرد
{
    public partial class Yacht : Form
    {
        public Yacht()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\source\repos\جرد\جرد\Database1.mdf;Integrated Security=True");
        private void Yacht_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from Yachet";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "insert into Yachet values(N'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand("INSERT INTO Yachet (الصنف,العدد,المفقود,الهالك) VALUES " +
                "(@الصنف,@العدد,@المفقود,@الهالك)", Con);
            cmd.Parameters.AddWithValue("@الصنف", textBox1.Text);
            cmd.Parameters.AddWithValue("@العدد", textBox2.Text);
            cmd.Parameters.AddWithValue("@المفقود", textBox3.Text);
            cmd.Parameters.AddWithValue("@الهالك", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافه");

            Con.Close();
            populate();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Yachet set الصنف=N'" + textBox1.Text + "',العدد='" + textBox2.Text + "',المفقود='" + textBox3.Text + "',الهالك='" + textBox4.Text + "' where الصنف=N'" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updateed successfully");
            Con.Close();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from Yachet where الصنف=N'" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحذف");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvprinter = new DGVPrinter();
            dgvprinter.Title = "جرد المركب";
            dgvprinter.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            dgvprinter.PorportionalColumns = true;
            dgvprinter.FooterSpacing = 20;
            dgvprinter.PageNumbers = true; ;
            dgvprinter.PrintDataGridView(dataGridView1);
            populate();
        }
    }
}
