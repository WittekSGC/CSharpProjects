using System;
using System.Windows.Forms;

namespace WFA_Valetova
{
    public partial class AlgPrimaForm : Form
    {
        int[,] matrix;
        public AlgPrimaForm()
        {
            InitializeComponent();
        }

        private void AlgPrimaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void AlgPrimaForm_Load(object sender, EventArgs e)
        {
            pickRowCol.Value = 5;
            table.RowCount = 5;
            table.ColumnCount = 5;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                for (int j = 0; j < table.RowCount; j++)
                {
                    table.Rows[j].Cells[i].Value = 0;
                }
            }
        }

        private void pickCol_ValueChanged(object sender, EventArgs e)
        {
            if (pickRowCol.Value > 1)
            {
                table.ColumnCount = int.Parse(pickRowCol.Value.ToString());
                if (pickRowCol.Value > table.RowCount)
                    for (int i = 0; i < pickRowCol.Value - table.RowCount; i++)
                        table.Rows.Add();
                else
                    if (pickRowCol.Value < table.RowCount)
                        for (int i = 0; i < table.RowCount - pickRowCol.Value; i++)
                            table.Rows.Remove(table.Rows[table.RowCount - 1]);
                ObNullIt();
            }
            else
                pickRowCol.Value = table.ColumnCount;
        }

        private void findBTN_Click(object sender, EventArgs e)
        {
            outBox.Clear();
            int x = int.Parse(pickRowCol.Value.ToString()), y = x;
            int step = x;
            matrix = new int[step, step]; ;
            int[] prohod = new int[step - 1];
            int min = int.MaxValue, imin = -1, jmin = -1;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = int.Parse(table.Rows[j].Cells[i].Value.ToString());
                    if (min > matrix[i, j] && matrix[i, j] != 0)
                    {
                        min = matrix[i, j];
                        imin = i;
                        jmin = j;
                    }
                }
            }

            for (int k = 0; k < step - 1; k++) // number of repeat cyckles
            {
                //find min
                for (int i = 0; i < step; i++)
                {
                    for (int j = 0; j < step; j++)
                    {
                        if (min > matrix[i, j] && matrix[i, j] != 0)
                        {
                            min = matrix[i, j];
                            imin = i;
                            jmin = j;
                        }
                    }
                }

                //entrying '0'
                for (int count = 0; count < step; count++)
                {
                    matrix[imin, count] = 0;
                    matrix[jmin, count] = 0;
                }

                //memoring and clean;
                prohod[k] = min;
                min = int.MaxValue;
                imin = -1;
                jmin = -1;
            }

            for (int i = 0; i < x-1; i++)
            {
                outBox.Text += prohod[i] + " ";
            }
        }


        // user methods

        void ObNullIt()
        {
            for (int i = 0; i < table.Columns.Count; i++)
            {
                for (int j = 0; j < table.RowCount; j++)
                {
                    if (table.Rows[j].Cells[i].Value == null)
                        table.Rows[j].Cells[i].Value = 0;
                }
            }
        }

        void PrintTable()
        {
            for (int i = 0; i < pickRowCol.Value; i++)
            {
                for (int j = 0; j < pickRowCol.Value; j++)
                {
                    table.Rows[j].Cells[i].Value = matrix[i, j];
                }
            }
        }
    }
}
