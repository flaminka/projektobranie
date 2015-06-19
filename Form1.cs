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
        //inicjalizator klasy, co chcę, żeby pojawiło się wraz z otworzeniem tego okna (tu:aplikacji)
        public Form1()
        {
            InitializeComponent();
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

    
        // działanie opcji  z zakładki Plik/Nowa ankieta/Praca - robię to jako oddzielne okno a nie w oknie głównym
        private void pracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zapobiegam kilkukrotnemu otwarciu tego samego okna; zmodyfikowana wersja kodu z 
            //www.c-sharpcorner.com/UploadFile/kirtan007/how-to-prevent-multiple-instances-of-child-form-in-mdi-windows-form-application/
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

            if (OknoOtwarte == false)
            {
                Praca praca1 = new Praca();    
                //żeby uaktualniało się okno główne wydarzeniem z okna Praca
                //bierzemy wydarzenie Uzupelnianie_obserwacji okna praca1 (reprezentanta klasy Praca) i zatrudniamy gościa do radzenia sobie z tym wydarzeniem
                praca1.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(praca1_Uzupelnianie_obserwacji);
                // otwieranie okna tabelka
                Tabela tabelka_praca = new Tabela();
                tabelka_praca.IleKolumn = praca1.IleGroupBoxwOknie(praca1);
                // ustawiam okno Form1 jako okno główne, w którym wyświetlę okno tabelka (W Form1 zaznaczyłam w IsMDIContainer!!!)
                tabelka_praca.MdiParent = this;
                tabelka_praca.Dock = DockStyle.Fill;
                // wyświetlam nowe okno w oknie głównym
                tabelka_praca.Show();
                praca1.Show();   
            }
            
        }
        //co ma czemu przypisywać
        //zawsze gdy wyzwalane jest wydarzenie Uzupelnianie_obserwacji ta metoda wykonuje to wydarzenie i co robi określamy
        private void praca1_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
              //jeśli są jakieś właściwości argumentów to przypisujemy Name (które niesie wartość z praca1) obiektowi  z okna Form1, tj. label1
            if (e != null && e.Name != null)
                label1.Text = e.Name;
            if (e != null && e.Nazwa != null)
                label2.Text = e.Nazwa;      
        }
       







    }
}
