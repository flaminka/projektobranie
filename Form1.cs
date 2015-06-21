﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //do zapisywania tabeli


namespace PROJEKT_CSS
{
    public partial class Form1 : Form
    {

        //ZMIENNE
        private int IleKolumn; //liczba kolumn w tabela_glowna


        //INICJALIZATOR
        public Form1()
        {
            InitializeComponent();//inicjalizator klasy - to, co chcę, żeby pojawiło się wraz z otworzeniem tego okna (tu:aplikacji)
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
                        IleKolumn = praca1.IleGroupBoxwOknie(praca1); //ustalenie liczby kolumn potrzebnych do tej ankiety
                        for (int i = 1; i <= IleKolumn; i++) //nazywanie kolumn i nagłówków
                        {
                            string nazwaKolumny = "pytanie" + i.ToString();
                            string naglowekKolumny = "pytanie " + i.ToString();
                            tabela_glowna.Columns.Add(nazwaKolumny, naglowekKolumny);
                        }
                }
                //chcemy, żeby zostało wykonane wydarzenie Uzupelnianie_obserwacji i zatrudniamy funkcję by to zrobiła i określamy co ma tu zrobić
                praca1.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(praca1_Uzupelnianie_obserwacji);
            }
            
        }


        //co ma czemu przypisywać
        //zawsze gdy wyzwalane jest wydarzenie Uzupelnianie_obserwacji ta metoda wykonuje to wydarzenie i co robi określamy
        private void praca1_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
        {
            //jeśli są jakieś właściwości argumentów to przypisujemy zmienna wiersz (która niesie wartość z praca1) obiektowi  z okna Form1, tj.tabela_glowna
            if (e != null && e.wiersz != null)
                tabela_glowna.Rows.Add(e.wiersz);

        }






        // NIEZROBIONE - działanie opcji  z zakładki Plik/Nowa ankieta/Szkoła - robię to w oknie głównym 
        private void szkołaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nadaję funckcjonalność opcji Szkoła w Nowa Ankieta - otwieranie okna Szkoła
            Szkoła szkoła1 = new Szkoła();
            // wyświetlam nowe okno w oknie głównym
            szkoła1.Show();

        }

        // działanie opcji Plik/Zamknij
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.mainform.Close();
        }

        // działanie opcji Kwestionariusz/Statystyki
        private void statystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statystyki stata = new Statystyki();
            stata.Show();
        }



        // działanie opcji Plik/Zapisz dane jako .csv
        private void zapiszDaneJakocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog okno_sciezki = new FolderBrowserDialog(); //wybór miejsca zapisu danych
           okno_sciezki.ShowDialog();
           EksportDoCSV(Program.mainform.tabela_glowna, okno_sciezki.SelectedPath); //eksport danych
        }

        //funkcja pobierająca dane z DataGridView, zamieniająca je na format .csv i zapisująca je w wybrane miejsce (sciezka) pod nazwą KWESTi_DANE
        //poprawiony kod z stackoverflow.com/questions/13563343/simple-way-to-export-datagridview-to-excel
        public void EksportDoCSV(DataGridView tabelka, string sciezka)
         {

             // otwieramy KWESTi_DANE.csv (ew.tworzymy nowy plik we wskazanym przez użytkownika miejscu)
             StreamWriter skryba = new StreamWriter(sciezka+"/KWESTi_DANE.csv");

             //zapisujemy nazwy kolumn do pliku
             for (int i = 0; i < tabelka.Columns.Count; i++)
             {
                 if (i != tabelka.Columns.Count-1)
                    skryba.Write(tabelka.Columns[i].Name.ToString() + ",");
                 else skryba.Write(tabelka.Columns[i].Name.ToString());//żeby ostatnia kolumna nie kończyła się przecinkiem
             }

             skryba.WriteLine(); //nowa linia

             //zapisujemy rekordy do pliku
             for (int i = 0; i < (tabelka.Rows.Count - 1); i++) //o 1 wiersz mniej by nie czytało tego pustego
             {
                 for (int j = 0; j < tabelka.Columns.Count; j++)
                 {
                     if (j != tabelka.Columns.Count - 1)
                        skryba.Write(tabelka.Rows[i].Cells[j].Value + ",");
                     else skryba.Write(tabelka.Rows[i].Cells[j].Value);            
                 }

                 skryba.WriteLine();
             }

             //zamykamy plik
             skryba.Close();
         }


        private void button1_Click(object sender, EventArgs e)
        {
            // DataSet zbiorek = (DataSet)(tabela_glowna.DataSource);

        }
    }
}
