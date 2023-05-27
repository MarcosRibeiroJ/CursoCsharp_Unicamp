using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Map
    {
        private Cell[,] cells = new Cell[10, 10];

        public void gerarMapa() {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    if(i == 0 && j == 0) {
                        cells[i, j] = new Robot();
                        Console.Write(cells[i, j].desenhar() + " ");
                    } else if((i == 1 && j == 4) || (i == 2 && j == 5) || (i == 3 && j == 9) || (i == 5 && j == 9) || (i == 8 && j == 3)){
                        cells[i, j] = new Obstacle(ObstacleType.TREE);
                        cells[i, j].X = i;
                        cells[i, j].Y = j;
                        Console.Write(cells[i, j].desenhar() + " ");
                    } else if(i == 5 && j < 7) {
                        cells[i, j] = new Obstacle(ObstacleType.WATTER);
                        cells[i, j].X = i;
                        cells[i, j].Y = j;
                        Console.Write(cells[i, j].desenhar() + " ");
                    } else {
                        cells[i, j] = new Cell();
                        cells[i, j].X = i;
                        cells[i, j].Y = j;
                        Console.Write(cells[i, j].desenhar() + " ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bag total items: 0 | Bag total items: 0");
            Console.WriteLine("Enter de comand: ");
        }

    }
}