using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDL
{
    [Serializable]
    class WorkExperience : ICloneable
    {
        private int _workYear;
        private string _company;

        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        //方法一深表复制需要继承ICloneable
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
