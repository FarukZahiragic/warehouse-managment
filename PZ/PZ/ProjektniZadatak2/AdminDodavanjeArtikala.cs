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
    public partial class AdminDodavanjeArtikala : Form
    {
        public AdminDodavanjeArtikala()
        {
            InitializeComponent();
        }

        private void AdminDodavanjeArtikala_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void PrikazArtikala() {
            try
            {
                String query = "SELECT artikal.artikal_id as 'Sifra artikla', naziv_artikla as 'Naziv artikla', vrsta_artikla as 'Vrsta artikla', cijena AS 'Cijena', kolicina_stanje as 'Kolicina na stanju' " +
                               " FROM artikal, skladiste "+
                               " WHERE skladiste.artikal_id= artikal.artikal_id ";


                if (textBox1.Text != "")
                {
                    query += "and artikal.artikal_id LIKE '" + textBox1.Text + "%' ";
                }
                if (textBox2.Text != "" && textBox1.Text == "")
                {
                    query += "and artikal.naziv_artikla LIKE '" + textBox2.Text + "%' ";
                }


                query += " ORDER BY artikal.artikal_id ASC ";

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

        private void button1_Click(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                String query = "SELECT naziv_artikla FROM artikal ";
                MySqlConnection konekcija = new MySqlConnection(AdminKreiranjeKupca.konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                int a = 0;
                while (reader.Read())
                {
                    if (textBox3.Text == reader[0].ToString())
                    {
                        MessageBox.Show("Vec postoji artikal sa ovim nazivom");
                        a = 1;
                        break;
                    }
                }

                reader.Close();


                if (a == 0)
                {
                    String upit = "BEGIN; " +
                                  " INSERT INTO artikal (artikal.naziv_artikla, artikal.vrsta_artikla, artikal.cijena) "+
                                  " VALUES('"+textBox3.Text+"' , '"+textBox4.Text+"', '"+textBox5.Text+" KM'); "+
                                  " INSERT INTO skladiste (skladiste.artikal_id, skladiste.kolicina_stanje) "+
                                  " VALUES(LAST_INSERT_ID(), '" + textBox6.Text + "'); " +
                                  " COMMIT; ";
                    MySqlCommand cmd2 = new MySqlCommand(upit, konekcija);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Artikal uspjesno dodan");
                    PrikazArtikala();
                    BrisanjeTextBox();
                }
                konekcija.Close();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void BrisanjeTextBox()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            numericUpDown1.Value = 0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            PopuniTextBox();
        }

        private void PopuniTextBox() {
            try
            {
                String upit = "SELECT naziv_artikla, vrsta_artikla, cijena, kolicina_stanje "+
" FROM artikal, skladiste "+
" WHERE artikal.artikal_id=skladiste.artikal_id AND "+
" artikal.artikal_id= '"+textBox7.Text+"'";

                MySqlConnection konekcija = new MySqlConnection(AdminKreiranjeKupca.konekStr);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox3.Text = reader[0].ToString();
                    textBox4.Text = reader[1].ToString();
                    textBox5.Text = reader[2].ToString();
                    textBox6.Text = reader[3].ToString();
                }
                else
                {
                    BrisanjeTextBox();
                }


                reader.Close();
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection konekcija = new MySqlConnection(AdminKreiranjeKupca.konekStr);
                konekcija.Open();

                    String upit = "UPDATE skladiste "+
" SET kolicina_stanje= kolicina_stanje + '" + numericUpDown1.Value.ToString() + "'" +
" WHERE artikal_id= '"+textBox7.Text+"'";

                    MySqlCommand cmd2 = new MySqlCommand(upit, konekcija);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Podaci za artikal ID=" + textBox7.Text + " ("+textBox3.Text+") su azurirani!!!");
                    BrisanjeTextBox();
                    PrikazArtikala();


                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void kreiranjeAžuriranjeKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminKreiranjeKupca adminkupac = new AdminKreiranjeKupca();
            adminkupac.Show();
        }

        private void AdminDodavanjeArtikala_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void prikazBrisanjeNarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            PrikazBrisanjeNarudzbe fr2 = new PrikazBrisanjeNarudzbe();
            fr2.Show();
        }

    }
}
