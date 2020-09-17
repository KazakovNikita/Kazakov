using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мир_игрушек
{
    public partial class FormConstructors : Form
    {
        public FormConstructors()
        {
            InitializeComponent();
        }

        private void FormConstructors_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkPoezd.Checked)
                DataBank.s = DataBank.s + 1000;
            if (checkVelosiped.Checked)
                DataBank.s = DataBank.s + 400;
            if (checkKorablik.Checked)
                DataBank.s = DataBank.s + 699;
            if (checkDom.Checked)
                DataBank.s = DataBank.s + 1100;
            FormMain f1 = new FormMain();
            f1.Show();
            this.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkPoezd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
