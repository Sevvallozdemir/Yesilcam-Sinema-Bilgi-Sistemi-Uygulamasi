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
    public partial class YönetmenSilme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public YönetmenSilme()
        {
            InitializeComponent();
        }

        private void yonetmensilbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from yonetmenler where yonetmenid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(yonetmenidtxt.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.");
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
