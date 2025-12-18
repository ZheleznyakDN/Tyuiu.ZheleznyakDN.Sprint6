namespace Tyuiu.ZheleznyakDN.Sprint6.Task5.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCond_ZDN;
        private System.Windows.Forms.TextBox textBoxResult_ZDN;
        private System.Windows.Forms.Button buttonDo_ZDN;
        private System.Windows.Forms.Button buttonOpenFile_ZDN;
        private System.Windows.Forms.Button buttonHelp_ZDN;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZDN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues_ZDN;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            labelCond_ZDN = new Label();
            textBoxResult_ZDN = new TextBox();
            buttonDo_ZDN = new Button();
            buttonOpenFile_ZDN = new Button();
            buttonHelp_ZDN = new Button();
            dataGridViewResult_ZDN = new DataGridView();
            chartValues_ZDN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZDN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartValues_ZDN).BeginInit();
            SuspendLayout();
            // 
            // labelCond_ZDN
            // 
            labelCond_ZDN.AutoSize = true;
            labelCond_ZDN.Location = new System.Drawing.Point(12, 9);
            labelCond_ZDN.Name = "labelCond_ZDN";
            labelCond_ZDN.Size = new System.Drawing.Size(450, 60);
            labelCond_ZDN.TabIndex = 5;
            labelCond_ZDN.Text = "Прочитать значения из файла InPutFileTask5V16.txt\r\nВывести в DataGridView все положительные числа\r\nОкруглить значения до трех знаков после запятой\r\nПостроить диаграмму по этим значениям";
            // 
            // textBoxResult_ZDN
            // 
            textBoxResult_ZDN.Location = new System.Drawing.Point(15, 80);
            textBoxResult_ZDN.Multiline = true;
            textBoxResult_ZDN.Name = "textBoxResult_ZDN";
            textBoxResult_ZDN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZDN.Size = new System.Drawing.Size(170, 150);
            textBoxResult_ZDN.TabIndex = 4;
            textBoxResult_ZDN.Visible = false; // Скрываем TextBox, используем DataGridView
            // 
            // buttonDo_ZDN
            // 
            buttonDo_ZDN.Location = new System.Drawing.Point(754, 12);
            buttonDo_ZDN.Name = "buttonDo_ZDN";
            buttonDo_ZDN.Size = new System.Drawing.Size(110, 40);
            buttonDo_ZDN.TabIndex = 3;
            buttonDo_ZDN.Text = "Выполнить";
            buttonDo_ZDN.Click += buttonDo_ZDN_Click;
            // 
            // buttonOpenFile_ZDN
            // 
            buttonOpenFile_ZDN.Location = new System.Drawing.Point(870, 12);
            buttonOpenFile_ZDN.Name = "buttonOpenFile_ZDN";
            buttonOpenFile_ZDN.Size = new System.Drawing.Size(110, 40);
            buttonOpenFile_ZDN.TabIndex = 2;
            buttonOpenFile_ZDN.Text = "Открыть файл";
            buttonOpenFile_ZDN.Click += buttonOpenFile_ZDN_Click;
            // 
            // buttonHelp_ZDN
            // 
            buttonHelp_ZDN.Location = new System.Drawing.Point(638, 12);
            buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            buttonHelp_ZDN.Size = new System.Drawing.Size(110, 40);
            buttonHelp_ZDN.TabIndex = 1;
            buttonHelp_ZDN.Text = "Справка";
            buttonHelp_ZDN.Click += buttonHelp_ZDN_Click;
            // 
            // dataGridViewResult_ZDN
            // 
            dataGridViewResult_ZDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ZDN.Location = new System.Drawing.Point(15, 80);
            dataGridViewResult_ZDN.Name = "dataGridViewResult_ZDN";
            dataGridViewResult_ZDN.Size = new System.Drawing.Size(200, 350);
            dataGridViewResult_ZDN.TabIndex = 6;
            // 
            // chartValues_ZDN
            // 
            chartArea1.Name = "ChartArea1";
            chartValues_ZDN.ChartAreas.Add(chartArea1);
            chartValues_ZDN.Location = new System.Drawing.Point(230, 80);
            chartValues_ZDN.Name = "chartValues_ZDN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Name = "Series1";
            chartValues_ZDN.Series.Add(series1);
            chartValues_ZDN.Size = new System.Drawing.Size(750, 350);
            chartValues_ZDN.TabIndex = 7;
            title1.Name = "Title1";
            title1.Text = "График положительных значений";
            chartValues_ZDN.Titles.Add(title1);
            // 
            // FormMain
            // 
            ClientSize = new System.Drawing.Size(1000, 460);
            Controls.Add(chartValues_ZDN);
            Controls.Add(dataGridViewResult_ZDN);
            Controls.Add(buttonHelp_ZDN);
            Controls.Add(buttonOpenFile_ZDN);
            Controls.Add(buttonDo_ZDN);
            Controls.Add(textBoxResult_ZDN);
            Controls.Add(labelCond_ZDN);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 16 | Железняк Д.Н.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZDN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartValues_ZDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
