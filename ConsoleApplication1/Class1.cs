using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 第四次作业case0
{
    class Class1 : CollectionBase
    {
        public void Add(Class1 myClass1)
        {
            List.Add(myClass1);
        }
        public void Remove(Class1 myClass1)
        {
            List.Remove(myClass1);
        }
        public void Clear()
        {
            List.Clear();
        }
        public Class1 this[int Index]
        {
            get
            {
                return (Class1)List[Index];
            }
            set
            {
                List[Index] = value;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
