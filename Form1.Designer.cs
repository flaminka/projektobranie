namespace PROJEKT_CSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaSesjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaAnkietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwestionariuszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabela_glowna = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.zapiszDaneJakocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_glowna)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kwestionariuszToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaSesjaToolStripMenuItem,
            this.nowaAnkietaToolStripMenuItem,
            this.zapiszDaneJakocsvToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaSesjaToolStripMenuItem
            // 
            this.nowaSesjaToolStripMenuItem.Name = "nowaSesjaToolStripMenuItem";
            this.nowaSesjaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
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
            this.nowaAnkietaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
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
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
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
            this.statystykiToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.statystykiToolStripMenuItem.Text = "Statystyki";
            this.statystykiToolStripMenuItem.ToolTipText = "Policz statystyki dla danych";
            this.statystykiToolStripMenuItem.Click += new System.EventHandler(this.statystykiToolStripMenuItem_Click);
            // 
            // wykresyToolStripMenuItem
            // 
            this.wykresyToolStripMenuItem.Name = "wykresyToolStripMenuItem";
            this.wykresyToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.wykresyToolStripMenuItem.Text = "Wykresy";
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
            this.splitContainer1.Size = new System.Drawing.Size(1003, 527);
            this.splitContainer1.SplitterDistance = 498;
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
            this.splitContainer2.Size = new System.Drawing.Size(1003, 498);
            this.splitContainer2.SplitterDistance = 631;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabela_glowna
            // 
            this.tabela_glowna.AllowUserToOrderColumns = true;
            this.tabela_glowna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_glowna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela_glowna.Location = new System.Drawing.Point(0, 0);
            this.tabela_glowna.Name = "tabela_glowna";
            this.tabela_glowna.RowTemplate.Height = 24;
            this.tabela_glowna.Size = new System.Drawing.Size(631, 498);
            this.tabela_glowna.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1003, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // zapiszDaneJakocsvToolStripMenuItem
            // 
            this.zapiszDaneJakocsvToolStripMenuItem.Name = "zapiszDaneJakocsvToolStripMenuItem";
            this.zapiszDaneJakocsvToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.zapiszDaneJakocsvToolStripMenuItem.Text = "Zapisz dane jako .csv";
            this.zapiszDaneJakocsvToolStripMenuItem.Click += new System.EventHandler(this.zapiszDaneJakocsvToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_glowna)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneJakocsvToolStripMenuItem;
    }
}