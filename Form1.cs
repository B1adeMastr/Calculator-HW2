using System.Data;
using static System.Math;

namespace Calculator_HW2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(Output.Text));
                Output.Text = ans.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            int len = Output.Text.Length;
            if (Output.Text[--len] != '.')
            {
                Output.Text += ".";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void Square_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(Output.Text), 2);
                Output.Text = ans.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(Output.Text, "");
                Output.Text = ans.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}