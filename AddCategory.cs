using Login.Context;
using MyNote;
using NoteEditor.Models;

//using NoteEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AddCategory : Form
    {
        public event EventHandler CategoryUpdated;
        public AddCategory()
        {
            InitializeComponent();
            categorySelector1.CategoryChanged += CategorySelector1_CategoryChanged;
        }

        public void CategorySelector1_CategoryChanged(object sender, EventArgs e)
        {
            CategoryUpdated?.Invoke(this, EventArgs.Empty);
        }

       

        private void AddCategorybtn_Click(object sender, EventArgs e)
        {
            string newCategory = categorySelector1.newCategory;

            using (var myContext = new MyContext())
            {
                if (newCategory is not null && !myContext.Categories.Any(c => c.CategoryName == newCategory))
                {

                    Category newcategory = new Category
                    {
                        CategoryName = newCategory,
                    };
                    myContext.Categories.Add(newcategory);
                    myContext.SaveChanges();
                }
            }


            CategoryUpdated?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Category Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
