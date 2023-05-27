using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewel_Collector
{
    public abstract class Jewell
    {
        public int X {get; set;}
        public int Y {get; set;}

        public abstract override string ToString();
    }
}