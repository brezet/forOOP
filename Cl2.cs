using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_Sharp
{
    interface IYear
    {
        string Year { get; set; }
        void Break();
    }
    public abstract class BouquetAbst
    {
        public abstract void Add(int num);
        public virtual DateTime TimeCreate()
        {
            return DateTime.Now;
        }
    }
}