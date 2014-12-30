using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPattern.StrategyDL;

namespace DesignPattern
{
    public partial class Strategy : Form
    {
        public Strategy()
        { 
            InitializeComponent();
            BindCboDiscount(); 
        }

        public void BindCboDiscount()
        { 
            Dictionary<int,string> discountDictionary = new Dictionary<int, string>();
            discountDictionary.Add(1,"No Discount");
            discountDictionary.Add(2,"90% Discount");
            discountDictionary.Add(3,"300 return 100");

            BindingSource bsSource = new BindingSource();
            bsSource.DataSource = discountDictionary;
            cboDiscount.DataSource = bsSource;
            cboDiscount.ValueMember = "Key";
            cboDiscount.DisplayMember = "Value";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.txtPrice.Text.Trim() == "" || this.txtNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please input the price and number!");
                return;
            }

            CashContext cashContext;
            double cashFinal = 0;
            switch (Convert.ToInt32(this.cboDiscount.SelectedValue))
            {
                case 1:
                    cashContext = new CashContext(new CashNoDiscount());
                    cashFinal = cashContext.GetCashResultFinal(Convert.ToDouble(this.txtPrice.Text.Trim()),
                        Convert.ToDouble(this.txtNumber.Text.Trim()));
                    break;
                case 2:
                    cashContext = new CashContext(new CashPercent());
                    cashFinal = cashContext.GetCashResultFinal(Convert.ToDouble(this.txtPrice.Text.Trim()),
                        Convert.ToDouble(this.txtNumber.Text.Trim()));
                    break;
                case 3:
                    cashContext = new CashContext(new CashReturn());
                    cashFinal = cashContext.GetCashResultFinal(Convert.ToDouble(this.txtPrice.Text.Trim()),
                        Convert.ToDouble(this.txtNumber.Text.Trim()));
                    break;
            }

            this.txtResult.Text = "Total : " + cashFinal.ToString();
        }

    }
}
