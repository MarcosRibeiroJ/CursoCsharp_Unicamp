using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Game
{
    public class Obstacle : Cell
    {
        private ObstacleType obstType;
        public Obstacle(ObstacleType obstacleType) {
            obstType = obstacleType;
            setType(CellType.OBSTACULO);
        }

        public override string desenhar()
        {
            if(obstType == ObstacleType.TREE) {
                return " $$";
            } else {
                return " ##";
            }
        }

    }
}