using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonkursyMuzyczne
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new StronaGłówna());
            }
            catch (SystemException e)
            {
                //Deklarowanie treści komunikatu:
                string tytul = "Błąd";

                //Komunikat do zamknięcia programu:
                var rezultat = MessageBox.Show(Convert.ToString(e.StackTrace), tytul,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
    }
}
