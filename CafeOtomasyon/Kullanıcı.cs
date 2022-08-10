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
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");
        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Staff set Username=@m1,Password=@m2 where ID=@m3",connection);
            cmd.Parameters.AddWithValue("@m1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@m2",TxtSifre.Text);
            cmd.Parameters.AddWithValue("@m3",TxtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSifre.Text = "";

            MessageBox.Show("Sisteme Başarıyla Kayıt Oldunuz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            this.Hide();
        }
    }
}
