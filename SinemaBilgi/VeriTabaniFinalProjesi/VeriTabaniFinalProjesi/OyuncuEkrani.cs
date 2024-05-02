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
    public partial class OyuncuEkrani : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public OyuncuEkrani()
        {
            InitializeComponent();
        }

        private void oyuncueklebtn_Click(object sender, EventArgs e)
        {
            OyuncuEkleme oyuncuEkleme = new OyuncuEkleme();
            oyuncuEkleme.ShowDialog();
        }

        private void oyuncuguncellebtn_Click(object sender, EventArgs e)
        {
            OyuncuGuncelleme oyuncuGuncelleme = new OyuncuGuncelleme();
            oyuncuGuncelleme.ShowDialog();
        }

        private void oyuncusilmebtn_Click(object sender, EventArgs e)
        {
            OyuncuSilme oyuncuSilme = new OyuncuSilme();
            oyuncuSilme.ShowDialog();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from oyuncu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
