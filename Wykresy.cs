using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROJEKT_CSS
{
    public partial class Wykresy : Form
    {

        //ZMIENNE


        DataGridView TAB_GL = Program.mainform.tabela_glowna; //przypisanie po prostu
        DataGridView TAB_STAT = Program.mainform.tabcia_stat; //przypisanie po prostu


        //INICJALIZATOR


        public Wykresy()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            
            //dodajemy pytania do comboboxa
            foreach (DataGridViewColumn kolumna in TAB_GL.Columns)
            {
                if (kolumna.HeaderText != "ankieta")
                    comboBox1.Items.Add(kolumna.HeaderText);
            }
   
            
        }


        //PRZYCISKI


        // przycisk Utwórz wykres
        private void wykres_utworz_przycisk_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null) //jak nic nie będzie wybrane, to żeby program przeżył
            {
                string pytanie = comboBox1.SelectedItem.ToString(); //bierzemy wybrane pytanie
                foreach (DataGridViewColumn kolumna in TAB_GL.Columns)
                {
                    //generujemy wykres dla wybranego pytania
                    if (kolumna.HeaderText == pytanie)
                    {
                        //zapisujemy odpowiedzi, które wystąpiły dla danego pytania
                        HashSet<string> opcje = new HashSet<string>();
                        foreach (DataGridViewRow wiersz in TAB_GL.Rows)
                        {
                            if (wiersz != null)
                                opcje.Add((string)wiersz.Cells[pytanie].Value);
                        }
                        string[] rodzaj_odp = opcje.ToArray<string>(); //lista z rodzajami odpowiedziami

                        //zapisujemy listę odpowiedzi, które wystąpiły dla danego pytania
                        List<string> lista = new List<string>();
                        foreach (DataGridViewRow wiersz in TAB_GL.Rows)
                        {
                            if (wiersz != null)
                                lista.Add((string)wiersz.Cells[pytanie].Value);
                        }
                        string[] lista_odp = lista.ToArray<string>(); //lista z naszymi odpowiedziami


                        //liczymy ilość wystąpień
                        double[] count = new double[rodzaj_odp.Length]; //lista z ilością wystąpień odp (jako liczby)
                        for (int k = 0; k < rodzaj_odp.Length; k++)
                        {
                            count[k] = lista_odp.Where(x => x == rodzaj_odp[k]).Count();
                        }

                        //liczymy procenty
                        double[] procenty = new double[rodzaj_odp.Length]; //lista z procentami wystąpień odp (jako liczby)
                        for (int k = 0; k < rodzaj_odp.Length; k++)
                        {
                            procenty[k] = (Math.Round(((count[k]) / TAB_GL.RowCount) * 100, 2));
                        }

                        //czyścimy wykres za każdym razem
                        Program.mainform.wykres.Series.Clear();
                        Program.mainform.wykres.Titles.Clear();

                        //dodajemy tytuł - treść pytania (która jest przechowywana w ToolTipie kolumny w tabeli głównej)
                        Program.mainform.wykres.Titles.Add(kolumna.ToolTipText);

                        //dodajemy serię danych do wykresu
                        Series seria = new Series("Procent %");
                        seria.Points.DataBindXY(rodzaj_odp, procenty);
                        seria.Font = new Font("Arial", 8.0f, FontStyle.Regular);
                        Program.mainform.wykres.Series.Add(seria);
                        //dajemy możliwość wyboru rodzaju wykresu
                        if(radioButton1.Checked)
                           Program.mainform.wykres.Series[0].ChartType = SeriesChartType.Column; 
                        if (radioButton2.Checked)
                           Program.mainform.wykres.Series[0].ChartType = SeriesChartType.Bar;
                        if (radioButton3.Checked)
                        {
                            Program.mainform.wykres.Series[0].ChartType = SeriesChartType.Pie;
                            Program.mainform.wykres.Series[0]["PieLabelStyle"] = "Disabled"; //żeby etykiety były tylko w legendzie, nie na wykresie
                        }
                        if (radioButton4.Checked)
                        {
                            Program.mainform.wykres.Series[0].ChartType = SeriesChartType.Doughnut;
                            Program.mainform.wykres.Series[0]["PieLabelStyle"] = "Disabled";//żeby etykiety były tylko w legendzie, nie na wykresie
                        }

                    }
                }

                Program.mainform.wykres.Show();
            }
 
        }


        //przycisk Zapisz wykres
        private void wykresy_zapisz_przycisk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wygeneruj najpierw wykres!", "Brak pytania");
            }
            else
            {
                //otwieramy okno wyboru miejsca zapisu wykresu
                FolderBrowserDialog okno_zapisu = new FolderBrowserDialog();
                //jeśli użytkownik zdecyduje się zapisać wykres, zapisujemy go i wyświetlamy info o miejscu zapisu danych
                if (okno_zapisu.ShowDialog() == DialogResult.OK)
                {
                    Program.mainform.wykres.SaveImage(okno_zapisu.SelectedPath + "/KWESTi_wykres.png", System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Wykres został zapisany w " + okno_zapisu.SelectedPath.ToString(), "Zapisano wykres");
                }
            }
        }

  


    }
}
