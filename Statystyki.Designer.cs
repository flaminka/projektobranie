﻿namespace PROJEKT_CSS
{
    partial class Statystyki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.generujStatystyki_przycisk = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwa_ank_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.liczba_obs_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statystyki_wyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz pytanie, które chcesz podsumować:";
            // 
            // generujStatystyki_przycisk
            // 
            this.generujStatystyki_przycisk.Location = new System.Drawing.Point(199, 113);
            this.generujStatystyki_przycisk.Name = "generujStatystyki_przycisk";
            this.generujStatystyki_przycisk.Size = new System.Drawing.Size(165, 25);
            this.generujStatystyki_przycisk.TabIndex = 3;
            this.generujStatystyki_przycisk.Text = "Generuj statystyki";
            this.generujStatystyki_przycisk.UseVisualStyleBackColor = true;
            this.generujStatystyki_przycisk.Click += new System.EventHandler(this.generujStatystyki_przycisk_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa ankiety:";
            // 
            // nazwa_ank_label
            // 
            this.nazwa_ank_label.AutoSize = true;
            this.nazwa_ank_label.Location = new System.Drawing.Point(176, 18);
            this.nazwa_ank_label.Name = "nazwa_ank_label";
            this.nazwa_ank_label.Size = new System.Drawing.Size(0, 17);
            this.nazwa_ank_label.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(350, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liczba obserwacji:";
            // 
            // liczba_obs_label
            // 
            this.liczba_obs_label.AutoSize = true;
            this.liczba_obs_label.Location = new System.Drawing.Point(517, 17);
            this.liczba_obs_label.Name = "liczba_obs_label";
            this.liczba_obs_label.Size = new System.Drawing.Size(0, 17);
            this.liczba_obs_label.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(87, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 361);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "pytanie";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Odpowiedź";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Procent";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "N";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // statystyki_wyslij
            // 
            this.statystyki_wyslij.Location = new System.Drawing.Point(207, 534);
            this.statystyki_wyslij.Name = "statystyki_wyslij";
            this.statystyki_wyslij.Size = new System.Drawing.Size(165, 47);
            this.statystyki_wyslij.TabIndex = 10;
            this.statystyki_wyslij.Text = "Wyślij do okna głównego";
            this.statystyki_wyslij.UseVisualStyleBackColor = true;
            this.statystyki_wyslij.Click += new System.EventHandler(this.statystyki_wyslij_Click);
            // 
            // Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 588);
            this.Controls.Add(this.statystyki_wyslij);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.liczba_obs_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazwa_ank_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.generujStatystyki_przycisk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Statystyki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statystyki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generujStatystyki_przycisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nazwa_ank_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label liczba_obs_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button statystyki_wyslij;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}