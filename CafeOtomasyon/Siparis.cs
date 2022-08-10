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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4U51IH1\SQLEXPRESS;Initial Catalog=CafeDb;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 1)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();




        }

        public string MasaNo;
        public string BtnMasa;

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 2)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();


        }

        void siparisler()
        {
            connection.Open();

            SqlCommand cmd2 = new SqlCommand("select Tbl_Sales.ID,ProductName as 'Ürün Adı',Amount as 'Miktar', Tbl_Sales.Price as 'Fiyat',TableID as 'Masa' from Tbl_Sales inner join Tbl_Products on Tbl_Sales.ProductId=Tbl_Products.ID where TableID=(select ID from Tbl_Table where MasaNo=@m1) and Tbl_Sales.Status='True'", connection);
            cmd2.Parameters.AddWithValue("@m1", MasaNo);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd2);
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            dataGridView2.DataSource = dataTable1;
            connection.Close();
        }

        void Adisyon()
        {
            connection.Open();
            SqlCommand adisyon = new SqlCommand("select ID,TableId as 'Masa',TotalPrice as 'Toplam Fiyat',Dates as 'Tarih' from Tbl_Checks where TableID=(select ID from Tbl_Table where MasaNo=@m1) and Status='True'", connection);
            adisyon.Parameters.AddWithValue("@m1", MasaNo);
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(adisyon);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter1.Fill(dataTable2);
            dataGridView3.DataSource = dataTable2;
            connection.Close();
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            
            connection.Open();

            LblMasaNo.Text = MasaNo;
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            
            connection.Close();

            siparisler();

            Adisyon();

           
            

          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 3)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 4)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 5)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Tbl_Products.ID,ProductName as 'Ürün Adı',Price as 'Fiyatı',CategoryName as 'Kategori', Tbl_Products.Status as 'Durumu' from Tbl_Products inner join Tbl_Categories on Tbl_Products.CategoryID = Tbl_Categories.ID where CategoryID=(select ID from Tbl_Categories where ID = 6)", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string productid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string categoryid = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

           

            connection.Open();

            SqlCommand cmd = new SqlCommand("insert into Tbl_Sales (ProductID,TableID,Amount,Price) values (@u1,(select ID from Tbl_Table where MasaNo=@u2),@u3,(select Price*@u5 from Tbl_Products where ID=@pr))", connection);
            cmd.Parameters.AddWithValue("@u1", productid);
            cmd.Parameters.AddWithValue("@u5",Convert.ToInt32(TxtAdet.Text));
            cmd.Parameters.AddWithValue("@pr",productid);
            cmd.Parameters.AddWithValue("@u2",MasaNo);
            cmd.Parameters.AddWithValue("@u3",TxtAdet.Text);
            cmd.ExecuteNonQuery();

            connection.Close();

           

            siparisler();

            




        }

        private void BtnSiparisVer_Click(object sender, EventArgs e)
        {

            connection.Open();

            SqlCommand addChecks = new SqlCommand("insert into Tbl_Checks (CustomerID,StaffID,TableID,Dates,Status,TotalPrice) values ((select ID from Tbl_Customer where TableID=(select ID from Tbl_Table where MasaNo=@c1) and Status='True'),(select ID from Tbl_Staff where ID=1),(select ID from Tbl_Table where MasaNo=@mN),@t1,'True',(select sum(Price) from Tbl_Sales where TableID=(select ID from Tbl_Table where MasaNo=@a1) and Status='True'))", connection);
            addChecks.Parameters.AddWithValue("@mN", MasaNo);
            addChecks.Parameters.AddWithValue("@c1", MasaNo);
            addChecks.Parameters.AddWithValue("@a1", MasaNo);
            addChecks.Parameters.AddWithValue("@t1", DateTime.Now);
            addChecks.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand changeStatus = new SqlCommand("update Tbl_Sales set Status=0 where TableId=(select ID from Tbl_Table where MasaNo=@m1)", connection);
            changeStatus.Parameters.AddWithValue("@m1", MasaNo);
            changeStatus.ExecuteNonQuery();
            connection.Close();





            Adisyon();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            HesapOdeme hesap = new HesapOdeme();
            hesap.Show();
            this.Hide();

            hesap.MasaAd = MasaNo;

        }

        private void BtnRezerve_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand addmusteri = new SqlCommand("insert into Tbl_Customer (TableID,Status) values ((select ID from Tbl_Table where MasaNo=@m1),'True')", connection);
            addmusteri.Parameters.AddWithValue("@m1", MasaNo);
            addmusteri.ExecuteNonQuery();
            connection.Close();

            connection.Open();

            SqlCommand cmd = new SqlCommand("update Tbl_Table set Status=1 where MasaNo=@m1", connection);
            cmd.Parameters.AddWithValue("@m1", MasaNo);
            cmd.ExecuteNonQuery();

            connection.Close();

            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            string Salesid = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Tbl_Sales where ID=@m1",connection);
            cmd.Parameters.AddWithValue("@m1",Salesid);
            cmd.ExecuteNonQuery();
            connection.Close();

            siparisler();
            
        }
    }
}
