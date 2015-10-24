using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Level
    {
        public List<Point> pointList;

        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }
    }
}
