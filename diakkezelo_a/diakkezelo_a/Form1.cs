using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diakkezelo_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }

        class Diak
        {
            public string nev { get; private set; }
            public string kod { get; private set; }
            public int szulEv { get; private set; }

            public Diak(string nev, string kod, int szulEv)
            {
                this.nev = nev;
                this.kod = kod;
                this.szulEv = szulEv;
            }

            public override string ToString()
            {
                return $"{nev} ({kod})";
            }
        }

        private List<Diak> diakok = new List<Diak>();
        private List<CheckBox> chkBoxok = new List<CheckBox>(); 

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
        }

        private void AdatBevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBeolvasas(sr);
                    FelrakDiakok();
                    GombBeallitas(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }

        private void AdatBeolvasas(StreamReader sr)
        {
            string adat;

            while (!sr.EndOfStream)
            {
                adat = sr.ReadLine();
                Feldolgoz(adat);
            }
            sr.Close();
        }

        private void Feldolgoz(string adat)
        {
            // Az adatfájl szerkezet:
            // Hegedűs Emma;HEEMAB.PTE;1990

            string[] adatok = adat.Split(';');

            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        private int kezdoX = 10;
        private int kezdoY = 10;
        private int chYkoz = 30;

        private void FelrakDiakok()
        {
            CheckBox chkBox;
            for (int i = 0; i < diakok.Count; i++)
            {
                chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdoX, kezdoY + i * chYkoz);
                chkBox.Text = diakok[i].ToString();

                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }
            if (!vanValasztott)
            {
                MessageBox.Show("Senkit sem választott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int min = (lstKivalasztottak.Items[0] as Diak).szulEv;
            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.szulEv < min) min = diak.szulEv;
            }

            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if(diak.szulEv == min) lstLegidosebbek.Items.Add(diak);
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {

            Diak diak = (Diak)lstKivalasztottak.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.szulEv;
        }
    }
}