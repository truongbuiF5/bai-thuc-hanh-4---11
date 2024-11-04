using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuc_hanh_4__11
{
    public class Customer 
    {
        private static int counter = 0; 
        public int Id { get; private set; } 
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            Id = ++counter; 
        }

        public override string ToString()
        {
            return Name; 
        }
    }
}
