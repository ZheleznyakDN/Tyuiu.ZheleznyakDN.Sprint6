namespace Tyuiu.ZheleznyakDN.Sprint6.Task7.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask_ZDN = new Panel();
            groupBoxTask_ZDN = new GroupBox();
            textBoxTask_ZDN = new TextBox();
            buttonHelp_ZDN = new Button();
            buttonSave_ZDN = new Button();
            buttonDone_ZDN = new Button();
            buttonOpenFile_ZDN = new Button();
            groupBoxVvod_ZDN = new GroupBox();
            dataGridViewVvod_ZDN = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            groupBoxViv_ZDN = new GroupBox();
            dataGridViewVivod_ZDN = new DataGridView();
            panelVivod_ZDN = new Panel();
            panelVvod_ZDN = new Panel();
            panelTask_ZDN.SuspendLayout();
            groupBoxTask_ZDN.SuspendLayout();
            groupBoxVvod_ZDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_ZDN).BeginInit();
            groupBoxViv_ZDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_ZDN).BeginInit();
            panelVivod_ZDN.SuspendLayout();
            panelVvod_ZDN.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_ZDN
            // 
            panelTask_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTask_ZDN.Controls.Add(groupBoxTask_ZDN);
            panelTask_ZDN.Controls.Add(buttonHelp_ZDN);
            panelTask_ZDN.Controls.Add(buttonSave_ZDN);
            panelTask_ZDN.Controls.Add(buttonDone_ZDN);
            panelTask_ZDN.Controls.Add(buttonOpenFile_ZDN);
            panelTask_ZDN.Location = new Point(0, 0);
            panelTask_ZDN.Name = "panelTask_ZDN";
            panelTask_ZDN.Size = new Size(2022, 324);
            panelTask_ZDN.TabIndex = 0;
            // 
            // groupBoxTask_ZDN
            // 
            groupBoxTask_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_ZDN.Controls.Add(textBoxTask_ZDN);
            groupBoxTask_ZDN.Location = new Point(12, 165);
            groupBoxTask_ZDN.Name = "groupBoxTask_ZDN";
            groupBoxTask_ZDN.Size = new Size(2007, 156);
            groupBoxTask_ZDN.TabIndex = 1;
            groupBoxTask_ZDN.TabStop = false;
            groupBoxTask_ZDN.Text = "Условие:";
            // 
            // textBoxTask_ZDN
            // 
            textBoxTask_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_ZDN.Location = new Point(3, 35);
            textBoxTask_ZDN.Multiline = true;
            textBoxTask_ZDN.Name = "textBoxTask_ZDN";
            textBoxTask_ZDN.ReadOnly = true;
            textBoxTask_ZDN.Size = new Size(2001, 118);
            textBoxTask_ZDN.TabIndex = 0;
            textBoxTask_ZDN.Text = "Дан файл InPutFileTask6V5.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается I в результирующем строку и вывести ее в textBoxOut.";
            // 
            // buttonHelp_ZDN
            // 
            buttonHelp_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZDN.Cursor = Cursors.Help;
            buttonHelp_ZDN.FlatStyle = FlatStyle.Flat;
            buttonHelp_ZDN.ForeColor = Color.Silver;
            buttonHelp_ZDN.Image = Properties.Resources.spravka;
            buttonHelp_ZDN.Location = new Point(1840, 35);
            buttonHelp_ZDN.Name = "buttonHelp_ZDN";
            buttonHelp_ZDN.Size = new Size(145, 109);
            buttonHelp_ZDN.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp_ZDN, "Справка");
            buttonHelp_ZDN.UseVisualStyleBackColor = true;
            buttonHelp_ZDN.Click += buttonHelp_ZDN_Click;
            // 
            // buttonSave_ZDN
            // 
            buttonSave_ZDN.Cursor = Cursors.Hand;
            buttonSave_ZDN.Enabled = false;
            buttonSave_ZDN.FlatStyle = FlatStyle.Flat;
            buttonSave_ZDN.ForeColor = Color.Silver;
            buttonSave_ZDN.Image = Properties.Resources.save;
            buttonSave_ZDN.Location = new Point(436, 35);
            buttonSave_ZDN.Name = "buttonSave_ZDN";
            buttonSave_ZDN.Size = new Size(163, 109);
            buttonSave_ZDN.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSave_ZDN, "Сохранить в файл");
            buttonSave_ZDN.UseVisualStyleBackColor = true;
            buttonSave_ZDN.Click += buttonSave_ZDN_Click;
            // 
            // buttonDone_ZDN
            // 
            buttonDone_ZDN.Cursor = Cursors.Hand;
            buttonDone_ZDN.Enabled = false;
            buttonDone_ZDN.FlatStyle = FlatStyle.Flat;
            buttonDone_ZDN.ForeColor = Color.Silver;
            buttonDone_ZDN.Image = Properties.Resources.run;
            buttonDone_ZDN.Location = new Point(225, 35);
            buttonDone_ZDN.Name = "buttonDone_ZDN";
            buttonDone_ZDN.Size = new Size(161, 109);
            buttonDone_ZDN.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone_ZDN, "Выполнить");
            buttonDone_ZDN.UseVisualStyleBackColor = true;
            buttonDone_ZDN.Click += buttonDone_ZDN_Click;
            // 
            // buttonOpenFile_ZDN
            // 
            buttonOpenFile_ZDN.Cursor = Cursors.Hand;
            buttonOpenFile_ZDN.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_ZDN.ForeColor = Color.Silver;
            buttonOpenFile_ZDN.Image = Properties.Resources.file;
            buttonOpenFile_ZDN.Location = new Point(23, 35);
            buttonOpenFile_ZDN.Name = "buttonOpenFile_ZDN";
            buttonOpenFile_ZDN.Size = new Size(168, 109);
            buttonOpenFile_ZDN.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile_ZDN, "Выберите файл");
            buttonOpenFile_ZDN.UseVisualStyleBackColor = true;
            buttonOpenFile_ZDN.Click += buttonOpenFile_ZDN_Click;
            // 
            // groupBoxVvod_ZDN
            // 
            groupBoxVvod_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxVvod_ZDN.Controls.Add(dataGridViewVvod_ZDN);
            groupBoxVvod_ZDN.Location = new Point(6, 3);
            groupBoxVvod_ZDN.Name = "groupBoxVvod_ZDN";
            groupBoxVvod_ZDN.Size = new Size(1039, 1054);
            groupBoxVvod_ZDN.TabIndex = 0;
            groupBoxVvod_ZDN.TabStop = false;
            groupBoxVvod_ZDN.Text = "Ввод:";
            // 
            // dataGridViewVvod_ZDN
            // 
            dataGridViewVvod_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewVvod_ZDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVvod_ZDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVvod_ZDN.ColumnHeadersVisible = false;
            dataGridViewVvod_ZDN.Location = new Point(-3, 38);
            dataGridViewVvod_ZDN.Name = "dataGridViewVvod_ZDN";
            dataGridViewVvod_ZDN.ReadOnly = true;
            dataGridViewVvod_ZDN.RowHeadersVisible = false;
            dataGridViewVvod_ZDN.RowHeadersWidth = 82;
            dataGridViewVvod_ZDN.ScrollBars = ScrollBars.None;
            dataGridViewVvod_ZDN.Size = new Size(1036, 680);
            dataGridViewVvod_ZDN.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // groupBoxViv_ZDN
            // 
            groupBoxViv_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxViv_ZDN.Controls.Add(dataGridViewVivod_ZDN);
            groupBoxViv_ZDN.Location = new Point(0, 6);
            groupBoxViv_ZDN.Name = "groupBoxViv_ZDN";
            groupBoxViv_ZDN.Size = new Size(962, 1000);
            groupBoxViv_ZDN.TabIndex = 1;
            groupBoxViv_ZDN.TabStop = false;
            groupBoxViv_ZDN.Text = "Вывод:";
            // 
            // dataGridViewVivod_ZDN
            // 
            dataGridViewVivod_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewVivod_ZDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVivod_ZDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_ZDN.ColumnHeadersVisible = false;
            dataGridViewVivod_ZDN.Location = new Point(-3, 38);
            dataGridViewVivod_ZDN.Name = "dataGridViewVivod_ZDN";
            dataGridViewVivod_ZDN.ReadOnly = true;
            dataGridViewVivod_ZDN.RowHeadersVisible = false;
            dataGridViewVivod_ZDN.RowHeadersWidth = 82;
            dataGridViewVivod_ZDN.ScrollBars = ScrollBars.None;
            dataGridViewVivod_ZDN.Size = new Size(965, 680);
            dataGridViewVivod_ZDN.TabIndex = 0;
            // 
            // panelVivod_ZDN
            // 
            panelVivod_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelVivod_ZDN.Controls.Add(groupBoxViv_ZDN);
            panelVivod_ZDN.Location = new Point(1054, 327);
            panelVivod_ZDN.Name = "panelVivod_ZDN";
            panelVivod_ZDN.Size = new Size(965, 733);
            panelVivod_ZDN.TabIndex = 3;
            // 
            // panelVvod_ZDN
            // 
            panelVvod_ZDN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelVvod_ZDN.Controls.Add(groupBoxVvod_ZDN);
            panelVvod_ZDN.Location = new Point(0, 330);
            panelVvod_ZDN.Name = "panelVvod_ZDN";
            panelVvod_ZDN.Size = new Size(1048, 730);
            panelVvod_ZDN.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2022, 1060);
            Controls.Add(panelTask_ZDN);
            Controls.Add(panelVvod_ZDN);
            Controls.Add(panelVivod_ZDN);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Tаск 7 | Вариант 11 | Железняк Д. Н.";
            panelTask_ZDN.ResumeLayout(false);
            groupBoxTask_ZDN.ResumeLayout(false);
            groupBoxTask_ZDN.PerformLayout();
            groupBoxVvod_ZDN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_ZDN).EndInit();
            groupBoxViv_ZDN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_ZDN).EndInit();
            panelVivod_ZDN.ResumeLayout(false);
            panelVvod_ZDN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_ZDN;
        private Panel panelInput_ZDN;
        private TextBox textBoxTask_ZDN;
        private GroupBox groupBoxTask_ZDN;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button buttonHelp_ZDN;
        private Button buttonSave_ZDN;
        private Button buttonDone_ZDN;
        private Button buttonOpenFile_ZDN;
        private GroupBox groupBoxVvod_ZDN;
        private DataGridView dataGridViewVvod_ZDN;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private GroupBox groupBoxViv_ZDN;
        private DataGridView dataGridViewVivod_ZDN;
        private Panel panelVivod_ZDN;
        private Panel panelVvod_ZDN;
    }
}
