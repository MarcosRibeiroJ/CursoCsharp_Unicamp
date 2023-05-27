using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jewel_Collector
{
    public class Tree : Obstacle
    {
        public Tree(int linha, int coluna) {
            X = linha;
            Y = coluna;
        }

        public override string ToString()
        {
            return " $$";
        }

    }
}