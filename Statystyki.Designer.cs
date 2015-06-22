namespace PROJEKT_CSS
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.generujStatystyki_przycisk = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nazwa_ank_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.liczba_obs_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zBIOR = new PROJEKT_CSS.ZBIOR();
            this.zBIORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBIOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBIORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
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
            this.generujStatystyki_przycisk.Location = new System.Drawing.Point(572, 58);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(146, 326);
            this.dataGridView1.TabIndex = 9;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PROJEKT_CSS.Form1);
            // 
            // zBIOR
            // 
            this.zBIOR.DataSetName = "ZBIOR";
            this.zBIOR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zBIORBindingSource
            // 
            this.zBIORBindingSource.DataSource = this.zBIOR;
            this.zBIORBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.zBIORBindingSource;
            // 
            // Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 616);
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
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBIOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zBIORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generujStatystyki_przycisk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nazwa_ank_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label liczba_obs_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private ZBIOR zBIOR;
        private System.Windows.Forms.BindingSource zBIORBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
    }
}