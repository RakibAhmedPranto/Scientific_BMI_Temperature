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
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        float iCel, iFar, iKel;
        char iOperatior;
        float weight;
        float height;
        String cat;
        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 326;
            textBox1.Width = 285;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 640;
            textBox1.Width = 597;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 326;
            textBox1.Width = 285;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1041;
            textBox1.Width = 285;
            textBox2.Focus();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox1.Location = new Point(636, 27);
            groupBox1.Height = 425;
            groupBox1.Width = 377;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1041;
            textBox1.Width = 285;
        }

        private void multiplicationTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1041;
            textBox1.Width = 285;
            textBox4.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(636, 27);
            groupBox3.Height = 425;
            groupBox3.Width = 377;
        }

        private void bMICalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1041;
            textBox1.Width = 285;
            textBox5.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = true;
            groupBox5.Location = new Point(636, 27);
            groupBox5.Height = 425;
            groupBox5.Width = 377;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || (enter_value))
            {
                textBox1.Text = "";
            }
            enter_value = false;
            Button num = (Button)sender;
            if(num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + num.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        private void btnSpace_click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if(textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void arithmatic_operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void btnEqual_click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (result % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    Double i = Double.Parse(textBox1.Text);
                    Double q = (result);
                    //textBox1.Text = Math.Exp(i*Math.Log(q*4)).ToString();
                    textBox1.Text = Math.Pow(q,i).ToString();
                    break;
            }
        }

        private void btnPI_click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589793238";
        }

        private void btnLog_click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log"+"("+(textBox1.Text)+")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void btnSqrt_click(object sender, EventArgs e)
        {
            Double iSqrt = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("√" + "(" + (textBox1.Text) + ")");
            iSqrt = Math.Sqrt(iSqrt);
            textBox1.Text = System.Convert.ToString(iSqrt);
        }

        private void buttonSquare_click(object sender, EventArgs e)
        {
            Double iSqr = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("(" + (textBox1.Text) + ")"+"^2");
            iSqr = Math.Pow(iSqr,2);
            textBox1.Text = System.Convert.ToString(iSqr);
        }

        private void btnCube_clicl(object sender, EventArgs e)
        {
            Double iQub = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("(" + (textBox1.Text) + ")" + "^3");
            iQub = Math.Pow(iQub, 3);
            textBox1.Text = System.Convert.ToString(iQub);
        }

        private void iQub_clicl(object sender, EventArgs e)
        {
            Double iInv = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("(" + (textBox1.Text) + ")" + "^-1");
            iInv = Math.Pow(iInv, -1);
            textBox1.Text = System.Convert.ToString(iInv);
        }

        private void btnSinh_click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sinh" + "(" + (textBox1.Text) + ")");
            val = Math.Sinh(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnSin_click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sin" + "(" + (textBox1.Text) + ")");
            val = Math.Sin(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");
            val = Math.Cosh(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text) + ")");
            val = Math.Cos(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Tanh" + "(" + (textBox1.Text) + ")");
            val = Math.Tanh(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            Double val = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text) + ")");
            val = Math.Tan(val);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int val = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(val);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int val = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(val, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int val = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(val, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int val = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(val, 8);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("ln" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void radCtoF_CheckedChanged(object sender, EventArgs e)
        {
            iOperatior = 'C';
        }

        private void radFtoC_CheckedChanged(object sender, EventArgs e)
        {
            iOperatior = 'F';
        }

        private void radK_CheckedChanged(object sender, EventArgs e)
        {
            iOperatior = 'K';
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Text = "";
            radCtoF.Checked = false;
            radFtoC.Checked = false;
            radK.Checked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox4.Text);
            for(int i = 1; i < 13; i++)
            {
                TimeTable.Items.Add(i+"x"+a+"="+a*i);
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            TimeTable.Items.Clear();
            textBox4.Clear();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            
            weight = float.Parse(textBox5.Text);
            height = float.Parse(textBox6.Text);
            float bmi;
            
            bmi = weight / (height * height);

            if (bmi < 15)
            {
                cat = "Very severely underweight";
            }
            else if(bmi>15 && bmi<16)
            {
                cat = "severely underweight";
            }
            else if (bmi > 16 && bmi < 18.5)
            {
                cat = "underweight";
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                cat = "Healthy Weight";
            }
            else if (bmi > 25 && bmi < 30)
            {
                cat = "Overweight";
            }
            else if (bmi > 30 && bmi < 35)
            {
                cat = "Moderately obese";
            }
            else if (bmi > 35 && bmi < 40)
            {
                cat = "Severely obese";
            }
            else if (bmi > 40)
            {
                cat = "Very severely obese";
            }
            textBox7.Text = System.Convert.ToString(bmi);
            textBox8.Text = cat;

        }

        private void btnResetBMI_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btn_conv1_Click(object sender, EventArgs e)
        {
            switch (iOperatior)
            {
                case 'C':
                    iCel = float.Parse(textBox2.Text);
                    textBox3.Text = ((((9 * iCel) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFar = float.Parse(textBox2.Text);
                    textBox3.Text = ((((iFar-32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKel = float.Parse(textBox2.Text);
                    textBox3.Text = (((((9 * iKel) / 5) + 32)+273.15).ToString());
                    break;
            }
        }
    }

}
