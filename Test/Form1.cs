using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string t1 = textBox1.Text;
            string t2 = textBox2.Text;

            if (t1 == "" || t2 == "")
            {
                MessageBox.Show("the input boxs are empty already!!");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            if (s1 == "")
            {
                MessageBox.Show("text field_01 is empty");

            }
            else
            {
                listBox1.Items.Add(s1);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("input name is empty!");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    label6.Text = "Your name is : " + textBox3.Text + "  and your gender is : " + radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    label6.Text = "Your name is : " + textBox3.Text + "  and your gender is : " + radioButton2.Text;
                }
                else
                {
                    MessageBox.Show("select a gender!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "......";
            textBox3.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox2.Items.Add(checkBox1.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox2.Items.Add(checkBox2.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox2.Text);
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox2.Items.Add(checkBox3.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox3.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                listBox2.Items.Add(checkBox4.Text);
            }
            else
            {
                listBox2.Items.Remove(checkBox4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }
    }
}
