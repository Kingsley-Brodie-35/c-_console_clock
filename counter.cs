using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class Counter
    {
        /*fields*/
        private int _count;
        private string _name;
        /*constructor*/
        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        /*property*/
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }
        //Methods
        public void Increment()
        {
            _count++;
        }
        public void Reset()
        {
            _count = 0;
        }
    }
}
