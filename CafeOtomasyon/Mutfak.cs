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
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");

        void Listele()
        {
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            TxtId.Text = "";
            TxtUrunAd.Text = "";
            TxtUrunFiyat.Text = "";
            CmbKategori.Text = "";
        }
        private void Mutfak_Load(object sender, EventArgs e)
        {

            Listele();

            connection.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Tbl_Categories", connection);
            SqlDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                CmbKategori.Items.Add(dr[1]);
            }

            connection.Close();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void CmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {   
          
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where ProductName like @m1+'%'", connection);
            cmd.Parameters.AddWithValue("@m1",TxtUrunAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunFiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();   
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("insert into Tbl_Products (ProductName,Price,CategoryID) values (@m1,@m2,(select ID from Tbl_Categories where CategoryName=@m3))",connection);
            cmd.Parameters.AddWithValue("@m1",TxtUrunAd.Text);
            cmd.Parameters.AddWithValue("@m2",Convert.ToDecimal(TxtUrunFiyat.Text));
            cmd.Parameters.AddWithValue("@m3",CmbKategori.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            Listele();
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("update Tbl_Products set ProductName=@m1, Price=@m2, CategoryID=(select ID from Tbl_Categories where CategoryName=@m3) where ID=@m4", connection);
            cmd.Parameters.AddWithValue("@m1", TxtUrunAd.Text);
            cmd.Parameters.AddWithValue("@m2", Convert.ToDecimal(TxtUrunFiyat.Text));
            cmd.Parameters.AddWithValue("@m3", CmbKategori.Text);
            cmd.Parameters.AddWithValue("@m4",TxtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            Listele();
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Tbl_Products where ID=@m4",connection);
            cmd.Parameters.AddWithValue("@m4", TxtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            Listele();
            Temizle();
        }
    }
}
