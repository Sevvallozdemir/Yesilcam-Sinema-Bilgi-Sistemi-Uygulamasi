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
    public partial class YonetmenOyuncularListesi : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public YonetmenOyuncularListesi()
        {
            InitializeComponent();
        }

        private void goruntulebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string yonetmenadi = yonetmenaditxt.Text;
            string komut3 = " SELECT\r\n    yonetmenler.gercekadi AS \"Yönetmen Adı\",\r\n    oyuncu.gercekadi AS \"Oyuncu Adı\",\r\n    COUNT(*) AS \"Film Sayısı\"\r\nFROM\r\n    Film\r\nINNER JOIN\r\n    yonetmenler ON film.yonetmenid = yonetmenler.yonetmenid\r\nINNER JOIN\r\n    oyuncufilm ON film.filmid = oyuncufilm.filmid\r\nINNER JOIN\r\n    oyuncu ON oyuncufilm.oyuncuid = oyuncu.oyuncuid\r\nWHERE\r\n    yonetmenler.gercekadi = @p1 -- Belirli bir yönetmen adı\r\nGROUP BY\r\n    yonetmenler.gercekadi, oyuncu.gercekadi\r\nORDER BY\r\n    \"Film Sayısı\" DESC;\r\n";
            using (NpgsqlCommand command = new NpgsqlCommand(komut3, baglanti))
            {

                command.Parameters.AddWithValue("@p1", yonetmenadi);


                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
