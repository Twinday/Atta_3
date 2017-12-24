using LogicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLib
{
    public class GVUtility
    {
        //вывод матрицы(списка) в GridView
        public static void CreateGVMatrix(DataGridView dgv, List<Triangle> Matrix)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 6;
            dgv.RowCount = Matrix.Count;

            dgv.Columns[0].HeaderText = "X1";
            dgv.Columns[1].HeaderText = "Y1";
            dgv.Columns[2].HeaderText = "X2";
            dgv.Columns[3].HeaderText = "Y2";
            dgv.Columns[4].HeaderText = "X3";
            dgv.Columns[5].HeaderText = "Y3";
            for (int j = 0; j < dgv.ColumnCount; j++)
                dgv.Columns[j].Width = 40;

            int i = 0;
            foreach(Triangle t in Matrix)
            {
                dgv.Rows[i].Cells[0].Value = t.X1;
                dgv.Rows[i].Cells[1].Value = t.Y1;
                dgv.Rows[i].Cells[2].Value = t.X2;
                dgv.Rows[i].Cells[3].Value = t.Y2;
                dgv.Rows[i].Cells[4].Value = t.X3;
                dgv.Rows[i].Cells[5].Value = t.Y3;
                i++;
            }
        }

        //чтение матрицы(списка) из GridView
        public static List<Triangle> ReadGVMatrix(DataGridView dgv)
        {
            List<Triangle> GVmatrix = new List<Triangle>();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                double x1 = double.Parse(dgv.Rows[i].Cells[0].Value.ToString());
                double y1 = double.Parse(dgv.Rows[i].Cells[1].Value.ToString());
                double x2 = double.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                double y2 = double.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                double x3 = double.Parse(dgv.Rows[i].Cells[4].Value.ToString());
                double y3 = double.Parse(dgv.Rows[i].Cells[5].Value.ToString());
                GVmatrix.Add(new Triangle(x1, y1, x2, y2, x3, y3));
            }
            return GVmatrix;
        }

        //создание рандомной матрицы
        public  static List<Triangle> CreateRandomMatrix(int row)
        {
            Random rnd = new Random();
            List<Triangle> rndMatrix = new List<Triangle>();
            for (int i = 0; i < row; i++)
            {
                double x1 = rnd.Next(-50, 50);
                double y1 = rnd.Next(-50, 50);
                double x2 = rnd.Next(-50, 50);
                double y2 = rnd.Next(-50, 50);
                double x3 = rnd.Next(-50, 50);
                double y3 = rnd.Next(-50, 50);
                rndMatrix.Add(new Triangle(x1, y1, x2, y2, x3, y3));
            }
            return rndMatrix;
        }

        //возможные ошибки
        public  static void Error(int type)
        {
            switch (type)
            {
                case 0:
                    MessageBox.Show("Матрица не задана", "Error");
                    break;
                case 1:
                    MessageBox.Show("Ошибка чтения файла", "Error");
                    break;
                case 2:
                    MessageBox.Show("Ошибка записи файла", "Error");
                    break;
            }
        }
    }
}
