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
        private int cyklicznosc;
        private String lokalizacja;
        private String zasieg;
        private String organizator;
        private String zalozyciel;
        private Boolean rozpoczacInsert = true;
        public Boolean getRozpoczacInsert()
        {
            return this.rozpoczacInsert;
        }

        public Konkurs_Szkielet(String nazwa, String rodzaj, int cyklicznosc, String lokalizacja, String zasieg, String organizator, String zalozyciel)
        {
            this.nazwa = nazwa;
            this.rodzaj = rodzaj;
            this.cyklicznosc = cyklicznosc;
            this.lokalizacja = lokalizacja;
            this.zasieg = lokalizacja;
            this.organizator = organizator;
            this.zalozyciel = zalozyciel;
            this.mapa.Add("nazwa", nazwa);
            this.mapa.Add("rodzaj", rodzaj);
            this.mapa.Add("lokalizacja", lokalizacja);
            this.mapa.Add("zasięg", zasieg);
            this.mapa.Add("organizator", organizator);
            this.mapa.Add("zalożyciel", zalozyciel);
            if (cyklicznosc <= 0)
            {
                string wiadomosc = "Pole cykliczność ma niedopuszczaną wartość!";
                string tytul = "Błąd!";

                MessageBox.Show(wiadomosc, tytul, MessageBoxButtons.OK, MessageBoxIcon.Error);

                rozpoczacInsert = false;
            }
            else
            {
                sprawdz(mapa);
            }
    }
        public void sprawdz(Dictionary<string, string> mapa)
        {
            this.mapa = mapa;
            for (int i = 0; i < mapa.Count; i++)
            {
                if (mapa.ElementAt(i).Value.Equals(""))
                {
                    string wiadomosc = "Pole " + mapa.ElementAt(i).Key + " jest puste!";
                    string tytul = "Błąd!";

                    MessageBox.Show(wiadomosc, tytul, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    rozpoczacInsert = false;

                    break;
                }

            }

        }
    }
}
