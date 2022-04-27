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
    public partial class KupacPrikazNarudzbi : Form
    {
        public KupacPrikazNarudzbi()
        {
            InitializeComponent();
            PrikaziNarudzbe();
        }

        String konekStr = LoginForma.konekcioniString;
        String kupacId = LoginForma.kupacID;
       
        private void buttonPrikaziStavke_Click(object sender, EventArgs e)
        {
            PrikaziStavke();
            PrikaziUkupno();
        }

        private void PrikaziNarudzbe()
        {
            string query = "SELECT narudzbenica_id as 'Sifra narudzbe', datum_narudzbe as 'Datum narudzbe' FROM narudzbenica WHERE kupac_id= '" + kupacId + "' ";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);

            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataAdapter.Dispose();

            konekcija.Close();
        }

        private void PrikaziStavke()
        {
            string query = "SELECT narudzbenica_id as 'Sifra narudzbe', artikal.artikal_id as 'Sifra artikla', cijena as 'Cijena', " + 
                " kolicina as 'Kolicina' FROM stavka_narudzbenice, artikal WHERE artikal.artikal_id=stavka_narudzbenice.artikal_id and " +
                " narudzbenica_id= '" + Convert.ToInt32(textBoxId.Text) + "' ";

            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);

            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView2.DataSource = tabela;
            dataAdapter.Dispose();

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

        private void KupacPrikazNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kreiranjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            KupacKreiranjeNarudzbe kkn = new KupacKreiranjeNarudzbe();
            kkn.Show();
        }
    }
}
