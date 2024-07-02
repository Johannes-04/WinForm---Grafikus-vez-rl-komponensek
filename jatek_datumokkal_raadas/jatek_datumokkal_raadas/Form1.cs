using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek_datumokkal_raadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime ma;
        private void Form1_Load(object sender, EventArgs e)
        {
            ma = DateTime.Now;
            //lblAktualis:Text = ma.ToString();
            lblAktualis.Text = ma.ToString("g");
            lblErtekeles.Text = "";
            lblTalalkozo.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAktualis.Text = DateTime.Now.ToString("F");
        }

        private void btnErtekel_Click(object sender, EventArgs e)
        {
            DateTime datum, ido, talakozo;
            datum = dtTmPckrDatum.Value;
            ido = dtTmPckrIdo.Value;
            talakozo = datum.Date + ido.TimeOfDay;

            // Csak próbaképpen;
            //lblTalalkozo.Text = datum + "--" + ido;

            lblTalalkozo.Text = $"{datum.ToShortDateString()} {ido.ToShortTimeString()}";
            if(talakozo < ma)
            {
                lblErtekeles.Text = "Ezt lekésted";
            }
            else
            {
                TimeSpan hatraLevo = talakozo - ma;
                lblErtekeles.Text = $"Még {hatraLevo.Days} nap {hatraLevo.Hours} óra {hatraLevo.Seconds} perc";
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            lblErtekeles.Text = "";
            lblTalalkozo.Text = "";
            lblAktualis.Text = "";
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}