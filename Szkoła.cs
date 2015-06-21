using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CSS
{
    public partial class Szkoła : Form
    {

        //INICJALIZATOR
        public Szkoła()
        {
            InitializeComponent();
        }

        
        //funkcja licząca ile jest groupboxów w oknie
        public int IleGroupBoxwOknie(Form okno)
        {
            return okno.Controls.OfType<GroupBox>().Count();
        }


        //funkcja biorąca tekst z zaznaczonych radiobuttonów, poprawiony kod z www.techbrij.com/get-selected-radio-button-text-windows-app-net
        private string BierzemyTekstzZaznaczonegoRadioButtona(GroupBox grb)
        {   
            //rozważamy elementy typu RadioButton z danego groupBoxa, które spełniaja warunek bycia zaznaczonymi i  bierzemy właściwość Text tych RadioButtonów
            if (grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true) != null)
                return grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            else return "-"; //zabezpieczenie jak nic nie zaznaczono, traktowane jako missing value   
        }


        //funkcja odpowiadająca za pobieranie wszystkich odpowiedzi z groupboxów i łączenie ich w jeden wiersz (reprezentowany jako ciąg string-ów); jej argumentem jest liczba pytań
        private string[] TworzenieRekordu(int LiczbaPytan)
        {
            string[] rekord = new string[LiczbaPytan+1]; // +1 bo zaczyna się od 0
            int i = 0;
            foreach (var grupuś in Controls.OfType<GroupBox>())
            {
               rekord[i] = BierzemyTekstzZaznaczonegoRadioButtona(grupuś);
               i++;
            }
            rekord[LiczbaPytan] = "Szkoła"; //żeby wiadomo było, z której ankiety dane pochodzą
            Array.Reverse(rekord); //odwracam kolejność w tablicy na poprawną
            return rekord;
        }


        //przycisk Wyślij
         private void szkola_wyslij_Click(object sender, EventArgs e)
        {
            
            string[] rekord = TworzenieRekordu(IleGroupBoxwOknie(ActiveForm));//tworzymy zmienną, której przypisujemy wartość rekordu         
            Moje_Arg_Wydarzen Arg_Tabeli = new Moje_Arg_Wydarzen();//tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie Arg_Tabeli (czyli tworzymy argumenty dla wydarzenia)
            Arg_Tabeli.wiersz = rekord;   //przypisujemy tym argumentom wartość
            WyzwalaczUzupelnianie_obserwacji(Arg_Tabeli);    //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)

            //dodajemy MessageBoxa, by poinformować o wypełnieniu ankiety i możliwości kolejnego jej wypełnienia
            if (MessageBox.Show("Ankieta: Szkoła została wypełniona i wysłana do bazy danych. \n Czy chcesz wypełnić ją ponownie?", "Kolejne wypełnienie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActiveForm.Close(); //zamykam obecne okno i otwieram nowe (mniej klikania niż przez menu)
                Szkoła szkoła2 = new Szkoła();
                szkoła2.Show();
                //to samo co w oknie głównym, tylko robione z poziomu wywołania tego okna za pomocą przycisku wyślij
                szkoła2.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(szkoła2_Uzupelnianie_obserwacji);
            }

            else
            {
                ActiveForm.Close(); //zamykam to okno po prostu
            }
        }


       private void szkoła2_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
            //jeśli są jakieś właściwości argumentów to przypisujemy Name (które niesie wartość z praca1) obiektowi  z okna Form1, tj. label1
            if (e != null && e.wiersz != null)
                Program.mainform.tabela_glowna.Rows.Add(e.wiersz);
        }


        //PRZEKAZYWANIE DANYCH Z Praca DO  Form1

        //tworzymy wydarzenie o argumentach klasy Moje_Arg_Wydarzen, które nazywamy Uzupelnianie_obserwacji
        public event EventHandler<Moje_Arg_Wydarzen> Uzupelnianie_obserwacji;

        //wyzwalacz wydarzenia Uzupelnianie_obserwacji będący metodą (o nazwie WyzwalaczUzupelnianie_obserwacji), której argument to e z klasy Moje_Arg_Wydarzen
        protected virtual void WyzwalaczUzupelnianie_obserwacji(Moje_Arg_Wydarzen e)
        {
            //jeśli wywołamy zdarzenie Uzupelnianie_obserwacji, to będzie ono działać na obiekcie wskazanym przez wskaźnik this (tu: Praca) a jego argumentami (wydarzenia Uzupelnianie_obserwacji) będą e
            if (Uzupelnianie_obserwacji != null)
                Uzupelnianie_obserwacji(this, e);
        }

    }
}
