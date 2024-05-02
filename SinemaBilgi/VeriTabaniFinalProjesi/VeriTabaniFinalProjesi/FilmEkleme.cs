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
    public partial class FilmEkleme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmEkleme()
        {
            InitializeComponent();
            FilmTurleriniComboBoxDoldur();
        }
        private void FilmTurleriniComboBoxDoldur()
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT DISTINCT turadi FROM filmturleri"; // Distinct kullanarak benzersiz film türlerini al
                using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string filmTur = reader["turadi"].ToString();
                        comboBox1.Items.Add(filmTur);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void filmeklebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into film(filmid,ad,rating,butce,yapimyili,gisesayisi,yonetmenid,tur) values(@p1,@p2,@p3,@p4,@p5,@p6,@p8,@p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(filmidtxt.Text));
            komut1.Parameters.AddWithValue("@p2", filmaditxt.Text);
            komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(ratingtxt.Text));
            komut1.Parameters.AddWithValue("@p4", Convert.ToInt32(butcetxt.Text));
            komut1.Parameters.AddWithValue("@p5", Convert.ToInt32(yapimyilitxt.Text));
            komut1.Parameters.AddWithValue("@p6", Convert.ToInt32(gisesayisitxt.Text));
           
            komut1.Parameters.AddWithValue("@p8", Convert.ToInt32(yonetmenid.Text));

            komut1.Parameters.AddWithValue("@p9", comboBox1.Text);


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film ekleme işlemi başarılı bir şekilde gerçekleşmiştir");



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
