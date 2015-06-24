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

    public partial class Praca : Form
    {

        //INICJALIZATOR
        public Praca()
        {
            InitializeComponent();
             
        }


        // DO TREŚCI ANKIETY


        // jeśli w pytaniu 4 mam zaznaczone NIE, to 5 pytanie się chowa
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
               
            if (radioButton15.Checked)
            {
                groupBox5.Hide();
                // zabezpieczenie: jak w pytaniu 4 jest Nie, to ma czyścić wszystkie wcześniej zaznaczone radiobuttony w pytaniu 5
                    radioButton19.Checked = false;
                    radioButton18.Checked = false;
                    radioButton17.Checked = false;
                    radioButton16.Checked = false;
            }

        }

        //jak ponownie zaznaczę w 4 pytaniu TAK, to 5 pytanie się pojawia
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            { 
                groupBox5.Show();
            }
        }


        //PRZYCISKI


        //przycisk Wyślij
        private void praca_wyslij_Click(object sender, EventArgs e)
        {

            Moje_Arg_Wydarzen Arg_Tabeli = new Moje_Arg_Wydarzen();//tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie Arg_Tabeli (czyli tworzymy argumenty dla wydarzenia)
            
            //przypisujemy argumentom wydarzeń wartość
            string[] rekord = TworzenieRekordu(IleGroupBoxwOknie(ActiveForm));//dodajemy wiersz do tabeli
            Arg_Tabeli.wiersz = rekord;
            string[] etykietki = DodawanieEtykiet(IleGroupBoxwOknie(ActiveForm)); //dodajemy etykiety kolumnom
            Arg_Tabeli.etykiety = etykietki;  

            WyzwalaczUzupelnianie_obserwacji(Arg_Tabeli);    //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)


            //dodajemy MessageBoxa, by poinformować o wypełnieniu ankiety i możliwości kolejnego jej wypełnienia
            if (MessageBox.Show("Ankieta: Praca została wypełniona i wysłana do bazy danych. \n Czy chcesz wypełnić ją ponownie?", "Kolejne wypełnienie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActiveForm.Close(); //zamykam obecne okno i otwieram nowe (mniej klikania niż przez menu)
                Praca praca2 = new Praca();
                praca2.Show();
                //to samo co w oknie głównym, tylko robione z poziomu wywołania tego okna za pomocą przycisku wyślij
                praca2.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(praca2_Uzupelnianie_obserwacji);
            }

            else
            {
                ActiveForm.Close(); //zamykam to okno po prostu
            }
        }



        //FUNKCJE


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
            string[] rekord = new string[LiczbaPytan+1]; 
            int i = 0;
            foreach (var grupuś in Controls.OfType<GroupBox>())
            {
               rekord[i] = BierzemyTekstzZaznaczonegoRadioButtona(grupuś);
               i++;
            }
            rekord[LiczbaPytan] = "Praca"; //żeby wiadomo było, z której ankiety dane pochodzą
            Array.Reverse(rekord); //odwracam kolejność w tablicy na poprawną
            return rekord;
        }

        //funkcja odpowiadająca za pobieranie treści pytań z groupboxów (tj. ich właściwości Text) i zapisywanie ich w jednym wektorze ciągów znakowych
        private string[] DodawanieEtykiet(int LiczbaPytan)
        {
            string[] etykietki = new string[LiczbaPytan]; 
            for (int i = 0; i < LiczbaPytan; i++) 
            {
                foreach (GroupBox grb in Controls.OfType<GroupBox>())
                {
                    if (grb.Name == ("groupBox" + (i + 1).ToString())) //musimy zadbać o to, by przy tworzeniu ankiet nie zmieniać nazw ani kolejności groupboxów
                        etykietki[i] = grb.Text;
                }
            }
            return etykietki;
        }


        //PRZEKAZYWANIE DANYCH Z Praca DO  Form1 ZA POMOCĄ EVENTHANDLER


        //tworzymy wydarzenie o argumentach klasy Moje_Arg_Wydarzen, które nazywamy Uzupelnianie_obserwacji
        public event EventHandler<Moje_Arg_Wydarzen> Uzupelnianie_obserwacji;

        //wyzwalacz wydarzenia Uzupelnianie_obserwacji będący metodą (o nazwie WyzwalaczUzupelnianie_obserwacji), której argument to e z klasy Moje_Arg_Wydarzen
        protected virtual void WyzwalaczUzupelnianie_obserwacji(Moje_Arg_Wydarzen e)
        {
            //jeśli wywołamy zdarzenie Uzupelnianie_obserwacji, to będzie ono działać na obiekcie wskazanym przez wskaźnik this (tu: Praca) a jego argumentami (wydarzenia Uzupelnianie_obserwacji) będą e
            if (Uzupelnianie_obserwacji != null)
                Uzupelnianie_obserwacji(this, e);
        }


        private void praca2_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
            //jeśli są jakieś właściwości argumentów to dodajemy wiersz (który niesie wartości z praca1) obiektowi z okna Form1, tj. tabela_glowna
            if (e != null && e.wiersz != null && e.etykiety != null)
            {
                //dodajemy etykiety kolumnom
                int i = 0;
                foreach (DataGridViewColumn kol in Program.mainform.tabela_glowna.Columns)
                    {
                        if (kol.Name != "ankieta")
                        {
                            kol.ToolTipText = e.etykiety[i];
                            i++;
                        }
                    }
                //dodajemy obserwacje
                Program.mainform.tabela_glowna.Rows.Add(e.wiersz);

            }

        }
    }
}
