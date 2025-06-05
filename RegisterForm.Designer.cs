namespace Login
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            k = new Label();
            label3 = new Label();
            label4 = new Label();
            RegisterBtn = new Button();
            RegisterUsernameTxt = new TextBox();
            RegisterPasswordTxt = new TextBox();
            pictureBox1 = new PictureBox();
            BackToLoginBtn = new Button();
            RegisterUsernameLbl = new Label();
            RegisterPasswordLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(273, 23);
            label1.Name = "label1";
            label1.Size = new Size(509, 35);
            label1.TabIndex = 0;
            label1.Text = "Create An Account To Manage Your Notes";
            // 
            // k
            // 
            k.AutoSize = true;
            k.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            k.Location = new Point(575, 102);
            k.Name = "k";
            k.Size = new Size(111, 28);
            k.TabIndex = 1;
            k.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(575, 190);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(575, 401);
            label4.Name = "label4";
            label4.Size = new Size(179, 28);
            label4.TabIndex = 3;
            label4.Text = "I have an account";
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.Highlight;
            RegisterBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegisterBtn.ForeColor = SystemColors.HighlightText;
            RegisterBtn.Location = new Point(703, 303);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(138, 42);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += button2_Click;
            // 
            // RegisterUsernameTxt
            // 
            RegisterUsernameTxt.Location = new Point(575, 130);
            RegisterUsernameTxt.Name = "RegisterUsernameTxt";
            RegisterUsernameTxt.Size = new Size(406, 27);
            RegisterUsernameTxt.TabIndex = 6;
            // 
            // RegisterPasswordTxt
            // 
            RegisterPasswordTxt.Location = new Point(575, 218);
            RegisterPasswordTxt.Name = "RegisterPasswordTxt";
            RegisterPasswordTxt.PasswordChar = '*';
            RegisterPasswordTxt.Size = new Size(406, 27);
            RegisterPasswordTxt.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // BackToLoginBtn
            // 
            BackToLoginBtn.BackColor = SystemColors.ActiveBorder;
            BackToLoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BackToLoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            BackToLoginBtn.Location = new Point(802, 396);
            BackToLoginBtn.Name = "BackToLoginBtn";
            BackToLoginBtn.Size = new Size(179, 39);
            BackToLoginBtn.TabIndex = 9;
            BackToLoginBtn.Text = "Back To Login";
            BackToLoginBtn.UseVisualStyleBackColor = false;
            BackToLoginBtn.Click += button1_Click;
            // 
            // RegisterUsernameLbl
            // 
            RegisterUsernameLbl.AutoSize = true;
            RegisterUsernameLbl.Location = new Point(824, 106);
            RegisterUsernameLbl.Name = "RegisterUsernameLbl";
            RegisterUsernameLbl.Size = new Size(157, 20);
            RegisterUsernameLbl.TabIndex = 10;
            RegisterUsernameLbl.Text = "Please enter username";
            // 
            // RegisterPasswordLbl
            // 
            RegisterPasswordLbl.AutoSize = true;
            RegisterPasswordLbl.Location = new Point(824, 194);
            RegisterPasswordLbl.Name = "RegisterPasswordLbl";
            RegisterPasswordLbl.Size = new Size(156, 20);
            RegisterPasswordLbl.TabIndex = 11;
            RegisterPasswordLbl.Text = "Please enter password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1057, 490);
            Controls.Add(RegisterPasswordLbl);
            Controls.Add(RegisterUsernameLbl);
            Controls.Add(BackToLoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(RegisterPasswordTxt);
            Controls.Add(RegisterUsernameTxt);
            Controls.Add(RegisterBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(k);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label k;
        private Label label3;
        private Label label4;
        private Button RegisterBtn;
        private TextBox RegisterUsernameTxt;
        private TextBox RegisterPasswordTxt;
        private PictureBox pictureBox1;
        private Button BackToLoginBtn;
        private Label RegisterUsernameLbl;
        private Label RegisterPasswordLbl;
    }
}