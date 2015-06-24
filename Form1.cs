using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; //do zapisywania tabeli
using RDotNet; //do łączenia R i C#, do zrobienia kiedyś


namespace PROJEKT_CSS
{


    public partial class Form1 : Form
    {

        //ZMIENNE
        public int IleKolumn; //liczba kolumn w tabela_glowna


        //INICJALIZATOR
        public Form1()
        {
            InitializeComponent();//inicjalizator klasy - to, co chcę, żeby pojawiło się wraz z otworzeniem tego okna (tu:aplikacji)
           
        }
       

        //MENUSTRIP

        // działanie opcji Plik/Nowa sesja 
        private void nowaSesjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //usuwamy wiersze i kolumny i aktualizuje wygląd tabela_glowna
            tabela_glowna.Rows.Clear();
            tabela_glowna.Columns.Clear();
            tabela_glowna.Refresh();
            //usuwamy wiersze i kolumny i aktualizuje wygląd tabcia_stat
            tabcia_stat.Rows.Clear();
            tabcia_stat.Columns.Clear();
            tabcia_stat.Refresh();
            tabcia_stat.Hide();
            //do odświeżania wykresu POPRAWIC - tytuł się nie odświeża
            wykres.Series.Clear();
            wykres.Titles.Clear();
            wykres.Hide();
        }

 
        // działanie opcji Plik/Nowa ankieta/Praca
        private void pracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zapobiegamy kilkukrotnemu otwarciu tego samego okna; zmodyfikowana wersja kodu z www.c-sharpcorner.com/UploadFile/kirtan007/how-to-prevent-multiple-instances-of-child-form-in-mdi-windows-form-application/
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
                        tabela_glowna.Columns.Add("ankieta", "ankieta");
                        IleKolumn = praca1.IleGroupBoxwOknie(praca1); //ustalenie liczby kolumn potrzebnych do tej ankiety
                        for (int i = 1; i <= IleKolumn; i++) //nazywanie kolumn i nagłówków kolumn
                        {
                            string nazwaKolumny = "pytanie" + i.ToString();
                            string naglowekKolumny = "pytanie" + i.ToString();
                            tabela_glowna.Columns.Add(nazwaKolumny, naglowekKolumny);
                        }
                }
                //chcemy, żeby zostało wykonane wydarzenie Uzupelnianie_obserwacji i zatrudniamy gostka by się tym zajął
                praca1.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(praca1_Uzupelnianie_obserwacji);
            }
            
        }


        //określamy co ten gostek ma robić, gdy wywoływane jest wydarzenie Uzupełnianie_obserwacji z praca1
        private void praca1_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
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



        //działanie opcji  Plik/Nowa ankieta/Szkoła 
        private void szkołaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //zapobiegam kilkukrotnemu otwarciu tego samego okna; zmodyfikowana wersja kodu z www.c-sharpcorner.com/UploadFile/kirtan007/how-to-prevent-multiple-instances-of-child-form-in-mdi-windows-form-application/
            bool OknoOtwarte = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Szkoła")
                {
                    OknoOtwarte = true;
                    f.Focus(); //przełącza na otwarte okno
                    break;
                }
            }

            //otwieranie okna Szkoła
            if (OknoOtwarte == false)
            {
                Szkoła szkoła1 = new Szkoła();
                szkoła1.Show();

                if (tabela_glowna.ColumnCount == 0) //jak zamkniemy okno i uruchomimy je z menustrip, to żeby nam nie dodało kolumn jeszcze raz
                {
                    tabela_glowna.Columns.Add("ankieta", "ankieta");
                    IleKolumn = szkoła1.IleGroupBoxwOknie(szkoła1); //ustalenie liczby kolumn potrzebnych do tej ankiety
                    for (int i = 1; i <= IleKolumn; i++) //nazywanie kolumn i nagłówków kolumn
                    {
                        string nazwaKolumny = "pytanie" + i.ToString();
                        string naglowekKolumny = "pytanie" + i.ToString();
                        tabela_glowna.Columns.Add(nazwaKolumny, naglowekKolumny);
                    }
                }
                //chcemy, żeby zostało wykonane wydarzenie Uzupelnianie_obserwacji i zatrudniamy gostka by się tym zajął
                szkoła1.Uzupelnianie_obserwacji += new EventHandler<Moje_Arg_Wydarzen>(szkoła1_Uzupelnianie_obserwacji);
            }

        }


        //określamy co ten gostek ma robić, gdy wywoływane jest wydarzenie Uzupełnianie_obserwacji z szkoła1
        private void szkoła1_Uzupelnianie_obserwacji(object sender, Moje_Arg_Wydarzen e)
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


        // działanie opcji Plik/Zapisz dane jako .csv
        private void zapiszDaneJakocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog okno_sciezki = new FolderBrowserDialog(); //wybór miejsca zapisu danych 
            if (okno_sciezki.ShowDialog() == DialogResult.OK)
            {
                EksportDoCSV(Program.mainform.tabela_glowna, okno_sciezki.SelectedPath); //eksport danych
                MessageBox.Show("Dane zostały zapisany w " + okno_sciezki.SelectedPath.ToString(), "Zapisano dane");
            }

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
            if (stata.comboBox1.Items.Count == 0) //jak nie wygenerujemy danych z ankiet to nie otworzy okna
                MessageBox.Show("Wygeneruj najpierw dane wypełniając ankiety!", "Brak danych");
            else stata.Show();
        }


        // działanie opcji Kwestionariusz/Wykresy
        private void wykresyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wykresy wykresiki = new Wykresy();
            if (tabela_glowna.RowCount == 0) //jak nie wygenerujemy pierw danych to nie otworzy okna
            {
                MessageBox.Show("Wygeneruj najpierw dane wypełniając ankiety!", "Brak danych");
            }
            else wykresiki.Show();
        }


        //FUNKCJE


        //funkcja pobierająca dane z DataGridView, zamieniająca je na format .csv i zapisująca je w wybranym miejscu (sciezka) pod nazwą KWESTi_DANE
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
             for (int i = 0; i < (tabelka.Rows.Count); i++)
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


        



    
    }
}
