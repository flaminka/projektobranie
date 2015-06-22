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
            foreach (DataGridViewColumn kolumna in Program.mainform.tabela_glowna.Columns)
            {
                if (kolumna.HeaderText != "ankieta")
                    comboBox1.Items.Add(kolumna.HeaderText);
            }
            if (Program.mainform.tabela_glowna.RowCount != 0)
            {
                nazwa_ank_label.Text = Program.mainform.tabela_glowna.Rows[0].Cells[0].Value.ToString();
                liczba_obs_label.Text = (Program.mainform.tabela_glowna.RowCount - 1).ToString();
            }
        }


        private void generujStatystyki_przycisk_Click(object sender, EventArgs e)
        {
            
            string pytanie = comboBox1.SelectedItem.ToString();

        }
         



    }
}
