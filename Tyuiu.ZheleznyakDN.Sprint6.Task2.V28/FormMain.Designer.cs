namespace Tyuiu.ZheleznyakDN.Sprint6.Task2.V28
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
            labelFormula1_ZDN = new Label();
            labelFormula2_ZDN = new Label();
            labelInput_ZDN = new Label();
            labelOutput_ZDN = new Label();
            labelStartStep_ZDN = new Label();
            labelStopStep_ZDN = new Label();
            textBoxStartStep_ZDN = new TextBox();
            textBoxStopStep_ZDN = new TextBox();
            textBoxResult_ZDN = new TextBox();
            buttonHelp_ZDN = new Button();
            buttonDone_ZDN = new Button();
            groupBoxCond_ZDN = new GroupBox();
            groupBoxCond_ZDN.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula1_ZDN
            // 
            labelFormula1_ZDN.AutoSize = true;
            labelFormula1_ZDN.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFormula1_ZDN.Location = new Point(150, 50);
            labelFormula1_ZDN.Name = "labelFormula1_ZDN";
            labelFormula1_ZDN.Size = new Size(250, 36);
            labelFormula1_ZDN.TabIndex = 0;
            labelFormula1_ZDN.Text = "sin(x) - 2x";
            labelFormula1_ZDN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFormula2_ZDN
            // 
            labelFormula2_ZDN.AutoSize = true;
            labelFormula2_ZDN.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFormula2_ZDN.Location = new Point(50, 100);
            labelFormula2_ZDN.Name = "labelFormula2_ZDN";
            labelFormula2_ZDN.Size = new Size(450, 36);
            labelFormula2_ZDN.TabIndex = 1;
            labelFormula2_ZDN.Text = "F(x) = 3a + sin(x) - 3x + 2";
            labelFormula2_ZDN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInput_ZDN
            // 
            labelInput_ZDN.AutoSize = true;
            labelInput_ZDN.Font = new Font("Microsoft Sans Serif", 10F);
            labelInput_ZDN.Location = new Point(24, 224);
            labelInput_ZDN.Name = "labelInput_ZDN";
            labelInput_ZDN.Size = new Size(125, 20);
            labelInput_ZDN.TabIndex = 2;
            labelInput_ZDN.Text = "Ввод данных:";
            // 
            // labelOutput_ZDN
            // 
            labelOutput_ZDN.AutoSize = true;
            labelOutput_ZDN.Font = new Font("Microsoft Sans Serif", 10F);
            labelOutput_ZDN.Location = new Point(642, 12);
            labelOutput_ZDN.Name = "labelOutput_ZDN";
            labelOutput_ZDN.Size = new Size(137, 20);
            labelOutput_ZDN.TabIndex = 3;
            labelOutput_ZDN.Text = "Вывод данных:";
            // 
            // labelStartStep_ZDN
            // 
            labelStartStep_ZDN.AutoSize = true;
            labelStartStep_ZDN.Location = new Point(20, 269);
            labelStartStep_ZDN.Name = "labelStartStep_ZDN";
            labelStartStep_ZDN.Size = new Size(88, 20);
            labelStartStep_ZDN.TabIndex = 4;
            labelStartStep_ZDN.Text = "Старт шага:";
            // 
            // labelStopStep_ZDN
            // 
            labelStopStep_ZDN.AutoSize = true;
            labelStopStep_ZDN.Location = new Point(20, 304);
            labelStopStep_ZDN.Name = "labelStopStep_ZDN";
            labelStopStep_ZDN.Size = new Size(94, 20);
            labelStopStep_ZDN.TabIndex = 5;
            labelStopStep_ZDN.Text = "Конец шага:";
            // 
            // textBoxStartStep_ZDN
            // 
            textBoxStartStep_ZDN.Location = new Point(120, 262);
            textBoxStartStep_ZDN.Name = "textBoxStartStep_ZDN";
            textBoxStartStep_ZDN.Size = new Size(99, 27);
            textBoxStartStep_ZDN.TabIndex = 6;
            // 
            // textBoxStopStep_ZDN
            // 
            textBoxStopStep_ZDN.Location = new Point(120, 304);
            textBoxStopStep_ZDN.Name = "textBoxStopStep_ZDN";
            textBoxStopStep_ZDN.Size = new Size(99, 27);
            textBoxStopStep_ZDN.TabIndex = 7;
            // 
            // textBoxResult_ZDN
            // 
            textBoxResult_ZDN.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ZDN.Location = new Point(593, 54);
            textBoxResult_ZDN.Multiline = true;
            textBoxResult_ZDN.Name = "textBoxResult_ZDN";
            textBoxResult_ZDN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZDN.Size = new Size(250, 277);
            textBoxResult_ZDN.TabIndex = 8;
            // 
            // buttonHelp_ZDN
            // 
            buttonHelp_ZDN.BackColor = Color.SkyBlue;
            buttonHelp_ZDN.Location = new Point(284, 240);
            buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            buttonHelp_ZDN.Size = new Size(123, 70);
            buttonHelp_ZDN.TabIndex = 9;
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
            buttonDone_ZDN.TabIndex = 10;
            buttonDone_ZDN.Text = "Выполнить";
            buttonDone_ZDN.UseVisualStyleBackColor = false;
            buttonDone_ZDN.Click += buttonDone_ZDN_Click;
            // 
            // groupBoxCond_ZDN
            // 
            groupBoxCond_ZDN.Controls.Add(labelFormula1_ZDN);
            groupBoxCond_ZDN.Controls.Add(labelFormula2_ZDN);
            groupBoxCond_ZDN.Location = new Point(20, 12);
            groupBoxCond_ZDN.Name = "groupBoxCond_ZDN";
            groupBoxCond_ZDN.Size = new Size(552, 195);
            groupBoxCond_ZDN.TabIndex = 11;
            groupBoxCond_ZDN.TabStop = false;
            groupBoxCond_ZDN.Text = "Условие";
            // 
            // FormMain
            // 
            ClientSize = new Size(856, 344);
            Controls.Add(groupBoxCond_ZDN);
            Controls.Add(labelOutput_ZDN);
            Controls.Add(labelInput_ZDN);
            Controls.Add(labelStartStep_ZDN);
            Controls.Add(labelStopStep_ZDN);
            Controls.Add(textBoxStartStep_ZDN);
            Controls.Add(textBoxStopStep_ZDN);
            Controls.Add(textBoxResult_ZDN);
            Controls.Add(buttonHelp_ZDN);
            Controls.Add(buttonDone_ZDN);
            Name = "FormMain";
            Text = "Спринт 6 | Task 1 | Вариант 19 | Железняк Д.Н.";
            groupBoxCond_ZDN.ResumeLayout(false);
            groupBoxCond_ZDN.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFormula1_ZDN;
        private System.Windows.Forms.Label labelFormula2_ZDN;
        private System.Windows.Forms.Label labelInput_ZDN;
        private System.Windows.Forms.Label labelOutput_ZDN;
        private System.Windows.Forms.Label labelStartStep_ZDN;
        private System.Windows.Forms.Label labelStopStep_ZDN;
        private System.Windows.Forms.TextBox textBoxStartStep_ZDN;
        private System.Windows.Forms.TextBox textBoxStopStep_ZDN;
        private System.Windows.Forms.TextBox textBoxResult_ZDN;
        private System.Windows.Forms.Button buttonHelp_ZDN;
        private System.Windows.Forms.Button buttonDone_ZDN;
        private GroupBox groupBoxCond_ZDN;
    }
}
