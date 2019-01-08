using System;
using System.Windows.Forms;

namespace KonkursyMuzyczne
{
    public partial class StronaGłówna : Form
    {
        public StronaGłówna()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Deklarowanie treści komunikatu:
            string wiadomosc = "Program przygotowany w ramach przedmiotu ADO.NET\nAplikacja ma za zadanie łączenie się z bazą danych uczestników konkursów muzycznych oraz możliwość jej edycji.\n\nPrzygotowali: Maciej Jabłoński, Magda Witecka\n\nProwadzący: dr Karol Korczak\n\nInformatyka i Ekonometria Rok III 2018-2019 Semestr zimowy";
            string tytul = "O programie";

            //Komunikat z informacjami o programie:
            MessageBox.Show(wiadomosc, tytul, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void otwórzDokumentacjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otwieranie dokumentacji:
            System.Diagnostics.Process.Start(@"C:\Users\Magda1\Desktop\dokumentacja.odt");
        }

        private void otwórzPrzewodnikPoAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otwieranie przewodnika użytkownika:
            System.Diagnostics.Process.Start(@"C:\Users\Magda1\Desktop\dokumentacja.odt");
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

        private void uczestnicy_Click(object sender, EventArgs e)
        {

        }

        private void konkursy_Click(object sender, EventArgs e)
        {
            // Tworzenie nowej instancji
            Konkursy konkursy = new Konkursy();

            // Dodawanie ustawień do stworzonej instancji
            konkursy.Show();
            this.Visible = false;
        }
    }
}
