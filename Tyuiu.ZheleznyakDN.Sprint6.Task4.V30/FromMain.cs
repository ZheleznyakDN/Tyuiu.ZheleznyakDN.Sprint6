using Tyuiu.ZheleznyakDN.Sprint6.Task4.V30.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task4.V30
{
    public partial class FromMain : Form
    {
        DataService ds = new DataService();
        public FromMain()
        {
            InitializeComponent();
        }
        private void buttonDone_ZDN_Click(object sender, EventArgs e)
        {
            textBoxResult_ZDN.Clear();
            chartFunction_ZDN.Series[0].Points.Clear();

            int start = -5;
            int stop = 5;

            double[] values = ds.GetMassFunction(start, stop);

            int x = start;

            for (int i = 0; i < values.Length; i++)
            {
                textBoxResult_ZDN.AppendText($"x = {x}: {values[i]}" + Environment.NewLine);
                chartFunction_ZDN.Series[0].Points.AddXY(x, values[i]);
                x++;
            }
        }

        private void buttonSave_ZDN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"OutPutFileTask4V30.txt";

                File.WriteAllText(path, textBoxResult_ZDN.Text);

                DialogResult result = MessageBox.Show(
                    $"Файл сохранён:\n{Path.GetFullPath(path)}\nОткрыть файл?",
                    "Сохранение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }

        private void buttonHelp_ZDN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 4 выполнил студент группы ПКТб-25-1 Железняк Дамир Николаевич",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
