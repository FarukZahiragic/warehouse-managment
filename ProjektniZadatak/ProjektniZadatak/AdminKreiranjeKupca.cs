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
    public partial class AdminKreiranjeKupca : Form
    {
        public AdminKreiranjeKupca()
        {
            InitializeComponent();
        }
        public static String konekStr = "Server=localhost; Port=3306; " +
            "Database=baza_ppj; Uid=root; Pwd=";

        private void PrikazKupaca() {
            try
            {
                String query = "SELECT kupac_id AS 'ID zaposlenika', ime AS 'Ime'," +
                    " prezime AS 'Prezime', grad AS 'Grad', adresa AS 'Adresa', " +
                    " telefon AS 'telefonski broj', user AS 'Korisnicko ime', pass AS 'Lozinka' " +
                    " FROM kupac ";


                if (textBox1.Text != "")
                {
                    query += "WHERE kupac.ime LIKE '" + textBox1.Text + "%' ";
                }
                if (textBox2.Text != "" && textBox1.Text=="")
                {
                    query += "WHERE kupac.prezime LIKE '" + textBox2.Text + "%' ";
                }


                query += " ORDER BY kupac_id ASC ";

                MySqlConnection konekcija = new MySqlConnection(konekStr);

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
            PrikazKupaca();
        }

        private void AdminKreiranjeKupca_Load(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {

                String query = "SELECT `user` FROM kupac ";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                int a = 0;
                while (reader.Read())
                {
                    if (textBox8.Text == reader[0].ToString())
                    {
                        MessageBox.Show("Neko se vec prijavio sa ovim korisnickim imenom");
                        a = 1;
                        break;
                    }
                }

                reader.Close();


                if (a == 0) {
                    String upit = "INSERT INTO kupac(kupac.ime, kupac.prezime, kupac.grad, kupac.adresa, kupac.telefon, kupac.`user`, kupac.pass) VALUES('" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "') ";
                    MySqlCommand cmd2 = new MySqlCommand(upit, konekcija);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Korisnik uspjesno dodan");
                    PrikazKupaca();
                    BrisanjeTextBox();
                }
                konekcija.Close();
              
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void BrisanjeTextBox() {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT `user` FROM kupac ";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                int a = 0;
                while (reader.Read())
                {
                    if (textBox8.Text == reader[0].ToString())
                    {
                        MessageBox.Show("Neko vec posjeduje ovo korisnicko ime");
                        a = 1;
                        break;
                    }
                }

                reader.Close();

                if (a == 0) {
                    String upit = "UPDATE kupac " +
                "SET ime='" + textBox3.Text + "' , prezime='" + textBox4.Text + "',  grad='" + textBox5.Text + "', adresa='" + textBox6.Text + "', telefon='" + textBox7.Text + "', `user`='" + textBox8.Text + "', pass='" + textBox9.Text + "' " +
                "WHERE kupac_id='" + textBox10.Text + "' ";

                    MySqlCommand cmd2 = new MySqlCommand(upit, konekcija);

                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Podaci za korisnika ID=" + textBox10.Text + " su azurirani!!!");
                    BrisanjeTextBox();
                    PrikazKupaca();
                
                }


                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void PopuniTextBox() {
            try
            {
                String upit = "SELECT ime, prezime, grad, adresa, telefon, `user`, pass FROM kupac WHERE kupac_id='"+textBox10.Text+"' ";

                MySqlConnection konekcija = new MySqlConnection(konekStr);
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
                    textBox7.Text = reader[4].ToString();
                    textBox8.Text = reader[5].ToString();
                    textBox9.Text = reader[6].ToString();
                }
                else {
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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            PopuniTextBox();
        }

        private void dodavanjeAžuriranjeArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminDodavanjeArtikala adminartikal = new AdminDodavanjeArtikala();
            adminartikal.Show();
        }


    }
}
