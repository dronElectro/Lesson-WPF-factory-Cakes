using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class Pie : Cake
    {
        int weight;
        public Pie(string name, int count, int weight):base(name, count)
        {
            this.weight = weight;
        }
        public override bool bake(int duration)
        {
            if (duration < 200 && duration > 100)
                return true;
            else
                return false;
        }
    }
}
