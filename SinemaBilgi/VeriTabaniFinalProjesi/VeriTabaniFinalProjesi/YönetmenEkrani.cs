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
    public partial class YönetmenEkrani : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public YönetmenEkrani()
        {
            InitializeComponent();
        }

        private void yonetmeneklebtn_Click(object sender, EventArgs e)
        {
            YönetmenEkle yönetmenEkle = new YönetmenEkle();
            yönetmenEkle.ShowDialog();
        }

        private void yonetmenguncellebtn_Click(object sender, EventArgs e)
        {
            YönetmenGüncelleme yönetmenGüncelleme = new YönetmenGüncelleme();
            yönetmenGüncelleme.ShowDialog();
        }

        private void yonetmensilmebtn_Click(object sender, EventArgs e)
        {
            YönetmenSilme yönetmenSilme = new YönetmenSilme();
            yönetmenSilme.ShowDialog();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from yonetmenler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
