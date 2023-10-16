using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        

        public override string GetInfo()
        {
            return $"{Name} {Price}";
        }
    }
}
