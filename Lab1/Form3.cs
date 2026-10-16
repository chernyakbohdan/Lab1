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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = string.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToInt32(textBox1.Text);
                int m = string.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToInt32(textBox2.Text);

                if (n <= 0 || m <= 0)
                {
                    MessageBox.Show("Кількість рядків і стовпців має бути більшою за 0!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Array2D twoDimArray = new Array2D(n, m);

                dataGridView1.Columns.Clear();
                for (int i = 0; i < twoDimArray.Y_length; i++)
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.Width = 40;
                    dataGridView1.Columns.Add(col);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = twoDimArray.X_length;

                for (int i = 0; i < twoDimArray.X_length; i++)
                {
                    for (int j = 0; j < twoDimArray.Y_length; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = twoDimArray[i, j].ToString();
                    }
                }

                int result = twoDimArray.CountNegativeBelowMainDiagonal();
                labelResult.Text = "Кількість від'ємних під гол. діагоналлю: " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
