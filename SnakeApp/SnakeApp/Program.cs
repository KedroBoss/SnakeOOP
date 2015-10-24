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
            /* Point p1 = new Point(1, 3, '*');
             Point p2 = new Point(3, 5, '#');*/

            /* List<Point> pointList = new List<Point>(); //Через массив точек*/
            /* List<char> symList = new List<char>(); //Через массив символов*/

            /* pointList.Add(p1);
             pointList.Add(p2);
             */
            /*foreach(Point p in pointList)
            {
                p.Draw();
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

            Console.SetBufferSize(80, 25);
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            HorizontalWall UHline = new HorizontalWall(consoleWidth - consoleWidth + 2, consoleWidth - 2, consoleHeight - consoleHeight+2, '#');
            HorizontalWall DHline = new HorizontalWall(consoleWidth - consoleWidth + 2, consoleWidth - 2, consoleHeight - 2, '#');
            VerticalWall LVline = new VerticalWall(consoleHeight - consoleHeight + 2, consoleHeight - 2, consoleWidth - consoleWidth + 2, '#');
            VerticalWall RVline = new VerticalWall(consoleHeight - consoleHeight + 2, consoleHeight - 2, consoleWidth - 2 , '#');
            UHline.Draw(); LVline.Draw();
            DHline.Draw(); RVline.Draw();


            Console.ReadKey();
        }

        
    }
}
