using Tyuiu.SchcapovMA.Sprint6.Task0.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task0.V13
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }











        private void buttonDoneAnswer_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСБ-24-1 Щапов Максим Александрович","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoneRes_SMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SMA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxValueX_SMA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBoxValueX_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
