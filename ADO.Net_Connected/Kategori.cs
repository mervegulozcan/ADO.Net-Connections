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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        
        
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Categories";
            komut.Connection = conn;
            conn.Open();
            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                string kategoriAdi = rdr["CategoryName"].ToString();
                string aciklama = rdr["Description"].ToString();
                listBox1.Items.Add(kategoriAdi + "--" + aciklama);
            }
            conn.Close();
        }

        private void btnurunGoster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
