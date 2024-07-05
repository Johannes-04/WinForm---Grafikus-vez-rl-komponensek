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

namespace pizzeria
{
    public partial class PizzaForm : Form
    {
        private bool lathato;

        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak= new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        public PizzaForm()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "";
            lathato = false;
            LathatossagBeallitasa(lathato);
        }

        private void LathatossagBeallitasa(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arKicsi, int arNagy)
            {
                Nev = nev;
                ArKicsi = arKicsi;
                ArNagy = arNagy;
            }

            public override string ToString()
            {
                return this.Nev;
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
            string[] adatok = adat.Split(';');
            pizzak.Add(new Pizza(adatok[0], int.Parse(adatok[1]), int.Parse(adatok[2])));
        }

        private int bal = 20, fent = 10;
        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 400;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 40;
        private int meretDb = 50;
        private int koz = 3;
         
        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;
            Label labelDarab;

            for (int i = 0; i < pizzak.Count; i++)
            {
                // checkBox felrakás
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY);
                checkBox.Size = new Size(meretChk, meretY);
                checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                 
                // a most beállított jelölőnégyzetet hozzáadjuk
                // a jelölő négyzetek listájához
                jeloloNegyzetek.Add(checkBox);
                pnlKozponti.Controls.Add(checkBox);

                // panel felrakása
                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);

                // A panelt rárakjuk a központi panelre
                pnlKozponti.Controls.Add(panel);

                // radiobtn kicsi ár felrakása
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleLeft;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0, 0);
                rdBtnKicsiArak.Add(radioButton);

                // A rádiógombot rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(radioButton);

                // Fix Ft felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr + koz, 0);
                label.Size = new Size(meretFt * 2, meretY);
                panel.Controls.Add(label);

                // radiobtn nagy ár
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArNagy.ToString();
                radioButton.Location = new Point(meretAr + meretFt * 2 + koz * 2, 0);
                rdBtnNagyArak.Add(radioButton);

                // A rádiógombot rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(radioButton);

                // Fix Ft felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr * 2 + meretFt * 2 + koz * 3, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

                // tetxBox darabszám
                textBox = new TextBox();
                textBox.Size = new Size(meretDb, meretY);
                textBox.Location = new Point(meretAr * 2 + meretFt * 4 + koz * 4, 0);
                txtDarabok.Add(textBox);

                // A texBox-ott rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(textBox);

                // Fix darab felirat
                labelDarab = new Label();
                labelDarab.TextAlign = ContentAlignment.MiddleLeft;
                labelDarab.Text = " darab";
                labelDarab.Location = new Point(meretAr * 2 + meretFt * 4 + meretDb + koz * 5, 0);
                labelDarab.Size = new Size(meretDb, meretY);
                panel.Controls.Add(labelDarab);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox valasztoGomb = (CheckBox)sender;
            // megállapítjuk, hogy melyik sorszámú jelölőnégyzetetr
            // választottuk
            int index = jeloloNegyzetek.IndexOf(valasztoGomb);

            if(valasztoGomb.Checked)
            {
                rdBtnNagyArak[index].Checked = true;
            }
            else
            {
                rdBtnKicsiArak[index].Checked = false;
                rdBtnNagyArak[index].Checked = false;
            }

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

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            bool vanKijeloles = false;
            int db, osszeg = 0, ar = 0;

            for (int i = 0; i < jeloloNegyzetek.Count; i++)
            {
                if (jeloloNegyzetek[i].Checked)
                {
                    vanKijeloles = true;
                    try
                    {
                        if (rdBtnKicsiArak[i].Checked) ar = pizzak[i].ArKicsi;
                        else if (rdBtnNagyArak[i].Checked) ar = pizzak[i].ArNagy;
                        else throw new MissingFieldException();

                        db = int.Parse(txtDarabok[i].Text);

                        if (db < 0) throw new Exception();
                        txtDarabok[i].BackColor = Color.White;
                        osszeg += ar * db;
                    }
                    catch (MissingFieldException)
                    {
                        MessageBox.Show("Nem választott méretet", "Hiba");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hibásan adat meg a darabszámot", "Hiba");
                        txtDarabok[i].BackColor= Color.Coral;
                        txtDarabok[i].Clear();
                    }
                }
            }
            if (!vanKijeloles) MessageBox.Show("Nincs kijelölve semmi", "Figyelmeztetés");
            else txtFizetendo.Text = osszeg + " Ft";

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBeolvasas(sr);

                    // Ez a metódus tölti fel a vezérlőeleemeket
                    ValasztekFeltoltes();

                    // A láthatóság
                    lathato = true;
                    LathatossagBeallitasa(lathato);
                    btnAdatBe.Visible = false;
                    // Leszedjük a háttérképet.
                    this.BackgroundImage = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
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

        
    }
}
