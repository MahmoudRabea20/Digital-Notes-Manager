namespace assignment4
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            format = new GroupBox();
            underlinebtn = new CheckBox();
            italicbtn = new CheckBox();
            boldbox = new CheckBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            color = new GroupBox();
            Blue = new RadioButton();
            green = new RadioButton();
            red = new RadioButton();
            okbtn = new Button();
            format.SuspendLayout();
            color.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 127);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 0;
            label2.Text = "Size";
            // 
            // format
            // 
            format.Controls.Add(underlinebtn);
            format.Controls.Add(italicbtn);
            format.Controls.Add(boldbox);
            format.Location = new Point(67, 187);
            format.Margin = new Padding(3, 4, 3, 4);
            format.Name = "format";
            format.Padding = new Padding(3, 4, 3, 4);
            format.Size = new Size(266, 64);
            format.TabIndex = 1;
            format.TabStop = false;
            format.Text = "Format";
            // 
            // underlinebtn
            // 
            underlinebtn.AutoSize = true;
            underlinebtn.Location = new Point(161, 28);
            underlinebtn.Margin = new Padding(3, 4, 3, 4);
            underlinebtn.Name = "underlinebtn";
            underlinebtn.Size = new Size(98, 24);
            underlinebtn.TabIndex = 2;
            underlinebtn.Tag = "4";
            underlinebtn.Text = "UnderLine";
            underlinebtn.UseVisualStyleBackColor = true;
            underlinebtn.CheckedChanged += fonttype_CheckedChanged;
            // 
            // italicbtn
            // 
            italicbtn.AutoSize = true;
            italicbtn.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            italicbtn.Location = new Point(90, 28);
            italicbtn.Margin = new Padding(3, 4, 3, 4);
            italicbtn.Name = "italicbtn";
            italicbtn.Size = new Size(63, 24);
            italicbtn.TabIndex = 1;
            italicbtn.Tag = "2";
            italicbtn.Text = "Italic";
            italicbtn.UseVisualStyleBackColor = true;
            italicbtn.CheckedChanged += fonttype_CheckedChanged;
            // 
            // boldbox
            // 
            boldbox.AutoSize = true;
            boldbox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boldbox.Location = new Point(14, 28);
            boldbox.Margin = new Padding(3, 4, 3, 4);
            boldbox.Name = "boldbox";
            boldbox.Size = new Size(63, 24);
            boldbox.TabIndex = 0;
            boldbox.Tag = "1";
            boldbox.Text = "Bold";
            boldbox.UseVisualStyleBackColor = true;
            boldbox.CheckedChanged += fonttype_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 41);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 127);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // color
            // 
            color.Controls.Add(Blue);
            color.Controls.Add(green);
            color.Controls.Add(red);
            color.Location = new Point(234, 52);
            color.Margin = new Padding(3, 4, 3, 4);
            color.Name = "color";
            color.Padding = new Padding(3, 4, 3, 4);
            color.Size = new Size(99, 127);
            color.TabIndex = 4;
            color.TabStop = false;
            color.Text = "Color";
            // 
            // Blue
            // 
            Blue.AutoSize = true;
            Blue.ForeColor = Color.FromArgb(0, 0, 192);
            Blue.Location = new Point(19, 100);
            Blue.Margin = new Padding(3, 4, 3, 4);
            Blue.Name = "Blue";
            Blue.Size = new Size(59, 24);
            Blue.TabIndex = 2;
            Blue.TabStop = true;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = true;
            Blue.CheckedChanged += fontcolor_CheckedChanged;
            // 
            // green
            // 
            green.AutoSize = true;
            green.ForeColor = Color.FromArgb(0, 192, 0);
            green.Location = new Point(19, 67);
            green.Margin = new Padding(3, 4, 3, 4);
            green.Name = "green";
            green.Size = new Size(69, 24);
            green.TabIndex = 1;
            green.TabStop = true;
            green.Text = "Green";
            green.UseVisualStyleBackColor = true;
            green.CheckedChanged += fontcolor_CheckedChanged;
            // 
            // red
            // 
            red.AutoSize = true;
            red.ForeColor = Color.Red;
            red.Location = new Point(19, 33);
            red.Margin = new Padding(3, 4, 3, 4);
            red.Name = "red";
            red.Size = new Size(56, 24);
            red.TabIndex = 0;
            red.TabStop = true;
            red.Text = "Red";
            red.UseVisualStyleBackColor = true;
            red.CheckedChanged += fontcolor_CheckedChanged;
            // 
            // okbtn
            // 
            okbtn.BackColor = SystemColors.Highlight;
            okbtn.ForeColor = SystemColors.HighlightText;
            okbtn.Location = new Point(62, 259);
            okbtn.Margin = new Padding(3, 4, 3, 4);
            okbtn.Name = "okbtn";
            okbtn.Size = new Size(272, 44);
            okbtn.TabIndex = 5;
            okbtn.Text = "OK";
            okbtn.UseVisualStyleBackColor = false;
            okbtn.Click += okbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(379, 311);
            Controls.Add(okbtn);
            Controls.Add(color);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(format);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Dialog";
            format.ResumeLayout(false);
            format.PerformLayout();
            color.ResumeLayout(false);
            color.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox format;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox color;
        private RadioButton Blue;
        private RadioButton green;
        private RadioButton red;
        private CheckBox underlinebtn;
        private CheckBox italicbtn;
        private CheckBox boldbox;
        private Button okbtn;
    }
}