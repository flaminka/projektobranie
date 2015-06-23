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
        DataGridView TAB_GL = Program.mainform.tabela_glowna; //przypisanie po prostu

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
                liczba_obs_label.Text = (TAB_GL.RowCount).ToString();
            }

            //zwrócenie uwagi użytkownikowi, że korzysta z różnych ankiet - poprawić na brak możliwości wystąpienia takiej sytuacji
            foreach (DataGridViewRow wiersz in TAB_GL.Rows)
            {
                if (wiersz.Cells["ankieta"].Value.ToString() != nazwa_ank_label.Text)
                    MessageBox.Show("Uwaga! W zbiorze znajdują się odpowiedzi z różnych ankiet.", "Różne ankiety");
            }
               

        }


        //OKNO

        //przycisk Generuj statystyki
        private void generujStatystyki_przycisk_Click(object sender, EventArgs e)
        {
            wyliczStatystyki();
        }

        //wyliczamy dla wybranego pytania statystyki
        private void wyliczStatystyki()
        {
            if (comboBox1.SelectedItem != null) //jak nic nie będzie wybrane, to żeby program przeżył
            {
                string pytanie = comboBox1.SelectedItem.ToString(); //bierzemy wybrane pytanie
                foreach (DataGridViewColumn kolumna in TAB_GL.Columns)
                {
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
                        IList<string> lista = new List<string>();
                        foreach (DataGridViewRow wiersz in TAB_GL.Rows)
                        {
                            if (wiersz != null)
                                lista.Add((string)wiersz.Cells[pytanie].Value);
                        }
                        string[] lista_odp = lista.ToArray<string>(); //lista z naszymi odpowiedziami


                        //liczymy ilość wystąpień
                        string[] liczba_wyst = new string[rodzaj_odp.Length]; //lista z ilością wystąpień odp (jako string)
                        double[] count = new double[rodzaj_odp.Length]; //lista z ilością wystąpień odp (jako liczby)
                        for (int k = 0; k < rodzaj_odp.Length; k++)
                        {
                            count[k] = lista_odp.Where(x => x == rodzaj_odp[k]).Count();
                            liczba_wyst[k] = count[k].ToString();
                        }

                        //robimy z tego wszystkiego rekord w tabeli w naszym oknie Statystyki
                        for (int j = 0; j < rodzaj_odp.Length; j++)
                        {
                            string[] rekordzik = new string[4];

                            rekordzik[0] = pytanie; //z jakiego pytania pochodzą odpowiedzi
                            rekordzik[1] = rodzaj_odp[j]; //jak brzmi dana odpowiedź
                            rekordzik[2] = (Math.Round(((count[j]) / TAB_GL.RowCount) * 100, 2)).ToString(); //liczymy procent wystąpień tej odpowiedzi
                            rekordzik[3] = liczba_wyst[j]; //liczymy ilość wystąpień tej odpowiedzi

                            dataGridView1.Rows.Add(rekordzik);
                        }

                    }
                }

            }
        }


        // przycisk Wyślij do okna głównego
       private void statystyki_wyslij_Click(object sender, EventArgs e)
        {
            Program.mainform.tabcia_stat.Show();
            kopiujDane();
            ActiveForm.Close();

        }


        //funkcja kopiująca dane z dataGridView1 z okna Statystyki do okna głównego
        private void kopiujDane()
        {

            if (Program.mainform.tabcia_stat.ColumnCount == 0)//żeby nie dodało kolumn jeszcze raz jak uruchomimy ponownie Kwestionariusz/Statystyki
            {
                Program.mainform.tabcia_stat.Columns.Add("pytanie", "pytanie");
                Program.mainform.tabcia_stat.Columns.Add("odpowiedź", "odpowiedź");
                Program.mainform.tabcia_stat.Columns.Add("procent", "procent");
                Program.mainform.tabcia_stat.Columns.Add("N", "N");
            }

            //kopiujemy dane
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string[] rekordzik = new string[4];
                rekordzik[0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                rekordzik[1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                rekordzik[2] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                rekordzik[3] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                Program.mainform.tabcia_stat.Rows.Add(rekordzik);
            }   
        }
   















    }
}
