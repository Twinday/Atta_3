using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsLib
{
    public class Triangle
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }

        //1 - точки лежат во 2 и 4 четвертях
        //2 - точки лежат в 1 и 3 четвертях
        //3 - точки лежат в 3-х различных четвертях
        public int Way;
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.X3 = x3;
            this.Y3 = y3;
        }

        //отбирает треугольники, вершины которых лежат в 2-х не соседних плоскостях
        //или в 3 плоскостях
        //так как только в этих случаях треугольник может лежать в 4-х плоскостях
        public bool FirstFilter()
        {
            int AreaA = NumberArea(X1, Y1);
            int AreaB = NumberArea(X2, Y2);
            int AreaC = NumberArea(X3, Y3);
            if ((AreaA == 2) && (AreaB == 2) && (AreaC == 4))
            {
                Way = 1;
                return true;
            }
            else if ((AreaA == 1) && (AreaB == 1) && (AreaC == 3))
            {
                Way = 2;
                return true;
            }
            else if ((AreaA == 2) && (AreaC == 2) && (AreaB == 4))
            {
                Way = 1;
                return true;
            }
            else if ((AreaA == 1) && (AreaC == 1) && (AreaB == 3))
            {
                Way = 2;
                return true;
            }
            else if ((AreaB == 2) && (AreaC == 2) && (AreaA == 4))
            {
                Way = 1;
                return true;
            }
            else if ((AreaB == 1) && (AreaC == 1) && (AreaA == 3))
            {
                Way = 2;
                return true;
            }
            else if ((AreaA != AreaB) && (AreaA != AreaC) && (AreaB != AreaC))
            {
                Way = 3;
                return true;
            }
            else
                return false;
        }

        //определяет в какой четверти лежит точка
        public int NumberArea(double x, double y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else
                return 4;
        }

        //проверяет пересекает ли отрезок оси координат
        //если отрезок пересекает и ОХ и OY, то возвращает true
        //иначе false
        public bool LineSegmentCrossOXandOY(double x1, double y1, double x2, double y2)
        {
            double x;
            double y;
            double k;
            double b;
            k = (y2 - y1) / (x2 - x1);
            b = y1 - (k * x1);
            //пересечение прямой с осью OY
            y = b;
            //пересечение прямой с осью OX
            x = - b / k;
            bool ox, oy;
            if ((x > x1) && (x < x2) || (x > x2) && (x < x1))
                ox = true;
            else
                ox = false;
            if ((y > y1) && (y < y2) || (y > y2) && (y < y1))
                oy = true;
            else
                oy = false;
            if (ox && oy)
                return true;
            else
                return false;
        }

        //возвращает номер четверти, которую пересекает отрезок прямой
        public int NumberCrossArea(double x1, double y1, double x2, double y2)
        {
            double x;
            double y;
            double k;
            double b;
            k = (y2 - y1) / (x2 - x1);
            b = y1 - (k * x1);
            //пересечение прямой с осью OY
            y = b;
            //пересечение прямой с осью OX
            x = -b / k;
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else
                return 4;
        }

        //true - если треугольник лежит в 4 четвертях,
        //иначе - false
        public bool SecondFilter()
        {
            int AreaA = NumberArea(X1, Y1);
            int AreaB = NumberArea(X2, Y2);
            int AreaC = NumberArea(X3, Y3);
            bool AB = LineSegmentCrossOXandOY(X1, Y1, X2, Y2);
            bool BC = LineSegmentCrossOXandOY(X2, Y2, X3, Y3);
            bool AC = LineSegmentCrossOXandOY(X1, Y1, X3, Y3);
            int dotAB = NumberCrossArea(X1, Y1, X2, Y3);
            int dotBC = NumberCrossArea(X2, Y2, X3, Y3);
            int dotAC = NumberCrossArea(X1, Y1, X3, Y3);
            if (Way == 1 && ((AB && dotAB == 1) || (BC && dotBC == 1) || (AC && dotAC == 1)) && ((AB && dotAB == 3) || (BC && dotBC == 3) || (AC && dotAC == 3)))
                return true;
            else if (Way == 2 && ((AB && dotAB == 2) || (BC && dotBC == 2) || (AC && dotAC == 2)) && ((AB && dotAB == 4) || (BC && dotBC == 4) || (AC && dotAC == 4)))
                return true;
            else if (Way == 3 && (AB || BC || AC) && (((dotAB != AreaA) && (dotAB != AreaB) && (dotAB != AreaC)) || ((dotBC != AreaA) && (dotBC != AreaB) && (dotBC != AreaC)) || ((dotAC != AreaA) && (dotAC != AreaB) && (dotAC != AreaC))))
                return true;
            else
                return false;

        }
    }
}
