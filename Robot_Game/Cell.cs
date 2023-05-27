using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Cell
    {
        public int X {get; set;}
        
        public int Y {get; set;}
        private CellType tipo = CellType.VAZIO;
        
        public CellType getType() {
            return this.tipo;
        }
        
        public void setType(CellType valor) {
            tipo = valor;
        }
        
        public virtual string desenhar() {
            return " --";
        }
        
        public int[] informarPosicao() {
            return  new int[] {X, Y};
        }

    }
}