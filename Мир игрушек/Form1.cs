using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Мир_игрушек
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGirls f2 = new FormGirls();
            f2.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormZakaz f5 = new FormZakaz();
            f5.Show();
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBoys_Click(object sender, EventArgs e)
        {
            FormBoys f1 = new FormBoys();
            f1.Show();
            this.Visible = false;
        }

        private void buttonBaby_Click(object sender, EventArgs e)
        {
            FormBaby f3 = new FormBaby();
            f3.Show();
            this.Visible = false;
        }

        private void buttonConstructors_Click(object sender, EventArgs e)
        {
            FormConstructors f4 = new FormConstructors();
            f4.Show();
            this.Visible = false;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo f9 = new FormInfo();
            f9.Show();
            this.Visible = false;
        }
    }
}
