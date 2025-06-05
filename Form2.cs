using NoteEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;


namespace assignment4
{
    public partial class Form2 : Form
    {
        Form1 NoteForm;
        List<string> fontfamily = new List<string>() { "Arial", "Helvetica", "Verdana", "Calibri" };
        public Form2(Form1 form1)
        {
            InitializeComponent();
            comboBox1.DataSource = fontfamily;
            NoteForm = form1;
        }

     
        string color2;
        FontStyle fonttype2;
        string fontfam;
        int size;
        FontStyle style;
        
        private void okbtn_Click(object sender, EventArgs e)
        {
         

            if (color2 == "Red")
                NoteForm.content.ForeColor = Color.Red;
            else if (color2 == "Green")
                NoteForm.content.ForeColor = Color.Green;
            else if (color2 == "Blue")
                NoteForm.content.ForeColor = Color.Blue;
            else
                NoteForm.content.ForeColor = Color.Black; 

            



            NoteForm.content.Font = null;
            NoteForm.content.Font = new Font(fontfam, size, style);
            this.Close();

        }
        private void fontcolor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                color2 = radioButton.Text;

            }
        }

        private void fonttype_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CheckBoxx = sender as CheckBox;
            if (CheckBoxx.Checked )
            {
                fonttype2 |= (FontStyle)int.Parse(CheckBoxx.Tag.ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 0)
            {
                size = int.Parse(textBox1.Text);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontfam = comboBox1.SelectedItem.ToString();
            
        }
        

    }
}
