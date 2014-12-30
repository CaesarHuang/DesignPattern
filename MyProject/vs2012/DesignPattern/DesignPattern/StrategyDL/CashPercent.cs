using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyDL
{
    public class CashPercent : ICashResultInterface
    {
        private double _percent = 0.9;

        public double GetCashResult(double price, double number)
        {
            return _percent*price*number;
        }
    }
}
