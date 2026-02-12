namespace Sorbent
{
    partial class ucAuthorization
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAuthorization));
            pbLogo = new PictureBox();
            lblTitle = new Label();
            labelLogin = new Label();
            txtLogin = new TextBox();
            labelPassword = new Label();
            txtPassword = new TextBox();
            btnEnter = new Button();
            lblError = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(40, 30);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(80, 80);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(140, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Авторизация";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(60, 140);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 20);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.Location = new Point(140, 137);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(262, 27);
            txtLogin.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(60, 200);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(140, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.FlatStyle = FlatStyle.System;
            btnEnter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEnter.Location = new Point(140, 270);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(120, 45);
            btnEnter.TabIndex = 6;
            btnEnter.Text = "Войти";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(60, 330);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(40, 368);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 8;
            label1.Text = "АО «Сорбент»";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(360, 368);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "2026 г.";
            label2.Click += label2_Click;
            // 
            // ucAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblError);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtLogin);
            Controls.Add(labelLogin);
            Controls.Add(lblTitle);
            Controls.Add(pbLogo);
            Name = "ucAuthorization";
            Size = new Size(480, 420);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitle;
        private Label labelLogin;
        private TextBox txtLogin;
        private Label labelPassword;
        private TextBox txtPassword;
        private Button btnEnter;
        private Label lblError;
        private Label label1;
        private Label label2;
    }
}
