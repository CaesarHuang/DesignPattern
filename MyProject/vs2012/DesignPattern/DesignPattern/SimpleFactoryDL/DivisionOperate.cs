using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactoryDL
{
    public class DivisionOperate : Operation
    {
        public override double GetResult()
        {
            if (NumberB <= 1e-15)
            {
                return 0;
            }
            else
            {
                return NumberA / NumberB;
            }
        }
    }
}
