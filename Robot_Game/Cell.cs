using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Cell
    {
        private int x = 0;
        private int y = 0;
        private CellType tipo = CellType.VAZIO;
        
        public int getX() {
        return this.x;
        }
        
        public void setX(int valor) {
        x = valor;
        }
        
        public int getY() {
        return this.y;
        }
        
        public void setY(int valor) {
        y = valor;
        }
        
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
        return  new int[] {this.getX(), this.getY()};
        }

    }
}