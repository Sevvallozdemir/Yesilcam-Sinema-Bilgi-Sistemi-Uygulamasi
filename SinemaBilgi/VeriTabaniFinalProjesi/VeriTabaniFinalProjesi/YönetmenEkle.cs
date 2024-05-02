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
    public partial class YönetmenEkle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public YönetmenEkle()
        {
            InitializeComponent();
        }

        private void yonetmeneklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into yonetmenler(yonetmenid,sahneadi,gercekadi,dogumtarihi,cinsiyet,odulsayisi) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(yonetmenidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", sahneaditxt.Text);
            komut1.Parameters.AddWithValue("@p3", gercekaditxt.Text);
            komut1.Parameters.AddWithValue("@p4", Convert.ToDateTime(dogumtarihitxt.Text));
            komut1.Parameters.AddWithValue("@p5", cinsiyettxt.Text);
            komut1.Parameters.AddWithValue("@p6", Convert.ToInt32(odulsayisitxt.Text));


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetmen ekleme işlemi başarılı bir şekilde gerçekleşmiştir");
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
