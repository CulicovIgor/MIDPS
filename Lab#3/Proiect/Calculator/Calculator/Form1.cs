using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool actB = false;
        bool BufF = false;
        int actN = 0,actNp;
        string Nbuf1 = "", Nbuf2 = "";
        double act(double a, double b) {
            switch (actN) {
                case 1:
                    a += b;
                    break;
                case 2:
                    a -= b;
                    break;
                case 3:
                    a *= b;
                    break;
                case 4:
                    a /= b;
                    break;
                case 5:
                    a = Math.Pow(a,b);
                    break;
            }
            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (actB == true) { 
                textBox1.Text = "1";
                actB = false;
            }
            else textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "6";
                actB = false;
            }
            else textBox1.Text += "6";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "7";
                actB = false;
            }
            else textBox1.Text += "7"; 
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "8";
                actB = false;
            }
            else textBox1.Text += "8"; 
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "9";
                actB = false;
            }
            else textBox1.Text += "9"; 
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "4";
                actB = false;
            }
            else textBox1.Text += "4"; 
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "5";
                actB = false;
            }
            else textBox1.Text += "5"; 
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "2";
                actB = false;
            }
            else textBox1.Text += "2"; 
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "3";
                actB = false;
            }
            else textBox1.Text += "3"; 
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (actB == true)
            {
                textBox1.Text = "0";
                actB = false;
            }
            else textBox1.Text += "0"; 
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false && textBox1.Text != "")
            {
                textBox1.Text += ",";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actN = 0;
            actB = false;
            Nbuf1 = "";
            Nbuf2 = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (BufF == false)
            {
                Nbuf1 = textBox1.Text;
            }
            if (BufF == true)
            {
                Nbuf2 = textBox1.Text;
            }
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BufF = true;
            actNp = actN;
            actN = 1;
            actB = true;
            Nbuf2 = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BufF = true;
            actNp = actN;
            actN = 2;
            actB = true;
            Nbuf2 = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BufF = true;
            actNp = actN;
            actN = 3;
            actB = true;
            Nbuf2 = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BufF = true;
            actNp = actN;
            actN = 4;
            actB = true;
            Nbuf2 = textBox1.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BufF = true;
            actNp = actN;
            actN = 5;
            actB = true;
            Nbuf2 = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actNp = actN;
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(Nbuf1)));
            actN = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BufF = false;
            actB = true;
            if (Nbuf1 == "") Nbuf1 = "0";
            if(Nbuf2 == "") Nbuf2 = Nbuf1;
            Nbuf1 = Convert.ToString(act(Convert.ToDouble(Nbuf1), Convert.ToDouble(Nbuf2)));
            textBox1.Text = Nbuf1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double nbuff = 0;
            if (textBox1.Text != "" || textBox1.Text != "0")
            {
                nbuff -= Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(nbuff);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = e.KeyChar;
        }

        private void b7_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b8_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b9_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b4_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b5_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b6_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b2_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b3_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void bdot_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void b0_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button9_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button5_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button8_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1') button1_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '2') b2_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '3') b3_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '4') b4_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '5') b5_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '6') button6_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '7') b7_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '8') b8_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '9') b9_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '0') b0_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '+') button1_Click_1(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '-') button2_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '=' || Convert.ToInt32(e.KeyChar) == 13) button3_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '/') button5_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '*') button4_Click(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '^') button6_Click_1(sender, MouseEventArgs.Empty);
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                bdot_Click(sender,MouseEventArgs.Empty);
            }
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
