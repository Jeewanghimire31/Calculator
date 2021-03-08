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
    public partial class frmCalc : Form
    {
        int num1 = 0, num2 = 0;
        string result;
        int op = 0;
        int sign =0;
        string s, x;
        string expression;
        bool equal = false;
        public frmCalc()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        private void button1_Click(object sender, EventArgs e)
        {
            if(equal==true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression+= btn_One.Text;
            txtResult.Text = expression;
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Zero.Text;
            txtResult.Text = expression;

        }

        private void btn_Two_Click(object sender, EventArgs e)
        {

            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Two.Text;
            txtResult.Text = expression;
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Three.Text;
            txtResult.Text = expression;

        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Four.Text;
            txtResult.Text = expression;

        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Five.Text;
            txtResult.Text = expression;

        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Six.Text;
            txtResult.Text = expression;

        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Seven.Text;
            txtResult.Text = expression;

        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Eight.Text;
            txtResult.Text = expression;

        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Nine.Text;
            txtResult.Text = expression;

        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            result = Eval(expression);
 
            txtResult1.Text = result;
            equal = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            expression = "";
            txtResult.Text = expression;
            txtResult1.Text = "";
            equal = false;

        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {

            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Plus.Text;
            txtResult.Text = expression;
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Minus.Text;
            txtResult.Text = expression;


        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Multiply.Text;
            txtResult.Text = expression;


        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += btn_Divide.Text;
            txtResult.Text = expression;


        }

        private void btn_Sine_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Tan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Pi_Click(object sender, EventArgs e)
        {
            if (equal == true)
            {
                expression = "";
                txtResult.Text = expression;
                txtResult1.Text = "";
                equal = false;
            }

            expression += Math.PI.ToString();
            txtResult.Text = expression;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(txtResult.Text);
            s = Math.Sqrt(l);
            txtResult.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Log(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtResult.Text); i++)
                {
                    fact = fact * i;
                }
                txtResult.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Acos(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_INVSine_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Asin(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_INVTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Atan(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtResult.Text.Length - 1;
            if (sign != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtResult.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1)
                {
                    txtResult.Text = txtResult.Text + Convert.ToString(".");
                }
            }
        }

        private void btn_1DivX_Click(object sender, EventArgs e)
        {
            txtResult.Text = (1 / Convert.ToDouble(txtResult.Text)).ToString();
        }

        private void btn_Expo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }
                sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
           string  s = txtResult.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            txtResult.Text = x;
            x = "";
        }

        private void txtResult1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(txtResult.Text));
                    txtResult.Text = Convert.ToString(l);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        String Eval(String expression)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToString(table.Compute(expression, String.Empty));
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
