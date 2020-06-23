using System;
using System.Windows.Forms;

namespace CreateCalculator
{
    public partial class Form1 : Form
    {
        private int temp = 20;
        Double val = 0;
        String text = "";
        bool op = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((output.Text == "0") || (op))
            {
                output.Clear();
            }
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            op = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }
        private void op_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);
            op = true;
        }
        private void op_res(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    output.Text = (val + Double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (val - Double.Parse(output.Text)).ToString();
                    break;
                case "*":
                    output.Text = (val * Double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (val / Double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            op = false;
        }
        private void c_press(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
