namespace WindowsFormsApplication1
{
    partial class KupacKreiranjeNarudzbe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazNarudžbiIStavkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonKreirajNarudzbu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxKol = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeNarudžbeToolStripMenuItem,
            this.prikazNarudžbiIStavkiToolStripMenuItem});
            this.meniToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            this.meniToolStripMenuItem.Click += new System.EventHandler(this.meniToolStripMenuItem_Click);
            // 
            // kreiranjeNarudžbeToolStripMenuItem
            // 
            this.kreiranjeNarudžbeToolStripMenuItem.Name = "kreiranjeNarudžbeToolStripMenuItem";
            this.kreiranjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.kreiranjeNarudžbeToolStripMenuItem.Text = "Kreiranje narudžbe";
            // 
            // prikazNarudžbiIStavkiToolStripMenuItem
            // 
            this.prikazNarudžbiIStavkiToolStripMenuItem.Name = "prikazNarudžbiIStavkiToolStripMenuItem";
            this.prikazNarudžbiIStavkiToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.prikazNarudžbiIStavkiToolStripMenuItem.Text = "Prikaz narudžbi i stavki";
            this.prikazNarudžbiIStavkiToolStripMenuItem.Click += new System.EventHandler(this.prikazNarudžbiIStavkiToolStripMenuItem_Click);
            // 
            // buttonKreirajNarudzbu
            // 
            this.buttonKreirajNarudzbu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKreirajNarudzbu.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonKreirajNarudzbu.Location = new System.Drawing.Point(535, 23);
            this.buttonKreirajNarudzbu.Name = "buttonKreirajNarudzbu";
            this.buttonKreirajNarudzbu.Size = new System.Drawing.Size(136, 31);
            this.buttonKreirajNarudzbu.TabIndex = 0;
            this.buttonKreirajNarudzbu.Text = "Kreiraj narudžbu";
            this.buttonKreirajNarudzbu.UseVisualStyleBackColor = false;
            this.buttonKreirajNarudzbu.Click += new System.EventHandler(this.buttonKreirajNarudzbu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pregled artikala";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 316);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDodaj.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonDodaj.Location = new System.Drawing.Point(535, 270);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(67, 26);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonObrisi.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonObrisi.Location = new System.Drawing.Point(535, 301);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(67, 23);
            this.buttonObrisi.TabIndex = 2;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(532, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Korpa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(618, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(675, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "KOL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(574, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(715, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "KM";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(604, 289);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(48, 22);
            this.textBoxID.TabIndex = 10;
            // 
            // textBoxKol
            // 
            this.textBoxKol.Location = new System.Drawing.Point(668, 289);
            this.textBoxKol.Name = "textBoxKol";
            this.textBoxKol.Size = new System.Drawing.Size(52, 22);
            this.textBoxKol.TabIndex = 11;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(622, 333);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(89, 22);
            this.textBoxTotal.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(536, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(457, 166);
            this.dataGridView2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.textBoxKol);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonObrisi);
            this.groupBox1.Controls.Add(this.buttonDodaj);
            this.groupBox1.Controls.Add(this.buttonKreirajNarudzbu);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 371);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreiranje narudžbe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // KupacKreiranjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KupacKreiranjeNarudzbe";
            this.Text = "Kreiranje narudžbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KupacKreiranjeNarudzbe_FormClosed);
            this.Load += new System.EventHandler(this.KupacKreiranjeNarudzbe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazNarudžbiIStavkiToolStripMenuItem;
        private System.Windows.Forms.Button buttonKreirajNarudzbu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxKol;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}