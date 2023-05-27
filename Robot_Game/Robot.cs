using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Robot : Cell
    {
        public Robot() {
            setType(CellType.ROBO);
        }

        public override string desenhar() {
		    return " ME";
	    }
    }
}