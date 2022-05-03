using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;

namespace ProjektniZadatak
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        public static String konekcioniString = "Server=localhost; Port=3306; " +
            "Database=baza_ppj; Uid=root; Pwd=root";

        public static String kupacID;

        private void buttonPrijava_Click_1(object sender, EventArgs e)
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
                    String pass = reader[0].ToString();
                    String imePrezime = reader[1].ToString();
                    kupacID = reader[2].ToString();

                    if (sifra == pass)
                    {
                        if (kupacID == "1")
                        {
                            MessageBox.Show("Uspješno ste logovani " + imePrezime + " kao administrator.");
                            AdminKreiranjeKupca krk = new AdminKreiranjeKupca();
                            this.Hide();
                            krk.Show();
                        }
                        else
                        {
                            MessageBox.Show("Uspješno ste logovani " + imePrezime + " kao kupac.");
                            KupacKreiranjeNarudzbe kkn = new KupacKreiranjeNarudzbe();
                            this.Hide();
                            kkn.Show();
                            
                        }
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

        private void LoginForma_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}