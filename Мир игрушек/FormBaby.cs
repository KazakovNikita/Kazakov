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
    public partial class FormBaby : Form
    {
        public FormBaby()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkPiramidka.Checked)
                DataBank.s = DataBank.s + 200;
            if (checkYla.Checked)
                DataBank.s = DataBank.s + 150;
            if (checkKorablik.Checked)
                DataBank.s = DataBank.s + 100;
            if (checkPogremyshka.Checked)
                DataBank.s = DataBank.s + 50;
            FormMain f1 = new FormMain();
            f1.Show();
            this.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormBaby_Load(object sender, EventArgs e)
        {

        }
    }
}
