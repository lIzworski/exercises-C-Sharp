using System.Security.Cryptography.X509Certificates;

namespace zad3
{
    internal class Program
    {
        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public struct Line
        {
            public Point start;
            public Point end;

            public Line(Point st, Point ed)
            {
                start = st;
                end = ed;
            }

            public double distanceBetweenPoints()
            {
               double distance = Math.Sqrt((end.x - start.x) * (end.x - start.x) + (end.y - start.y) * (end.y - start.y));
               return distance;
            }
            public void showDistanceBetweenPoint()
            {
                Console.WriteLine($"odległość pomiedzy punktem x:{start.x} y:{start.y} a puntem x:{end.x} y:{end.y} wynosi {distanceBetweenPoints()}");
            }
        }
        public struct Triangle
        {
            public Line l1;
            public Line l2;
            public Line l3;
            public double xl1;
            public double xl2;
            public double xl3;
            public Triangle(Point x1, Point y1, Point x2, Point y2, Point x3, Point y3 )
            {
                l1 = new Line(x1, y1);
                l2 = new Line(x2, y2); 
                l3 = new Line(x3, y3);
                xl1 = l1.distanceBetweenPoints();
                xl2 = l2.distanceBetweenPoints();
                xl3 = l3.distanceBetweenPoints();
            }

            public bool CanWeBuildATriagle()
            {
                bool isPossible = false;
                if(xl1 > xl2)
                {
                    if(xl1 > xl3)
                    {
                        if(xl3 + xl2 > xl1)
                        {
                            isPossible = true;
                        }
                        else
                        {
                            isPossible = false;
                        }
                    }
                }
                else if(xl2 > xl1)
                {
                    if(xl2 > xl3)
                    {
                        if (xl3 + xl1 > xl2)
                        {
                            isPossible = true;
                        }
                        else
                        {
                            isPossible = false;
                        }
                    }
                }
                else
                {
                    if (xl1 + xl2 > xl3)
                    {
                        isPossible = true;
                    }
                    else
                    {
                        isPossible = false;
                    }
                }
                return isPossible;
            }

            public void showInformationAboutItIsPosibleToCreateATraingle()
            {
                if (CanWeBuildATriagle() == true)
                {
                    Console.WriteLine("Tak, z tych odcinków można zbudować trójkąt");
                }
                else
                {
                    Console.WriteLine("Nie, z tych odcinków nie mozna zbudowac trójkąta");
                }
            }
        }


        static void Main(string[] args)
        {
            Line line = new Line(new Point(1,2),new Point(1,4));
            line.showDistanceBetweenPoint();
            Console.WriteLine();
            Triangle t1 = new Triangle(new Point(1,1), new Point(1, 2), new Point(1, 1), new Point(1,3), new Point(1, 1), new Point(1, 4)) ;
            t1.showInformationAboutItIsPosibleToCreateATraingle(); // 1 + 2 == 3
            Triangle t2 = new Triangle(new Point(1,1), new Point(1, 3), new Point(1, 1), new Point(1,3), new Point(1, 1), new Point(1, 4)) ;
            t2.showInformationAboutItIsPosibleToCreateATraingle(); // 2 + 2 > 3

        }
    }
}