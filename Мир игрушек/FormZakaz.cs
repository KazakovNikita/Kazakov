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
using System.IO;
namespace Мир_игрушек
{
    public partial class FormZakaz : Form
    {
        public FormZakaz()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain f1 = new FormMain();
            f1.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(DataBank.s) + " руб.", "Стоимость заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOplata_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null && textBoxName.Text != "")
            {               
                    FormOplata f21 = new FormOplata();
                    f21.Show();
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Не все значения введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string films = @"D:\visual\Мир игрушек\Мир игрушек\bin\Debug\file.txt"; // Путь файла
            string tams = @"D:\visual\Мир игрушек\Мир игрушек\bin\Debug\file1.txt"; //Путь 
            

            if (File.Exists(films) && File.Exists(tams))
            {

                MessageBox.Show("Мы записали ваши данные!", "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


            }
            else if (!File.Exists(films) || !File.Exists(tams))
            {
                if (!File.Exists(films))
                {
                    using (StreamWriter stream = new StreamWriter(films))
                        stream.WriteLine(textBoxName);
                    

                }
                else if (!File.Exists(tams))
                {

                    File.Create(tams).Close();

                }


                }
            }

        private void FormZakaz_Load(object sender, EventArgs e)
        {

        }
    }
}
