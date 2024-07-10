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
    public partial class SugoForm : Form
    {
        public SugoForm()
        {
            InitializeComponent();
        }

        private void SugoForm_Load(object sender, EventArgs e)
        {
            rchTextBox.Clear();
            rchTextBox.Text = "A fájl menüpontban lehet megynyitni az itallistátt tartalmazó adatfájlt, és itt lehet majd elmenteni a számlák adatait tartalmazó fájlt." +
                "\n\nAz itallap az adatfájl belöltés után is megjelenik, de bármikor máskor is előhozható az Itallap menüponont hatására." +
                "\n\nA galéria menüpont hatására megnézhet néhány képet a falu nevezetességéről és a környékéről.";
        }
    }
}
