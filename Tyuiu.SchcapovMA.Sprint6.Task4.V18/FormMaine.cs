using Tyuiu.SchcapovMA.Sprint6.Task4.V18.Lib;

namespace Tyuiu.SchcapovMA.Sprint6.Task4.V18
{
    public partial class FormMaine : Form
    {
        public FormMaine()
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

                //this.chartView_SMA.Titles.Add("������ ������� 2x-3/(x+cos(x))+5 ");

                this.chartView_SMA.ChartAreas[0].AxisX.Title = "��� X";
                this.chartView_SMA.ChartAreas[0].AxisY.Title = "��� Y";
                textBoxOut_SMA.Text = "";
                chartView_SMA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.textBoxOut_SMA.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartView_SMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxValInSt_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonAnswer_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 ����� ������ �������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileSprint5Task4.txt");
                File.WriteAllText(path, textBoxOut_SMA.Text);
                DialogResult dialogResult = MessageBox.Show("����: " + path + " ������� �������!\n������� ���?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }

            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRes_SMA_MouseEnter(object sender, EventArgs e)
        {
            buttonRes_SMA.BackColor = Color.Red;
        }

        private void buttonRes_SMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRes_SMA.BackColor = Color.Green;
        }

        private void buttonRes_SMA_MouseLeave(object sender, EventArgs e)
        {
            buttonRes_SMA.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void buttonSave_SMA_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_SMA.BackColor = Color.Red;
        }

        private void buttonSave_SMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSave_SMA.BackColor = Color.Green;
        }

        private void buttonSave_SMA_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_SMA.BackColor = Color.DodgerBlue;
        }
    }
}
//buttonSave_SMA.BackColor = Color.DodgerBlue;