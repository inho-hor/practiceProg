namespace regAndAuto
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.userLoginField = new System.Windows.Forms.TextBox();
            this.userPasswordField = new System.Windows.Forms.TextBox();
            this.userPasswordDbField = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.returnEntrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подтверждение пароля";
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(57, 65);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(172, 22);
            this.userNameField.TabIndex = 4;
            // 
            // userLoginField
            // 
            this.userLoginField.Location = new System.Drawing.Point(57, 110);
            this.userLoginField.Name = "userLoginField";
            this.userLoginField.Size = new System.Drawing.Size(172, 22);
            this.userLoginField.TabIndex = 5;
            // 
            // userPasswordField
            // 
            this.userPasswordField.Location = new System.Drawing.Point(57, 155);
            this.userPasswordField.Name = "userPasswordField";
            this.userPasswordField.Size = new System.Drawing.Size(172, 22);
            this.userPasswordField.TabIndex = 6;
            this.userPasswordField.UseSystemPasswordChar = true;
            // 
            // userPasswordDbField
            // 
            this.userPasswordDbField.Location = new System.Drawing.Point(57, 200);
            this.userPasswordDbField.Name = "userPasswordDbField";
            this.userPasswordDbField.Size = new System.Drawing.Size(172, 22);
            this.userPasswordDbField.TabIndex = 7;
            this.userPasswordDbField.UseSystemPasswordChar = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(57, 228);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(172, 29);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // returnEntrance
            // 
            this.returnEntrance.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnEntrance.Location = new System.Drawing.Point(57, 263);
            this.returnEntrance.Name = "returnEntrance";
            this.returnEntrance.Size = new System.Drawing.Size(172, 27);
            this.returnEntrance.TabIndex = 9;
            this.returnEntrance.Text = "Авторизация";
            this.returnEntrance.UseVisualStyleBackColor = true;
            this.returnEntrance.Click += new System.EventHandler(this.returnEntrance_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 342);
            this.Controls.Add(this.returnEntrance);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.userPasswordDbField);
            this.Controls.Add(this.userPasswordField);
            this.Controls.Add(this.userLoginField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userLoginField;
        private System.Windows.Forms.TextBox userPasswordField;
        private System.Windows.Forms.TextBox userPasswordDbField;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button returnEntrance;
    }
}