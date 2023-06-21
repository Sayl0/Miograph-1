namespace Miograph
{
    partial class PersonalProfile
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
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSelectUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoctorName.Location = new System.Drawing.Point(30, 46);
            this.labelDoctorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(258, 29);
            this.labelDoctorName.TabIndex = 0;
            this.labelDoctorName.Text = "Врач ФИО/Пациенты";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(36, 434);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(302, 68);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSelectUser
            // 
            this.buttonSelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectUser.Location = new System.Drawing.Point(708, 434);
            this.buttonSelectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectUser.Name = "buttonSelectUser";
            this.buttonSelectUser.Size = new System.Drawing.Size(302, 68);
            this.buttonSelectUser.TabIndex = 10;
            this.buttonSelectUser.Text = "Выбрать пациента";
            this.buttonSelectUser.UseVisualStyleBackColor = true;
            this.buttonSelectUser.Click += new System.EventHandler(this.buttonSelectUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(382, 434);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(302, 68);
            this.buttonAddUser.TabIndex = 11;
            this.buttonAddUser.Text = "Добавить пациента";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // PersonalProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonSelectUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDoctorName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonalProfile";
            this.Text = "PersonalProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSelectUser;
        private System.Windows.Forms.Button buttonAddUser;
    }
}