using Tyuiu.SchcapovMA.Sprint6.Task7.V19.Lib;
namespace Tyuiu.SchcapovMA.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_SMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_SMA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_SMA.ColumnCount = 50;
            dataGridViewOutPut_SMA.ColumnCount = 50;

            dataGridViewInPut_SMA.RowCount = 50;
            dataGridViewOutPut_SMA.RowCount = 50;


            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_SMA.Columns[i].Width = 25;
                dataGridViewOutPut_SMA.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_SMA_Click(object sender, EventArgs e)
        {
            saveFileDialog_SMA.FileName = "OutPutFileTask7V19.csv";
            saveFileDialog_SMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SMA.ShowDialog();

            string path = saveFileDialog_SMA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_SMA.RowCount;
            int columns = dataGridViewOutPut_SMA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_SMA.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_SMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

       

        

        private void buttonOpenFile_SMA_Click_1(object sender, EventArgs e)
        {
            openFileDialog_SMA.ShowDialog();
            openFilePath = openFileDialog_SMA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_SMA.ColumnCount = columns;
            dataGridViewInPut_SMA.RowCount = rows;
            dataGridViewOutPut_SMA.ColumnCount = columns;
            dataGridViewOutPut_SMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_SMA.Columns[i].Width = 25;
                dataGridViewOutPut_SMA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_SMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonOutPutRes_SMA.Enabled = true;

        }

        private void buttonOutPutRes_SMA_Click_1(object sender, EventArgs e)
        {
            try
            {
                int[,] arrayValues = new int[rows, columns];
                arrayValues = ds.GetMatrix(openFilePath);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPut_SMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                buttonSaveFile_SMA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не содержит матрицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
