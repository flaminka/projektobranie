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
        public Praca()
        {
            InitializeComponent();
             
        }
        // jeśli w pytaniu 4 mam zaznaczone NIE, to 5 pytanie się chowa
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
               
            if (radioButton15.Checked)
            {
                groupBox5.Hide();
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

        //próba dowiedzenia się ile jest groupboxów w oknie
        public int IleGroupBoxwOknie(Form okno)
        {
            return okno.Controls.OfType<GroupBox>().Count();
        }


        //próba wzięcia danych z zaznaczonych radiobuttonów kod z www.techbrij.com/get-selected-radio-button-text-windows-app-net
        private string BierzemyTekstzZaznaczonegoRadioButtona(GroupBox grb)
        {   //bierzemy into consideration elementy typu RadioButton z danego groupBoxa, a dokładniej, te
            //które spełniaja warunek bycia zaznaczonymi i tych RadioButtonów bierzemy właściwość Text
            if (grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true) != null)
                return grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            else return "-"; //zabezpieczenie jak nic nie zaznaczono, POPRAW na messageboxa może?     
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

       
        private void praca_wyslij_Click(object sender, EventArgs e)
        {
            //tworzymy zmienną, której przypisujemy wartość rekordu
            string[] rekord = TworzenieRekordu(IleGroupBoxwOknie(ActiveForm));
            //tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie Arg_Tabeli (czyli tworzymy argumenty dla wydarzenia)
            Moje_Arg_Wydarzen Arg_Tabeli = new Moje_Arg_Wydarzen();
            //przypisujemy tym argumentom wartość
            Arg_Tabeli.wiersz = rekord;
            //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)
            WyzwalaczUzupelnianie_obserwacji(Arg_Tabeli);

            //dodać opcję dodawania gdzieś jakoś tych danych DODAC
            //dodaję MessageBoxa, by sprawdzić czy wszystkie pola są wypełnione ZROBIC
            //MessageBox.Show("Nie zaznaczono odpowiedzi", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //dodaję MessageBoxa, by poinformować o wypełnieniu ankiety i możliwości kolejnego jej wypełnienia
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



       private void praca2_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
            //jeśli są jakieś właściwości argumentów to przypisujemy Name (które niesie wartość z praca1) obiektowi  z okna Form1, tj. label1
            if (e != null && e.wiersz != null)
                Program.mainform.tabela_glowna.Rows.Add(e.wiersz);
        }


        //PRZEKAZYWANIE DANYCH Z Praca DO  Form1 - pierwsze próby

        //tworzymy wydarzenie o argumentach klasy Moje_Arg_Wydarzen, które nazywamy Uzupelnianie_obserwacji
        public event EventHandler<Moje_Arg_Wydarzen> Uzupelnianie_obserwacji;

        //wyzwalacz wydarzenia Uzupelnianie_obserwacji będący metodą (o nazwie WyzwalaczUzupelnianie_obserwacji), której argument to e z klasy Moje_Arg_Wydarzen
        protected virtual void WyzwalaczUzupelnianie_obserwacji(Moje_Arg_Wydarzen e)
        {
            //jeśli wywołamy zdarzenie Uzupelnianie_obserwacji, to będzie ono działać na obiekcie wskazanym przez wskaźnik this (tu: Praca)
            // a jego argumentami (wydarzenia Uzupelnianie_obserwacji) będą e
            if (Uzupelnianie_obserwacji != null)
                Uzupelnianie_obserwacji(this, e);
        }
    }
}
