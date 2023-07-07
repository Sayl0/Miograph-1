using System.Windows.Forms;

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
            this.buttonExit.Location = new System.Drawing.Point(41, 582);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(227, 55);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.AccessibleDescription = "";
            this.textBoxSecondName.AccessibleName = "";
            this.textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.Location = new System.Drawing.Point(41, 87);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(233, 30);
            this.textBoxSecondName.TabIndex = 1;
            this.textBoxSecondName.Tag = "";
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.textBoxSecondName_TextChanged);
            this.textBoxSecondName.Enter += new System.EventHandler(this.textBoxSecondName_Enter);
            this.textBoxSecondName.Leave += new System.EventHandler(this.textBoxSecondName_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AccessibleDescription = "";
            this.textBoxFirstName.AccessibleName = "";
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(41, 141);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(233, 30);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Tag = "";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.AccessibleDescription = "";
            this.textBoxMiddleName.AccessibleName = "";
            this.textBoxMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(41, 197);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(233, 30);
            this.textBoxMiddleName.TabIndex = 3;
            this.textBoxMiddleName.Tag = "";
            this.textBoxMiddleName.TextChanged += new System.EventHandler(this.textBoxMiddleName_TextChanged);
            this.textBoxMiddleName.Enter += new System.EventHandler(this.textBoxMiddleName_Enter);
            this.textBoxMiddleName.Leave += new System.EventHandler(this.textBoxMiddleName_Leave);
            // 
            // textBoxUserWeight
            // 
            this.textBoxUserWeight.AccessibleDescription = "";
            this.textBoxUserWeight.AccessibleName = "";
            this.textBoxUserWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserWeight.Location = new System.Drawing.Point(130, 466);
            this.textBoxUserWeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserWeight.Name = "textBoxUserWeight";
            this.textBoxUserWeight.Size = new System.Drawing.Size(233, 30);
            this.textBoxUserWeight.TabIndex = 8;
            this.textBoxUserWeight.Tag = "";
            this.textBoxUserWeight.Enter += new System.EventHandler(this.textBoxUserWeight_Enter);
            this.textBoxUserWeight.Leave += new System.EventHandler(this.textBoxUserWeight_Leave);
            // 
            // textBoxUserHeight
            // 
            this.textBoxUserHeight.AccessibleDescription = "";
            this.textBoxUserHeight.AccessibleName = "";
            this.textBoxUserHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserHeight.Location = new System.Drawing.Point(130, 407);
            this.textBoxUserHeight.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserHeight.Name = "textBoxUserHeight";
            this.textBoxUserHeight.Size = new System.Drawing.Size(233, 30);
            this.textBoxUserHeight.TabIndex = 7;
            this.textBoxUserHeight.Tag = "";
            this.textBoxUserHeight.Enter += new System.EventHandler(this.textBoxUserHeight_Enter);
            this.textBoxUserHeight.Leave += new System.EventHandler(this.textBoxUserHeight_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 350);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButtonWoman);
            this.groupBox1.Controls.Add(this.radioButtonMen);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(41, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(133, 65);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(77, 24);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(45, 27);
            this.radioButtonWoman.TabIndex = 5;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Ж";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(16, 24);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(45, 27);
            this.radioButtonMen.TabIndex = 4;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "М";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // labelUserHeight
            // 
            this.labelUserHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserHeight.AutoSize = true;
            this.labelUserHeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserHeight.Location = new System.Drawing.Point(9, 408);
            this.labelUserHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserHeight.Name = "labelUserHeight";
            this.labelUserHeight.Size = new System.Drawing.Size(52, 23);
            this.labelUserHeight.TabIndex = 20;
            this.labelUserHeight.Text = "Рост";
            // 
            // labelUserWeight
            // 
            this.labelUserWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserWeight.AutoSize = true;
            this.labelUserWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserWeight.Location = new System.Drawing.Point(9, 468);
            this.labelUserWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserWeight.Name = "labelUserWeight";
            this.labelUserWeight.Size = new System.Drawing.Size(42, 23);
            this.labelUserWeight.TabIndex = 21;
            this.labelUserWeight.Text = "Вес";
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateBirth.Location = new System.Drawing.Point(9, 350);
            this.labelDateBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(148, 23);
            this.labelDateBirth.TabIndex = 22;
            this.labelDateBirth.Text = "Дата рождения";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(282, 582);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(227, 55);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelMedicalHistory
            // 
            this.labelMedicalHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMedicalHistory.AutoSize = true;
            this.labelMedicalHistory.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicalHistory.Location = new System.Drawing.Point(36, 32);
            this.labelMedicalHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMedicalHistory.Name = "labelMedicalHistory";
            this.labelMedicalHistory.Size = new System.Drawing.Size(191, 29);
            this.labelMedicalHistory.TabIndex = 24;
            this.labelMedicalHistory.Text = "Карта пациента";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 701);
            this.BackColor = System.Drawing.Color.FloralWhite;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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