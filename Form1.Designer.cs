namespace NoteEditor
{
    partial class Form1
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
            panel1 = new Panel();
            Newcategory = new Button();
            comboBoxCategory = new ComboBox();
            TimePicker = new DateTimePicker();
            Reminder = new Label();
            datePicker = new DateTimePicker();
            title = new TextBox();
            titleLable = new Label();
            Category = new Label();
            content = new RichTextBox();
            savebtn = new Button();
            cancelbtn = new Button();
            AddNewTextbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Newcategory);
            panel1.Controls.Add(comboBoxCategory);
            panel1.Controls.Add(TimePicker);
            panel1.Controls.Add(Reminder);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(title);
            panel1.Controls.Add(titleLable);
            panel1.Controls.Add(Category);
            panel1.Location = new Point(21, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 143);
            panel1.TabIndex = 0;
            // 
            // Newcategory
            // 
            Newcategory.BackColor = SystemColors.Highlight;
            Newcategory.ForeColor = SystemColors.HighlightText;
            Newcategory.Location = new Point(531, 46);
            Newcategory.Name = "Newcategory";
            Newcategory.Size = new Size(155, 42);
            Newcategory.TabIndex = 13;
            Newcategory.Text = "Add New Category";
            Newcategory.UseVisualStyleBackColor = false;
            Newcategory.Click += Newcategory_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(135, 54);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(390, 28);
            comboBoxCategory.TabIndex = 12;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // TimePicker
            // 
            TimePicker.CustomFormat = "hh:mm tt";
            TimePicker.Location = new Point(538, 99);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(145, 27);
            TimePicker.TabIndex = 11;
            // 
            // Reminder
            // 
            Reminder.AutoSize = true;
            Reminder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Reminder.ForeColor = SystemColors.Desktop;
            Reminder.Location = new Point(21, 99);
            Reminder.Name = "Reminder";
            Reminder.Size = new Size(98, 25);
            Reminder.TabIndex = 10;
            Reminder.Text = "Reminder";
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy ";
            datePicker.Location = new Point(135, 97);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(390, 27);
            datePicker.TabIndex = 6;
            // 
            // title
            // 
            title.BorderStyle = BorderStyle.None;
            title.Location = new Point(135, 23);
            title.Name = "title";
            title.Size = new Size(390, 20);
            title.TabIndex = 5;
            // 
            // titleLable
            // 
            titleLable.AutoSize = true;
            titleLable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            titleLable.ForeColor = SystemColors.Desktop;
            titleLable.Location = new Point(21, 18);
            titleLable.Name = "titleLable";
            titleLable.Size = new Size(50, 25);
            titleLable.TabIndex = 4;
            titleLable.Text = "Title";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category.ForeColor = SystemColors.Desktop;
            Category.Location = new Point(19, 57);
            Category.Name = "Category";
            Category.Size = new Size(90, 25);
            Category.TabIndex = 0;
            Category.Text = "Category";
            // 
            // content
            // 
            content.Location = new Point(21, 162);
            content.Name = "content";
            content.Size = new Size(686, 293);
            content.TabIndex = 6;
            content.Text = "";
            // 
            // savebtn
            // 
            savebtn.BackColor = SystemColors.Highlight;
            savebtn.ForeColor = SystemColors.HighlightText;
            savebtn.Location = new Point(300, 474);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(122, 44);
            savebtn.TabIndex = 7;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += save_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = SystemColors.Highlight;
            cancelbtn.DialogResult = DialogResult.Cancel;
            cancelbtn.ForeColor = SystemColors.HighlightText;
            cancelbtn.Location = new Point(576, 474);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(120, 44);
            cancelbtn.TabIndex = 8;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += canclebtn_Click;
            // 
            // AddNewTextbtn
            // 
            AddNewTextbtn.BackColor = SystemColors.Highlight;
            AddNewTextbtn.ForeColor = SystemColors.HighlightText;
            AddNewTextbtn.Location = new Point(42, 474);
            AddNewTextbtn.Name = "AddNewTextbtn";
            AddNewTextbtn.Size = new Size(120, 44);
            AddNewTextbtn.TabIndex = 9;
            AddNewTextbtn.Text = "Add New Text";
            AddNewTextbtn.UseVisualStyleBackColor = false;
            AddNewTextbtn.Click += AddNewTextbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(737, 612);
            Controls.Add(AddNewTextbtn);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(content);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Category;
        //private Label reminder;
        private TextBox title;
        private Label titleLable;
        public RichTextBox content;
        private Button savebtn;
        private DateTimePicker datePicker;
        private Button cancelbtn;
        private Label Reminder;
        private DateTimePicker TimePicker;
        private Button AddNewTextbtn;
        private ComboBox comboBoxCategory;
        private Button Newcategory;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
