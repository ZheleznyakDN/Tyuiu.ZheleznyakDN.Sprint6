using Tyuiu.ZheleznyakDN.Sprint6.Task5.V16.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        private string filePath_ZDN = @"C:\Users\Дамир\OneDrive\Desktop\InPutDataFileTask5V16.txt";
        private DataService ds_ZDN = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_ZDN_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Julia\Desktop\DataSprint6\InPutFileTask5V16.txt";

            if (File.Exists(path))
            {
                MessageBox.Show("Файл найден! Открываю...", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Открытие файла
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDo_ZDN_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values_ZDN = ds_ZDN.LoadFromDataFile(filePath_ZDN);

                dataGridViewResult_ZDN.Rows.Clear();
                dataGridViewResult_ZDN.Columns.Clear();
                dataGridViewResult_ZDN.Columns.Add("col", "Значения");

                foreach (double val_ZDN in values_ZDN)
                    dataGridViewResult_ZDN.Rows.Add(val_ZDN.ToString("F3"));

                chartValues_ZDN.Series[0].Points.Clear();
                for (int i = 0; i < values_ZDN.Length; i++)
                {
                    chartValues_ZDN.Series[0].Points.AddXY(i + 1, values_ZDN[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonHelp_ZDN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание выполнил студент группы ПКТб-25-1 Железняк Д.Н."
            );
        }
    }
}
