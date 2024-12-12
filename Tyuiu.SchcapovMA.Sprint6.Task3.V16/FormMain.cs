using System.Drawing.Drawing2D;
using Tyuiu.SchcapovMA.Sprint6.Task3.V16.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{14, 1, -3, 1, 10 },
                                        { 7, -3, 5, -4, 0 },
                                        { -10, -19, -18, -9, 19 },
                                        { -2, -2, -16, 2, -17 },
                                        { -16, 9, 5, 10, 16 } };

        private void buttonAnswer_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСБ-24-1 Щапов Максим Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewRes_SMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewValue_SMA.ColumnCount = columns;
            dataGridViewValue_SMA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewValue_SMA.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    dataGridViewValue_SMA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }

            }
        }

        private void buttonRes_SMA_Click(object sender, EventArgs e)
        {
            int[,] mtrxr = ds.Calculate(mtrx);
            int rows = mtrxr.GetUpperBound(0) + 1;
            int columns = mtrxr.Length / rows;
            dataGridViewRes_SMA.ColumnCount = columns;
            dataGridViewRes_SMA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                this.dataGridViewRes_SMA.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    this.dataGridViewRes_SMA.Rows[i].Cells[j].Value = Convert.ToString(mtrxr[i, j]);
                }

            }

        }

        private void textBoxStrel_SMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
