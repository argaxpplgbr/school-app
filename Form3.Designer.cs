namespace SchoolApp
{
    partial class FormRegister
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
            txtPassword = new TextBox();
            btnSubmitRegister = new Button();
            btnNavToLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 0;
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSubmitRegister.Location = new Point(251, 254);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(287, 59);
            btnSubmitRegister.TabIndex = 1;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = true;
            btnSubmitRegister.Click += button1_Click;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.Location = new Point(251, 375);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(152, 29);
            btnNavToLogin.TabIndex = 2;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = true;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 54);
            label1.TabIndex = 3;
            label1.Text = "Form Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 339);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 4;
            label2.Text = "Already have account? click login";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(251, 147);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "UserName...";
            txtUserName.Size = new Size(287, 27);
            txtUserName.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(251, 91);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name...";
            txtFullName.Size = new Size(287, 27);
            txtFullName.TabIndex = 6;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFullName);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSubmitRegister);
            Controls.Add(txtPassword);
            Name = "FormRegister";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnSubmitRegister;
        private Button btnNavToLogin;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtFullName;
    }
}