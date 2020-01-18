using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kino
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
           
        }
        int a=14,b=0;
               

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label5.Text = a.ToString();
            label4.Text = b.ToString();
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button13.BackColor = Color.DarkRed;
                button13.Enabled = false;
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button1.BackColor = Color.DarkRed;
                button1.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button2.BackColor = Color.DarkRed;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button3.BackColor = Color.DarkRed;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button4.BackColor = Color.DarkRed;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button5.BackColor = Color.DarkRed;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button6.BackColor = Color.DarkRed;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button7.BackColor = Color.DarkRed;
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button8.BackColor = Color.DarkRed;
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button9.BackColor = Color.DarkRed;
                button9.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button10.BackColor = Color.DarkRed;
                button10.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button11.BackColor = Color.DarkRed;
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button12.BackColor = Color.DarkRed;
                button12.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button15.Enabled == false) {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button15.Text);
                wr.Close();
            }
            if (button13.Enabled == false)
            {
                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button13.Text);
                wr.Close();
            }
            if (button1.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button1.Text);
                wr.Close();
            }
            if (button2.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button2.Text);
                wr.Close();
            }
            if (button3.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button3.Text);
                wr.Close();
            }
            if (button4.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button4.Text);
                wr.Close();
            }
            if (button5.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button5.Text);
                wr.Close();
            }
            if (button6.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button6.Text);
                wr.Close();
            }
            if (button7.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button7.Text);
                wr.Close();
            }
            if (button8.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button8.Text);
                wr.Close();
            }
            if (button9.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button9.Text);
                wr.Close();
            }
            if (button10.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button10.Text);
                wr.Close();
            }
            if (button11.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button11.Text);
                wr.Close();
            }
            if (button12.Enabled == false)
            {

                StreamWriter wr = new StreamWriter("Занятые места красный зал.txt", true);
                wr.WriteLine(label6.Text);
                wr.WriteLine(button12.Text);
                wr.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = dateTimePicker1.Text.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Да", "Забронировать место?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                a = a - 1;
                b = b + 1;
                label5.Text = a.ToString();
                label4.Text = b.ToString();
                button15.BackColor = Color.DarkRed;
                button15.Enabled = false;
            }
            
        }
    }
}
