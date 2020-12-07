using System;
using System.Windows.
    Forms;

namespace darbas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int sum = 0;
        int i = 0;
        int[] numbers = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                numbers[i] = Convert.ToInt32(textBox1.Text);
                i++;
                MessageBox.Show("įvesti" +
                    " papildomus skaičius");
            }
            else
            {
                for (int i = 0; i < numbers
                    .Length; i++)
                {
                    sum += numbers[i];
                }
                MessageBox.Show(sum.ToString());
            }
                            















        }

    }
}
