using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsLib
{
    public class Logics
    {
        public List<Triangle> Triangle { get; set; }
        public Logics(List<Triangle> triangle)
        {
            this.Triangle = triangle;
        }

        //логика 10.1.12
        /*Для набора треугольников, заданных тремя вершинами, найти такие, которые одновременно лежат во всех 4-х четвертях (на координатной сетке).*/
        public List<Triangle> TriangleIn4Part()
        {
            List<Triangle> NewTriangle = new List<Triangle>();
            foreach (Triangle t in Triangle)
            {
                Triangle trngl = new Triangle(t.X1, t.Y1, t.X2, t.Y2, t.X3, t.Y3);
                if (trngl.FirstFilter())
                {
                    if (trngl.SecondFilter())
                    {
                        NewTriangle.Add(t);
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            return NewTriangle;
        }

    }
}
