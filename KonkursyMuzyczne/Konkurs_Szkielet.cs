using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonkursyMuzyczne
{
    class Konkurs_Szkielet
    {
        Dictionary<string, string> mapa = new Dictionary<string, string>();
        private String nazwa;
        private String rodzaj;
        private String lokalizacja;
        private String zasieg;
        private String organizator;
        public Konkurs_Szkielet(String nazwa, String rodzaj, String lokalizacja, String zasieg, String organizator)
        {
            this.nazwa = nazwa;
            this.rodzaj = rodzaj;
            this.lokalizacja = lokalizacja;
            this.zasieg = lokalizacja;
            this.organizator = organizator;
            this.mapa.Add("nazwa", nazwa);
            this.mapa.Add("rodzaj", rodzaj);
            this.mapa.Add("lokalizacja", lokalizacja);
            this.mapa.Add("zasieg", zasieg);
            this.mapa.Add("organizator", organizator);
            sprawdz(mapa);
        }
        public void sprawdz(Dictionary<string, string> mapa)
        {
            this.mapa = mapa;
            for (int i = 0; i < mapa.Count; i++)
            {
                if (mapa.ElementAt(i).Value.Equals(null))
                {
                    string wiadomosc = "Pole" + mapa.ElementAt(i).Key + "jest puste!";
                    string tytul = "Błąd!";

                    MessageBox.Show(wiadomosc, tytul, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                }

            }

        }
    }
}
