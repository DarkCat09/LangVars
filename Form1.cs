using System;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox6_Click(null, null);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Text = Languages.Eng["Настройки"];

            label1.Text = Languages.Eng["Выберите Язык"];
            label2.Text = Languages.Eng["Выберите язык"];
            label3.Text = Languages.Eng["Выберите сложность"];

            button1.Text = Languages.Eng["Новичок"];
            button2.Text = Languages.Eng["Любитель"];
            button3.Text = Languages.Eng["Профи"];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Text = Languages.Rus["Настройки"];

            label1.Text = Languages.Rus["Выберите язык"];
            label2.Text = Languages.Rus["Выберите язык"];
            label3.Text = Languages.Rus["Выберите сложность"];

            button1.Text = Languages.Rus["Новичок"];
            button2.Text = Languages.Rus["Любитель"];
            button3.Text = Languages.Rus["Профи"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Text = Languages.Ukr["Настройки"];

            label1.Text = Languages.Ukr["Выберите Язык"];
            label2.Text = Languages.Ukr["Выберите язык"];
            label3.Text = Languages.Ukr["Выберите сложность"];

            button1.Text = Languages.Ukr["Новичок"];
            button2.Text = Languages.Ukr["Любитель"];
            button3.Text = Languages.Ukr["Профи"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Для новичков слишком новенько!\n" +
                                "It's too new for newbies/beginners!\n" +
                                "Для новачків занадто новенький!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Для любителей слишком любительско!!\n" +
                                "It's too amateur for amateurs!!\n" +
                                "Для любителів занадто аматорських!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Для профи слишком профессионально!!!\n" +
                                "It's too professional for prof!!!\n" +
                                "Для профі занадто професійно!!!");
        }
    }
}
