using LogicsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ConsoleLib
{
    public class ConsoleUtility
    {
        //вопрос открыт файл или нет
        public static bool AnswerOpen()
        {
            Console.Write("Открыть файл (1 - да, 0 - нет): ");
            try
            {
                int ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                    return true;
                else if (ans == 0)
                    return false;
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
                return AnswerOpen();
            }
        }

        //чтение матрицы из файла
        public static List<Triangle> MatrixRead()
        {
            Console.WriteLine("Введите путь к файлу (Например: input10.txt):");
            List<Triangle> matrix = new List<Triangle>();
            try
            {
                matrix = FileTools.ReadFileAndConvertStrToList(Console.ReadLine());
                return matrix;
            }
            catch
            {
                Console.WriteLine("Ошибка чтения файла");
                return MatrixRead();
            }
        }

        //вывод матрицы
        public static void OutputMatrix(List<Triangle> matrix)
        {
            foreach (Triangle t in matrix)
            {
                Console.WriteLine(t.X1 + " " + t.Y1 + " " + t.X2 + " " + t.Y2 + " " + t.X3 + " " + t.Y3);
            }
        }

        //перезаписывает матрицу в существующий файл или создаёт новый
        public static void WriteMatrix(List<Triangle> matrix)
        {
            try
            {
                Console.WriteLine("Куда записать матрицу (Например: output10.txt):");
                FileTools.WriteFileAndConvertListToStr(Console.ReadLine(), matrix);
                Console.WriteLine("Файл записан.");
            }
            catch
            {
                Console.WriteLine("Ошибка записи матрицы в файл. Повторите попытку.");
                WriteMatrix(matrix);
            }
        }

        //ввод кол-во строк и/или столбцов для рандомной матрицы
        public static int InputRowAndColumn(string name)
        {
            Console.Write(name);
            try
            {
                int num = int.Parse(Console.ReadLine());
                return num;
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
                return InputRowAndColumn(name);
            }
        }
    }
}
