﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VeriTabaniFinalProjesi
{
    public partial class FilmSilme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmSilme()
        {
            InitializeComponent();
        }

        private void filmsilbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from film where filmid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(filmidtxt.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.");
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from film";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
