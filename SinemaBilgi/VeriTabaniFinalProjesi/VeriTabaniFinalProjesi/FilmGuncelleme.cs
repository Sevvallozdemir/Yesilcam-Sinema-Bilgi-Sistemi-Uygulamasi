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
    public partial class FilmGuncelleme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public FilmGuncelleme()
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

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("UPDATE film SET ad = @p2, rating = @p3, butce = @p4, yapimyili = @p5, gisesayisi = @p6,yonetmenid=@p8,tur=@p9 WHERE filmid = @p1", baglanti);

            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(filmidtxt.Text));
            komut2.Parameters.AddWithValue("@p2", filmaditxt.Text);
            komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(ratingtxt.Text));
            komut2.Parameters.AddWithValue("@p4", Convert.ToInt32(butcetxt.Text));
            komut2.Parameters.AddWithValue("@p5", Convert.ToInt32(yapimyilitxt.Text));
            komut2.Parameters.AddWithValue("@p6", Convert.ToInt32(gisesayisitxt.Text));
            
            komut2.Parameters.AddWithValue("@p8", Convert.ToInt32(yonetmenidtxt.Text));

            komut2.Parameters.AddWithValue("@p9", comboBox1.Text);


            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.");
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
