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
    public partial class OyuncuGuncelleme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public OyuncuGuncelleme()
        {
            InitializeComponent();
        }

        private void oyuncuguncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("UPDATE oyuncu SET sahneadi = @p2, gercekadi = @p3, dogumtarihi = @p4, cinsiyet = @p5, odulsayisi = @p6 WHERE oyuncuid = @p1", baglanti);

            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(oyuncuidtxt.Text));
            komut2.Parameters.AddWithValue("@p2", sahneaditxt.Text);
            komut2.Parameters.AddWithValue("@p3", gercekaditxt.Text);
            komut2.Parameters.AddWithValue("@p4", Convert.ToDateTime(dogumtarihitxt.Text));
            komut2.Parameters.AddWithValue("@p5", cinsiyettxt.Text);
            komut2.Parameters.AddWithValue("@p6", Convert.ToInt32(odulsayisitxt.Text));

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.");
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
