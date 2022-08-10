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

namespace CafeOtomasyon
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");

        void Listele()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select ID,Name as 'Ad',Surname as 'Soyad',Status as 'Durumu' from Tbl_Staff",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        void Temizle()
        {
            TxtPerID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CbAktif.Checked = false;
            Cbİzinli.Checked = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtPerID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            

            if (dataGridView1.Rows[secilen].Cells[3].Value.ToString() == "True")
            {
                CbAktif.Checked = true;
                Cbİzinli.Checked = false;
            }
            else
            {
                CbAktif.Checked = false;
                Cbİzinli.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("insert into Tbl_Staff (Name,Surname) values (@m1,@m2)", connection);
            cmd.Parameters.AddWithValue("@m1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@m2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            Listele();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string durum = "True";

            if (CbAktif.Checked)
            {
                durum = "True";
            }
            if (Cbİzinli.Checked)
            {
                durum = "False";
            }

            connection.Open();

            SqlCommand cmd = new SqlCommand("update Tbl_Staff set Name=@m1, Surname=@m2, Status=@m3 where ID=@m4", connection);
            cmd.Parameters.AddWithValue("@m1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@m2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@m3",durum);
            cmd.Parameters.AddWithValue("@m4", TxtPerID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

          

            Listele();
            Temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Tbl_Staff where ID=@m4", connection);
            cmd.Parameters.AddWithValue("@m4", TxtPerID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            Listele();
            Temizle();

        }

        private void Btnİslemler_Click(object sender, EventArgs e)
        {
            Kullanıcı kullanıcı = new Kullanıcı();
            kullanıcı.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
