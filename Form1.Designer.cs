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
            this.nowaAnkietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwestionariuszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.nowaAnkietaToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 527);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ankieta";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KWESTi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}