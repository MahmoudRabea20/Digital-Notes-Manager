namespace NoteEditor
{
    partial class AddTextForm
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
            textBox1 = new TextBox();
            OK = new Button();
            Cancle = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(700, 27);
            textBox1.TabIndex = 0;
            // 
            // OK
            // 
            OK.BackColor = SystemColors.Highlight;
            OK.DialogResult = DialogResult.OK;
            OK.ForeColor = SystemColors.HighlightText;
            OK.Location = new Point(475, 87);
            OK.Name = "OK";
            OK.Size = new Size(101, 39);
            OK.TabIndex = 1;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = false;
            // 
            // Cancle
            // 
            Cancle.BackColor = SystemColors.Highlight;
            Cancle.DialogResult = DialogResult.Cancel;
            Cancle.ForeColor = SystemColors.HighlightText;
            Cancle.Location = new Point(625, 87);
            Cancle.Name = "Cancle";
            Cancle.Size = new Size(101, 39);
            Cancle.TabIndex = 2;
            Cancle.Text = "Cancle";
            Cancle.UseVisualStyleBackColor = false;
            // 
            // AddTextForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(779, 150);
            Controls.Add(Cancle);
            Controls.Add(OK);
            Controls.Add(textBox1);
            Name = "AddTextForm";
            Text = "AddTextForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button OK;
        private Button Cancle;
    }
}