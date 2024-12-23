using Tyuiu.SchcapovMA.Sprint6.Task6.V11.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void OpenFile_SMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMA.ShowDialog();
            openFilePath = openFileDialogTask_SMA.FileName;
            textBoxInPut_SMA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SMA.Text = groupBoxInPut_SMA.Text + " " + openFileDialogTask_SMA.FileName;
            buttonDone_SMA.Enabled = true;
            textBoxInPut_SMA.Enabled = true;
            OpenFile_SMA.Enabled = false;
            OpenFile_SMA.Enabled = true;
        }

        private void buttonDone_SMA_Click(object sender, EventArgs e)
        {

            textBoxOutPut_SMA.Text = ds.CollectTextFromFile(openFilePath);
            textBoxOutPut_SMA.Enabled = true;
            buttonDone_SMA.Enabled = false;
            buttonDone_SMA.Enabled = true;
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            buttonHelp_SMA.Enabled = false;
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
            buttonHelp_SMA.Enabled = true;
        }
    }
}
