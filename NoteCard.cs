using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Context;
using Login.Model;
using Microsoft.Data.SqlClient;
using NoteEditor;

namespace Login
{
    public partial class NoteCard : UserControl
    {
        private Note note;
        public delegate void NoteDeletedEventHandler();
        public event NoteDeletedEventHandler NoteDeleted;

        public NoteCard()
        {
            InitializeComponent();
        }

        public void SetNote(Note note)
        {

            this.note = note;
            TitleLabel.Text = note?.Title ?? "No Title";
            ConLabel.Text = note?.Content ?? "No Content";
            CatLabel.Text = note?.Category ?? "General";
            CrDateLabel.Text = note?.CreationDate.ToShortDateString() ?? DateTime.Now.ToShortDateString();
            ReDateLabel.Text = note?.ReminderDate.ToShortDateString() ?? DateTime.Now.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (note == null)
            {
                MessageBox.Show("Invalid note selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DeleteNote(note.NoteId);
                NoteDeleted?.Invoke();
                if (this.Parent != null)
                {
                    this.Parent.Invoke((MethodInvoker)(() => this.Parent.Controls.Remove(this)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void DoneButton_Click(object sender, EventArgs e)
        //{
        //    if (note != null && note.NoteID > 0)
        //    {
        //        this.BackColor = Color.LightGreen;
        //    }
        //}

        private void EditButton_Click(object sender, EventArgs e)
        {
            //MyContext db = new MyContext();
            //Form1 editForm = new Form1(note.UserID);

            //MessageBox.Show(note.NoteId.ToString());

            if (note == null)
            {
                MessageBox.Show("Invalid note selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Form1 editForm = new Form1(note.UserID);

                editForm.CurrentNoteId = note.NoteId;   


                editForm.LoadNoteFromText(note.Title, note.Content, note.Category, note.ReminderDate);
                editForm.NoteSaved += () =>
                {
                    try
                    {
                        MyContext db = new MyContext();
                        var updatedNote = db.Notes.SingleOrDefault(n => n.NoteId == note.NoteId);
                        if (updatedNote != null)
                        {
                            SetNote(updatedNote);
                        }
                        else
                        {
                            MessageBox.Show("Failed to refresh note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error refreshing note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                editForm.MdiParent = this.FindForm()?.MdiParent;
                editForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteNote(int noteId)
        {
            MyContext db = new MyContext();
            
            var note = db.Notes.FirstOrDefault(x => x.NoteId == noteId);

            db.Notes.Remove(note);
            db.SaveChanges();
            
            }
        }
}

