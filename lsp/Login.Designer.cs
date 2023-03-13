namespace lsp
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ActionLogin = new Button();
            InputPassword = new TextBox();
            InputPasswordLabel = new Label();
            InputEmail = new TextBox();
            InputEmailLabel = new Label();
            InputEmailError = new Label();
            InputPasswordError = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 16);
            label1.Name = "label1";
            label1.Size = new Size(151, 67);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(InputPasswordError);
            panel2.Controls.Add(InputEmailError);
            panel2.Controls.Add(ActionLogin);
            panel2.Controls.Add(InputPassword);
            panel2.Controls.Add(InputPasswordLabel);
            panel2.Controls.Add(InputEmail);
            panel2.Controls.Add(InputEmailLabel);
            panel2.Location = new Point(93, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 253);
            panel2.TabIndex = 1;
            // 
            // ActionLogin
            // 
            ActionLogin.BackColor = Color.DodgerBlue;
            ActionLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            ActionLogin.ForeColor = Color.White;
            ActionLogin.Location = new Point(247, 195);
            ActionLogin.Name = "ActionLogin";
            ActionLogin.Size = new Size(113, 40);
            ActionLogin.TabIndex = 5;
            ActionLogin.Text = "Login";
            ActionLogin.UseVisualStyleBackColor = false;
            ActionLogin.Click += ActionLogin_Click;
            // 
            // InputPassword
            // 
            InputPassword.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputPassword.Location = new Point(209, 131);
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(216, 34);
            InputPassword.TabIndex = 3;
            InputPassword.UseSystemPasswordChar = true;
            // 
            // InputPasswordLabel
            // 
            InputPasswordLabel.AutoSize = true;
            InputPasswordLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputPasswordLabel.Location = new Point(91, 134);
            InputPasswordLabel.Name = "InputPasswordLabel";
            InputPasswordLabel.Size = new Size(93, 28);
            InputPasswordLabel.TabIndex = 2;
            InputPasswordLabel.Text = "Password";
            // 
            // InputEmail
            // 
            InputEmail.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputEmail.Location = new Point(209, 52);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(216, 34);
            InputEmail.TabIndex = 1;
            // 
            // InputEmailLabel
            // 
            InputEmailLabel.AutoSize = true;
            InputEmailLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputEmailLabel.Location = new Point(91, 55);
            InputEmailLabel.Name = "InputEmailLabel";
            InputEmailLabel.Size = new Size(59, 28);
            InputEmailLabel.TabIndex = 0;
            InputEmailLabel.Text = "Email";
            // 
            // InputEmailError
            // 
            InputEmailError.AutoSize = true;
            InputEmailError.BackColor = Color.Transparent;
            InputEmailError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputEmailError.ForeColor = Color.Red;
            InputEmailError.Location = new Point(100, 97);
            InputEmailError.Name = "InputEmailError";
            InputEmailError.Size = new Size(0, 15);
            InputEmailError.TabIndex = 6;
            // 
            // InputPasswordError
            // 
            InputPasswordError.AutoSize = true;
            InputPasswordError.BackColor = Color.Transparent;
            InputPasswordError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputPasswordError.ForeColor = Color.Red;
            InputPasswordError.Location = new Point(100, 180);
            InputPasswordError.Name = "InputPasswordError";
            InputPasswordError.Size = new Size(0, 15);
            InputPasswordError.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label InputEmailLabel;
        private TextBox InputPassword;
        private Label InputPasswordLabel;
        private TextBox InputEmail;
        private Button ActionLogin;
        private Label InputPasswordError;
        private Label InputEmailError;
    }
}