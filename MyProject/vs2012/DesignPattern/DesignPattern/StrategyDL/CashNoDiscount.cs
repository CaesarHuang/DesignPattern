using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyDL
{
    public class CashNoDiscount : ICashResultInterface
    { 
        public double GetCashResult(double price, double number)
        { 
                return price*number;
        }
    }
}
