using Tyuiu.ZheleznyakDN.Sprint6.Task3.V18.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint6.Task3.V18
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
                // Создаем исходный массив из задания
                int[,] matrix = new int[5, 5]
                {
                    {-19, -19, 1, 18, 7},
                    {5, 3, 4, 6, -12},
                    {-15, 6, 2, 2, -14},
                    {-9, -10, 15, 5, 6},
                    {-13, -15, 9, 7, 1}
                };

                // Выполняем расчет
                int[,] resultMatrix = ds.Calculate(matrix);

                // Очищаем DataGridView
                dataGridViewResult_ZDN.Rows.Clear();
                dataGridViewResult_ZDN.Columns.Clear();

                // Настраиваем DataGridView для отображения матрицы 5x5
                dataGridViewResult_ZDN.ColumnCount = 5;
                dataGridViewResult_ZDN.RowCount = 5;

                // Заполняем DataGridView результатами
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_ZDN.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
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
