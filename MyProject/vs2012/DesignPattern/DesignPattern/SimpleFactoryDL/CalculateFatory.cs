using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactoryDL
{
    public class CalculateFatory
    {
        private Operation _operation;

        public Operation CalculateResult(string operate)
        {
            switch (operate)
            {
                case "+":
                    _operation = new AddOperate();
                    break;
                case "-":
                    _operation = new MinusOperate();
                    break;
                case "*":
                    _operation = new RideOperate();
                    break;
                case "/":
                    _operation = new DivisionOperate();
                    break;
            }
            return _operation;
        }
    }
}
