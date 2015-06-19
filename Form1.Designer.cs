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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaSesjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaAnkietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwestionariuszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabela_glowna = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
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
            this.nowaAnkietaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaSesjaToolStripMenuItem
            // 
            this.nowaSesjaToolStripMenuItem.Name = "nowaSesjaToolStripMenuItem";
            this.nowaSesjaToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.nowaSesjaToolStripMenuItem.Text = "Nowa sesja";
            this.nowaSesjaToolStripMenuItem.Click += new System.EventHandler(this.nowaSesjaToolStripMenuItem_Click);
            // 
            // nowaAnkietaToolStripMenuItem
            // 
            this.nowaAnkietaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szkołaToolStripMenuItem,
            this.pracaToolStripMenuItem});
            this.nowaAnkietaToolStripMenuItem.Name = "nowaAnkietaToolStripMenuItem";
            this.nowaAnkietaToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.nowaAnkietaToolStripMenuItem.Text = "Nowa ankieta";
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
            // 
            // wykresyToolStripMenuItem
            // 
            this.wykresyToolStripMenuItem.Name = "wykresyToolStripMenuItem";
            this.wykresyToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.wykresyToolStripMenuItem.Text = "Wykresy";
            // 
            // tabela_glowna
            // 
            this.tabela_glowna.AllowUserToOrderColumns = true;
            this.tabela_glowna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_glowna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela_glowna.Location = new System.Drawing.Point(0, 28);
            this.tabela_glowna.Name = "tabela_glowna";
            this.tabela_glowna.RowTemplate.Height = 24;
            this.tabela_glowna.Size = new System.Drawing.Size(1003, 527);
            this.tabela_glowna.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 555);
            this.Controls.Add(this.tabela_glowna);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KWESTi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        public System.Windows.Forms.DataGridView tabela_glowna;
    }
}