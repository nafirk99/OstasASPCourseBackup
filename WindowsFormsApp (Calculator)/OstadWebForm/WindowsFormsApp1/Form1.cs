using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = 0;
                if (textBox1.Text != "")
                    a = int.Parse(textBox1.Text);

                b = 0;
                if (textBox2.Text != "")
                    b = int.Parse(textBox2.Text);
                textBox3.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = 0;
                if (textBox1.Text != "")
                    a = int.Parse(textBox1.Text);

                b = 0;
                if (textBox2.Text != "")
                    b = int.Parse(textBox2.Text);

                textBox3.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                //MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a=0, b=0;
                if(textBox1.Text!="")
                    a = int.Parse(textBox1.Text);

                if (textBox2.Text != "")
                    b = int.Parse(textBox2.Text);

                textBox3.Text= (a + b).ToString();
            }
            catch (Exception ex)
            {
                textBox2.Text = "";
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
