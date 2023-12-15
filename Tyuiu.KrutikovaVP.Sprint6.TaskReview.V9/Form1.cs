using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tyuiu.KrutikovaVP.Sprint6.TaskReview.V9.Lib;

namespace Tyuiu.KrutikovaVP.Sprint6.TaskReview.V9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonGetMatrix_KVP_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxVarN_KVP.Text);
                int m = Convert.ToInt32(textBoxVarM_KVP.Text);
                int n1 = Convert.ToInt32(textBoxVarN1_KVP.Text);
                int n2 = Convert.ToInt32(textBoxVarM1_KVP.Text);


                int[,] array = new int[n, m];


                array = ds.GetMatrix(n, m, n1, n2);

                dataGridViewGetMatrix_KVP.ColumnCount = n;
                dataGridViewGetMatrix_KVP.RowCount = m;

                for (int i = 0; i < m; i++)
                {
                    dataGridViewGetMatrix_KVP.Columns[i].Width = 90;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridViewGetMatrix_KVP.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                    }
                }
                buttonDone_KVP.Enabled = true;

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxVarN_KVP.Text);
            int m = Convert.ToInt32(textBoxVarM_KVP.Text);
            int c = Convert.ToInt32(textBoxVarC_KVP.Text);
            int k = Convert.ToInt32(textBoxVarK_KVP.Text);
            int l = Convert.ToInt32(textBoxVarL_KVP.Text);

            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(dataGridViewGetMatrix_KVP.Rows[i].Cells[j].Value);
                }
            }

            int res = ds.resultGetMatrix(array, c, k, l);
            textBoxResult_KVP.Text = Convert.ToString(res);
        }
    }
    
}
