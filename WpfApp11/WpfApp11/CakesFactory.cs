using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class CakesFactory
    {
        List<Cake> list;
        public CakesFactory(List<Cake> list)
        {
            this.list = list;
        }
        public Cake newCake(int numb)
        {
            if (numb < list.Count)
                return list[numb];
            else
                throw new Exception("No such cake");
        }
    }
}
