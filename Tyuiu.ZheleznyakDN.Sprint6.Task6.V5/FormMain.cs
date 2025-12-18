using Tyuiu.ZheleznyakDN.Sprint6.Task6.V5.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        private string openFilePath_ZDN = "";
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_ZDN_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_ZDN.ShowDialog() == DialogResult.OK)
            {
                openFilePath_ZDN = openFileDialogTask_ZDN.FileName;
                textBoxIn_ZDN.Text = File.ReadAllText(openFilePath_ZDN);
                buttonDone_ZDN.Enabled = true;
            }
        }

        private void buttonDone_ZDN_Click(object sender, EventArgs e)
        {
            if (openFilePath_ZDN == "")
            {
                MessageBox.Show("Файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string result = ds.CollectTextFromFile(openFilePath_ZDN);
                textBoxOut_ZDN.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZDN_Click(object sender, EventArgs e)
        {
            // Если нужен простой MessageBox
            MessageBox.Show(
                "Разработчик: Железняк Дамир Николаевич\n" +
                "Группа: ПКТб-25-1\n" +
                "Вариант: 5\n" +
                "Задание: Найти слова, содержащие букву 'I'",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
