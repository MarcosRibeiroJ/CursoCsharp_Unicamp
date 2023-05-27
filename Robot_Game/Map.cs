using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Map
    {
        private Cell[,] cp = new Cell[10, 10];

        public void gerarMapa() {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    if(i == 0 && j == 0) {
                        cp[i, j] = new Robot();
                        Console.Write(cp[i, j].desenhar() + " ");
                    } else {
                        cp[i, j] = new Cell();
                        Console.Write(cp[i, j].desenhar() + " ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bag total items: 0 | Bag total items: 0");
            Console.WriteLine("Enter de comand: ");
        }

    }
}