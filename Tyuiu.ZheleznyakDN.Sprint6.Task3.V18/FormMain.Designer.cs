namespace Tyuiu.ZheleznyakDN.Sprint6.Task3.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelCond_ZDN = new Label();
            labelInput_ZDN = new Label();
            labelOutput_ZDN = new Label();
            buttonHelp_ZDN = new Button();
            buttonDone_ZDN = new Button();
            groupBoxCond_ZDN = new GroupBox();
            dataGridViewResult_ZDN = new DataGridView();
            groupBoxCond_ZDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZDN).BeginInit();
            SuspendLayout();
            // 
            // labelCond_ZDN
            // 
            labelCond_ZDN.AutoSize = true;
            labelCond_ZDN.Font = new Font("Microsoft Sans Serif", 12F);
            labelCond_ZDN.Location = new Point(6, 26);
            labelCond_ZDN.Name = "labelCond_ZDN";
            labelCond_ZDN.Size = new Size(540, 100);
            labelCond_ZDN.TabIndex = 0;
            labelCond_ZDN.Text = "Дан массив 5 на 5 элементов. Заменить четные значения\nв четвертой строке на 0.\n\n-19 -19  1  18  7\n   5  3  4  6 -12\n-15  6  2  2 -14\n -9 -10 15  5  6\n-13 -15  9  7  1";
            // 
            // labelInput_ZDN
            // 
            labelInput_ZDN.AutoSize = true;
            labelInput_ZDN.Font = new Font("Microsoft Sans Serif", 10F);
            labelInput_ZDN.Location = new Point(24, 224);
            labelInput_ZDN.Name = "labelInput_ZDN";
            labelInput_ZDN.Size = new Size(125, 20);
            labelInput_ZDN.TabIndex = 1;
            labelInput_ZDN.Text = "Исходный массив:";
            // 
            // labelOutput_ZDN
            // 
            labelOutput_ZDN.AutoSize = true;
            labelOutput_ZDN.Font = new Font("Microsoft Sans Serif", 10F);
            labelOutput_ZDN.Location = new Point(642, 12);
            labelOutput_ZDN.Name = "labelOutput_ZDN";
            labelOutput_ZDN.Size = new Size(137, 20);
            labelOutput_ZDN.TabIndex = 2;
            labelOutput_ZDN.Text = "Результат:";
            // 
            // buttonHelp_ZDN
            // 
            buttonHelp_ZDN.BackColor = Color.SkyBlue;
            buttonHelp_ZDN.Location = new Point(284, 240);
            buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            buttonHelp_ZDN.Size = new Size(123, 70);
            buttonHelp_ZDN.TabIndex = 8;
            buttonHelp_ZDN.Text = "Справка";
            buttonHelp_ZDN.UseVisualStyleBackColor = false;
            buttonHelp_ZDN.Click += buttonHelp_ZDN_Click;
            // 
            // buttonDone_ZDN
            // 
            buttonDone_ZDN.BackColor = Color.LightGreen;
            buttonDone_ZDN.Location = new Point(413, 232);
            buttonDone_ZDN.Name = "buttonDone_ZDN";
            buttonDone_ZDN.Size = new Size(159, 81);
            buttonDone_ZDN.TabIndex = 9;
            buttonDone_ZDN.Text = "Выполнить";
            buttonDone_ZDN.UseVisualStyleBackColor = false;
            buttonDone_ZDN.Click += buttonDone_ZDN_Click;
            // 
            // groupBoxCond_ZDN
            // 
            groupBoxCond_ZDN.Controls.Add(labelCond_ZDN);
            groupBoxCond_ZDN.Location = new Point(20, 12);
            groupBoxCond_ZDN.Name = "groupBoxCond_ZDN";
            groupBoxCond_ZDN.Size = new Size(552, 195);
            groupBoxCond_ZDN.TabIndex = 10;
            groupBoxCond_ZDN.TabStop = false;
            groupBoxCond_ZDN.Text = "Условие";
            // 
            // dataGridViewResult_ZDN
            // 
            dataGridViewResult_ZDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ZDN.Location = new Point(593, 54);
            dataGridViewResult_ZDN.Name = "dataGridViewResult_ZDN";
            dataGridViewResult_ZDN.RowHeadersWidth = 51;
            dataGridViewResult_ZDN.Size = new Size(250, 277);
            dataGridViewResult_ZDN.TabIndex = 11;
            // 
            // FormMain
            // 
            ClientSize = new Size(856, 344);
            Controls.Add(dataGridViewResult_ZDN);
            Controls.Add(groupBoxCond_ZDN);
            Controls.Add(labelOutput_ZDN);
            Controls.Add(labelInput_ZDN);
            Controls.Add(buttonHelp_ZDN);
            Controls.Add(buttonDone_ZDN);
            Name = "FormMain";
            Text = "Спринт 6 | Task 1 | Вариант 19 | Железняк Д.Н.";
            groupBoxCond_ZDN.ResumeLayout(false);
            groupBoxCond_ZDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ZDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelCond_ZDN;
        private System.Windows.Forms.Label labelInput_ZDN;
        private System.Windows.Forms.Label labelOutput_ZDN;
        private System.Windows.Forms.Button buttonHelp_ZDN;
        private System.Windows.Forms.Button buttonDone_ZDN;
        private GroupBox groupBoxCond_ZDN;
        private DataGridView dataGridViewResult_ZDN;
    }
}
