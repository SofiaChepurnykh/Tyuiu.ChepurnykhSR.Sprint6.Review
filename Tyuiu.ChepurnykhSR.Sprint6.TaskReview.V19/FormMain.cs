using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChepurnykhSR.Sprint6.TaskReview.V19.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.TaskReview.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService(); 

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск Ревью выполнила студентка группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение");
        }

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBoxN_CSR.Text);
            int column = Convert.ToInt32(textBoxM_CSR.Text);
            int startRnd = Convert.ToInt32(textBoxn1_CSR.Text);
            int stopRnd = Convert.ToInt32(textBoxn2_CSR.Text);
            int[,] array = new int[row, column];
            Random rng = new Random();

            dataGridViewMatrix_CSR.RowCount = row;
            dataGridViewMatrix_CSR.ColumnCount = column;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j % 3 == 0 && j != 0)
                    {
                        array[i, j] = array[i, j - 3] - array[i, j - 2] - array[i, j - 1];                        
                    }
                    else
                    {
                        array[i, j] = rng.Next(startRnd, stopRnd);
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewMatrix_CSR.Rows[i].Cells[j].Value = array[i, j];
                    dataGridViewMatrix_CSR.Columns[j].Width = 40;
                }
            }

            int r = Convert.ToInt32(textBoxR_CSR.Text);
            int k = Convert.ToInt32(textBoxK_CSR.Text);
            int l = Convert.ToInt32(textBoxL_CSR.Text);
            int result = ds.GetMatrix(array, r, k, l);
            textBoxOutPut_CSR.Text = Convert.ToString(result);
        }
    }
}
