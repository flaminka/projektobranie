using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration; //do wpf


namespace PROJEKT_CSS
{
    public partial class Statystyki : Form
    {

        //ZMIENNE
        DataGridView TAB_GL = Program.mainform.tabela_glowna;


        //INICJALIZATOR
        public Statystyki()
        {
            InitializeComponent();

            /*do WPF
            ElementHost elhost = new ElementHost();
            elhost.Size = new Size(561, 32);
            elhost.Location = new Point(357, 23);

            MyWPFControl wpfctl = new MyWPFControl();
            elhost.Child = wpfctl;

            this.Controls.Add(elhost);
             */
            
            comboBox1.Items.Clear();

            //dodajemy pytania do comboboxa
            foreach (DataGridViewColumn kolumna in TAB_GL.Columns)
            {
                if (kolumna.HeaderText != "ankieta")
                    comboBox1.Items.Add(kolumna.HeaderText);
            }

            //dodajemy info o ankiecie i liczbie obserwacji (pod warunkiem istnienia obserwacji w zbiorze)
            if (TAB_GL.RowCount != 0)
            {
                nazwa_ank_label.Text = TAB_GL.Rows[0].Cells[0].Value.ToString();
                liczba_obs_label.Text = (TAB_GL.RowCount - 1).ToString();
            }
        }


        //przycisk Generuj statystyki (dla wybranego pytania)
        private void generujStatystyki_przycisk_Click(object sender, EventArgs e)
        {
            
            string pytanie = comboBox1.SelectedItem.ToString(); //bierzemy wybrane pytanie
            foreach (DataGridViewColumn kolumna in TAB_GL.Columns)
            {
                if (kolumna.HeaderText == pytanie)
                {
                    //zapisujemy odpowiedzi, które wystąpiły dla danego pytania
                    HashSet<string> opcje = new HashSet<string>();
                    foreach (DataGridViewRow wiersz in TAB_GL.Rows)
                        if(wiersz != null)
                        opcje.Add((string)wiersz.Cells[pytanie].Value);
                    string[] rodzaj_odp = opcje.ToArray<string>(); //lista z rodzajami odpowiedziami

                    //zapisujemy ilość odpowiedzi, które wystąpiły dla danego pytania
                    IList<string> lista = new List<string>();
                    foreach (DataGridViewRow wiersz in TAB_GL.Rows)
                        if (wiersz != null)
                        lista.Add((string)wiersz.Cells[pytanie].Value);
                    string[] lista_odp = lista.ToArray<string>(); //lista z naszymi odpowiedziami


                    //liczymy ilość wystąpień
                    string[] liczba_wyst = new string[rodzaj_odp.Length]; //lista z ilością wystąpień odp
                    double[] count = new double[rodzaj_odp.Length];
                    for (int k = 0; k < rodzaj_odp.Length; k++)
                    {
                        count[k] = lista_odp.Where(x => x == rodzaj_odp[k]).Count();
                        liczba_wyst[k] = count[k].ToString();
                    }

                    //robimy z tego wszystkiego rekord w tabeli w Statystyka
                    for (int j = 0; j < rodzaj_odp.Length; j++)
                    {
                        string[] rekordzik = new string[rodzaj_odp.Length];

                        rekordzik[0] = rodzaj_odp[j];
                        rekordzik[1] = (Math.Round(((count[j]) / (TAB_GL.RowCount- 1)) * 100,2)).ToString(); //pojawia sie pusty wiersz i jak jest jedna odpowiedz
                        rekordzik[2] = liczba_wyst[j];


                        dataGridView1.Rows.Add(rekordzik);
                    }
                }
            }

            /// 

        }



    }
}
