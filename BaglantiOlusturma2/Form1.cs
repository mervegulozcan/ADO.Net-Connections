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
using System.Configuration;

namespace BaglantiOlusturma2
{
    public partial class Form1 : Form
    {
        string baglanti = "kapali";

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        private void btnLocal_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            if (baglanti == "kapali")
            {
                conn2.ConnectionString = @"Data Source=WISSEN\MSSQLSRV; Initial Catalog = Northwind; User ID = sa; Password = 12345srv ";

                conn2.Open();
                MessageBox.Show("Bağlantı Local Değişken ile Açıldı");
                baglanti = "acik";
            }
            else if (baglanti == "acik")
            {
                conn2.Close();
                MessageBox.Show("Bağlantı Local Değişken ile kapatıldı");
                baglanti = "kapali";
            }
        }



        private void btnGlobal_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = @"Data Source=WISSEN\MSSQLSRV; Initial Catalog = Northwind; User ID = sa; Password = 12345srv ";

                    conn.Open();
                    MessageBox.Show("Bağlantı Global Değişken ile Açıldı");
                }
                else if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("Bağlantı Global ile kapatıldı");
                }
            }
            catch
            {
                MessageBox.Show("Global Değişken ile bağlanırken hata oluştu");
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
                conn.Open();
                MessageBox.Show("Bağlantı App Config  ile açıldı");
            }
            else if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı App Config ile kapatıldı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClass_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = Tools.ConnectionString;
                conn.Open();
                MessageBox.Show("Bağlantı Class Değişken ile Açıldı");
            }
            else if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı  Class Değişken ile kapatıldı");
            }
        }
    }
}
