using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactoryDL
{
    public class AddOperate : Operation
    { 
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
