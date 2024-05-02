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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeriTabaniFinalProjesi
{
    public partial class YonetmenCektigi_Odul : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=YesilcamSinemaBilgiSistemi;User ID=postgres;password=12345");
        public YonetmenCektigi_Odul()
        {
            InitializeComponent();
        }

        private void goruntulebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            int yonetmenId = Convert.ToInt32(yonetmenidtxt.Text);


            string sorgu4 = "SELECT yonetmenler.gercekadi, film.ad, yonetmenler.odulsayisi FROM yonetmenler JOIN film ON yonetmenler.yonetmenid = film.yonetmenid WHERE yonetmenler.yonetmenid=@p1";


            using (NpgsqlCommand command = new NpgsqlCommand(sorgu4, baglanti))
            {

                command.Parameters.AddWithValue("@p1", yonetmenId);


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

