namespace Miograph
{
    partial class SelectUser
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labellSecondName = new System.Windows.Forms.Label();
            this.labeFirstName = new System.Windows.Forms.Label();
            this.labelMidlename = new System.Windows.Forms.Label();
            this.buttonEditMap = new System.Windows.Forms.Button();
            this.buttonRunDiagnostics = new System.Windows.Forms.Button();
            this.buttonCourseParmeters = new System.Windows.Forms.Button();
            this.buttonGenerateStatement = new System.Windows.Forms.Button();
            this.labelDateDiagnosis = new System.Windows.Forms.Label();
            this.labelNoDiagnostics = new System.Windows.Forms.Label();
            this.labelFormationDate = new System.Windows.Forms.Label();
            this.labelNotFormed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(207, 599);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(218, 66);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Карта пациента";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.AccessibleDescription = "";
            this.textBoxMiddleName.AccessibleName = "";
            this.textBoxMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(230, 260);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(233, 30);
            this.textBoxMiddleName.TabIndex = 16;
            this.textBoxMiddleName.Tag = "";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AccessibleDescription = "";
            this.textBoxFirstName.AccessibleName = "";
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(230, 213);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(233, 30);
            this.textBoxFirstName.TabIndex = 15;
            this.textBoxFirstName.Tag = "";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.AccessibleDescription = "";
            this.textBoxSecondName.AccessibleName = "";
            this.textBoxSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecondName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.Location = new System.Drawing.Point(230, 165);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(233, 30);
            this.textBoxSecondName.TabIndex = 14;
            this.textBoxSecondName.Tag = "";
            // 
            // labellSecondName
            // 
            this.labellSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellSecondName.AutoSize = true;
            this.labellSecondName.Location = new System.Drawing.Point(67, 168);
            this.labellSecondName.Name = "labellSecondName";
            this.labellSecondName.Size = new System.Drawing.Size(92, 23);
            this.labellSecondName.TabIndex = 17;
            this.labellSecondName.Text = "Фамилия";
            // 
            // labeFirstName
            // 
            this.labeFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeFirstName.AutoSize = true;
            this.labeFirstName.Location = new System.Drawing.Point(67, 213);
            this.labeFirstName.Name = "labeFirstName";
            this.labeFirstName.Size = new System.Drawing.Size(48, 23);
            this.labeFirstName.TabIndex = 18;
            this.labeFirstName.Text = "Имя";
            // 
            // labelMidlename
            // 
            this.labelMidlename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMidlename.AutoSize = true;
            this.labelMidlename.Location = new System.Drawing.Point(67, 260);
            this.labelMidlename.Name = "labelMidlename";
            this.labelMidlename.Size = new System.Drawing.Size(93, 23);
            this.labelMidlename.TabIndex = 19;
            this.labelMidlename.Text = "Отчество";
            // 
            // buttonEditMap
            // 
            this.buttonEditMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditMap.Location = new System.Drawing.Point(603, 135);
            this.buttonEditMap.Name = "buttonEditMap";
            this.buttonEditMap.Size = new System.Drawing.Size(256, 60);
            this.buttonEditMap.TabIndex = 20;
            this.buttonEditMap.Text = "Редактировать карту";
            this.buttonEditMap.UseVisualStyleBackColor = true;
            this.buttonEditMap.Click += new System.EventHandler(this.buttonEditMap_Click);
            // 
            // buttonRunDiagnostics
            // 
            this.buttonRunDiagnostics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunDiagnostics.Location = new System.Drawing.Point(603, 207);
            this.buttonRunDiagnostics.Name = "buttonRunDiagnostics";
            this.buttonRunDiagnostics.Size = new System.Drawing.Size(256, 60);
            this.buttonRunDiagnostics.TabIndex = 21;
            this.buttonRunDiagnostics.Text = "Провести диагностику";
            this.buttonRunDiagnostics.UseVisualStyleBackColor = true;
            this.buttonRunDiagnostics.Click += new System.EventHandler(this.buttonRunDiagnostics_Click);
            // 
            // buttonCourseParmeters
            // 
            this.buttonCourseParmeters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCourseParmeters.Location = new System.Drawing.Point(603, 284);
            this.buttonCourseParmeters.Name = "buttonCourseParmeters";
            this.buttonCourseParmeters.Size = new System.Drawing.Size(256, 60);
            this.buttonCourseParmeters.TabIndex = 22;
            this.buttonCourseParmeters.Text = "Пармаетры курса";
            this.buttonCourseParmeters.UseVisualStyleBackColor = true;
            this.buttonCourseParmeters.Click += new System.EventHandler(this.buttonCourseParmeters_Click);
            // 
            // buttonGenerateStatement
            // 
            this.buttonGenerateStatement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGenerateStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateStatement.Location = new System.Drawing.Point(603, 599);
            this.buttonGenerateStatement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonGenerateStatement.Name = "buttonGenerateStatement";
            this.buttonGenerateStatement.Size = new System.Drawing.Size(256, 66);
            this.buttonGenerateStatement.TabIndex = 23;
            this.buttonGenerateStatement.Text = "Сформировать выписку";
            this.buttonGenerateStatement.UseVisualStyleBackColor = true;
            this.buttonGenerateStatement.Click += new System.EventHandler(this.buttonGenerateStatement_Click);
            // 
            // labelDateDiagnosis
            // 
            this.labelDateDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateDiagnosis.AutoSize = true;
            this.labelDateDiagnosis.Location = new System.Drawing.Point(67, 379);
            this.labelDateDiagnosis.Name = "labelDateDiagnosis";
            this.labelDateDiagnosis.Size = new System.Drawing.Size(283, 23);
            this.labelDateDiagnosis.TabIndex = 24;
            this.labelDateDiagnosis.Text = "Дата проведения диагностики";
            // 
            // labelNoDiagnostics
            // 
            this.labelNoDiagnostics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoDiagnostics.AutoSize = true;
            this.labelNoDiagnostics.Location = new System.Drawing.Point(67, 426);
            this.labelNoDiagnostics.Name = "labelNoDiagnostics";
            this.labelNoDiagnostics.Size = new System.Drawing.Size(273, 23);
            this.labelNoDiagnostics.TabIndex = 25;
            this.labelNoDiagnostics.Text = "Диагностика не проводилась";
            // 
            // labelFormationDate
            // 
            this.labelFormationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormationDate.AutoSize = true;
            this.labelFormationDate.Location = new System.Drawing.Point(67, 478);
            this.labelFormationDate.Name = "labelFormationDate";
            this.labelFormationDate.Size = new System.Drawing.Size(254, 23);
            this.labelFormationDate.TabIndex = 26;
            this.labelFormationDate.Text = "Дата формирования курса:";
            // 
            // labelNotFormed
            // 
            this.labelNotFormed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotFormed.AutoSize = true;
            this.labelNotFormed.Location = new System.Drawing.Point(67, 531);
            this.labelNotFormed.Name = "labelNotFormed";
            this.labelNotFormed.Size = new System.Drawing.Size(164, 23);
            this.labelNotFormed.TabIndex = 27;
            this.labelNotFormed.Text = "Не сформирован";
            // 
            // SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 714);
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.labelNotFormed);
            this.Controls.Add(this.labelFormationDate);
            this.Controls.Add(this.labelNoDiagnostics);
            this.Controls.Add(this.labelDateDiagnosis);
            this.Controls.Add(this.buttonGenerateStatement);
            this.Controls.Add(this.buttonCourseParmeters);
            this.Controls.Add(this.buttonRunDiagnostics);
            this.Controls.Add(this.buttonEditMap);
            this.Controls.Add(this.labelMidlename);
            this.Controls.Add(this.labeFirstName);
            this.Controls.Add(this.labellSecondName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectUser";
            this.Text = "SelectUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelectUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labellSecondName;
        private System.Windows.Forms.Label labeFirstName;
        private System.Windows.Forms.Label labelMidlename;
        private System.Windows.Forms.Button buttonEditMap;
        private System.Windows.Forms.Button buttonRunDiagnostics;
        private System.Windows.Forms.Button buttonCourseParmeters;
        private System.Windows.Forms.Button buttonGenerateStatement;
        private System.Windows.Forms.Label labelDateDiagnosis;
        private System.Windows.Forms.Label labelNoDiagnostics;
        private System.Windows.Forms.Label labelFormationDate;
        private System.Windows.Forms.Label labelNotFormed;
    }
}