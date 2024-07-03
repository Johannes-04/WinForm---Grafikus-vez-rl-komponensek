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

namespace pizzeria_proba
{
    public partial class Form1 : Form
    {
        // konstruktor
        public Form1()
        {
            // A generált inicializálás.
            // Tartalma megnézhető a Form1.Designer.cs fájlban.

            InitializeComponent();

            // Beállítjuk a fájldialógust aktuális mappáját (ez jeleneik meg megnyitáskor)
            // és a keresés során felkínált fájlnevet.

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LathatossagBeallitasa(false);
        }


        private void LathatossagBeallitasa(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        private int meretKicsi = 32, meretNagy = 45;
        private List<Pizza> pizzak = new List<Pizza>();


        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNAgy { get; set; }

            public Pizza(string nev, int arKicsi, int arNAgy)
            {
                Nev = nev;
                ArKicsi = arKicsi;
                ArNAgy = arNAgy;
            }

            public override string ToString()
            {
                return this.Nev;
            }
        }


        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            try
            {
                AdatBevitel();
                ElemekMegjelenitese();
                LathatossagBeallitasa(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }

        private void AdatBevitel()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    String fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBeolvasas(sr);
                }
                catch
                {
                    MessageBox.Show("Adatbevitel hiba", "Hiba");
                }
                finally
                {
                    if(sr != null)
                    {
                        sr.Close();
                    }
                }
            }

            /*
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    AdatBeolvasas(fajlNev);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }*/
        }

        private void AdatBeolvasas(StreamReader sr)
        {
            string adat;

            while (!sr.EndOfStream)
            {
                adat = sr.ReadLine();
                Feldolgoz(adat);
            } sr.Close();
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }

        private void ElemekMegjelenitese()
        {
            lblKicsi.Text = meretKicsi + " cm";
            lblNagy.Text = meretNagy + " cm";

            checkBox1.Text = pizzak[0].Nev;
            rdBtn1Kicsi.Text = pizzak[0].ArKicsi + " Ft";
            rdBtn1Nagy.Text = pizzak[0].ArNAgy + " Ft";

            checkBox2.Text = pizzak[1].Nev;
            rdBtn2Kicsi.Text = pizzak[1].ArKicsi + " Ft";
            rdBtn2Nagy.Text = pizzak[1].ArNAgy + " Ft";
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                int osszeg = 0, ar = 0, db = 0;

                // Ha az első pizzát választottuk
                if (checkBox1.Checked)
                {
                    // ha az első fajtát választottuk
                    if (rdBtn1Kicsi.Checked) ar = pizzak[0].ArKicsi;
                    // ha a második fajtátt választottuk
                    else if (rdBtn1Nagy.Checked) ar = pizzak[0].ArNAgy;
                    // ha egyáltalán nem választottunk
                    else throw new MissingFieldException("Válasszon méretet");

                    // ide már csak akkor jut, ha tényleg választottunk, ezért
                    // kiolvashatja a db értékét. Ha hibás formátumot adunk meg 
                    // (üres vagy nem égesz szám), akkor FormatException kivételt dob.

                    db = int.Parse(txtDb1.Text);

                    // azt is vizsgálni kell, hogy nem írtunk-e negatív értéket.
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;
                }

                // Ha a második pizzát választottuk
                if (checkBox2.Checked)
                {
                    // ha az első fajtát választottuk
                    if (rdBtn2Kicsi.Checked) ar = pizzak[1].ArKicsi;
                    // ha a második fajtátt választottuk
                    else if (rdBtn2Nagy.Checked) ar = pizzak[1].ArNAgy;
                    // ha egyáltalán nem választottunk
                    else throw new MissingFieldException("Válasszon méretet");

                    // ide már csak akkor jut, ha tényleg választottunk, ezért
                    // kiolvashatja a db értékét. Ha hibás formátumot adunk meg 
                    // (üres vagy nem égesz szám), akkor FormatException kivételt dob.

                    db = int.Parse(txtDb2.Text);

                    // azt is vizsgálni kell, hogy nem írtunk-e negatív értéket.
                    if (db < 0) throw new ArgumentOutOfRangeException("Nem lehet negatív");
                    osszeg += ar * db;

                }
                // Ha egyiket sem választottuk
                if (!checkBox1.Checked && !checkBox2.Checked) throw new MissingFieldException();

                txtFizetendo.Text = osszeg + " Ft";
            }
            catch(FormatException)
            {
                MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
            }
            catch (ArgumentOutOfRangeException aox)
            {
                MessageBox.Show(aox.Message, "Hiba");
            }
            catch (MissingFieldException mex)
            {
                MessageBox.Show(mex.Message, "Hiba");
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            //Végigmegyünk a felületre tett vezérlőelemek
            foreach (Control item in this.Controls)
            {
                // Töröljük a checkBox-ok kijelölését
                if (item is CheckBox) (item as CheckBox).Checked = false;
                // Töröljük a textBox-ok kijelölését
                // csak azért szerepel kétféle típuskényszerítés, hogy mindkettőre lássonpéldát
                if (item is TextBox) ((TextBox)item).Clear();

                // A rádiógombok nem közvetlenül a form-on vannak, ezért a panel,
                // ill. groupBox gyerekeit kell vizsgálnunk.
                if (item.HasChildren)
                {
                    foreach (Control gyerek in item.Controls)
                    {
                        if (gyerek is RadioButton) (gyerek as RadioButton).Checked = false;
                    }
                }
            }
        }
    }
}
