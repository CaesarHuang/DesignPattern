using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPattern.PrototypeDL
{
    [Serializable]
    class Resume : ICloneable
    {
        private string _name;
        private int _age;

        private WorkExperience _workExperience = new WorkExperience(); //引用类型的浅表复制，所有的副本对象均指向同一个地址，改其中某个副本的值，其他也会改变

        public Resume(string name, int age)
        {
            this._name = name;
            this._age = age; 
        }

        public void SetWorkExperience(int workYear,string company)
        {
            this._workExperience.WorkYear = workYear;
            this._workExperience.Company = company;
        }

        public string DisplayResume()
        {
            return "Name: " + _name + " Age:" + _age + " Work in " + this._workExperience.Company + " for " + this._workExperience.WorkYear + "years";
        }

        public object Clone()
        {
            //深表复制。 
            //1）引用类型需要继承ICloneable 
            //Resume resume = new Resume(this._name, this._age);
            //resume._workExperience = (WorkExperience) this._workExperience.Clone();
            //return resume;

            //2）利用序列化跟反序列化实现 
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            Resume resume = (Resume) binaryFormatter.Deserialize(memoryStream);
            return resume; 
            //return (Resume) this.MemberwiseClone();  浅表复制只要这一句就ok
        }
    }
}
