using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 obj = new Class1(3);

        Color[] col = { Color.Red, Color.Green, Color.Yellow, Color.White, Color.Gray,
                        Color.Blue, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGray,
                        Color.DarkRed, Color.DarkGreen, Color.Orange };

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_x.Text == "" || textBox_z.Text == "")
            {
                MessageBox.Show("Fill the gaps!");
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 12);
                button2.BackColor = col[value];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_x.Text == "" || textBox_z.Text == "")
            {
                MessageBox.Show("Fill the gaps!");
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 12);
                button1.BackColor = col[value];
            }
        }

        private void textBox_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {
            /*if (button1.BackColor == Color.Cyan)
            {
                double x = Convert.ToDouble(textBox_x.Text);
                double z = Convert.ToDouble(textBox_z.Text);
                double y = Math.Sqrt(Math.Abs(x * x - 4)) / (2 * z);
                textBox1.Text = "y = " + y.ToString();
            }
            else textBox1.Text = "Wrong color!";*/
            textBox1.Text = Convert.ToString(obj.GetNum());
        }

        private void button2_BackColorChanged(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.DarkCyan)
            {
                double x = Convert.ToDouble(textBox_x.Text);
                double z = Convert.ToDouble(textBox_z.Text);
                double y = (Math.Sqrt(Math.Abs(x - 1)) - Math.Pow(Math.Abs(z), 1 / 3)) / (1 - x * x / 2 - z / x);
                textBox2.Text = "y = " + y.ToString();
            }
            else textBox2.Text = "Wrong color!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Натисни на справку",
            "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            0,
            "https://bit.ly/3s6iVxA",
            "Keyword");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure?",
            "EXit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes) this.Close();
        }

    }
}
