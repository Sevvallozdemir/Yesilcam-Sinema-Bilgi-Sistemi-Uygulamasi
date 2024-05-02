namespace VeriTabaniFinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmekranibtn_Click(object sender, EventArgs e)
        {
            FilmEkrani filmEkrani = new FilmEkrani();
            filmEkrani.ShowDialog();
        }

        private void oyuncuekranibtn_Click(object sender, EventArgs e)
        {
            OyuncuEkrani oyuncuEkrani = new OyuncuEkrani();
            oyuncuEkrani.ShowDialog();
        }

        private void yonetmenekranibtn_Click(object sender, EventArgs e)
        {
            YönetmenEkrani yönetmenEkrani = new YönetmenEkrani();
            yönetmenEkrani.ShowDialog();
        }

        private void oyuncufilmekran_Click(object sender, EventArgs e)
        {
            OyuncuFilmEkrani oyuncuFilmEkrani = new OyuncuFilmEkrani();
            oyuncuFilmEkrani.ShowDialog();
        }

        private void yonetmencektigifilmbtn_Click(object sender, EventArgs e)
        {
            YonetmenCektigi_Odul yonetmenCektigi_Odul = new YonetmenCektigi_Odul();
            yonetmenCektigi_Odul.ShowDialog();
        }

        private void ratingsirasiEkran_Click(object sender, EventArgs e)
        {
            TüreGöreRating türeGöreRating = new TüreGöreRating();
            türeGöreRating.ShowDialog();
        }

        private void yonetmeninCalistigiOyuncularbtn_Click(object sender, EventArgs e)
        {
            YonetmenOyuncularListesi yonetmenOyuncularListesi = new YonetmenOyuncularListesi();
            yonetmenOyuncularListesi.ShowDialog();
        }

        private void filmturueklemebtn_Click(object sender, EventArgs e)
        {
            FilmTürüEkleme filmTürüEkleme = new FilmTürüEkleme();
            filmTürüEkleme.ShowDialog();
        }

        private void filmoyuncuekleme_Click(object sender, EventArgs e)
        {
            FilmOyuncuEkleme filmOyuncuEkleme = new FilmOyuncuEkleme();
            filmOyuncuEkleme.ShowDialog();
        }

        private void birlikteoynayanoyuncubtn_Click(object sender, EventArgs e)
        {
            BirlikteOynayanOyuncu birlikteOynayanOyuncu = new BirlikteOynayanOyuncu();
            birlikteOynayanOyuncu.ShowDialog();
        }
    }
}