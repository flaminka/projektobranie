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
    public partial class Form1 : Form
    {

        //ZMIENNE
        private int IleKolumn; //liczba kolumn w tabela_glowna


        //INICJALIZATOR
        public Form1()
        {
            InitializeComponent();//inicjalizator klasy - co chcę, żeby pojawiło się wraz z otworzeniem tego okna (tu:aplikacji)
        }
       

        //MENUSTRIP

        // działanie opcji Plik/Nowa sesja - usuwam wiersze i kolumny i aktualizuję wyglad tabela_glowna
        private void nowaSesjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabela_glowna.Rows.Clear();
            tabela_glowna.Columns.Clear();
            tabela_glowna.Refresh();
        }

 
        // działanie opcji Plik/Nowa ankieta/Praca
        private void pracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zapobiegam kilkukrotnemu otwarciu tego samego okna; zmodyfikowana wersja kodu z www.c-sharpcorner.com/UploadFile/kirtan007/how-to-prevent-multiple-instances-of-child-form-in-mdi-windows-form-application/
            bool OknoOtwarte = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Praca") 
                {
                    OknoOtwarte = true;
                    f.Focus(); //przełącza na otwarte okno
                    break;
                }
            }

            //otwieranie okna Praca
            if (OknoOtwarte == false)
            {
                Praca praca1 = new Praca();    
                
                praca1.Show();

                if(tabela_glowna.ColumnCount == 0) //jak zamkniemy okno i uruchomimy je z menustrip, to żeby nam nie dodało kolumn jeszcze raz
                {
                        tabela_glowna.Columns.Add("ankieta", "Ankieta");
               
                        IleKolumn = praca1.IleGroupBoxwOknie(praca1);
                        for (int i = 1; i <= IleKolumn; i++)
                        {
                            string nazwaKolumny = "kolumna" + i.ToString();
                            string naglowekKolumny = "pytanie " + i.ToString();
                            tabela_glowna.Columns.Add(nazwaKolumny, naglowekKolumny);
                        }
                }

                praca1.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(praca1_Uzupelnianie_obserwacji);
            }
            
        }


        //co ma czemu przypisywać
        //zawsze gdy wyzwalane jest wydarzenie Uzupelnianie_obserwacji ta metoda wykonuje to wydarzenie i co robi określamy
        private void praca1_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
            //jeśli są jakieś właściwości argumentów to przypisujemy Name (które niesie wartość z praca1) obiektowi  z okna Form1, tj. label1
            if (e != null && e.wiersz != null)
                tabela_glowna.Rows.Add(e.wiersz);

        }



        // NIEZROBIONE działanie opcji  z zakładki Plik/Nowa ankieta/Szkoła - robię to w oknie głównym 
        private void szkołaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nadaję funckcjonalność opcji Szkoła w Nowa Ankieta - otwieranie okna Szkoła
            Szkoła newMDIChild = new Szkoła();
            // ustawiam obecne okno (Form1 jako okno główne, w którym wyświetlę okno Szkoła
            newMDIChild.MdiParent = this;
            // wyświetlam nowe okno w oknie głównym
            newMDIChild.Show();

        }



    

    }
}
