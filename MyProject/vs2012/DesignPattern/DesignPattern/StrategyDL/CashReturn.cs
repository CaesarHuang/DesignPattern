using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyDL
{
    public class CashReturn : ICashResultInterface
    {
        private double _full = 300;
        private double _return = 100;

        public double GetCashResult(double price, double number)
        {
            if (price * number >= _full)
            {
                return price * number -  _return;
            }
            else
            {
                return price * number;
            }

        }
    }
}
