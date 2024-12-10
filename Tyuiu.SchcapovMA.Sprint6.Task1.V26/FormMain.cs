using Tyuiu.SchcapovMA.Sprint6.Task1.V26.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonRes_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInValStart_SMA.Text);
                int stopStep = Convert.ToInt32(textBoxInValEnd_SMA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOutRes_SMA.Text = "";
                textBoxOutRes_SMA.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxOutRes_SMA.AppendText("|    X    |   f(x)   " + Environment.NewLine);
                textBoxOutRes_SMA.AppendText("+---------+---------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0, 5:d}    | {1, 5:f2}    ", startStep, valueArray[i]);
                    textBoxOutRes_SMA.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }
                textBoxOutRes_SMA.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAnswer_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������� ������ �����-24-1 ����� ������ �������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxInValStart_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != 8) && (e.KeyChar != ',')&&( e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
