using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinglemouse
{

    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
        public class Kata
        {

            public static bool AllAlone(char[][] house)
            {
                Point potus = default;

                for (int i = 0; i < house.GetLength(0); i++)
                {
                    for (int j = 0; j < house[i].Length; j++)
                    {
                        if (house[i][j] == 'X')
                        {
                            potus = new Point(i, j);
                        }
                    }

                }

                var scannedPoints = new List<Point>();

                var isNotAlone = Scan(potus, house, scannedPoints);

                return !isNotAlone;

                
            }

            public static bool Scan(Point point, char[][] house, List<Point> scannedPoints)
            {
                if (scannedPoints.Contains(point))
                {
                    return false;
                }
                scannedPoints.Add(point);

                if (house[point.X][ point.Y] == 'o')
                {
                    return true;
                }
                if (house[point.X][point.Y] == '#')
                {
                    return false;
                }

                var pointUp = new Point(point.X, point.Y - 1);
                var pointDown = new Point(point.X, point.Y + 1);
                var pointToLeft = new Point(point.X - 1, point.Y);
                var pointToRight = new Point(point.X + 1, point.Y);

                //if(Scan(pointUp, house, scannedPoints))
                //{
                //    return true;
                //}
                //if (Scan(pointDown, house, scannedPoints))
                //{
                //    return true;
                //}
                //if (Scan(pointToLeft, house, scannedPoints))
                //{
                //    return true;
                //}
                //if (Scan(pointToRight, house, scannedPoints))
                //{
                //    return true;
                //}

                return Scan(pointUp, house, scannedPoints) ||
                        Scan(pointDown, house, scannedPoints) ||
                        Scan(pointToLeft, house, scannedPoints) ||
                        Scan(pointToRight, house, scannedPoints);

                
            }
        }
    }

