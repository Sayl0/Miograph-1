namespace Miograph
{
    partial class QuickStart
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
            this.exitButton = new System.Windows.Forms.Button();
            this.passiveButton = new System.Windows.Forms.Button();
            this.passiveAnkleButton = new System.Windows.Forms.Button();
            this.activePassiveButton = new System.Windows.Forms.Button();
            this.activeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(40, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 80);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passiveButton
            // 
            this.passiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passiveButton.Location = new System.Drawing.Point(242, 81);
            this.passiveButton.Name = "passiveButton";
            this.passiveButton.Size = new System.Drawing.Size(400, 80);
            this.passiveButton.TabIndex = 1;
            this.passiveButton.Text = "Пассивный режим";
            this.passiveButton.UseVisualStyleBackColor = true;
            this.passiveButton.Click += new System.EventHandler(this.passiveButton_Click);
            // 
            // passiveAnkleButton
            // 
            this.passiveAnkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passiveAnkleButton.Location = new System.Drawing.Point(242, 167);
            this.passiveAnkleButton.Name = "passiveAnkleButton";
            this.passiveAnkleButton.Size = new System.Drawing.Size(400, 80);
            this.passiveAnkleButton.TabIndex = 2;
            this.passiveAnkleButton.Text = "Пассивный режим, голеностоп";
            this.passiveAnkleButton.UseVisualStyleBackColor = true;
            this.passiveAnkleButton.Click += new System.EventHandler(this.passiveAnkleButton_Click);
            // 
            // activePassiveButton
            // 
            this.activePassiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activePassiveButton.Location = new System.Drawing.Point(242, 253);
            this.activePassiveButton.Name = "activePassiveButton";
            this.activePassiveButton.Size = new System.Drawing.Size(400, 80);
            this.activePassiveButton.TabIndex = 3;
            this.activePassiveButton.Text = "Активно-пассивный режим";
            this.activePassiveButton.UseVisualStyleBackColor = true;
            this.activePassiveButton.Click += new System.EventHandler(this.activePassiveButton_Click);
            // 
            // activeButton
            // 
            this.activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeButton.Location = new System.Drawing.Point(242, 339);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(400, 80);
            this.activeButton.TabIndex = 4;
            this.activeButton.Text = "Активный режим";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // QuickStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 674);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.activePassiveButton);
            this.Controls.Add(this.passiveAnkleButton);
            this.Controls.Add(this.passiveButton);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuickStart";
            this.Text = "QuickStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button passiveButton;
        private System.Windows.Forms.Button passiveAnkleButton;
        private System.Windows.Forms.Button activePassiveButton;
        private System.Windows.Forms.Button activeButton;
    }
}