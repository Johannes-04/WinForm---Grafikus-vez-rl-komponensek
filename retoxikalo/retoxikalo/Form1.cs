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

namespace retoxikalo
{
    public partial class Form1 : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image> ();
        private int kepekSzama = 10;

        private ItalLapForm italForm = new ItalLapForm();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "konyveles.txt";
        }

        // A képek csak egyszer akarjuk betölteni, ezért van itt a helye
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch
            {
                MessageBox.Show("Hiba a képek létrehozásakor", "Hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 0; i < kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        //Megnyitás menüpont
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBevitel(sr);

                    ItallapMenuItem.Enabled = true;
                    SaveMenuItem.Enabled = true;

                    italForm.ArlapotIr(italok);
                    italForm.Show();
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

        private void AdatBevitel(StreamReader sr)
        {
            string sor = sr.ReadLine();
            string[] adatok;
            while (sor != null)
            {
                adatok = sor.Split(';');
                // Kupica kisüsti szilva pálinka;200

                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = sr.ReadLine();
            }
        }

        // Ittalap menüpont
        private void ItallapMenuItem_Click(object sender, EventArgs e)
        {
            italForm.ArlapotIr(italok);
            italForm.ShowDialog();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    sw = new StreamWriter(fajlNev);
                    FajlbaIr(sw);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "Hiba");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }

        private void FajlbaIr(StreamWriter sw)
        {
            foreach (Ital item in italok)
            {
                sw.WriteLine(item.Konyvelesbe());
            }
        }

        // Galéria menűpont
        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaleriaForm galeriaForm = new GaleriaForm();
            galeriaForm.Atad(kepek);
            galeriaForm.Show();
        }

        private void sugoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SugoForm sugoForm = new SugoForm();
            sugoForm.ShowDialog();
        }

        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fejlesztette: Mester Johanes William","Fejlesztő névjegy");
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}