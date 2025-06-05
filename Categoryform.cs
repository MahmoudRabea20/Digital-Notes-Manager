using Login.Context;

namespace MyNote
{
    public partial class Categoryform : Form
    {
        MyContext db = new MyContext();
        private int userId;

        public Categoryform(int userId)
        {

            InitializeComponent();
            this.userId = userId;
            var list = db.Categories.Select(e => e.CategoryName).Distinct();
            CategoryBox.DataSource = list.ToList();
            CategoryBox.SelectedItem = "All Categories";


        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CategoryBox.SelectedItem.ToString() == "All Categories")
            {
                dataGridView.DataSource = db.Notes.Where(n=>n.UserID == userId).ToList();
            }
            else
            {
                var list = db.Notes.Where(e => e.Category == CategoryBox.Text && e.UserID == userId).ToList();
                dataGridView.DataSource = list;

            }

        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            var filter = db.Notes.ToList().Where(n => n.Content.Contains(SearchtextBox.Text.ToString(), StringComparison.OrdinalIgnoreCase) || n.Category.Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase) || n.CreationDate.ToString().Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase) || n.NoteId.ToString().Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase) || n.Title.Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase) || n.ReminderDate.ToString().Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase) || n.UserID.ToString().Contains(SearchtextBox.Text, StringComparison.OrdinalIgnoreCase));
            dataGridView.DataSource = filter.Where(n => n.UserID == userId).ToList();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (var note in db.Notes.ToList())
            {
                if ((e.RowIndex + 1031) == note.NoteId)
                {
                    viewNote viewForm = new();
                    viewForm.Title = note.Title;
                    viewForm.Category = note.Category;
                    viewForm.Date = note.ReminderDate.ToString();
                    viewForm.Content = note.Content;
                    viewForm.Show();
                }
            }
        }
    }
}
