namespace Login
{
    partial class AddCategory
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
            categorySelector1 = new NoteEditor.CategorySelector();
            AddCategorybtn = new Button();
            SuspendLayout();
            // 
            // categorySelector1
            // 
            categorySelector1.BackColor = SystemColors.ButtonHighlight;
            categorySelector1.Location = new Point(53, 48);
            categorySelector1.Name = "categorySelector1";
            categorySelector1.Size = new Size(573, 31);
            categorySelector1.TabIndex = 0;
            // 
            // AddCategorybtn
            // 
            AddCategorybtn.BackColor = SystemColors.Highlight;
            AddCategorybtn.ForeColor = SystemColors.HighlightText;
            AddCategorybtn.Location = new Point(543, 95);
            AddCategorybtn.Name = "AddCategorybtn";
            AddCategorybtn.Size = new Size(142, 42);
            AddCategorybtn.TabIndex = 1;
            AddCategorybtn.Text = "Add Category";
            AddCategorybtn.UseVisualStyleBackColor = false;
            AddCategorybtn.Click += AddCategorybtn_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(697, 149);
            Controls.Add(AddCategorybtn);
            Controls.Add(categorySelector1);
            Name = "AddCategory";
            Text = "AddCategory";
            ResumeLayout(false);
        }

        #endregion

        private NoteEditor.CategorySelector categorySelector1;
        private Button AddCategorybtn;
    }
}