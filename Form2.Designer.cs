namespace SchoolApp
{
    partial class FormLogin
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSubmitLogin = new Button();
            btnNavToRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserName.Location = new Point(144, 98);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "masukan username...";
            txtUserName.Size = new Size(457, 39);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Location = new Point(144, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "masukan password...";
            txtPassword.Size = new Size(457, 39);
            txtPassword.TabIndex = 2;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSubmitLogin.Location = new Point(144, 227);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(457, 55);
            btnSubmitLogin.TabIndex = 3;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = true;
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.Location = new Point(144, 349);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(225, 29);
            btnNavToRegister.TabIndex = 4;
            btnNavToRegister.Text = "To Register";
            btnNavToRegister.UseVisualStyleBackColor = true;
            btnNavToRegister.Click += btnNavToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 54);
            label1.TabIndex = 5;
            label1.Text = "Form Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 309);
            label2.Name = "label2";
            label2.Size = new Size(225, 20);
            label2.TabIndex = 6;
            label2.Text = "dont have account? click register";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNavToRegister);
            Controls.Add(btnSubmitLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnSubmitLogin;
        private Button btnNavToRegister;
        private Label label1;
        private Label label2;
    }
}