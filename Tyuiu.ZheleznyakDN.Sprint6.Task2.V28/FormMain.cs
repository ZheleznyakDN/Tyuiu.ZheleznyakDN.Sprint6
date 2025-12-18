using Tyuiu.ZheleznyakDN.Sprint6.Task2.V28.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_ZDN_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep_ZDN.Text);
                int stop = Convert.ToInt32(textBoxStopStep_ZDN.Text);

                // Проверяем, что старт = -5 и стоп = 5 как в задании
                if (start != -5 || stop != 5)
                {
                    MessageBox.Show("По заданию диапазон должен быть [-5; 5]!\nВведите -5 и 5",
                                    "Информация",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                double[] arr = ds.GetMassFunction(start, stop);

                textBoxResult_ZDN.Text = "";

                textBoxResult_ZDN.AppendText("+-------+----------+" + Environment.NewLine);
                textBoxResult_ZDN.AppendText("|   X   |   F(x)   |" + Environment.NewLine);
                textBoxResult_ZDN.AppendText("+-------+----------+" + Environment.NewLine);

                int x = start;

                for (int i = 0; i < arr.Length; i++)
                {
                    string line = String.Format("|{0,7:D}|{1,10:F2}|", x, arr[i]);
                    textBoxResult_ZDN.AppendText(line + Environment.NewLine);
                    x++;
                }

                textBoxResult_ZDN.AppendText("+-------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ошибка: неверно введены данные!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZDN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-25-1 Железняк Дамир Николаевич",
                            "Справка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


        }
    }
}
