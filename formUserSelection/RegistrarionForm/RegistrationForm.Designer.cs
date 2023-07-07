﻿namespace Miograph
{
    partial class RegistrationForm
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.labelRegistrationForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.Location = new System.Drawing.Point(317, 455);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(279, 55);
            this.buttonSignUp.TabIndex = 7;
            this.buttonSignUp.Text = "Зарегистрироваться";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(397, 299);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(186, 29);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(300, 302);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 24);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(397, 250);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(186, 29);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(317, 539);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(279, 55);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(313, 253);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(69, 24);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(397, 349);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(186, 29);
            this.textBoxPasswordConfirm.TabIndex = 4;
            this.textBoxPasswordConfirm.UseSystemPasswordChar = true;
            this.textBoxPasswordConfirm.TextChanged += new System.EventHandler(this.textBoxPasswordConfirm_TextChanged);
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirm.Location = new System.Drawing.Point(182, 356);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(207, 24);
            this.labelConfirm.TabIndex = 14;
            this.labelConfirm.Text = "Подтвердите пароль:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullName.Location = new System.Drawing.Point(397, 200);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(186, 29);
            this.textBoxFullName.TabIndex = 1;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(151, 203);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(234, 24);
            this.labelFullName.TabIndex = 16;
            this.labelFullName.Text = "Фамилия, имя, отчество:";
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDoctor.Location = new System.Drawing.Point(664, 199);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(71, 28);
            this.radioButtonDoctor.TabIndex = 5;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Врач";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            this.radioButtonDoctor.CheckedChanged += new System.EventHandler(this.radioButtonDoctor_CheckedChanged);
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOperator.Location = new System.Drawing.Point(664, 232);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(118, 28);
            this.radioButtonOperator.TabIndex = 6;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Оператор";
            this.radioButtonOperator.UseVisualStyleBackColor = true;
            this.radioButtonOperator.CheckedChanged += new System.EventHandler(this.radioButtonOperator_CheckedChanged);
            // 
            // labelRegistrationForm
            // 
            this.labelRegistrationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegistrationForm.AutoSize = true;
            this.labelRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationForm.Location = new System.Drawing.Point(383, 128);
            this.labelRegistrationForm.Name = "labelRegistrationForm";
            this.labelRegistrationForm.Size = new System.Drawing.Size(265, 29);
            this.labelRegistrationForm.TabIndex = 20;
            this.labelRegistrationForm.Text = "Форма регистрации";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(890, 701);
            this.Controls.Add(this.labelRegistrationForm);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.radioButtonDoctor);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.Label labelRegistrationForm;
    }
}