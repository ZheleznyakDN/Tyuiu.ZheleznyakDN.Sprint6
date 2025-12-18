using Tyuiu.ZheleznyakDN.Sprint6.Task7.V11.Lib;

namespace Tyuiu.ZheleznyakDN.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        private void buttonHelp_ZDN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return matrix;
        }
        private void buttonOpenFile_ZDN_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] matrix = new int[rows, columns];

            matrix = LoadFromFileData(openFilePath);

            dataGridViewVvod_ZDN.ColumnCount = columns;
            dataGridViewVvod_ZDN.RowCount = rows;
            dataGridViewVivod_ZDN.ColumnCount = columns;
            dataGridViewVivod_ZDN.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewVvod_ZDN.Columns[h].Width = 70;
                dataGridViewVivod_ZDN.Columns[h].Width = 70;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewVvod_ZDN.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonDone_ZDN.Enabled = true;
        }
        private void buttonDone_ZDN_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, columns];
            matrix = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewVivod_ZDN.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonSave_ZDN.Enabled = true;
        }

        private void buttonSave_ZDN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewVivod_ZDN.RowCount;
            int columns = dataGridViewVivod_ZDN.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewVivod_ZDN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewVivod_ZDN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }
}
