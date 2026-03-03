using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 + num2);
        }

        private void buttonSubtract_Click_1(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 - num2);
        }

        private void buttonMultiply_Click_1(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 * num2);
        }

        private void buttonDivide_Click_1(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) =>
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Ошибка: деление на ноль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                return num1 / num2;
            });

        }
        private void PerformOperation(Func<double, double, double> operation)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = operation(num1, num2);
                labelResult.Text = "Результат: " + result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
