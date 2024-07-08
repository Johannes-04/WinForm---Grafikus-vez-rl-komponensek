using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diakkezelo_b
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

        private List<Button> btnEvek = new List<Button>();
        private List<int> evek = new List<int>();

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
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
            lstDiakok.Items.Add(diak);
            if(!evek.Contains(diak.szulEv)) evek.Add(diak.szulEv);
            FelrakEvek();

        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            AdatBevitel();
        }

        private int kezdoX = 10;
        private int kezdoY = 10;
        private int btnXKoz = 80;

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort();
            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();

                btn.Click += new System.EventHandler(Kivalaszt);

                pnlEvek.Controls.Add(btn);
                btnEvek.Add(btn);
            }
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            int ev = int.Parse((sender as Button).Text);

            lstEredmeny.Items.Clear();
            foreach (Diak diak in lstDiakok.Items)
            {
                if (diak.szulEv == ev) lstEredmeny.Items.Add(diak);
            }

        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {

            Diak diak = (Diak)lstEredmeny.SelectedItem;
            if (diak != null) lblDiak.Text = diak + ", születési éve: " + diak.szulEv;
        }
    }
}
