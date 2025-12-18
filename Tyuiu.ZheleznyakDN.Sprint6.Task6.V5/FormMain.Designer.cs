namespace Tyuiu.ZheleznyakDN.Sprint6.Task6.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelCondition_ZDN = new Label();
            textBoxIn_ZDN = new TextBox();
            textBoxOut_ZDN = new TextBox();
            buttonOpenFile_ZDN = new Button();
            buttonDone_ZDN = new Button();
            buttonHelp_ZDN = new Button();
            openFileDialogTask_ZDN = new OpenFileDialog();
            labelIn_ZDN = new Label();
            labelOut_ZDN = new Label();
            toolTip1_ZDN = new ToolTip(components);
            SuspendLayout();
            // 
            // labelCondition_ZDN
            // 
            labelCondition_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCondition_ZDN.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelCondition_ZDN.Location = new System.Drawing.Point(12, 60);
            labelCondition_ZDN.Name = "labelCondition_ZDN";
            labelCondition_ZDN.Size = new System.Drawing.Size(939, 40);
            labelCondition_ZDN.TabIndex = 0;
            labelCondition_ZDN.Text = "Дан файл InPutFileTask6V5.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается I в результирующем строку и вывести ее в textBoxOut.";
            // 
            // textBoxIn_ZDN
            // 
            textBoxIn_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_ZDN.Location = new System.Drawing.Point(12, 140);
            textBoxIn_ZDN.Multiline = true;
            textBoxIn_ZDN.Name = "textBoxIn_ZDN";
            textBoxIn_ZDN.ScrollBars = ScrollBars.Both;
            textBoxIn_ZDN.Size = new System.Drawing.Size(450, 392);
            textBoxIn_ZDN.TabIndex = 1;
            // 
            // textBoxOut_ZDN
            // 
            textBoxOut_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxOut_ZDN.Location = new System.Drawing.Point(489, 140);
            textBoxOut_ZDN.Multiline = true;
            textBoxOut_ZDN.Name = "textBoxOut_ZDN";
            textBoxOut_ZDN.ScrollBars = ScrollBars.Both;
            textBoxOut_ZDN.Size = new System.Drawing.Size(462, 392);
            textBoxOut_ZDN.TabIndex = 2;
            // 
            // buttonOpenFile_ZDN
            // 
            buttonOpenFile_ZDN.Location = new System.Drawing.Point(12, 10);
            buttonOpenFile_ZDN.Name = "buttonOpenFile_ZDN";
            buttonOpenFile_ZDN.Size = new System.Drawing.Size(50, 45);
            buttonOpenFile_ZDN.TabIndex = 3;
            buttonOpenFile_ZDN.Text = "📂";
            toolTip1_ZDN.SetToolTip(buttonOpenFile_ZDN, "Открыть файл  \r\nВыберите нужный файл для обработки");
            buttonOpenFile_ZDN.UseVisualStyleBackColor = true;
            buttonOpenFile_ZDN.Click += buttonOpenFile_ZDN_Click;
            // 
            // buttonDone_ZDN
            // 
            buttonDone_ZDN.Enabled = false;
            buttonDone_ZDN.Location = new System.Drawing.Point(70, 10);
            buttonDone_ZDN.Name = "buttonDone_ZDN";
            buttonDone_ZDN.Size = new System.Drawing.Size(50, 45);
            buttonDone_ZDN.TabIndex = 4;
            buttonDone_ZDN.Text = "✔";
            toolTip1_ZDN.SetToolTip(buttonDone_ZDN, "Выполнить задание");
            buttonDone_ZDN.UseVisualStyleBackColor = true;
            buttonDone_ZDN.Click += buttonDone_ZDN_Click;
            // 
            // buttonHelp_ZDN
            // 
            buttonHelp_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZDN.Location = new System.Drawing.Point(901, 10);
            buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            buttonHelp_ZDN.Size = new System.Drawing.Size(50, 45);
            buttonHelp_ZDN.TabIndex = 5;
            buttonHelp_ZDN.Text = "?";
            toolTip1_ZDN.SetToolTip(buttonHelp_ZDN, "О программе");
            buttonHelp_ZDN.UseVisualStyleBackColor = true;
            buttonHelp_ZDN.Click += buttonHelp_ZDN_Click;
            // 
            // openFileDialogTask_ZDN
            // 
            openFileDialogTask_ZDN.FileName = "openFileDialogTask_ZDN";
            openFileDialogTask_ZDN.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialogTask_ZDN.Title = "Выберите файл для обработки";
            // 
            // labelIn_ZDN
            // 
            labelIn_ZDN.AutoSize = true;
            labelIn_ZDN.Location = new System.Drawing.Point(12, 120);
            labelIn_ZDN.Name = "labelIn_ZDN";
            labelIn_ZDN.Size = new System.Drawing.Size(46, 20);
            labelIn_ZDN.TabIndex = 6;
            labelIn_ZDN.Text = "Ввод:";
            // 
            // labelOut_ZDN
            // 
            labelOut_ZDN.AutoSize = true;
            labelOut_ZDN.Location = new System.Drawing.Point(510, 120);
            labelOut_ZDN.Name = "labelOut_ZDN";
            labelOut_ZDN.Size = new System.Drawing.Size(57, 20);
            labelOut_ZDN.TabIndex = 7;
            labelOut_ZDN.Text = "Вывод:";
            // 
            // FormMain
            // 
            ClientSize = new System.Drawing.Size(963, 553);
            Controls.Add(labelOut_ZDN);
            Controls.Add(labelIn_ZDN);
            Controls.Add(buttonHelp_ZDN);
            Controls.Add(buttonDone_ZDN);
            Controls.Add(buttonOpenFile_ZDN);
            Controls.Add(textBoxOut_ZDN);
            Controls.Add(textBoxIn_ZDN);
            Controls.Add(labelCondition_ZDN);
            MinimumSize = new System.Drawing.Size(850, 500);
            Name = "FormMain";
            Text = "Спринт 6 | Task 6 | Вариант 5 | Железняк Д.Н.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelCondition_ZDN;
        private System.Windows.Forms.TextBox textBoxIn_ZDN;
        private System.Windows.Forms.TextBox textBoxOut_ZDN;
        private System.Windows.Forms.Button buttonOpenFile_ZDN;
        private System.Windows.Forms.Button buttonDone_ZDN;
        private System.Windows.Forms.Button buttonHelp_ZDN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZDN;
        private System.Windows.Forms.Label labelIn_ZDN;
        private System.Windows.Forms.Label labelOut_ZDN;
        private System.Windows.Forms.ToolTip toolTip1_ZDN;
    }
}
