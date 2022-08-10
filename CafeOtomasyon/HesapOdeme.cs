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
    public partial class HesapOdeme : Form
    {
        public HesapOdeme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");



        public string MasaAd;
        public void HesapOdeme_Load(object sender, EventArgs e)
        {
           
            

            //connection.Open();
            //SqlCommand cmd1 = new SqlCommand("select * from Tbl_Payments where CustomerID=(select ID from Tbl_Customer where TableID=(select ID from Tbl_Table where MasaNo=@t1))", connection);
            //cmd1.Parameters.AddWithValue("@t1",a);
            //SqlDataAdapter data = new SqlDataAdapter(cmd1);
            //DataTable dt = new DataTable();
            //data.Fill(dt);
            //hesapDT.DataSource = dt;

            //connection.Close();

            connection.Open();

            SqlCommand cmd = new SqlCommand("select PaymentType from Tbl_PaymentTypes",connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CmbOdemeTuru.Items.Add(dr[0]);
            }

            connection.Close();

          





        }

       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Tables table = new Tables();
            table.Show();
            this.Hide();
        }

        void Listele()
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Tbl_Payments where CustomerID=(select ID from Tbl_Customer where TableID=(select ID from Tbl_Table where MasaNo=@m1) and Status='True')", connection);
            cmd2.Parameters.AddWithValue("@m1", MasaAd);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            hesapDT.DataSource = dt;
            connection.Close();
        }

        private void BtnHesapGetir_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Tbl_Payments (PaymentTypeID,CustomerID,TotalAmount,Dates) values ((select ID from Tbl_PaymentTypes where PaymentType=@pt1),(select ID from Tbl_Customer where TableID=(select ID from Tbl_Table where MasaNo=@ti) and Status='True'),(select sum(TotalPrice) from Tbl_Checks where TableID=(select ID from Tbl_Table where MasaNo=@ti) and Status='True'),@dt)", connection);

            cmd1.Parameters.AddWithValue("@ti", MasaAd);
            cmd1.Parameters.AddWithValue("@pt1", CmbOdemeTuru.Text);
            cmd1.Parameters.AddWithValue("@dt", DateTime.Now);
            cmd1.ExecuteNonQuery();
            connection.Close();

            Listele();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update Tbl_Payments set Status='False' where CustomerID=(select ID from Tbl_Customer where TableID=(select ID from Tbl_Table where MasaNo=@m1 and Status='True') and Status='True')", connection);
            cmd.Parameters.AddWithValue("@m1",MasaAd);
            cmd.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("update Tbl_Customer set Status=0 where TableID=(select ID from Tbl_Table where MasaNo=@m1 and Status='True')",connection);
            cmd2.Parameters.AddWithValue("@m1", MasaAd);
            cmd2.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd1 = new SqlCommand("update Tbl_Checks set Status='False' where TableID=(select ID from Tbl_Table where MasaNo=@m1 and Status='True')",connection);
            cmd1.Parameters.AddWithValue("@m1", MasaAd);
            cmd1.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd3 = new SqlCommand("update Tbl_Table set Status=0 where MasaNo=@m1",connection);
            cmd3.Parameters.AddWithValue("@m1",MasaAd);
            cmd3.ExecuteNonQuery();
            connection.Close();



            Listele();
        }
    }
}
