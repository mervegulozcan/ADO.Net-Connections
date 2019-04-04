using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.Net_Connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KategoriForm ktg = new KategoriForm();
        SqlConnection conn = new SqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Products";
            komut.Connection = conn;
            conn.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            
            while(rdr.Read())
            {
                string urunAdi = rdr["ProductName"].ToString();
                int fiyat =Convert.ToInt32(rdr["UnitPrice"]);
                int stok = Convert.ToInt32(rdr["UnitsInStock"]);
                listBox1.Items.Add(urunAdi + "-" + fiyat + "-" + stok);
                


            }
            conn.Close();
        }

        private void btn_ktgAc_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ktg.Show();
        }
    }
}
