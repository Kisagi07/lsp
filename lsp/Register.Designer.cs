namespace lsp
{
    partial class Register
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
            InputPassword = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ActionRegister = new Button();
            InputNama = new TextBox();
            InputNamaLabel = new Label();
            InputPasswordLabel = new Label();
            InputEmail = new TextBox();
            InputEmailLabel = new Label();
            InputNamaError = new Label();
            InputPasswordError = new Label();
            InputEmailError = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // InputPassword
            // 
            InputPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputPassword.Location = new Point(209, 153);
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(216, 23);
            InputPassword.TabIndex = 3;
            InputPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 100);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 16);
            label1.Name = "label1";
            label1.Size = new Size(206, 67);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(InputEmailError);
            panel2.Controls.Add(InputPasswordError);
            panel2.Controls.Add(InputNamaError);
            panel2.Controls.Add(ActionRegister);
            panel2.Controls.Add(InputNama);
            panel2.Controls.Add(InputNamaLabel);
            panel2.Controls.Add(InputPassword);
            panel2.Controls.Add(InputPasswordLabel);
            panel2.Controls.Add(InputEmail);
            panel2.Controls.Add(InputEmailLabel);
            panel2.Location = new Point(93, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 253);
            panel2.TabIndex = 3;
            // 
            // ActionRegister
            // 
            ActionRegister.BackColor = Color.DodgerBlue;
            ActionRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            ActionRegister.ForeColor = Color.White;
            ActionRegister.Location = new Point(238, 204);
            ActionRegister.Name = "ActionRegister";
            ActionRegister.Size = new Size(113, 40);
            ActionRegister.TabIndex = 4;
            ActionRegister.Text = "Register";
            ActionRegister.UseVisualStyleBackColor = false;
            ActionRegister.Click += ActionRegister_Click;
            // 
            // InputNama
            // 
            InputNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputNama.Location = new Point(209, 28);
            InputNama.Name = "InputNama";
            InputNama.Size = new Size(216, 23);
            InputNama.TabIndex = 5;
            // 
            // InputNamaLabel
            // 
            InputNamaLabel.AutoSize = true;
            InputNamaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputNamaLabel.Location = new Point(131, 31);
            InputNamaLabel.Name = "InputNamaLabel";
            InputNamaLabel.Size = new Size(39, 15);
            InputNamaLabel.TabIndex = 4;
            InputNamaLabel.Text = "Nama";
            // 
            // InputPasswordLabel
            // 
            InputPasswordLabel.AutoSize = true;
            InputPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputPasswordLabel.Location = new Point(131, 156);
            InputPasswordLabel.Name = "InputPasswordLabel";
            InputPasswordLabel.Size = new Size(57, 15);
            InputPasswordLabel.TabIndex = 2;
            InputPasswordLabel.Text = "Password";
            // 
            // InputEmail
            // 
            InputEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputEmail.Location = new Point(209, 94);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(216, 23);
            InputEmail.TabIndex = 1;
            // 
            // InputEmailLabel
            // 
            InputEmailLabel.AutoSize = true;
            InputEmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InputEmailLabel.Location = new Point(131, 94);
            InputEmailLabel.Name = "InputEmailLabel";
            InputEmailLabel.Size = new Size(36, 15);
            InputEmailLabel.TabIndex = 0;
            InputEmailLabel.Text = "Email";
            // 
            // InputNamaError
            // 
            InputNamaError.AutoSize = true;
            InputNamaError.BackColor = Color.Transparent;
            InputNamaError.ForeColor = Color.Red;
            InputNamaError.Location = new Point(132, 63);
            InputNamaError.Name = "InputNamaError";
            InputNamaError.Size = new Size(0, 15);
            InputNamaError.TabIndex = 6;
            // 
            // InputPasswordError
            // 
            InputPasswordError.AutoSize = true;
            InputPasswordError.BackColor = Color.Transparent;
            InputPasswordError.ForeColor = Color.Red;
            InputPasswordError.Location = new Point(133, 182);
            InputPasswordError.Name = "InputPasswordError";
            InputPasswordError.Size = new Size(0, 15);
            InputPasswordError.TabIndex = 7;
            // 
            // InputEmailError
            // 
            InputEmailError.AutoSize = true;
            InputEmailError.BackColor = Color.Transparent;
            InputEmailError.ForeColor = Color.Red;
            InputEmailError.Location = new Point(133, 126);
            InputEmailError.Name = "InputEmailError";
            InputEmailError.Size = new Size(0, 15);
            InputEmailError.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Register";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox InputPassword;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button ActionRegister;
        private TextBox InputNama;
        private Label InputNamaLabel;
        private Label InputPasswordLabel;
        private TextBox InputEmail;
        private Label InputEmailLabel;
        private Label InputEmailError;
        private Label InputPasswordError;
        private Label InputNamaError;
    }
}