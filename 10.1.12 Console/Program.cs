using ConsoleLib;
using FormsLib;
using LogicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._12_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10.1.12");
            bool ansOpen = ConsoleUtility.AnswerOpen();
            List<Triangle> Matrix = new List<Triangle>();
            List<Triangle> newMatrix = new List<Triangle>();
            if (ansOpen == true)
            {
                Matrix = ConsoleUtility.MatrixRead();
                Console.WriteLine("Генерирум список трекгольников...");
                ConsoleUtility.OutputMatrix(Matrix);
            }
            else
            {
                Console.WriteLine("Введите размерность матрицы");

                int row = ConsoleUtility.InputRowAndColumn("Кол-во строк в матрице: ");
                Console.WriteLine("Генерирум список трекгольников...");
                Matrix = GVUtility.CreateRandomMatrix(row);
                ConsoleUtility.OutputMatrix(Matrix);
            }
            Logics log = new Logics(Matrix);
            newMatrix = log.TriangleIn4Part();
            if (newMatrix.Count == 0)
                Console.WriteLine("Ни один из данных треугольников не может лежать сразу в 4 четвертях");
            else
            {
                Console.WriteLine("Эти треугольники лежат в 4 четвертях на координатной сетке:");
                ConsoleUtility.OutputMatrix(newMatrix);
                ConsoleUtility.WriteMatrix(newMatrix);
            }

            Console.ReadKey();
        }
    }
}
