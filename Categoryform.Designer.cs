namespace MyNote
{
    partial class Categoryform
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
            CategoryBox = new ComboBox();
            dataGridView = new DataGridView();
            SearchtextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // CategoryBox
            // 
            CategoryBox.Dock = DockStyle.Left;
            CategoryBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Location = new Point(3, 4);
            CategoryBox.Margin = new Padding(3, 4, 3, 4);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(132, 36);
            CategoryBox.TabIndex = 0;
            CategoryBox.SelectedIndexChanged += CategoryBox_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Right;
            dataGridView.Location = new Point(141, 4);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(583, 606);
            dataGridView.TabIndex = 1;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchtextBox.Location = new Point(3, 75);
            SearchtextBox.Margin = new Padding(3, 4, 3, 4);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.PlaceholderText = "search";
            SearchtextBox.Size = new Size(132, 34);
            SearchtextBox.TabIndex = 2;
            SearchtextBox.TextChanged += SearchtextBox_TextChanged;
            // 
            // Categoryform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(735, 614);
            Controls.Add(SearchtextBox);
            Controls.Add(dataGridView);
            Controls.Add(CategoryBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Categoryform";
            Padding = new Padding(3, 4, 11, 4);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryBox;
        private DataGridView dataGridView;
        private TextBox SearchtextBox;
    }
}
