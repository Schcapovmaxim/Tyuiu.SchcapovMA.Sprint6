using Tyuiu.SchcapovMA.Sprint6.Task5.V16.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task5.V16
{
    public partial class FormMaine : Form
    {
        public FormMaine()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V16.txt");
        private void buttonRun_SMA_Click(object sender, EventArgs e)
        {
            dataGridView_SMA.ColumnCount = 2;
            dataGridView_SMA.Columns[0].Width = 77;
            dataGridView_SMA.Columns[1].Width = 77;
            this.chart_SMA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_SMA.ChartAreas[0].AxisY.Title = "Ось Y";
            chart_SMA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_SMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_SMA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonAnswer_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСБ-24-1 Щапов Максим Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenF_SMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonRun_SMA_MouseEnter(object sender, EventArgs e)
        {
            buttonRun_SMA.BackColor = Color.Red;
        }

        private void buttonRun_SMA_MouseLeave(object sender, EventArgs e)
        {
            buttonRun_SMA.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void buttonRun_SMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRun_SMA.BackColor = Color.FromArgb(128, 255, 128);
        }
    }
}
