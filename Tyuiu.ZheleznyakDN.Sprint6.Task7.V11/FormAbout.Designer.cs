namespace Tyuiu.ZheleznyakDN.Sprint6.Task7.V11
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxLogo_ZDN = new PictureBox();
            labelDeveloper_ZDN = new Label();
            labelGroup_ZDN = new Label();
            labelPurpose_ZDN = new Label();
            labelUniversity_ZDN = new Label();
            labelInternalName_ZDN = new Label();
            buttonOK_ZDN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZDN).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo_ZDN
            // 
            pictureBoxLogo_ZDN.Image = Properties.Resources.logo;
            pictureBoxLogo_ZDN.Location = new Point(12, 12);
            pictureBoxLogo_ZDN.Name = "pictureBoxLogo_ZDN";
            pictureBoxLogo_ZDN.Size = new Size(200, 200);
            pictureBoxLogo_ZDN.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_ZDN.TabIndex = 0;
            pictureBoxLogo_ZDN.TabStop = false;
            // 
            // labelDeveloper_ZDN
            // 
            labelDeveloper_ZDN.AutoSize = true;
            labelDeveloper_ZDN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDeveloper_ZDN.Location = new Point(218, 20);
            labelDeveloper_ZDN.Name = "labelDeveloper_ZDN";
            labelDeveloper_ZDN.Size = new Size(331, 23);
            labelDeveloper_ZDN.TabIndex = 1;
            labelDeveloper_ZDN.Text = "Разработчик: Железняк Дамир Николаевич";
            // 
            // labelGroup_ZDN
            // 
            labelGroup_ZDN.AutoSize = true;
            labelGroup_ZDN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup_ZDN.Location = new Point(218, 55);
            labelGroup_ZDN.Name = "labelGroup_ZDN";
            labelGroup_ZDN.Size = new Size(111, 23);
            labelGroup_ZDN.TabIndex = 2;
            labelGroup_ZDN.Text = "Группа: ПКТб-25-1";
            // 
            // labelPurpose_ZDN
            // 
            labelPurpose_ZDN.AutoSize = true;
            labelPurpose_ZDN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPurpose_ZDN.Location = new Point(218, 90);
            labelPurpose_ZDN.Name = "labelPurpose_ZDN";
            labelPurpose_ZDN.Size = new Size(336, 23);
            labelPurpose_ZDN.TabIndex = 3;
            labelPurpose_ZDN.Text = "Программа разработана в рамках изучения языка С#";
            // 
            // labelUniversity_ZDN
            // 
            labelUniversity_ZDN.AutoSize = true;
            labelUniversity_ZDN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUniversity_ZDN.Location = new Point(218, 125);
            labelUniversity_ZDN.Name = "labelUniversity_ZDN";
            labelUniversity_ZDN.Size = new Size(257, 23);
            labelUniversity_ZDN.TabIndex = 4;
            labelUniversity_ZDN.Text = "Тюменский индустриальный университет";
            // 
            // labelInternalName_ZDN
            // 
            labelInternalName_ZDN.AutoSize = true;
            labelInternalName_ZDN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInternalName_ZDN.Location = new Point(218, 160);
            labelInternalName_ZDN.Name = "labelInternalName_ZDN";
            labelInternalName_ZDN.Size = new Size(325, 23);
            labelInternalName_ZDN.TabIndex = 5;
            labelInternalName_ZDN.Text = "Внутреннее имя: Tyuiu.ZheleznyakDN.Sprint6.Task7.V11";
            // 
            // buttonOK_ZDN
            // 
            buttonOK_ZDN.Location = new Point(425, 195);
            buttonOK_ZDN.Name = "buttonOK_ZDN";
            buttonOK_ZDN.Size = new Size(150, 46);
            buttonOK_ZDN.TabIndex = 6;
            buttonOK_ZDN.Text = "OK";
            buttonOK_ZDN.UseVisualStyleBackColor = true;
            buttonOK_ZDN.Click += buttonOK_ZDN_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 253);
            Controls.Add(buttonOK_ZDN);
            Controls.Add(labelInternalName_ZDN);
            Controls.Add(labelUniversity_ZDN);
            Controls.Add(labelPurpose_ZDN);
            Controls.Add(labelGroup_ZDN);
            Controls.Add(labelDeveloper_ZDN);
            Controls.Add(pictureBoxLogo_ZDN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ZDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo_ZDN;
        private Label labelDeveloper_ZDN;
        private Label labelGroup_ZDN;
        private Label labelPurpose_ZDN;
        private Label labelUniversity_ZDN;
        private Label labelInternalName_ZDN;
        private Button buttonOK_ZDN;
    }
}