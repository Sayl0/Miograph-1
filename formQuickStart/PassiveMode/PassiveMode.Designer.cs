namespace Miograph
{
    partial class PassiveMode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.modeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.settingsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Miograph.Properties.Resources.detail_00050;
            this.pictureBox1.Location = new System.Drawing.Point(9, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(25, 473);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(229, 65);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(296, 473);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(229, 65);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Приступить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // modeText
            // 
            this.modeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeText.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeText.Location = new System.Drawing.Point(11, 19);
            this.modeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(283, 32);
            this.modeText.TabIndex = 4;
            this.modeText.Text = "Пассивный режим";
            this.modeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modeText.Click += new System.EventHandler(this.modeText_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(560, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время, мин.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(561, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Шагов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(561, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Скорость";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBox.Location = new System.Drawing.Point(684, 100);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(76, 30);
            this.timeBox.TabIndex = 8;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // stepBox
            // 
            this.stepBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepBox.Location = new System.Drawing.Point(685, 134);
            this.stepBox.Margin = new System.Windows.Forms.Padding(2);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(76, 30);
            this.stepBox.TabIndex = 9;
            this.stepBox.TextChanged += new System.EventHandler(this.stepBox_TextChanged);
            // 
            // speedBox
            // 
            this.speedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedBox.Location = new System.Drawing.Point(685, 168);
            this.speedBox.Margin = new System.Windows.Forms.Padding(2);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(76, 30);
            this.speedBox.TabIndex = 10;
            this.speedBox.TextChanged += new System.EventHandler(this.speedBox_TextChanged);
            // 
            // angleBox
            // 
            this.angleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.angleBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleBox.Location = new System.Drawing.Point(549, 245);
            this.angleBox.Margin = new System.Windows.Forms.Padding(2);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(76, 30);
            this.angleBox.TabIndex = 11;
            this.angleBox.TextChanged += new System.EventHandler(this.angleBox_TextChanged);
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsBox.Image = global::Miograph.Properties.Resources.calibre_01;
            this.settingsBox.Location = new System.Drawing.Point(671, 236);
            this.settingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(100, 90);
            this.settingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBox.TabIndex = 12;
            this.settingsBox.TabStop = false;
            this.settingsBox.Click += new System.EventHandler(this.settingsBox_Click);
            // 
            // PassiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 559);
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.speedBox);
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
            this.Name = "PassiveMode";
            this.Text = "PassiveMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.PictureBox settingsBox;
    }
}