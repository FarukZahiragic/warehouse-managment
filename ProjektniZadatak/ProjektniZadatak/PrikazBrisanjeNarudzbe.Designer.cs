namespace ProjektniZadatak
{
    partial class PrikazBrisanjeNarudzbe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(28, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1490, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Narudzbe:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(159, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1285, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Brisanje narudzbe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1558, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem,
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem});
            this.meniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.meniToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // dodavanjeAzuriranjeKupacaToolStripMenuItem
            // 
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.Name = "dodavanjeAzuriranjeKupacaToolStripMenuItem";
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.Size = new System.Drawing.Size(310, 28);
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.Text = "Dodavanje/ Azuriranje kupaca";
            this.dodavanjeAzuriranjeKupacaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeAzuriranjeKupacaToolStripMenuItem_Click);
            // 
            // dodavanjeAzuriranjeArtikalaToolStripMenuItem
            // 
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.Name = "dodavanjeAzuriranjeArtikalaToolStripMenuItem";
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.Size = new System.Drawing.Size(310, 28);
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.Text = "Dodavanje/ Azuriranje artikala";
            this.dodavanjeAzuriranjeArtikalaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeAzuriranjeArtikalaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1540, 416);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz/ Brisanje narudzbe";
            // 
            // PrikazBrisanjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1558, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrikazBrisanjeNarudzbe";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAzuriranjeKupacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeAzuriranjeArtikalaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}