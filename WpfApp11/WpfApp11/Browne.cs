using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class Browne : Cake
    {
        public Browne(string name, int count) : base(name, count)
        {}

        public override bool bake(int duration)
        {
            if (duration < 100 && duration > 50)
                return true;
            else
                return false;
        }
    }
}
