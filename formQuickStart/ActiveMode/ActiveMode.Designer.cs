namespace Miograph
{
    partial class ActiveMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveMode));
            this.stepBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.angleBox = new System.Windows.Forms.Label();
            this.maxPowerSettingsBox = new System.Windows.Forms.PictureBox();
            this.signalCalibrationBox = new System.Windows.Forms.PictureBox();
            this.kneeSettingsBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalCalibrationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stepBox
            // 
            this.stepBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepBox.Location = new System.Drawing.Point(691, 129);
            this.stepBox.Margin = new System.Windows.Forms.Padding(2);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(90, 30);
            this.stepBox.TabIndex = 37;
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBox.Location = new System.Drawing.Point(691, 95);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(90, 30);
            this.timeBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(567, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Шагов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(567, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Время, мин.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modeText
            // 
            this.modeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeText.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeText.Location = new System.Drawing.Point(8, 33);
            this.modeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(215, 32);
            this.modeText.TabIndex = 32;
            this.modeText.Text = "Активный режим";
            this.modeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(284, 499);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(258, 65);
            this.startButton.TabIndex = 31;
            this.startButton.Text = "Приступить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(22, 499);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(237, 65);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // angleBox
            // 
            this.angleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.angleBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleBox.Location = new System.Drawing.Point(604, 197);
            this.angleBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(60, 32);
            this.angleBox.TabIndex = 43;
            this.angleBox.Text = "80";
            this.angleBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.angleBox.Click += new System.EventHandler(this.angleBox_Click);
            // 
            // maxPowerSettingsBox
            // 
            this.maxPowerSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxPowerSettingsBox.Image = global::Miograph.Properties.Resources.calibre_03;
            this.maxPowerSettingsBox.Location = new System.Drawing.Point(691, 402);
            this.maxPowerSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxPowerSettingsBox.Name = "maxPowerSettingsBox";
            this.maxPowerSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.maxPowerSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxPowerSettingsBox.TabIndex = 44;
            this.maxPowerSettingsBox.TabStop = false;
            // 
            // signalCalibrationBox
            // 
            this.signalCalibrationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signalCalibrationBox.Image = global::Miograph.Properties.Resources.calibre_02;
            this.signalCalibrationBox.Location = new System.Drawing.Point(691, 288);
            this.signalCalibrationBox.Margin = new System.Windows.Forms.Padding(2);
            this.signalCalibrationBox.Name = "signalCalibrationBox";
            this.signalCalibrationBox.Size = new System.Drawing.Size(100, 90);
            this.signalCalibrationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signalCalibrationBox.TabIndex = 42;
            this.signalCalibrationBox.TabStop = false;
            // 
            // kneeSettingsBox
            // 
            this.kneeSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kneeSettingsBox.Image = global::Miograph.Properties.Resources.passive_angle;
            this.kneeSettingsBox.Location = new System.Drawing.Point(691, 175);
            this.kneeSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.kneeSettingsBox.Name = "kneeSettingsBox";
            this.kneeSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.kneeSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kneeSettingsBox.TabIndex = 40;
            this.kneeSettingsBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Miograph.Properties.Resources.detail_00050;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // ActiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 613);
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.maxPowerSettingsBox);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.signalCalibrationBox);
            this.Controls.Add(this.kneeSettingsBox);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActiveMode";
            this.Text = "ActiveMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalCalibrationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox signalCalibrationBox;
        private System.Windows.Forms.PictureBox kneeSettingsBox;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label angleBox;
        private System.Windows.Forms.PictureBox maxPowerSettingsBox;
    }
}