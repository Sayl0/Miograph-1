namespace Miograph
{
    partial class HomePage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuickStart = new System.Windows.Forms.Button();
            this.UseerSelection = new System.Windows.Forms.Button();
            this.UserManual = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuickStart
            // 
            this.QuickStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickStart.Location = new System.Drawing.Point(24, 65);
            this.QuickStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuickStart.Name = "QuickStart";
            this.QuickStart.Size = new System.Drawing.Size(330, 60);
            this.QuickStart.TabIndex = 0;
            this.QuickStart.Text = "Быстрый старт";
            this.QuickStart.UseVisualStyleBackColor = true;
            this.QuickStart.Click += new System.EventHandler(this.QuickStart_Click);
            // 
            // UseerSelection
            // 
            this.UseerSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UseerSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseerSelection.Location = new System.Drawing.Point(24, 150);
            this.UseerSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UseerSelection.Name = "UseerSelection";
            this.UseerSelection.Size = new System.Drawing.Size(330, 60);
            this.UseerSelection.TabIndex = 1;
            this.UseerSelection.Text = "Выбор пользователя";
            this.UseerSelection.UseVisualStyleBackColor = true;
            this.UseerSelection.Click += new System.EventHandler(this.UserSelection_Click);
            // 
            // UserManual
            // 
            this.UserManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserManual.Location = new System.Drawing.Point(24, 238);
            this.UserManual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserManual.Name = "UserManual";
            this.UserManual.Size = new System.Drawing.Size(330, 60);
            this.UserManual.TabIndex = 2;
            this.UserManual.Text = "Инструкция пользователя";
            this.UserManual.UseVisualStyleBackColor = true;
            this.UserManual.Click += new System.EventHandler(this.UserManual_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(24, 323);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(330, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 458);
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UserManual);
            this.Controls.Add(this.UseerSelection);
            this.Controls.Add(this.QuickStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuickStart;
        private System.Windows.Forms.Button UseerSelection;
        private System.Windows.Forms.Button UserManual;
        private System.Windows.Forms.Button ExitButton;
    }
}

