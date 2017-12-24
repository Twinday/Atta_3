using LogicsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public class FileTools
    {
        //чтение с файла и конвертирование строки в список треугольников
        public static List<Triangle> ReadFileAndConvertStrToList(string name)
        {
            List<Triangle> triangleList = new List<Triangle>();

            string[] fileLines = File.ReadAllLines(name);

            foreach (string line in fileLines)
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                double x1 = double.Parse(parts[0]);
                double y1 = double.Parse(parts[1]);
                double x2 = double.Parse(parts[2]);
                double y2 = double.Parse(parts[3]);
                double x3 = double.Parse(parts[4]);
                double y3 = double.Parse(parts[5]);

                triangleList.Add(new Triangle(x1, y1, x2, y2, x3, y3));
            }

            return triangleList;
        }

        //конвертирование и запись списка в файл
        public static void WriteFileAndConvertListToStr(string name, List<Triangle> L)
        {
            List<string> lines = new List<string>();

            foreach (Triangle t in L)
            {
                lines.Add(t.X1 + " " + t.Y1 + " " + t.X2 + " " + t.Y2 + " " + t.X3 + " " + t.Y3);
            }

            File.WriteAllLines(name, lines);
        }
                
    }
}
