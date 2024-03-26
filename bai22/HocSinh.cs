using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class HocSinh
    {
        // auto implemented properties
        public string name {  get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        // method
        // ToString
        public override string ToString()
        {
            return this.name + "\t" + this.email + "\t" + this.phone;
        }
    }
}
