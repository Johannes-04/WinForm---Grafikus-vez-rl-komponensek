using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikalo
{
    public partial class ItalLapForm : Form
    {
        public ItalLapForm()
        {
            InitializeComponent();
        }

        private List<Ital> italok = new List<Ital>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();
        private List<TextBox> txtBoxok = new List<TextBox>();

        private int bal = 10, fent = 10, chkXMeret = 250, chkYTav = 40, txtXmeret = 30, txtYmeret = 17, xKoz = 5;

        private int maxAdag = 999;

        internal void ArlapotIr(List<Ital> italok)
        {
            pnlValasztek.Controls.Clear();
            chkBoxok.Clear();
            txtBoxok.Clear();

            this.italok = italok;

            CheckBox checkBox;
            TextBox txtBox;
            Label lbl;

            for (int i = 0; i < italok.Count; i++)
            {
                checkBox = new CheckBox();
                txtBox= new TextBox();
                lbl = new Label();

                // chkBox

                checkBox.Location = new Point(bal, fent + i * chkYTav);
                checkBox.Size = new Size(chkXMeret, txtXmeret);
                checkBox.Text = italok[i].Arlistaba();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;

                // txtBox
                txtBox.Location = new Point(bal + chkXMeret, fent + i * chkYTav - 2);
                txtBox.Size = new Size(txtXmeret, txtYmeret);

                // lbl
                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXMeret + txtXmeret + xKoz, fent + i * chkYTav + 1);
                lbl.Text = "adag";

                // panelra pakolás
                pnlValasztek.Controls.Add(checkBox);
                pnlValasztek.Controls.Add(txtBox);
                pnlValasztek.Controls.Add(lbl);

                // listákba pakolás
                chkBoxok.Add(checkBox);
                txtBoxok.Add(txtBox);
            }
        }

        private void btnRenel_Click(object sender, EventArgs e)
        {
            bool valasztott = false, vanHibasAdag = false;
            int mennyiseg = 0;

            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    valasztott = true;
                    try
                    {
                        mennyiseg = int.Parse(txtBoxok[i].Text);
                        if (mennyiseg <= 0 || mennyiseg > maxAdag) throw new Exception();
                        italok[i].Rendel(mennyiseg);
                        txtBoxok[i].BackColor = Color.White;
                        chkBoxok[i].Checked = false;
                        txtBoxok[i].Clear();
                    }
                    catch (Exception)
                    {
                        txtBoxok[i].BackColor = Color.Salmon;
                        vanHibasAdag = true;
                    }
                }
            }

            if (!valasztott)
            {
                MessageBox.Show("Semmit nem választott!", "Figyelmeztetés");
            }
            else if(vanHibasAdag)
            {
                MessageBox.Show("A pirossal jelzett adagok hibásak", "Figyelmeztetés");
            }

        }

        // Számlát kér menüpont
        private void fizetMenuItem_Click(object sender, EventArgs e)
        {
            SzamlaForm szlaForm = new SzamlaForm();
            szlaForm.Kitolt(italok);
            szlaForm.ShowDialog();
        }

        // Fizet menüpont
        private void szamlatKerMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Ital item in italok)
            {
                item.Fizet();
            }
        }
    }
}
