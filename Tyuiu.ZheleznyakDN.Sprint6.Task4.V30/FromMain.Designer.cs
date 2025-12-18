namespace Tyuiu.ZheleznyakDN.Sprint6.Task4.V30
{
    partial class FromMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCond_ZDN;
        private System.Windows.Forms.TextBox textBoxResult_ZDN;
        private System.Windows.Forms.Button buttonDone_ZDN;
        private System.Windows.Forms.Button buttonSave_ZDN;
        private System.Windows.Forms.Button buttonHelp_ZDN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZDN;

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
            this.labelCond_ZDN = new System.Windows.Forms.Label();
            this.textBoxResult_ZDN = new System.Windows.Forms.TextBox();
            this.buttonDone_ZDN = new System.Windows.Forms.Button();
            this.buttonSave_ZDN = new System.Windows.Forms.Button();
            this.buttonHelp_ZDN = new System.Windows.Forms.Button();
            this.chartFunction_ZDN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCond_ZDN
            // 
            this.labelCond_ZDN.AutoSize = true;
            this.labelCond_ZDN.Location = new System.Drawing.Point(12, 9);
            this.labelCond_ZDN.Name = "labelCond_ZDN";
            this.labelCond_ZDN.Size = new System.Drawing.Size(500, 40);
            this.labelCond_ZDN.TabIndex = 5;
            this.labelCond_ZDN.Text = "Табулирование функции F(x) на диапазоне [-5; 5]\r\nF(x) = (5x + 2.5)/(sin(x) + 2) + 2x + 2\r\nРезультат вывести в TextBox и построить график.";
            // 
            // textBoxResult_ZDN
            // 
            this.textBoxResult_ZDN.Location = new System.Drawing.Point(15, 80);
            this.textBoxResult_ZDN.Multiline = true;
            this.textBoxResult_ZDN.Name = "textBoxResult_ZDN";
            this.textBoxResult_ZDN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZDN.Size = new System.Drawing.Size(250, 350);
            this.textBoxResult_ZDN.TabIndex = 4;
            // 
            // buttonDone_ZDN
            // 
            this.buttonDone_ZDN.Location = new System.Drawing.Point(870, 12);
            this.buttonDone_ZDN.Name = "buttonDone_ZDN";
            this.buttonDone_ZDN.Size = new System.Drawing.Size(110, 40);
            this.buttonDone_ZDN.TabIndex = 3;
            this.buttonDone_ZDN.Text = "Выполнить";
            this.buttonDone_ZDN.Click += new System.EventHandler(this.buttonDone_ZDN_Click);
            // 
            // buttonSave_ZDN
            // 
            this.buttonSave_ZDN.Location = new System.Drawing.Point(754, 12);
            this.buttonSave_ZDN.Name = "buttonSave_ZDN";
            this.buttonSave_ZDN.Size = new System.Drawing.Size(110, 40);
            this.buttonSave_ZDN.TabIndex = 2;
            this.buttonSave_ZDN.Text = "Сохранить";
            this.buttonSave_ZDN.Click += new System.EventHandler(this.buttonSave_ZDN_Click);
            // 
            // buttonHelp_ZDN
            // 
            this.buttonHelp_ZDN.Location = new System.Drawing.Point(403, 12);
            this.buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            this.buttonHelp_ZDN.Size = new System.Drawing.Size(110, 40);
            this.buttonHelp_ZDN.TabIndex = 1;
            this.buttonHelp_ZDN.Text = "Справка";
            this.buttonHelp_ZDN.Click += new System.EventHandler(this.buttonHelp_ZDN_Click);
            // 
            // chartFunction_ZDN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZDN.ChartAreas.Add(chartArea1);
            this.chartFunction_ZDN.Location = new System.Drawing.Point(330, 80);
            this.chartFunction_ZDN.Name = "chartFunction_ZDN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chartFunction_ZDN.Series.Add(series1);
            this.chartFunction_ZDN.Size = new System.Drawing.Size(650, 350);
            this.chartFunction_ZDN.TabIndex = 0;
            title1.Name = "Title1";
            title1.Text = "График функции F(x)";
            this.chartFunction_ZDN.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1000, 460);
            this.Controls.Add(this.chartFunction_ZDN);
            this.Controls.Add(this.buttonHelp_ZDN);
            this.Controls.Add(this.buttonSave_ZDN);
            this.Controls.Add(this.buttonDone_ZDN);
            this.Controls.Add(this.textBoxResult_ZDN);
            this.Controls.Add(this.labelCond_ZDN);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 30 | Железняк Д.Н.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
