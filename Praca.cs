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

        private void praca_wyslij_Click(object sender, EventArgs e)
        {

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
            }
                else 
                    {
                        ActiveForm.Close(); //zamykam to okno po prostu
                    }
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


        //próba wzięcia danych z zaznaczonych radiobuttonów kod z
        //www.techbrij.com/get-selected-radio-button-text-windows-app-net
        private string BierzemyTekstzZaznaczonegoRadioButtona(GroupBox grb)
        {   //bierzemy into consideration elementy typu RadioButton z danego groupBoxa, a dokładniej, te
            //które spełniaja warunek bycia zaznaczonymi i tych RadioButtonów bierzemy właściwość Text
            if (grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true) != null)
                return grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            else return "-"; //zabezpieczenie jak nic nie zaznaczono, POPRAW na messageboxa      
        }

       /* private string[] TworzenieRekordu(int IlePytan)//ilePytan=IleGroupBoxwOknie(praca1)
        {
            string[] rekord = { "11/22/1968", "29"};
            for (int i = 1; i <= IlePytan; i++)
            {
                rekord[i] = BierzemyTekstzZaznaczonegoRadioButtona();  
            }
            return rekord;
        }*/

        //funkcja odpowiadająca za pobieranie wszystkich odpowiedzi z groupboxów i łączenie ich w jeden wiersz
        //(reprezentowany jako ciąg string-ów); jej argumentem jest liczba pytań
        private string[] TworzenieRekordu(int LiczbaPytan)
        {
            string[] rekord = new string[LiczbaPytan];
            int i = 0;
            foreach (var grupuś in Controls.OfType<GroupBox>())
            {
               rekord[i] = BierzemyTekstzZaznaczonegoRadioButtona(grupuś);
               i++;
            }
            Array.Reverse(rekord); //odwracam kolejność w tablicy na poprawną
            return rekord;
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
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            // do brania info z RadioButtona
            //tworzymy zmienną, której przypisujemy wartość właściwości Text obiektu textBox1
            string potrzebnaZmienna = BierzemyTekstzZaznaczonegoRadioButtona(groupBox1);
           //tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie nuea (czyli tworzymy argumenty dla wydarzenia
           Moje_Arg_Wydarzen nuea = new Moje_Arg_Wydarzen();
            //przypisujemy tym argumentom wartość
            nuea.Name = potrzebnaZmienna;
            //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)
            WyzwalaczUzupelnianie_obserwacji(nuea);

          textBox1.Text =IleGroupBoxwOknie(ActiveForm).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tworzymy zmienną, której przypisujemy wartość właściwości Text obiektu textBox1
            string potrzebnaZmienna = textBox2.Text;
            //tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie nuea (czyli tworzymy argumenty dla wydarzenia
            Moje_Arg_Wydarzen nuea = new Moje_Arg_Wydarzen();
            //przypisujemy tym argumentom wartość
            nuea.Nazwa = potrzebnaZmienna;
            //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)
            WyzwalaczUzupelnianie_obserwacji(nuea);
            //dodawanie wiersza do tabeli
            //dataGridView1.Rows.Add(TworzenieRekordu(IleGroupBoxwOknie(ActiveForm)));
            //string[] zmienna = new string[IleGroupBoxwOknie(ActiveForm)];
            //zmienna = TworzenieRekordu(IleGroupBoxwOknie(ActiveForm));
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Tabela")
                {
                    TworzenieRekordu(IleGroupBoxwOknie(ActiveForm));
                    f.Focus(); //przełącza na otwarte okno
                    foreach ()
                    {
                    
                    }
                }

            }
        }
            
    }
}
