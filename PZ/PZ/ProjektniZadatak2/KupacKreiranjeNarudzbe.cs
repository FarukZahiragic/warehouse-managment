using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjektniZadatak;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class KupacKreiranjeNarudzbe : Form
    {
        public KupacKreiranjeNarudzbe()
        {
            InitializeComponent();
        }

        String konekStr = LoginForma.konekcioniString;
        String kupacId = LoginForma.kupacID;
        public static String narudzbenicaId;
        public static String kolicinaArtikla;

        private void KupacKreiranjeNarudzbe_Load(object sender, EventArgs e)
        {
            PrikazArtikala();
        }

        private void buttonKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO narudzbenica(kupac_id, datum_narudzbe) VALUES('" +kupacId+ "', '" +DateTime.Now.ToString("yyyy-MM-dd")+ "')";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlCommand cmd = new MySqlCommand(query, konekcija);

            cmd.ExecuteNonQuery();

            konekcija.Close();

            DobijBrojNarudzbenice();
            PrikazStavkiNarudzbenice();
            PrikaziUkupno();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DobijTrenutnuKolicinu();
            string query = "INSERT INTO stavka_narudzbenice(narudzbenica_id, artikal_id, kolicina) VALUES( '" +Convert.ToInt32(narudzbenicaId)+ "', '" + textBoxID.Text + "', '" + textBoxKol.Text + "');" +
                " UPDATE skladiste SET kolicina_stanje = kolicina_stanje - '" +Convert.ToInt32(textBoxKol.Text)+ "' WHERE artikal_id = '" +Convert.ToInt32(textBoxID.Text)+ "' ";
            try
            {
                if (Convert.ToInt32(textBoxKol.Text) <= Convert.ToInt32(kolicinaArtikla))
                {
                    MySqlConnection konekcija = new MySqlConnection(konekStr);
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand(query, konekcija);

                    int uneseno = cmd.ExecuteNonQuery();

                    if (uneseno == 0) MessageBox.Show("Niste unijeli validnu količinu i/ili ID artikla!");

                    konekcija.Close();

                    PrikazStavkiNarudzbenice();
                    PrikaziUkupno();
                }
                else {
                    MessageBox.Show("Odabrali ste veću količinu artikla nego što je dostupna!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            int izvrsenUpit = 0;
            String query = "DELETE FROM stavka_narudzbenice WHERE artikal_id = '" + Convert.ToInt32(textBoxID.Text) + "' and " +
                "kolicina = '" + Convert.ToInt32(textBoxKol.Text) + "' ";
            String query2 = "UPDATE skladiste SET kolicina_stanje = kolicina_stanje + '" + Convert.ToInt32(textBoxKol.Text) + "' WHERE artikal_id = '" + Convert.ToInt32(textBoxID.Text) + "' ";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlCommand cmd = new MySqlCommand(query, konekcija);

            izvrsenUpit = cmd.ExecuteNonQuery();

            konekcija.Close();

            PrikazStavkiNarudzbenice();
            PrikaziUkupno();

            if (izvrsenUpit != 0) {
                MySqlConnection con = new MySqlConnection(konekStr);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
            }

            izvrsenUpit = 0;
        }

        private void PrikazArtikala()
        {
            string query = "SELECT naziv_artikla AS 'Naziv artikla', kolicina_stanje 'Dostupna količina' FROM artikal, skladiste WHERE artikal.artikal_id=skladiste.artikal_id";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);

            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataAdapter.Dispose();

            konekcija.Close();
        }

        private void PrikazStavkiNarudzbenice()
        {
            string query = "SELECT artikal.artikal_id as 'Sifra artikla', naziv_artikla as 'Naziv artikla', cijena as 'Cijena artikla', kolicina as 'Kolicina' FROM artikal, stavka_narudzbenice WHERE " + 
                " artikal.artikal_id=stavka_narudzbenice.artikal_id and narudzbenica_id = '" +narudzbenicaId+ "' ";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);

            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView2.DataSource = tabela;
            dataAdapter.Dispose();

            konekcija.Close();
        }

        private void DobijBrojNarudzbenice()
        {
            string query = "SELECT MAX(narudzbenica_id) FROM narudzbenica";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlCommand cmd = new MySqlCommand(query, konekcija);

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            narudzbenicaId = reader[0].ToString();
            reader.Close();
            konekcija.Close();
        }

        private void DobijTrenutnuKolicinu()
        {
            String query = "SELECT kolicina_stanje FROM skladiste";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlCommand cmd = new MySqlCommand(query, konekcija);

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            kolicinaArtikla = reader[0].ToString();
            reader.Close();
            konekcija.Close();
        }

        private void PrikaziUkupno() 
        {
            int suma = 0;
            int cijenaStavke = 1;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                cijenaStavke = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                suma += cijenaStavke;
            }
            textBoxTotal.Text = suma.ToString();
        }

        private void KupacKreiranjeNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void prikazNarudžbiIStavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            KupacPrikazNarudzbi kpn = new KupacPrikazNarudzbi();
            kpn.Show();
        }

        private void meniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
