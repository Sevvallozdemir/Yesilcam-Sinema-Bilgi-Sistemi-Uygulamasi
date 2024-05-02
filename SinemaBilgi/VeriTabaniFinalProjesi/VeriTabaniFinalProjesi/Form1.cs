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
            Y�netmenEkrani y�netmenEkrani = new Y�netmenEkrani();
            y�netmenEkrani.ShowDialog();
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
            T�reG�reRating t�reG�reRating = new T�reG�reRating();
            t�reG�reRating.ShowDialog();
        }

        private void yonetmeninCalistigiOyuncularbtn_Click(object sender, EventArgs e)
        {
            YonetmenOyuncularListesi yonetmenOyuncularListesi = new YonetmenOyuncularListesi();
            yonetmenOyuncularListesi.ShowDialog();
        }

        private void filmturueklemebtn_Click(object sender, EventArgs e)
        {
            FilmT�r�Ekleme filmT�r�Ekleme = new FilmT�r�Ekleme();
            filmT�r�Ekleme.ShowDialog();
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