using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class VerticalWall 
    {
        List<Point> pointList;

        public VerticalWall(int yUp, int yDown, int x, char sym)
        {
            pointList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {

                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }
    }
}
