namespace Miograph.formUserSelection.PersonalProfile.SelectUser.RunDiagnostics
{
    partial class HipMuscleStrength
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.modeText = new System.Windows.Forms.Label();
            this.ankleSettingsBox = new System.Windows.Forms.PictureBox();
            this.kneeSettingsBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ankleSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(165, 576);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(315, 72);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // modeText
            // 
            this.modeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeText.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeText.Location = new System.Drawing.Point(68, 80);
            this.modeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(364, 32);
            this.modeText.TabIndex = 29;
            this.modeText.Text = "Диагностика сил мышц бедра";
            this.modeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ankleSettingsBox
            // 
            this.ankleSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ankleSettingsBox.Image = global::Miograph.Properties.Resources.calibre_03;
            this.ankleSettingsBox.Location = new System.Drawing.Point(750, 374);
            this.ankleSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ankleSettingsBox.Name = "ankleSettingsBox";
            this.ankleSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.ankleSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ankleSettingsBox.TabIndex = 31;
            this.ankleSettingsBox.TabStop = false;
            // 
            // kneeSettingsBox
            // 
            this.kneeSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kneeSettingsBox.Image = global::Miograph.Properties.Resources.calibre_03;
            this.kneeSettingsBox.Location = new System.Drawing.Point(750, 260);
            this.kneeSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.kneeSettingsBox.Name = "kneeSettingsBox";
            this.kneeSettingsBox.Size = new System.Drawing.Size(100, 90);
            this.kneeSettingsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kneeSettingsBox.TabIndex = 30;
            this.kneeSettingsBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Miograph.Properties.Resources.detail_00001;
            this.pictureBox1.Location = new System.Drawing.Point(73, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // HipMuscleStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 707);
            this.Controls.Add(this.ankleSettingsBox);
            this.Controls.Add(this.kneeSettingsBox);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HipMuscleStrength";
            this.Text = "HipMuscleStrength";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ankleSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kneeSettingsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox ankleSettingsBox;
        private System.Windows.Forms.PictureBox kneeSettingsBox;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}