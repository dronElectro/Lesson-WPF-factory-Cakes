using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp11
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Update(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        List<Cake> cakes;
        int count;
        bool rbB, rbP;

        void bake(object o)
        {
            if (rbB)
                cakes.Add(new Browne("b1", Count));
            else
                cakes.Add(new Pie("p1", 1, 500));
            Cakes = new List<Cake>(cakes);
            MessageBox.Show(cakes.Count.ToString());
        }

        public MyCommand BakeACake
        {
            get { return new MyCommand(bake); }
        }
        public ViewModel()
        {
            RbP = true;
            cakes = new List<Cake>();
        }

        public bool RbB
        {
            get { return rbB; }
            set
            {
                rbB = value;
                Update("RbB");
            }
        }
        public bool RbP
        {
            get { return rbP; }
            set
            {
                rbP = value;
                Update("RbP");
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                Update("Count");
            }
        }

        public List<Cake> Cakes
        {
            get { return cakes; }
            set
            {
                cakes = value;
                Update("Cakes");
            }
        }
    }
}
