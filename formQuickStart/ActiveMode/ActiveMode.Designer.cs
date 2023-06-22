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
            this.signalCalibrationBox = new System.Windows.Forms.PictureBox();
            this.kneeSettingsBox = new System.Windows.Forms.PictureBox();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.angleBox = new System.Windows.Forms.Label();
            this.maxPowerSettingsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signalCalibrationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerSettingsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signalCalibrationBox
            // 
            this.signalCalibrationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signalCalibrationBox.Location = new System.Drawing.Point(830, 360);
            this.signalCalibrationBox.Name = "signalCalibrationBox";
            this.signalCalibrationBox.Size = new System.Drawing.Size(120, 120);
            this.signalCalibrationBox.TabIndex = 42;
            this.signalCalibrationBox.TabStop = false;
            // 
            // kneeSettingsBox
            // 
            this.kneeSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kneeSettingsBox.Location = new System.Drawing.Point(830, 220);
            this.kneeSettingsBox.Name = "kneeSettingsBox";
            this.kneeSettingsBox.Size = new System.Drawing.Size(120, 120);
            this.kneeSettingsBox.TabIndex = 40;
            this.kneeSettingsBox.TabStop = false;
            // 
            // stepBox
            // 
            this.stepBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepBox.Location = new System.Drawing.Point(830, 164);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(100, 34);
            this.stepBox.TabIndex = 37;
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeBox.Location = new System.Drawing.Point(830, 124);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 34);
            this.timeBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(664, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 40);
            this.label2.TabIndex = 34;
            this.label2.Text = "Шагов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(664, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Время, мин.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modeText
            // 
            this.modeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeText.Location = new System.Drawing.Point(12, 9);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(400, 40);
            this.modeText.TabIndex = 32;
            this.modeText.Text = "Активный режим";
            this.modeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(273, 474);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 80);
            this.startButton.TabIndex = 31;
            this.startButton.Text = "Приступить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(17, 474);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(250, 80);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 350);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // angleBox
            // 
            this.angleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.angleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleBox.Location = new System.Drawing.Point(664, 253);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(80, 40);
            this.angleBox.TabIndex = 43;
            this.angleBox.Text = "80";
            this.angleBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.angleBox.Click += new System.EventHandler(this.angleBox_Click);
            // 
            // maxPowerSettingsBox
            // 
            this.maxPowerSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxPowerSettingsBox.Location = new System.Drawing.Point(830, 500);
            this.maxPowerSettingsBox.Name = "maxPowerSettingsBox";
            this.maxPowerSettingsBox.Size = new System.Drawing.Size(120, 120);
            this.maxPowerSettingsBox.TabIndex = 44;
            this.maxPowerSettingsBox.TabStop = false;
            // 
            // ActiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 755);
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
            this.Name = "ActiveMode";
            this.Text = "ActiveMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.signalCalibrationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPowerSettingsBox)).EndInit();
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