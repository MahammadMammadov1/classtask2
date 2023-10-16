using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public abstract string GetInfo();
        
    }
}
