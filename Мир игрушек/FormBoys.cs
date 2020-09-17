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
    public partial class FormBoys : Form
    {
        public FormBoys()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkCar.Checked)
                DataBank.s = DataBank.s + 200;
            if (checkRobot.Checked)
                DataBank.s = DataBank.s + 300;
            if (checkTank.Checked)
                DataBank.s = DataBank.s + 150;
            if (checkSoldatik.Checked)
                DataBank.s = DataBank.s + 100;
            FormMain f1 = new FormMain();
            f1.Show();
            this.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FormBoys_Load(object sender, EventArgs e)
        {

        }
    }
}
