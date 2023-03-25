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
    public partial class Yacht_Stoke : Form
    {
        public Yacht_Stoke()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\source\repos\جرد\جرد\Database1.mdf;Integrated Security=True");
        private void Yacht_Stoke_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            Con.Open();
            String query = "select * from Yachet_Stoke";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Pressesh pressesh = new Pressesh();
            pressesh.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            double tot;
            tot = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text);
            label8.Text = tot.ToString();
            Con.Open();
            String query = "insert into Yachet_Stoke values(N'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "')";
            SqlCommand cmd = new SqlCommand("INSERT INTO Yachet_Stoke (الصنف,العدد,السعر,التاريخ,الاجمالى) VALUES " +
                "(@الصنف,@العدد,@السعر,@التاريخ,@الاجمالى)", Con);
            cmd.Parameters.AddWithValue("@الصنف", textBox1.Text);
            cmd.Parameters.AddWithValue("@العدد", textBox2.Text);
            cmd.Parameters.AddWithValue("@السعر", textBox3.Text);
            cmd.Parameters.AddWithValue("@التاريخ", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@الاجمالى", label8.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تمت الاضافه");

            Con.Close();
            populate();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateTotal;
            updateTotal = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            label8.Text = updateTotal.ToString();
            Con.Open();
            string query = "update Yachet_Stoke set الصنف=N'" + textBox1.Text + "',العدد='" + textBox2.Text + "',السعر='" + textBox3.Text + "',التاريخ='" + dateTimePicker1.Value.Date + "',الاجمالى='" + label8.Text + "' where الصنف=N'" + textBox1.Text + "';";
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
                String query = "delete from Yachet_Stoke where الصنف=N'" + textBox1.Text + "';";
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
            dgvprinter.Title = "مشتريات المركب";
            dgvprinter.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            dgvprinter.PorportionalColumns = true;
            dgvprinter.FooterSpacing = 20;
            dgvprinter.PageNumbers = true; ;
            dgvprinter.PrintDataGridView(dataGridView1);
            populate();
        }
    }
}
