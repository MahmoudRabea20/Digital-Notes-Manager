namespace Login
{
    partial class NoteCard
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
            lblTitle = new Label();
            lblContent = new Label();
            lblCategory = new Label();
            lblCreated = new Label();
            lblReminder = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EditButton = new Button();
            button3 = new Button();
            TitleLabel = new Label();
            ConLabel = new Label();
            CatLabel = new Label();
            CrDateLabel = new Label();
            ReDateLabel = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(79, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 20);
            lblTitle.TabIndex = 0;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(85, 53);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(0, 20);
            lblContent.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(60, 91);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 20);
            lblCategory.TabIndex = 2;
            // 
            // lblCreated
            // 
            lblCreated.AutoSize = true;
            lblCreated.Location = new Point(101, 126);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(0, 20);
            lblCreated.TabIndex = 3;
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Location = new Point(101, 168);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(0, 20);
            lblReminder.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 5;
            label1.Text = "Title                   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 53);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Content             :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 91);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Category           :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 126);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 8;
            label4.Text = "Creation Date   :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 165);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 9;
            label5.Text = "Reminder Date :";
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.Highlight;
            EditButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(368, 14);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(128, 54);
            EditButton.TabIndex = 11;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(368, 128);
            button3.Name = "button3";
            button3.Size = new Size(128, 57);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(150, 19);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(51, 20);
            TitleLabel.TabIndex = 13;
            TitleLabel.Text = "label6";
            // 
            // ConLabel
            // 
            ConLabel.AutoSize = true;
            ConLabel.Location = new Point(150, 61);
            ConLabel.Name = "ConLabel";
            ConLabel.Size = new Size(51, 20);
            ConLabel.TabIndex = 14;
            ConLabel.Text = "label7";
            // 
            // CatLabel
            // 
            CatLabel.AutoSize = true;
            CatLabel.Location = new Point(150, 97);
            CatLabel.Name = "CatLabel";
            CatLabel.Size = new Size(51, 20);
            CatLabel.TabIndex = 15;
            CatLabel.Text = "label8";
            // 
            // CrDateLabel
            // 
            CrDateLabel.AutoSize = true;
            CrDateLabel.Location = new Point(150, 135);
            CrDateLabel.Name = "CrDateLabel";
            CrDateLabel.Size = new Size(51, 20);
            CrDateLabel.TabIndex = 16;
            CrDateLabel.Text = "label9";
            // 
            // ReDateLabel
            // 
            ReDateLabel.AutoSize = true;
            ReDateLabel.Location = new Point(145, 170);
            ReDateLabel.Name = "ReDateLabel";
            ReDateLabel.Size = new Size(60, 20);
            ReDateLabel.TabIndex = 17;
            ReDateLabel.Text = "label10";
            // 
            // NoteCard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ReDateLabel);
            Controls.Add(CrDateLabel);
            Controls.Add(CatLabel);
            Controls.Add(ConLabel);
            Controls.Add(TitleLabel);
            Controls.Add(button3);
            Controls.Add(EditButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblReminder);
            Controls.Add(lblCreated);
            Controls.Add(lblCategory);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(1);
            Name = "NoteCard";
            Size = new Size(610, 214);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblContent;
        private Label lblCategory;
        private Label lblCreated;
        private Label lblReminder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button EditButton;
        private Button button3;
        private Label TitleLabel;
        private Label ConLabel;
        private Label CatLabel;
        private Label CrDateLabel;
        private Label ReDateLabel;
    }
}