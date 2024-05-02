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
    public partial class TüreGöreRating : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public TüreGöreRating()
        {
            InitializeComponent();
        }

        private void goruntulebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            string filmturu = filmturutxt.Text;


            string sorgu4 = "SELECT \r\n    film.ad AS \"Film Adı\",\r\n    film.yonetmenid AS \"Yönetmen\",\r\n    string_agg(oyuncu.gercekadi, ', ') AS \"Oyuncular\",\r\n    MAX(film.rating) AS \"Rating\"\r\nFROM \r\n    film\r\nINNER JOIN oyuncufilm ON film.filmid = oyuncufilm.filmid\r\nINNER JOIN oyuncu ON oyuncufilm.oyuncuid = oyuncu.oyuncuid\r\nWHERE \r\n    film.tur = @p1\r\nGROUP BY\r\n    film.ad, film.yonetmenid\r\nORDER BY \r\n    MAX(film.rating) DESC\r\nLIMIT 10;";


            using (NpgsqlCommand command = new NpgsqlCommand(sorgu4, baglanti))
            {

                command.Parameters.AddWithValue("@p1", filmturu);


                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

            baglanti.Close();

            
        }
    }
}
