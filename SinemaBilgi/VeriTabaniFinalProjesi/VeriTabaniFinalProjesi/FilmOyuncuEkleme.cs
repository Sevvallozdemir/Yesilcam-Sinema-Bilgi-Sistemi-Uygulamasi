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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeriTabaniFinalProjesi
{
    public partial class FilmOyuncuEkleme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmOyuncuEkleme()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into oyuncufilm(oyuncuid, filmid) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(oyuncuidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt32(filmidtxt.Text));
          


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Filme oyuncu ekleme işlemi başarılı bir şekilde gerçekleşmiştir");
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from oyuncufilm";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
