using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                int numberOfDays = string.IsNullOrWhiteSpace(textBox1.Text) 
                    ? 0 : Convert.ToInt32(textBox1.Text);

                if (numberOfDays <= 0)
                {
                    MessageBox.Show("Введіть розмір масиву більше 0!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Array1D arr = new Array1D(numberOfDays);
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridView1.Rows.Add(arr[i].ToString());
                }

                var metrics = arr.CalculateMetrics();
                labelAvgTemp.Text = "Середня температура: " + metrics.Item1.ToString();
                labelCount.Text = "Днів вище середньої: " + metrics.Item2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
