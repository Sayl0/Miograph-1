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
            this.QuickStart.Location = new System.Drawing.Point(300, 80);
            this.QuickStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuickStart.Name = "QuickStart";
            this.QuickStart.Size = new System.Drawing.Size(120, 50);
            this.QuickStart.TabIndex = 0;
            this.QuickStart.Text = "Быстрый старт";
            this.QuickStart.UseVisualStyleBackColor = true;
            this.QuickStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // UseerSelection
            // 
            this.UseerSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UseerSelection.Location = new System.Drawing.Point(300, 140);
            this.UseerSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UseerSelection.Name = "UseerSelection";
            this.UseerSelection.Size = new System.Drawing.Size(120, 50);
            this.UseerSelection.TabIndex = 1;
            this.UseerSelection.Text = "Выбор пользователя";
            this.UseerSelection.UseVisualStyleBackColor = true;
            this.UseerSelection.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserManual
            // 
            this.UserManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserManual.Location = new System.Drawing.Point(300, 200);
            this.UserManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserManual.Name = "UserManual";
            this.UserManual.Size = new System.Drawing.Size(120, 50);
            this.UserManual.TabIndex = 2;
            this.UserManual.Text = "Инструкция пользоватлея";
            this.UserManual.UseVisualStyleBackColor = true;
            this.UserManual.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.Location = new System.Drawing.Point(300, 260);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(120, 50);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UserManual);
            this.Controls.Add(this.UseerSelection);
            this.Controls.Add(this.QuickStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuickStart;
        private System.Windows.Forms.Button UseerSelection;
        private System.Windows.Forms.Button UserManual;
        private System.Windows.Forms.Button ExitButton;
    }
}

