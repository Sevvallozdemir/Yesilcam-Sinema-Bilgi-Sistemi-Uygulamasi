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
    public partial class FilmTürüEkleme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmTürüEkleme()
        {
            InitializeComponent();
        }

        private void tureklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into filmturleri(turadi) values(@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tür ekleme işlemi başarılı bir şekilde gerçekleşmiştir");
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from filmturleri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
