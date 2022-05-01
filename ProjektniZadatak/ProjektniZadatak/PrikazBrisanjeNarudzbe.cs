using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjektniZadatak
{
    public partial class PrikazBrisanjeNarudzbe : Form
    {
        public PrikazBrisanjeNarudzbe()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrikazNarudzbe();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 120;
            }
        }

        void PrikazNarudzbe() {

            try
            {
                String query = "SELECT narudzbenica.narudzbenica_id as'ID', artikal.artikal_id as 'ID artikla',naziv_artikla as 'Naziv',vrsta_artikla as 'Vrsta', cijena as 'Cijena', kolicina as 'Kolicina', ime as 'Ime', prezime as 'Prezime', datum_narudzbe as 'Datum narudzbe' " +
" FROM narudzbenica, stavka_narudzbenice, kupac, artikal "+
" WHERE narudzbenica.narudzbenica_id=stavka_narudzbenice.narudzbenica_id AND "+
" stavka_narudzbenice.artikal_id= artikal.artikal_id AND "+
" narudzbenica.kupac_id= kupac.kupac_id ";

                if (textBox1.Text != "")
                {
                    query += " and narudzbenica.narudzbenica_id= " + textBox1.Text + " ";
                }

                MySqlConnection konekcija = new MySqlConnection(AdminKreiranjeKupca.konekStr);

                konekcija.Open();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);

                DataTable tabela = new DataTable();

                dataAdapter.Fill(tabela);

                dataGridView1.DataSource = tabela;

                dataAdapter.Dispose();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void dodavanjeAzuriranjeKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminKreiranjeKupca adminkupac = new AdminKreiranjeKupca();
            adminkupac.Show();
        }

        private void dodavanjeAzuriranjeArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminDodavanjeArtikala adminartikal = new AdminDodavanjeArtikala();
            adminartikal.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrisanjeNarudzbe();
        }

        private void BrisanjeNarudzbe() {

           try
            {

                MySqlConnection konekcija = new MySqlConnection(AdminKreiranjeKupca.konekStr);
                konekcija.Open();

                int i = 0, a = 0,b=0,c=0;


                for (i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    a = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    b = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    String upit2 = "UPDATE skladiste SET kolicina_stanje=kolicina_stanje+ '" +b  + "' WHERE artikal_id='" + a + "'";
                    MySqlCommand cmd2 = new MySqlCommand(upit2, konekcija);
                    cmd2.ExecuteNonQuery();
                    a = 0;
                    b = 0;
                }


                String upit3 = "SET FOREIGN_KEY_CHECKS = 0; DELETE FROM narudzbenica WHERE narudzbenica.narudzbenica_id= " + textBox1.Text + " ";
                MySqlCommand cmd3 = new MySqlCommand(upit3, konekcija);
                cmd3.ExecuteNonQuery();

                String upit4 = "SET FOREIGN_KEY_CHECKS = 0; DELETE FROM stavka_narudzbenice WHERE narudzbenica_id= " + textBox1.Text + " ";
                MySqlCommand cmd4 = new MySqlCommand(upit4, konekcija);
                cmd4.ExecuteNonQuery();

                String upit5 = "SET FOREIGN_KEY_CHECKS = 1;";
                MySqlCommand cmd5 = new MySqlCommand(upit5, konekcija);
                cmd5.ExecuteNonQuery();
                BrisanjeTextBox();

                MessageBox.Show("Narudzba uspjesno izbrisana");
                PrikazNarudzbe();
                konekcija.Close();







            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void BrisanjeTextBox() {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrikazNarudzbe();
        }

    }
}
