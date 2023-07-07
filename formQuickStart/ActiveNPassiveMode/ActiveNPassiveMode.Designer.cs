namespace Miograph
{
    partial class ActiveNPassiveMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heelBox = new System.Windows.Forms.TextBox();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kneeAngleBox = new System.Windows.Forms.TextBox();
            this.kneeSettingsBox = new System.Windows.Forms.PictureBox();
            this.ankleSettingsBox = new System.Windows.Forms.PictureBox();
            this.ankleAngleBox = new System.Windows.Forms.TextBox();
            this.sockBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankleSettingsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heelBox
            // 
            this.heelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heelBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heelBox.Location = new System.Drawing.Point(729, 411);
            this.heelBox.Margin = new System.Windows.Forms.Padding(2);
            this.heelBox.Name = "heelBox";
            this.heelBox.Size = new System.Drawing.Size(76, 30);
            this.heelBox.TabIndex = 22;
            this.heelBox.TextChanged += new System.EventHandler(this.heelBox_TextChanged);
            // 
            // stepBox
            // 
            this.stepBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepBox.Location = new System.Drawing.Point(729, 137);
            this.stepBox.Margin = new System.Windows.Forms.Padding(2);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(76, 30);
            this.stepBox.TabIndex = 21;
            this.stepBox.TextChanged += new System.EventHandler(this.stepBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBox.Location = new System.Drawing.Point(729, 104);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(76, 30);
            this.timeBox.TabIndex = 20;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(604, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Пятка";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(604, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Шагов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(604, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Время, мин.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modeText
            // 
            this.modeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeText.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeText.Location = new System.Drawing.Point(4, 24);
            this.modeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(347, 32);
            this.modeText.TabIndex = 16;
            this.modeText.Text = "Активно - пассивный режим";
            this.modeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modeText.Click += new System.EventHandler(this.modeText_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(308, 506);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(249, 65);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Приступить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(11, 506);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(239, 65);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Miograph.Properties.Resources.detail_00050;
            this.pictureBox1.Location = new System.Drawing.Point(9, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kneeAngleBox
            // 
            this.kneeAngleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kneeAngleBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kneeAngleBox.Location = new System.Drawing.Point(607, 217);
            this.kneeAngleBox.Margin = new System.Windows.Forms.Padding(2);
            this.kneeAngleBox.Name = "kneeAngleBox";
            this.kneeAngleBox.Size = new System.Drawing.Size(76, 30);
            this.kneeAngleBox.TabIndex = 23;
            this.kneeAngleBox.TextChanged += new System.EventHandler(this.kneeAngleBox_TextChanged);
            // 
            // kneeSettingsBox
            // 
            this.kneeSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kneeSettingsBox.Image = global::Miograph.Properties.Resources.calibre_01;
            this.kneeSettingsBox.Location = new System.Drawing.Point(729, 180);
            this.kneeSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.kneeSettingsBox.Name = "kneeSettingsBox";
            this.kneeSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.kneeSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kneeSettingsBox.TabIndex = 24;
            this.kneeSettingsBox.TabStop = false;
            this.kneeSettingsBox.Click += new System.EventHandler(this.kneeSettingsBox_Click);
            // 
            // ankleSettingsBox
            // 
            this.ankleSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ankleSettingsBox.Image = global::Miograph.Properties.Resources.calibre_06;
            this.ankleSettingsBox.Location = new System.Drawing.Point(729, 296);
            this.ankleSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ankleSettingsBox.Name = "ankleSettingsBox";
            this.ankleSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.ankleSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ankleSettingsBox.TabIndex = 26;
            this.ankleSettingsBox.TabStop = false;
            this.ankleSettingsBox.Click += new System.EventHandler(this.ankleSettingsBox_Click);
            // 
            // ankleAngleBox
            // 
            this.ankleAngleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ankleAngleBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ankleAngleBox.Location = new System.Drawing.Point(607, 333);
            this.ankleAngleBox.Margin = new System.Windows.Forms.Padding(2);
            this.ankleAngleBox.Name = "ankleAngleBox";
            this.ankleAngleBox.Size = new System.Drawing.Size(76, 30);
            this.ankleAngleBox.TabIndex = 25;
            this.ankleAngleBox.TextChanged += new System.EventHandler(this.ankleAngleBox_TextChanged);
            // 
            // sockBox
            // 
            this.sockBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sockBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sockBox.Location = new System.Drawing.Point(729, 444);
            this.sockBox.Margin = new System.Windows.Forms.Padding(2);
            this.sockBox.Name = "sockBox";
            this.sockBox.Size = new System.Drawing.Size(76, 30);
            this.sockBox.TabIndex = 28;
            this.sockBox.TextChanged += new System.EventHandler(this.sockBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(604, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Носок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ActiveNPassiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 614);
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.sockBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ankleSettingsBox);
            this.Controls.Add(this.ankleAngleBox);
            this.Controls.Add(this.kneeSettingsBox);
            this.Controls.Add(this.kneeAngleBox);
            this.Controls.Add(this.heelBox);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActiveNPassiveMode";
            this.Text = "ActiveNPassive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankleSettingsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox heelBox;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kneeAngleBox;
        private System.Windows.Forms.PictureBox kneeSettingsBox;
        private System.Windows.Forms.PictureBox ankleSettingsBox;
        private System.Windows.Forms.TextBox ankleAngleBox;
        private System.Windows.Forms.TextBox sockBox;
        private System.Windows.Forms.Label label4;
    }
}