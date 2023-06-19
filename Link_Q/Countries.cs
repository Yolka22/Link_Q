using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Q
{
    internal class Countri
    {

        public string Name { get; set; }

        public string Capital { get; set; }

        public int People { get; set; }
        public int Square { get; set; }
        public string Part { get; set; }

        public override string ToString()
        {
            return $"{Name} {Capital} {People} {Square} {Part}";
        }
    }
}
