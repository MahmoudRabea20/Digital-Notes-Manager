using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment4;
using Login;
using Login.Context;
using NoteEditor;
using FormsTimer = System.Windows.Forms.Timer;
using MyNote;
using Login.Model;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private FormsTimer timer;
        private MyContext NoteDbContext;
        Form1 NewForm;
        private string UserName;
        public MainForm(string username)
        {
            this.UserName = username;
            InitializeComponent();
            LoadNotes();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Username == UserName);
                int id = user.UserId;
                NewForm = new Form1(id);
                NewForm.NoteSaved += LoadNotes;
                NewForm.MdiParent = this;
                NewForm.Show();

            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form1 f)
            {
                f.content.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form1 f)
            {
                f.content.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form1 f)
            {
                f.content.Paste();
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Form1 f)
            {
                if (string.IsNullOrEmpty(f.content.ToString()))
                {
                    MessageBox.Show("write a word...", "format", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Form2 form2 = new Form2(f);
                    form2.ShowDialog();

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NoteDbContext = new MyContext();

            timer = new FormsTimer();
            timer.Interval = 60000;
            timer.Tick += CheckReminders;
            timer.Start();
        }

        private void CheckReminders(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            var note = NoteDbContext.Notes.Where(n => n.ReminderDate <= dateTime && n.ReminderDate > dateTime.AddMinutes(-1)).ToList();

            foreach (var item in note)
            {
                MessageBox.Show($" Reminder from your note: {item.Title}\n\n{item.Content}", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void notesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MyContext db = new MyContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Username == UserName);
                var userId = user.UserId;

                Categoryform cat = new Categoryform(userId);
                cat.MdiParent = this;
                cat.Show();
            }
        }

        private void LoadNotes()
        {
            FlowLayoutPanel.Controls.Clear();

            MyContext db = new MyContext();
            var user = db.Users.SingleOrDefault(u => u.Username == UserName);
            int id = user.UserId;

            var currentNotes = GetNotesByUserId(id);
            FlowLayoutPanel.Controls.Clear();

            foreach (var note in currentNotes)
            {
                NoteCard card = new NoteCard();
                card.SetNote(note);
                card.Width = 1000;
                card.NoteDeleted += LoadNotes;

                


                FlowLayoutPanel.Controls.Add(card);


            }
        }

        public static List<Note> GetNotesByUserId(int userId)
        {
            List<Note> myNotes = new List<Note>();

            MyContext db = new MyContext();

            myNotes = db.Notes.Where(n => n.UserID == userId).ToList();

            return myNotes;

        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NewForm == null || NewForm.IsDisposed)
            {
                MessageBox.Show("Please open a note form first.");
                return;
            }

            NewForm.filedialognote.Filter = "Rich Text File (.rtf)|.rtf|Plain Text File (.txt)|.txt";

            if (NewForm.filedialognote.ShowDialog() == DialogResult.OK)
            {
                string filePath = NewForm.filedialognote.FileName;
                string[] lines = File.ReadAllLines(filePath);

                string title = "";
                string content = "";
                string category = "";
                DateTime reminderDate = DateTime.Now;

                bool hasRecognizedFields = false;

                foreach (var line in lines)
                {
                    if (line.StartsWith("Title:", StringComparison.OrdinalIgnoreCase))
                    {
                        title = line.Substring(6).Trim();
                        hasRecognizedFields = true;
                    }
                    else if (line.StartsWith("Content:", StringComparison.OrdinalIgnoreCase))
                    {
                        content = line.Substring(8).Trim();
                        hasRecognizedFields = true;
                    }
                    else if (line.StartsWith("Category:", StringComparison.OrdinalIgnoreCase))
                    {
                        category = line.Substring(9).Trim();
                        hasRecognizedFields = true;
                    }
                    else if (line.StartsWith("ReminderDate:", StringComparison.OrdinalIgnoreCase))
                    {
                        if (DateTime.TryParse(line.Substring(13).Trim(), out DateTime date))
                        {
                            reminderDate = date;
                            hasRecognizedFields = true;
                        }
                    }
                }

                // If the file had structured fields
                if (hasRecognizedFields)
                {
                    NewForm.textbox.Text = title;
                    NewForm.richtextnote.Text = content;
                    NewForm.combo.Text = category;
                    NewForm.DateTimePicker.Value = reminderDate;
                }
                else
                {
                    // No structure found, treat the file as a plain note
                    if (Path.GetExtension(filePath).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                    {
                        NewForm.richtextnote.LoadFile(filePath);
                    }
                    else
                    {
                        NewForm.richtextnote.Text = File.ReadAllText(filePath);
                    }

                    // Clear other fields since they weren't in the file
                    NewForm.textbox.Text = "";
                    NewForm.combo.Text = "";
                    NewForm.DateTimePicker.Value = DateTime.Now;
                }
            }



            //if (NewForm == null || NewForm.IsDisposed)
            //{
            //    MessageBox.Show("Please open a note form first.");
            //    return;
            //}

            //NewForm.filedialognote.Filter = "Text Files (*.txt)|*.txt";

            //if (NewForm.filedialognote.ShowDialog() == DialogResult.OK)
            //{

            //    string filePath = NewForm.filedialognote.FileName;
            //    string[] lines = File.ReadAllLines(filePath);

            //    string title = "";
            //    string content = "";
            //    string category = "";
            //    DateTime reminderDate = DateTime.Now;

            //    foreach (var line in lines)
            //    {
            //        if (line.StartsWith("Title:", StringComparison.OrdinalIgnoreCase)) // Title:csharp
            //            title = line.Substring(6).Trim();
            //        else if (line.StartsWith("Content:", StringComparison.OrdinalIgnoreCase))
            //            content = line.Substring(8).Trim();
            //        else if (line.StartsWith("Category:"))
            //            category = line.Substring(9).Trim();
            //        else if (line.StartsWith("ReminderDate:"))
            //            reminderDate = DateTime.Parse(line.Substring(13).Trim());
            //    }

            //    NewForm.textbox.Text = title;
            //    NewForm.richtextnote.Text = content;
            //    NewForm.combo.Text = category;
            //    NewForm.DateTimePicker.Value = reminderDate;
            //}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (NewForm == null || NewForm.IsDisposed)
            {
                MessageBox.Show("Please open a note form first.");
                return;
            }

            NewForm.savefile.Filter = "Rich Text File (.rtf)|.rtf|Plain Text File (.txt)|.txt";

            var res = NewForm.savefile.ShowDialog();

            if (res == DialogResult.OK)
            {
                string filePath = NewForm.savefile.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                try
                {
                    if (extension == ".rtf")
                    {
                        // Save only the rich text content (no title, category, etc.)
                        NewForm.richtextnote.SaveFile(filePath);
                    }
                    else if (extension == ".txt")
                    {
                        // Save with metadata (structured format)
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine("Title: " + NewForm.textbox.Text);
                            writer.WriteLine("Content: " + NewForm.richtextnote.Text);
                            writer.WriteLine("Category: " + NewForm.combo.Text);
                            writer.WriteLine("ReminderDate: " + NewForm.DateTimePicker.Value.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unsupported file type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            //if (NewForm == null || NewForm.IsDisposed)
            //{
            //    MessageBox.Show("Please open a note form first.");
            //    return;
            //}

            //NewForm.savefile.Filter = "Text Files (*.txt)|*.txt";

            //var res = NewForm.savefile.ShowDialog();
            //if (res == DialogResult.OK)
            //{

            //    string path = NewForm.savefile.FileName;

            //    try
            //    {
            //        using (StreamWriter writer = new StreamWriter(path))
            //        {
            //            writer.WriteLine("Title: " + NewForm.textbox.Text);
            //            writer.WriteLine("Content:" + NewForm.richtextnote.Text);
            //            writer.WriteLine("Category: " + NewForm.combo.Text.ToString());
            //            writer.WriteLine("ReminderDate: " + NewForm.DateTimePicker.Value.ToString());
            //        }

            //        MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error saving note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }



            //}
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }






        //public void SubscribeToNoteCard(NoteCard noteCard)
        //{
        //    noteCard.NoteDeleted += () => LoadUserNotes(UserId);
        //}

        //private void LoadUserNotes(int userId)
        //{
        //    MyContext db = new MyContext();
        //    var notes = GetNotesByUserId(userId);
        //    //dataGridView.DataSource = notes;
        //}
    }
}
