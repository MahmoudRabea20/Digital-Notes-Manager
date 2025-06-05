namespace Login
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginUsernameTxt = new TextBox();
            LoginPasswordTxt = new TextBox();
            label4 = new Label();
            LoginBtn = new Button();
            CreateAccountBtn = new Button();
            pictureBox1 = new PictureBox();
            LoginUsernameLbl = new Label();
            LoginPasswordLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(397, 21);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 0;
            label1.Text = "Login To Your Notes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(557, 92);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(557, 170);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // LoginUsernameTxt
            // 
            LoginUsernameTxt.Location = new Point(557, 123);
            LoginUsernameTxt.Name = "LoginUsernameTxt";
            LoginUsernameTxt.Size = new Size(436, 27);
            LoginUsernameTxt.TabIndex = 3;
            // 
            // LoginPasswordTxt
            // 
            LoginPasswordTxt.Location = new Point(557, 204);
            LoginPasswordTxt.Name = "LoginPasswordTxt";
            LoginPasswordTxt.PasswordChar = '*';
            LoginPasswordTxt.Size = new Size(436, 27);
            LoginPasswordTxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(557, 411);
            label4.Name = "label4";
            label4.Size = new Size(240, 28);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account ?";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Highlight;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.HighlightText;
            LoginBtn.Location = new Point(693, 288);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(172, 43);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.BackColor = SystemColors.ActiveBorder;
            CreateAccountBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CreateAccountBtn.ForeColor = SystemColors.ActiveCaptionText;
            CreateAccountBtn.Location = new Point(803, 406);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(190, 45);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create a new account";
            CreateAccountBtn.UseVisualStyleBackColor = false;
            CreateAccountBtn.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginUsernameLbl
            // 
            LoginUsernameLbl.AutoSize = true;
            LoginUsernameLbl.Location = new Point(836, 99);
            LoginUsernameLbl.Name = "LoginUsernameLbl";
            LoginUsernameLbl.Size = new Size(157, 20);
            LoginUsernameLbl.TabIndex = 9;
            LoginUsernameLbl.Text = "Please enter username";
            // 
            // LoginPasswordLbl
            // 
            LoginPasswordLbl.AutoSize = true;
            LoginPasswordLbl.Location = new Point(837, 178);
            LoginPasswordLbl.Name = "LoginPasswordLbl";
            LoginPasswordLbl.Size = new Size(156, 20);
            LoginPasswordLbl.TabIndex = 10;
            LoginPasswordLbl.Text = "Please enter password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1057, 490);
            Controls.Add(LoginPasswordLbl);
            Controls.Add(LoginUsernameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(CreateAccountBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(LoginPasswordTxt);
            Controls.Add(LoginUsernameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                                     Login To Your Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginUsernameTxt;
        private TextBox LoginPasswordTxt;
        private Label label4;
        private Button LoginBtn;
        private Button CreateAccountBtn;
        private PictureBox pictureBox1;
        private Label LoginUsernameLbl;
        private Label LoginPasswordLbl;
    }
}
