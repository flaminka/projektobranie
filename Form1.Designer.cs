﻿namespace PROJEKT_CSS
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaSesjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaAnkietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDaneJakocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwestionariuszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabela_glowna = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabcia_stat = new System.Windows.Forms.DataGridView();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zapiszStatystykiJakocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_glowna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcia_stat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kwestionariuszToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(878, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaSesjaToolStripMenuItem,
            this.nowaAnkietaToolStripMenuItem,
            this.zapiszDaneJakocsvToolStripMenuItem,
            this.zapiszStatystykiJakocsvToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaSesjaToolStripMenuItem
            // 
            this.nowaSesjaToolStripMenuItem.Name = "nowaSesjaToolStripMenuItem";
            this.nowaSesjaToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.nowaSesjaToolStripMenuItem.Text = "Nowa sesja";
            this.nowaSesjaToolStripMenuItem.ToolTipText = "Utwórz nową tabelę na dane";
            this.nowaSesjaToolStripMenuItem.Click += new System.EventHandler(this.nowaSesjaToolStripMenuItem_Click);
            // 
            // nowaAnkietaToolStripMenuItem
            // 
            this.nowaAnkietaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szkołaToolStripMenuItem,
            this.pracaToolStripMenuItem});
            this.nowaAnkietaToolStripMenuItem.Name = "nowaAnkietaToolStripMenuItem";
            this.nowaAnkietaToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.nowaAnkietaToolStripMenuItem.Text = "Nowa ankieta";
            this.nowaAnkietaToolStripMenuItem.ToolTipText = "Wybierz ankietę";
            // 
            // szkołaToolStripMenuItem
            // 
            this.szkołaToolStripMenuItem.Name = "szkołaToolStripMenuItem";
            this.szkołaToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.szkołaToolStripMenuItem.Text = "Szkoła";
            this.szkołaToolStripMenuItem.Click += new System.EventHandler(this.szkołaToolStripMenuItem_Click);
            // 
            // pracaToolStripMenuItem
            // 
            this.pracaToolStripMenuItem.Name = "pracaToolStripMenuItem";
            this.pracaToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.pracaToolStripMenuItem.Text = "Praca";
            this.pracaToolStripMenuItem.Click += new System.EventHandler(this.pracaToolStripMenuItem_Click);
            // 
            // zapiszDaneJakocsvToolStripMenuItem
            // 
            this.zapiszDaneJakocsvToolStripMenuItem.Name = "zapiszDaneJakocsvToolStripMenuItem";
            this.zapiszDaneJakocsvToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.zapiszDaneJakocsvToolStripMenuItem.Text = "Zapisz dane jako .csv";
            this.zapiszDaneJakocsvToolStripMenuItem.ToolTipText = "Zapisz dane w formacie .csv";
            this.zapiszDaneJakocsvToolStripMenuItem.Click += new System.EventHandler(this.zapiszDaneJakocsvToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.ToolTipText = "Zamknij aplikację KWESTi";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // kwestionariuszToolStripMenuItem
            // 
            this.kwestionariuszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statystykiToolStripMenuItem,
            this.wykresyToolStripMenuItem});
            this.kwestionariuszToolStripMenuItem.Name = "kwestionariuszToolStripMenuItem";
            this.kwestionariuszToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.kwestionariuszToolStripMenuItem.Text = "Kwestionariusz";
            // 
            // statystykiToolStripMenuItem
            // 
            this.statystykiToolStripMenuItem.Name = "statystykiToolStripMenuItem";
            this.statystykiToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.statystykiToolStripMenuItem.Text = "Statystyki";
            this.statystykiToolStripMenuItem.ToolTipText = "Policz statystyki dla danych";
            this.statystykiToolStripMenuItem.Click += new System.EventHandler(this.statystykiToolStripMenuItem_Click);
            // 
            // wykresyToolStripMenuItem
            // 
            this.wykresyToolStripMenuItem.Name = "wykresyToolStripMenuItem";
            this.wykresyToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.wykresyToolStripMenuItem.Text = "Wykresy";
            this.wykresyToolStripMenuItem.ToolTipText = "Utwórz wykresy dla danych";
            this.wykresyToolStripMenuItem.Click += new System.EventHandler(this.wykresyToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(878, 527);
            this.splitContainer1.SplitterDistance = 488;
            this.splitContainer1.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabela_glowna);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(878, 488);
            this.splitContainer2.SplitterDistance = 564;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabela_glowna
            // 
            this.tabela_glowna.AllowUserToAddRows = false;
            this.tabela_glowna.AllowUserToResizeColumns = false;
            this.tabela_glowna.AllowUserToResizeRows = false;
            this.tabela_glowna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabela_glowna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_glowna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela_glowna.Location = new System.Drawing.Point(0, 0);
            this.tabela_glowna.Name = "tabela_glowna";
            this.tabela_glowna.ReadOnly = true;
            this.tabela_glowna.RowHeadersVisible = false;
            this.tabela_glowna.RowTemplate.Height = 24;
            this.tabela_glowna.Size = new System.Drawing.Size(564, 488);
            this.tabela_glowna.TabIndex = 9;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer3.Panel1.Controls.Add(this.tabcia_stat);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer3.Panel2.Controls.Add(this.wykres);
            this.splitContainer3.Size = new System.Drawing.Size(310, 488);
            this.splitContainer3.SplitterDistance = 277;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabcia_stat
            // 
            this.tabcia_stat.AllowUserToAddRows = false;
            this.tabcia_stat.AllowUserToResizeRows = false;
            this.tabcia_stat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabcia_stat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabcia_stat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcia_stat.Location = new System.Drawing.Point(0, 0);
            this.tabcia_stat.Name = "tabcia_stat";
            this.tabcia_stat.ReadOnly = true;
            this.tabcia_stat.RowHeadersVisible = false;
            this.tabcia_stat.RowTemplate.Height = 24;
            this.tabcia_stat.Size = new System.Drawing.Size(310, 277);
            this.tabcia_stat.TabIndex = 0;
            this.tabcia_stat.Visible = false;
            // 
            // wykres
            // 
            this.wykres.BorderlineColor = System.Drawing.Color.Black;
            this.wykres.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.wykres.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.wykres.BorderSkin.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea1);
            this.wykres.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.wykres.Legends.Add(legend1);
            this.wykres.Location = new System.Drawing.Point(0, 0);
            this.wykres.Name = "wykres";
            this.wykres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.wykres.Series.Add(series1);
            this.wykres.Size = new System.Drawing.Size(310, 207);
            this.wykres.TabIndex = 0;
            this.wykres.Text = "wykres";
            this.wykres.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 13);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // zapiszStatystykiJakocsvToolStripMenuItem
            // 
            this.zapiszStatystykiJakocsvToolStripMenuItem.Name = "zapiszStatystykiJakocsvToolStripMenuItem";
            this.zapiszStatystykiJakocsvToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.zapiszStatystykiJakocsvToolStripMenuItem.Text = "Zapisz statystyki jako .csv";
            this.zapiszStatystykiJakocsvToolStripMenuItem.ToolTipText = "Zapisz statystyki w formacie .csv";
            this.zapiszStatystykiJakocsvToolStripMenuItem.Click += new System.EventHandler(this.zapiszStatystykiJakocsvToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 555);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KWESTi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_glowna)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcia_stat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaAnkietaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szkołaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwestionariuszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaSesjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.DataGridView tabela_glowna;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneJakocsvToolStripMenuItem;
        public System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.DataGridView tabcia_stat;
        public System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.ToolStripMenuItem zapiszStatystykiJakocsvToolStripMenuItem;
    }
}