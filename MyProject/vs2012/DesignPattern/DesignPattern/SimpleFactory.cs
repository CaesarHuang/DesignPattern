using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DesignPattern.SimpleFactoryDL;

namespace DesignPattern
{
    public partial class SimpleFactory : Form
    {
        public SimpleFactory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (this.txtResult.Text.Trim() == "")
            {
                MessageBox.Show("Please input number!");
                return;
            }
            Regex regexOperate = new Regex("(?<value>[\\-\\+\\*/])");
            MatchCollection matchCollectionOperate = regexOperate.Matches(this.txtResult.Text.Trim());

            Regex regexNumber = new Regex("(?<value>[0-9.]+)");
            MatchCollection matchCollectionNumber = regexNumber.Matches(this.txtResult.Text.Trim());
            if (matchCollectionOperate.Count != 1 || matchCollectionNumber.Count != 2)
            {
                MessageBox.Show("Input error!");
                return;
            }
            else
            { 
                Operation operation;
                CalculateFatory calculateFatory = new CalculateFatory();
                operation = calculateFatory.CalculateResult(matchCollectionOperate[0].ToString());
                operation.NumberA = Convert.ToDouble(matchCollectionNumber[0].ToString());
                operation.NumberB = Convert.ToDouble(matchCollectionNumber[1].ToString());
                this.txtResult.Text = operation.GetResult().ToString();
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = this.txtResult.Text + "/";
        }
    }
}
