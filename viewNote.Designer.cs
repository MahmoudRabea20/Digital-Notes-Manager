namespace MyNote
{
    partial class viewNote
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
            textBoxTitle = new TextBox();
            textBoxCategory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextContent = new RichTextBox();
            textBoxDate = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(141, 108);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(283, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(141, 176);
            textBoxCategory.Margin = new Padding(3, 4, 3, 4);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(283, 27);
            textBoxCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F);
            label1.Location = new Point(23, 108);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F);
            label2.Location = new Point(23, 180);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F);
            label3.Location = new Point(23, 234);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F);
            label4.Location = new Point(23, 309);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 7;
            label4.Text = "Content";
            // 
            // richTextContent
            // 
            richTextContent.Location = new Point(141, 309);
            richTextContent.Margin = new Padding(3, 4, 3, 4);
            richTextContent.Name = "richTextContent";
            richTextContent.Size = new Size(283, 163);
            richTextContent.TabIndex = 8;
            richTextContent.Text = "";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(141, 233);
            textBoxDate.Margin = new Padding(3, 4, 3, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(283, 27);
            textBoxDate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 31);
            label5.Name = "label5";
            label5.Size = new Size(140, 37);
            label5.TabIndex = 10;
            label5.Text = "Note Info";
            // 
            // viewNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 483);
            Controls.Add(label5);
            Controls.Add(textBoxDate);
            Controls.Add(richTextContent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "viewNote";
            Text = "viewNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxContent;
        private TextBox textBoxCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextContent;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxDate;
        private Label label5;
    }
}