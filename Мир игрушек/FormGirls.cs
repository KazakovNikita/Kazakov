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
    public partial class FormGirls : Form
    {
        public FormGirls()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkHouse.Checked)
                DataBank.s = DataBank.s + 600;
            if (checkKykla.Checked)
                DataBank.s = DataBank.s + 100;
            if (checkBarbie.Checked)
                DataBank.s = DataBank.s + 299;
            if (checkKolyaska.Checked)
                DataBank.s = DataBank.s + 300;
            FormMain f1 = new FormMain();
            f1.Show();
            this.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormGirls_Load(object sender, EventArgs e)
        {

        }
    }
}
