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
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        public static String employeeID;
        public static String konekcioniString = "Server=192.168.2.191; Port=3306; " +
            "Database=baza_ppj; Uid=ucenik; Pwd=ucenik";

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            String korisnickoIme = textBoxKorisnickoIme.Text;
            String sifra = textBoxSifra.Text;

            String query = "SELECT pass, CONCAT(ime, ' ', prezime), " +
                " kupac_id FROM kupac WHERE user ='" + korisnickoIme + "' ";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);

                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(query, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    errorProvider1.SetError(textBoxKorisnickoIme, "Pogrešno korisničko ime !!!");
                }
                else
                {
                    String passwd = reader[0].ToString();
                    String imePrez = reader[1].ToString();
                    employeeID = reader[2].ToString();

                    if (sifra == passwd)
                    {
                        MessageBox.Show("Uspješno ste logovani " + imePrez);
                        //PostaviStatusLogin();
                        //Form2 fr2 = new Form2();
                        this.Hide();
                        //fr2.Show();
                    }
                    else
                    {
                        errorProvider1.SetError(textBoxSifra, "Pogrešan password !!!");
                    }
                }

                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
