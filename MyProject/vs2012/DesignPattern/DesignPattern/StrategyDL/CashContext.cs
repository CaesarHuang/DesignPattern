using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyDL
{
    public class CashContext
    {
        private readonly ICashResultInterface _cashReusult;

        public CashContext(ICashResultInterface cashReusult)
        {
            this._cashReusult = cashReusult;
        }

        public double GetCashResultFinal(double price,double number)
        {
            return this._cashReusult.GetCashResult(price, number);
        }
    }
}
