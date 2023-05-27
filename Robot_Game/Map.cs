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
                    } else if((i == 1 && j == 4) || (i == 2 && j == 5) || (i == 3 && j == 9) || (i == 5 && j == 9) || (i == 8 && j == 3)){
                        cp[i, j] = new Obstacle(ObstacleType.TREE);
                        Console.Write(cp[i, j].desenhar() + " ");
                    } else if(i == 5 && j < 7) {
                        cp[i, j] = new Obstacle(ObstacleType.WATTER);
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