﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BaglantiOlusturma
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            try
            { 
            
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
            }
            catch
            {
                MessageBox.Show("Server'a bağlanamadı..");
            }

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Bağlantı açıldı..");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık..");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı kapatıldı..");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten kapalı..");
            }
        }

        private void btn_Open_Close_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Bağlantı kapatıldı..");
            }
            else
            {
                conn.Open();
                MessageBox.Show("Bağlantı açıldı..");
            }
        }
    }
}
