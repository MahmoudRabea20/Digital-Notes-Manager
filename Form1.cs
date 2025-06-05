using System.ComponentModel;
using System.Windows.Forms;
using Login;
using Login.Context;
//using NoteEditor.Context;
using Login.Model;
using Microsoft.EntityFrameworkCore;
using MyNote;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteEditor
{
    public partial class Form1 : Form
    {
        public delegate void NoteSavedEventHandler();
        public event NoteSavedEventHandler NoteSaved;
        private int currentUserId;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public int CurrentNoteId { set; get; }
        private AddCategory changeCategoryForm;

        public Form1(int userId)
        {
            InitializeComponent();



            MyContext db = new MyContext();

            currentUserId = userId;



            comboBoxCategory.DataSource = db.Categories.Where(c => c.CategoryName != "All Categories").Select(c => c.CategoryName).ToList();
        }

        public OpenFileDialog filedialognote
        {
            get { return openFileDialog1; }
        }
        public RichTextBox richtextnote
        {
            get { return content; }
        }
        public SaveFileDialog savefile
        {
            get { return saveFileDialog1; }
        }
        public System.Windows.Forms.TextBox textbox
        {
            get { return title; }
        }
        public System.Windows.Forms.ComboBox combo
        {
            get { return comboBoxCategory; }
        }

        public DateTimePicker DateTimePicker
        {
            get { return datePicker; }
        }


        public DateTime reminder
        {
            get { return datePicker.Value; }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Short;

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "hh:mm tt";
            TimePicker.ShowUpDown = true;
        }

        private void save_Click(object sender, EventArgs e)
        {

            var date = datePicker.Value.Date;
            var time = TimePicker.Value;

            using (MyContext db = new MyContext())
            {
                var res = db.Notes.SingleOrDefault(n => n.NoteId == CurrentNoteId);

                if (res == null)
                {
                    DateTime reminder = date.AddHours(time.Hour).AddMinutes(time.Minute);

                    if (reminder <= DateTime.Now)
                    {

                        MessageBox.Show("The selected date and time must be in the future.", "Invalid Date || Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Note note = new Note()
                    {

                        UserID = currentUserId,
                        Title = title.Text,
                        Category = comboBoxCategory.SelectedItem.ToString(),
                        ReminderDate = reminder,
                        Content = content.Text,
                    };


                    db.Notes.Add(note);
                    db.SaveChanges();


                    NoteSaved?.Invoke();
                    if (this.Parent != null)
                    {
                        this.Parent.Invoke((MethodInvoker)(() => this.Parent.Controls.Remove(this)));
                    }

                    MessageBox.Show("Note saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {

                    res.Title = title.Text;
                    res.Content = content.Text;
                    res.Category = comboBoxCategory.SelectedItem.ToString();
                    res.ReminderDate = reminder;
                    res.UserID = currentUserId;

                    db.SaveChanges();


                    NoteSaved?.Invoke();
                    if (this.Parent != null)
                    {
                        this.Parent.Invoke((MethodInvoker)(() => this.Parent.Controls.Remove(this)));
                    }

                    MessageBox.Show("Note Edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }


            }
        }

        private void AddNewTextbtn_Click(object sender, EventArgs e)
        {
            AddTextForm addTextForm = new AddTextForm();

            var result = addTextForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                content.AppendText(addTextForm.NewText);
            }
        }
        public void LoadNoteFromText(string title1, string content1, string category1, DateTime reminderDate1)
        {
            title.Text = title1 ?? "";
            content.Text = content1 ?? "";

            comboBoxCategory.SelectedItem = category1;

            datePicker.Value = reminderDate1;
        }

        





        private void Newcategory_Click(object sender, EventArgs e)
        {
            if (changeCategoryForm == null || changeCategoryForm.IsDisposed)
            {
                changeCategoryForm = new AddCategory();


                changeCategoryForm.CategoryUpdated += Combobox_Update;

                changeCategoryForm.Show();
            }
        }
        private void Combobox_Update(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                comboBoxCategory.DataSource = null;

                string n = "All Categories";
                var list = context.Categories.Where(c => c.CategoryName != n).Select(c => c.CategoryName).ToList();

                comboBoxCategory.DataSource = list.ToList();
            }
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
