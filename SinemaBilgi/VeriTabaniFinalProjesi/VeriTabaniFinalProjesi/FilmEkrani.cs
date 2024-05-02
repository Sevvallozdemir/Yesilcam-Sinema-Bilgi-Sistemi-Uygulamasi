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
    public partial class FilmEkrani : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmEkrani()
        {
            InitializeComponent();
        }

        private void filmeklemeislembtn_Click(object sender, EventArgs e)
        {
            FilmEkleme filmEkleme = new FilmEkleme();
            filmEkleme.ShowDialog();
        }

        private void filmsilmeislembtn_Click(object sender, EventArgs e)
        {
            FilmSilme filmSilme = new FilmSilme();
            filmSilme.ShowDialog();
        }

        private void filmguncellemeislembtn_Click(object sender, EventArgs e)
        {
            FilmGuncelleme filmGuncelleme = new FilmGuncelleme();
            filmGuncelleme.ShowDialog();
        }

        private void filmlistelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from film";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
