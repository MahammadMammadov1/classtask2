using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Journal : Product
    {
        public string Company { get; set; }

        

        public override string GetInfo()
        {
            return $"{Name}";
        }
    }
}
