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
        //Form1 glowne_okno;
        public Praca()
        {
            InitializeComponent();
        }  

        private void praca_wyslij_Click(object sender, EventArgs e)
        {

            //dodać opcję dodawania gdzieś jakoś tych danych DODAC
            //dodaję MessageBoxa, by sprawdzić czy wszystkie pola są wypełnione ZROBIC
            //dodaję MessageBoxa, by poinformować o wypełnieniu ankiety i możliwości kolejnego jej wypełnienia
            if (MessageBox.Show("Ankieta: Praca została wypełniona i wysłana do bazy danych. \n Czy chcesz wypełnić ją ponownie?", "Kolejne wypełnienie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActiveForm.Close(); //zamykam obecne okno i otwieram nowe (mniej klikania niż przez menu)
                Praca praca2 = new Praca(); //i tu widać, że okno Praca jako szablon to good idea
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
        //próba wzięcia danych z zaznaczonych radiobuttonów
        //www.techbrij.com/get-selected-radio-button-text-windows-app-net
        private string GetSelectedRadioButtonText(GroupBox grb)
        { 
            return grb.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }




        //ZMIANA
        
        //przekazywanie informacji do Form1

        //tworzymy wydarzenie o argumentach klasy Moje_Arg_Wydarzen, które nazywamy Uzupelnianie_obserwacji
        public event EventHandler<Moje_Arg_Wydarzen> Uzupelnianie_obserwacji;

        //wyzwalacz wydarzenia Uzupelnianie_obserwacji będący metodą (o nazwie OnUzupelnianie_obserwacji), której argument to e z klasy Moje_Arg_Wydarzen
        protected virtual void OnUzupelnianie_obserwacji(Moje_Arg_Wydarzen e)
        {
            //jeśli wywołamy zdarzenie Uzupelnianie_obserwacji, to będzie ono działać na obiekcie wskazanym przez wskaźnik this (tu: Praca)
            // a jego argumentami (wydarzenia FistNameUpdated) będą e
            if (Uzupelnianie_obserwacji != null)
                Uzupelnianie_obserwacji(this, e);
       }
     
        private void button1_Click(object sender, EventArgs e)
        {
        //    GetSelectedRadioButtonText(groupBox1);
            //tworzymy zmienną, której przypisujemy wartość właściwości Text obiektu textBox1
           string newFirstName = textBox1.Text;
           //tworzymy egzemplarz klasy Moje_Arg_Wydarzen o nazwie nuea (czyli tworzymy argumenty dla wydarzenia
           Moje_Arg_Wydarzen nuea = new Moje_Arg_Wydarzen();
            //przypisujemy tym argumentom wartość
            nuea.Name = newFirstName;
            //wywołujemy metodę wyzwalającą wydarzenie (let it happen!)
            OnUzupelnianie_obserwacji(nuea);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string newFirstName = textBox2.Text;

            Moje_Arg_Wydarzen nuea = new Moje_Arg_Wydarzen();

            nuea.Nazwa = newFirstName;

            OnUzupelnianie_obserwacji(nuea);
        }
            
    }
}
