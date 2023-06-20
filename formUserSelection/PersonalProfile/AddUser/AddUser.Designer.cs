﻿using System.Windows.Forms;

namespace Miograph
{
    partial class AddUser
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
        /// 

        /*
         this.textBoxSecondName = new PHTextBox("Фамилия");
                    this.textBoxFirstName = new PHTextBox("Имя");
                    this.textBoxMiddleName = new PHTextBox("Отчество");
                    this.textBoxUserWeight = new PHTextBox("кг");
                    this.textBoxUserHeight = new PHTextBox("см");
         */

        private void InitializeComponent()
        {

            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxUserWeight = new System.Windows.Forms.TextBox();
            this.textBoxUserHeight = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.labelUserHeight = new System.Windows.Forms.Label();
            this.labelUserWeight = new System.Windows.Forms.Label();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelMedicalHistory = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(60, 832);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(340, 85);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName = new PHTextBox("Фамилия");
            this.textBoxSecondName.AccessibleDescription = "";
            this.textBoxSecondName.AccessibleName = "";
            this.textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.Location = new System.Drawing.Point(60, 132);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(347, 41);
            this.textBoxSecondName.TabIndex = 11;
            this.textBoxSecondName.Tag = "";
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.textBoxSecondName_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName = new PHTextBox("Имя");
            this.textBoxFirstName.AccessibleDescription = "";
            this.textBoxFirstName.AccessibleName = "";
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(60, 215);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(347, 41);
            this.textBoxFirstName.TabIndex = 12;
            this.textBoxFirstName.Tag = "";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName = new PHTextBox("Отчество");
            this.textBoxMiddleName.AccessibleDescription = "";
            this.textBoxMiddleName.AccessibleName = "";
            this.textBoxMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(60, 302);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(347, 41);
            this.textBoxMiddleName.TabIndex = 13;
            this.textBoxMiddleName.Tag = "";
            // 
            // textBoxUserWeight
            // 
            this.textBoxUserWeight = new PHTextBox("кг");
            this.textBoxUserWeight.AccessibleDescription = "";
            this.textBoxUserWeight.AccessibleName = "";
            this.textBoxUserWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserWeight.Location = new System.Drawing.Point(194, 650);
            this.textBoxUserWeight.Name = "textBoxUserWeight";
            this.textBoxUserWeight.Size = new System.Drawing.Size(347, 41);
            this.textBoxUserWeight.TabIndex = 15;
            this.textBoxUserWeight.Tag = "";
            // 
            // textBoxUserHeight
            // 
            this.textBoxUserHeight = new PHTextBox("см");
            this.textBoxUserHeight.AccessibleDescription = "";
            this.textBoxUserHeight.AccessibleName = "";
            this.textBoxUserHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserHeight.Location = new System.Drawing.Point(194, 567);
            this.textBoxUserHeight.Name = "textBoxUserHeight";
            this.textBoxUserHeight.Size = new System.Drawing.Size(347, 41);
            this.textBoxUserHeight.TabIndex = 14;
            this.textBoxUserHeight.Tag = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 491);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 41);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButtonWoman);
            this.groupBox1.Controls.Add(this.radioButtonMen);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(60, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(115, 37);
            this.radioButtonWoman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(65, 38);
            this.radioButtonWoman.TabIndex = 21;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Ж";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(24, 37);
            this.radioButtonMen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(64, 38);
            this.radioButtonMen.TabIndex = 20;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "М";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // labelUserHeight
            // 
            this.labelUserHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserHeight.AutoSize = true;
            this.labelUserHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserHeight.Location = new System.Drawing.Point(12, 570);
            this.labelUserHeight.Name = "labelUserHeight";
            this.labelUserHeight.Size = new System.Drawing.Size(77, 34);
            this.labelUserHeight.TabIndex = 20;
            this.labelUserHeight.Text = "Рост";
            // 
            // labelUserWeight
            // 
            this.labelUserWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserWeight.AutoSize = true;
            this.labelUserWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserWeight.Location = new System.Drawing.Point(12, 653);
            this.labelUserWeight.Name = "labelUserWeight";
            this.labelUserWeight.Size = new System.Drawing.Size(62, 34);
            this.labelUserWeight.TabIndex = 21;
            this.labelUserWeight.Text = "Вес";
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateBirth.Location = new System.Drawing.Point(12, 491);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(218, 34);
            this.labelDateBirth.TabIndex = 22;
            this.labelDateBirth.Text = "Дата рождения";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(422, 832);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(340, 85);
            this.buttonNext.TabIndex = 23;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // labelMedicalHistory
            // 
            this.labelMedicalHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMedicalHistory.AutoSize = true;
            this.labelMedicalHistory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicalHistory.Location = new System.Drawing.Point(54, 61);
            this.labelMedicalHistory.Name = "labelMedicalHistory";
            this.labelMedicalHistory.Size = new System.Drawing.Size(223, 34);
            this.labelMedicalHistory.TabIndex = 24;
            this.labelMedicalHistory.Text = "Карта пациента";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1074);
            this.Controls.Add(this.labelMedicalHistory);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDateBirth);
            this.Controls.Add(this.labelUserWeight);
            this.Controls.Add(this.labelUserHeight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxUserWeight);
            this.Controls.Add(this.textBoxUserHeight);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.buttonExit);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxUserWeight;
        private System.Windows.Forms.TextBox textBoxUserHeight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.Label labelUserHeight;
        private System.Windows.Forms.Label labelUserWeight;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelMedicalHistory;
    }
}