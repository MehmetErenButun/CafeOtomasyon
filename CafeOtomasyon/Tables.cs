using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");
            
        
        private void button1_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa1.Text;
      
            siparis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa2.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa3.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa4.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa5.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa6.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa7.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa8.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa9_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa9.Text;
            siparis.Show();
            this.Hide();
        }

        private void BtnMasa10_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.MasaNo = BtnMasa10.Text;
            siparis.Show();
            this.Hide();
        }

        private void PbReturn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Table",connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if(item is Button)
                    {
                        if (item.Name == "BtnMasa" + reader["ID"].ToString() && reader["Status"].ToString()=="True") {

                            item.BackColor = Color.Orange;
                        
                        }
                       else if (item.Name == "BtnMasa" + reader["ID"].ToString() && reader["Status"].ToString() == "False")
                        {

                            item.BackColor = Color.Beige;

                        }
                    }
                }
            }
            connection.Close();

        }
    }
}
