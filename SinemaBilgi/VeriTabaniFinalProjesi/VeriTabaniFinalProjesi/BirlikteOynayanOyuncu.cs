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
    public partial class BirlikteOynayanOyuncu : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public BirlikteOynayanOyuncu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = @"
            SELECT 
                FO1.oyuncuid AS OyuncuID1,
                O1.gercekadi AS OyuncuAdi1,
                FO2.oyuncuid AS OyuncuID2,
                O2.gercekadi AS OyuncuAdi2,
                COUNT(DISTINCT FO1.filmid) AS BirlikteOynadiklariFilmSayisi
            FROM oyuncufilm FO1
            JOIN oyuncufilm FO2 ON FO1.filmid = FO2.filmid AND FO1.oyuncuid < FO2.oyuncuid
            JOIN oyuncu O1 ON FO1.oyuncuid = O1.oyuncuid
            JOIN oyuncu O2 ON FO2.oyuncuid = O2.oyuncuid
            GROUP BY FO1.oyuncuid, O1.gercekadi, FO2.oyuncuid, O2.gercekadi
            ORDER BY BirlikteOynadiklariFilmSayisi DESC;
        ";

                
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, baglanti))
                {
                    DataTable dt = new DataTable();

                   
                    adapter.Fill(dt);

                   
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
