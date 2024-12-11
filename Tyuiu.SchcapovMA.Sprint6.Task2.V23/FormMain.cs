using Tyuiu.SchcapovMA.Sprint6.Task2.V23.Lib;

namespace Tyuiu.SchcapovMA.Sprint6.Task2.V23
{
    public partial class FormTask_SMA : Form
    {
        public FormTask_SMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonRes_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxValInSt_SMA.Text);
                int stopStep = Convert.ToInt32(textBoxValInEnd_SMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SMA.Titles.Add("График функции 4-2x+(2+cos(x))/(2x- 2)");

                this.chartFunction_SMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SMA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewRes_SMA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxValInSt_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonAns_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСБ-24-1 Щапов Максим Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRes_SMA_MouseEnter(object sender, EventArgs e)
        {
            buttonRes_SMA.BackColor = Color.Red;
        }

        private void buttonRes_SMA_MouseLeave(object sender, EventArgs e)
        {
            buttonRes_SMA.BackColor = Color.FromArgb(128,128,255);
        }

        private void buttonRes_SMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRes_SMA.BackColor = Color.Green;
        }
    }
}
