using System;
using System.Windows.Forms;

namespace KonkursyMuzyczne
{
    public partial class Konkursy : Form
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        public Konkursy()
        {
            InitializeComponent();
        }

        private void Konkursy_Load(object sender, EventArgs e)
        {
            // Ten wiersz kodu wczytuje dane do tabeli 'bazaKonkursyDataSet.Konkurs'.
            this.konkursTableAdapter.Fill(this.bazaKonkursyDataSet.Konkurs);
        }

        private void pełnyEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ustawienie pełnego ekranu:

            //Sprawdzanie stanu przycisku - Czy jest wciśnięty (standardowo nie wciśnięty):
            if (pełnyEkranToolStripMenuItem.Checked)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void otwórzDokumentacjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otwieranie dokumentacji:
            System.Diagnostics.Process.Start(@"C:\Users\Magda1\Desktop\dokumentacja.odt");
        }

        private void otwórzPrzewodnikPoAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otwieranie dokumentacji:
            System.Diagnostics.Process.Start(@"C:\Users\Magda1\Desktop\dokumentacja.odt");
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deklarowanie treści komunikatu:
            string wiadomosc = "Program przygotowany w ramach przedmiotu ADO.NET\nAplikacja ma za zadanie łączenie się z bazą danych uczestników konkursów muzycznych oraz możliwość jej edycji.\n\nPrzygotowali: Maciej Jabłoński, Magda Witecka\n\nProwadzący: dr Karol Korczak\n\nInformatyka i Ekonometria Rok III 2018-2019 Semestr zimowy";
            string tytul = "O programie";

            //Komunikat z informacjami o programie:
            MessageBox.Show(wiadomosc, tytul, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deklarowanie treści komunikatu:
            string wiadomosc = "Czy jestes pewny ze chcesz zakonczyc program?";
            string tytul = "Zamniecie";

            //Komunikat do zamknięcia programu:
            var rezultat = MessageBox.Show(wiadomosc, tytul,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            //Zamknięcie programu:
            if (rezultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void powrotSG_Click(object sender, EventArgs e)
        {
            // Tworzenie nowej instancji
            StronaGłówna stronaGlowna = new StronaGłówna();

            // Dodawanie ustawień do stworzonej instancji
            stronaGlowna.Visible = true;
            Dispose();
        }
    }
}
