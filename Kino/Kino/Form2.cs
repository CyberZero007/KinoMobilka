using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kino
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Скоро_в_прокате". При необходимости она может быть перемещена или удалена.
            this.скоро_в_прокатеTableAdapter.Fill(this.киноDataSet.Скоро_в_прокате);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.киноDataSet.Сеансы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Показы". При необходимости она может быть перемещена или удалена.
            this.показыTableAdapter.Fill(this.киноDataSet.Показы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Контролеры". При необходимости она может быть перемещена или удалена.
            this.контролерыTableAdapter.Fill(this.киноDataSet.Контролеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.киноDataSet.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "киноDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.киноDataSet.Билеты);
            this.скоро_в_прокатеTableAdapter.Update(this.киноDataSet.Скоро_в_прокате);
            ToolTip t = new ToolTip();
            t.SetToolTip(button15, "Выход");
            t.SetToolTip(button16, "Добавление информации в БД");
            t.SetToolTip(button11, "Просмотр мест в красном зале");
            t.SetToolTip(button12, "Просмотр мест в синем зале");
            t.SetToolTip(button13, "Просмотр мест в зеленом зале");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                Form7 f = new Form7();
                f.Show();
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\AMilobog\\Desktop\\AdminKino\\Kino\\help.hhd.hnd");
        }

        private void button15_Click(object sender, EventArgs e)
        {
        DialogResult dialogResult = MessageBox.Show("Да", "Вы действительно хотите выйти?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.скоро_в_прокатеTableAdapter.Update(this.киноDataSet.Скоро_в_прокате);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.билетыTableAdapter.Update(this.киноDataSet.Билеты);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }
    }
}
