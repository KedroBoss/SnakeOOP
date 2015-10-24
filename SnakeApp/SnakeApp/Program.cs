using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';

            p1.Draw(p1.x, p1.y, p1.sym);


            Point p2 = new Point();
            p2.x = 3;
            p2.y = 5;
            p2.sym = '#';

            p1.Draw(p2.x, p2.y, p2.sym);

            List<Point> pointList = new List<Point>();
            List<char> symList = new List<char>();

            pointList.Add(p1);
            pointList.Add(p2);

            foreach(Point p in pointList)
            {
                Console.WriteLine(p.sym);
            }

            /*for(int i = 0; i < pointList.Count; i++)
            {
                char pointChar;
                pointChar = pointList[i].sym;

                Console.WriteLine(pointChar);
            }*/

            /*symList.Add(p1.sym);
            symList.Add(p2.sym);

            foreach(char sym in symList)
            {
                Console.WriteLine(sym);
            }*/


            Console.ReadKey();
        }

        
    }
}
