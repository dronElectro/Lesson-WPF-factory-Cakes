using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    abstract class Cake
    {
        public string Name { get; set; }
        int count;

        public Cake(string name, int count)
        {
            Name = name;
            this.count = count;
        }
        public string Eat(int count)
        {
            if (this.count > count)
            {
                this.count -= count;
                return $"You eat {count} cakes";
            }
            else
                return "Not enough cakes";
        }
        abstract public bool bake(int duration);
    }
}
