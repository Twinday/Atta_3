using FormsLib;
using LogicsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _10._1._12
{
    public partial class Form1 : Form
    {
        public List<Triangle> Matrix;
        public List<Triangle> NewMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Matrix = GVUtility.ReadGVMatrix(InputMatrix);
            Logics Logic = new Logics(Matrix);
            NewMatrix = Logic.TriangleIn4Part();
            if (NewMatrix.Count == 0)
                MessageBox.Show("Ни один из данных треугольников не может лежать в 4 четвертях", "Message");
            else
                GVUtility.CreateGVMatrix(ResultMatrix, NewMatrix);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Matrix = FileTools.ReadFileAndConvertStrToList(openFileDialog1.FileName);
                    GVUtility.CreateGVMatrix(InputMatrix, Matrix);
                }
            }
            catch
            {
                GVUtility.Error(1);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileTools.WriteFileAndConvertListToStr(saveFileDialog1.FileName, NewMatrix);
            }
            catch
            {
                GVUtility.Error(2);
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (int.Parse(InputN.Text) != 0)
            {
                Matrix = GVUtility.CreateRandomMatrix(int.Parse(InputN.Text));
                GVUtility.CreateGVMatrix(InputMatrix, Matrix);
            }
            else
            {
                GVUtility.Error(0);
            }
        }
    }
}
