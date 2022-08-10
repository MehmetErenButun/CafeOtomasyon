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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");

        private void BtnEnter_Click(object sender, EventArgs e)
        {   
            connection.Open();
            SqlCommand cmd = new SqlCommand("select username,password from Tbl_Staff where UserName=@p1 and Password=@p2",connection);
            cmd.Parameters.AddWithValue("@p1",txtUsername.Text);
            cmd.Parameters.AddWithValue("@p2",txtPass.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı");
            }

            connection.Close();



        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
