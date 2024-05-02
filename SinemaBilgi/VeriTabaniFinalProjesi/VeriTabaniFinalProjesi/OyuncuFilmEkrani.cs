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
    public partial class OyuncuFilmEkrani : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public OyuncuFilmEkrani()
        {
            InitializeComponent();
        }

        private void OyuncuFilmleriGetirbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            
            int oyuncuID = Convert.ToInt32(oyuncuid.Text);

            
            string sorgu3 = "SELECT \r\n    film.ad AS \"Film Adı\", \r\n    oyuncufilm.oyuncuid AS \"Oyuncu ID\", \r\n    oyuncu.gercekadi AS \"Oyuncu Adı\"\r\nFROM \r\n    film\r\nINNER JOIN \r\n    oyuncufilm ON film.filmid = oyuncufilm.filmid\r\nINNER JOIN \r\n    oyuncu ON oyuncufilm.oyuncuid = oyuncu.oyuncuid\r\nWHERE \r\n    oyuncufilm.oyuncuid = @p1;\r\n";
            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu3, baglanti))
            {

                da.SelectCommand.Parameters.AddWithValue("@p1", oyuncuID);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }

            baglanti.Close();
           

        }
    }
    }


