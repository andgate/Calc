using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        List<string> history;

        public Form1()
        {
            history = new List<string>();
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");

                MessageBox.Show("Form.KeyPress: '" +
                            e.KeyChar.ToString() + "' consumed.");
                e.Handled = true;
            } */
        }

        /* Callbacks for button clicks on decimal numbers */
        private void n0_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "3"; 
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (output.Text == "0") output.Text = "";
            output.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        /* Decimal Point */
        private void decBtn_Click(object sender, EventArgs e)
        {
            // This needs to be disabled when the last
            // token in the input is not an integer.
            output.Text += ".";
        }

        /* Equality */
        private void eqBtn_Click(object sender, EventArgs e)
        {
            string result = Eval.eval(output.Text);
            string resultMsg = output.Text + " = " + result;

            history.Add(resultMsg);
            resultsBox.Text = string.Join("\n", history);
            output.Clear();
        }

        /* Clear current input string */
        private void clearBtn_Click(object sender, EventArgs e)
        {
            output.Clear();
            history.RemoveAt(history.Count() - 1);
            resultsBox.Text = string.Join("\n", history);
        }

        /* Clear current input string */
        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            output.Clear();
            resultsBox.Clear();
            history.Clear();
        }

        private void rparenBtn_Click(object sender, EventArgs e)
        {
            output.Text += ")";
        }

        private void lparenBtn_Click(object sender, EventArgs e)
        {
            output.Text += "(";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            output.Text += "+";
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            output.Text += "-";
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            output.Text += "*";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            output.Text += "/";
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            output.Text += "^";
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
