using System.Data;
using System.Text;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder str = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            str.Append('1');
            textBox1.Text = str.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            str.Append('2');
            textBox1.Text = str.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str.Append('3');
            textBox1.Text = str.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str.Append('4');
            textBox1.Text = str.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str.Append('5');
            textBox1.Text = str.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str.Append('6');
            textBox1.Text = str.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str.Append('7');
            textBox1.Text = str.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str.Append('8');
            textBox1.Text = str.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str.Append('9');
            textBox1.Text = str.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str.Append('0');
            textBox1.Text = str.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string expression = str.ToString();
            DataTable exp = new DataTable();
            try
            {
                var ans = exp.Compute(expression, "");
                textBox1.Text = str.ToString() + " = " + ans.ToString();
                string res = ans.ToString();
                str.Clear();
                str.Append(res);
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            str.Append('+');
            textBox1.Text = str.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            str.Append('-');
            textBox1.Text = str.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            str.Append('*');
            textBox1.Text = str.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            str.Append('/');
            textBox1.Text = str.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            str.Append('(');
            textBox1.Text = str.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            str.Append(')');
            textBox1.Text = str.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (str.Length > 0)
            {
                str.Remove(str.Length - 1, 1);
                textBox1.Text = str.ToString();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            str.Clear();
            textBox1.Text = str.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            str.Append('.');
            textBox1.Text = str.ToString();
        }
    }
}