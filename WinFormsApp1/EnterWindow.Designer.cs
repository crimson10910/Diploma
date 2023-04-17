namespace WinFormsApp1
{
    partial class EnterWindow
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(147, 150);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(175, 29);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(147, 185);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(175, 29);
            this.buttonRegistration.TabIndex = 1;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(147, 117);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(175, 27);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(147, 49);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(175, 27);
            this.textBoxLogin.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(62, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 52);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 20);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            // 
            // EnterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 280);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonEnter);
            this.Name = "EnterWindow";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EnterWindow_Load);
            this.VisibleChanged += new System.EventHandler(this.EnterWindow_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEnter;
        private Button buttonRegistration;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelPassword;
        private Label labelLogin;
    }
}