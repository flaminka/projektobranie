﻿using System;
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
    public partial class Tabela : Form
    {
        private Panel buttonPanel = new Panel();
        public DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        public int IleKolumn;
        


        public Tabela()
        {
            InitializeComponent();
            this.Load += new EventHandler(Tabela_Load);           
        }

        private void Tabela_Load(System.Object sender, System.EventArgs e)
        {
            // SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
           
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(songsDataGridView);
            songsDataGridView.Columns.Add("ankieta","Ankieta");

            for (int i = 1; i <= IleKolumn; i++)
            {
                string nazwaKolumny = "kolumna"+i.ToString();
                string naglowekKolumny = "pytanie " + i.ToString();
                songsDataGridView.Columns.Add(nazwaKolumny, naglowekKolumny);
            }

                 songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                 songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                 songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                     new Font(songsDataGridView.Font, FontStyle.Bold);

                 songsDataGridView.Name = "songsDataGridView";
                // songsDataGridView.Location = new Point(0, 0);
                 //songsDataGridView.Size = new Size(1885, 600);
                 songsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                 songsDataGridView.ColumnHeadersBorderStyle =
                     DataGridViewHeaderBorderStyle.Single;
                 songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                 songsDataGridView.GridColor = Color.Black;
                 songsDataGridView.RowHeadersVisible = false;
                 /*songsDataGridView.Columns[1].Name = "Track";
                 songsDataGridView.Columns[2].Name = "Title";
                 songsDataGridView.Columns[3].Name = "Artist";
                 songsDataGridView.Columns[4].Name = "Album";
                 songsDataGridView.Columns[4].DefaultCellStyle.Font =
                     new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);
                 */
                songsDataGridView.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Dock = DockStyle.Fill;

         /*   songsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);*/
        }

        private void PopulateDataGridView()
        {
            string[] wiersz = new string[IleKolumn];

            songsDataGridView.Rows.Add(wiersz);

            //songsDataGridView.Columns[0].DisplayIndex = 3;

        }

       /* private void SetupLayout()
        {
            // this.Size = new Size(1200, 500);
            addNewRowButton.Text = "Add Row";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
        }*/

        //do formatowania daty
       /* private void songsDataGridView_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }*/

        /*private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.songsDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.songsDataGridView.SelectedRows.Count > 0 &&
                this.songsDataGridView.SelectedRows[0].Index !=
                this.songsDataGridView.Rows.Count - 1)
            {
                this.songsDataGridView.Rows.RemoveAt(
                    this.songsDataGridView.SelectedRows[0].Index);
            }
        }*/
    }
}


