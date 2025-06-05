using Login.Context;
using Microsoft.Identity.Client;
using Login.Context;
using NoteEditor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteEditor
{
    public partial class CategorySelector : UserControl
    {

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string newCategory
        {
            get { return comboBox.Text; }
            set { comboBox.Text = value; }
        }

        private ComboBox comboBox;

        
        public event EventHandler CategoryChanged;
        public CategorySelector()
        {
            InitializeComponent();

            comboBox = new ComboBox();
            comboBox.Dock = DockStyle.Fill;
            comboBox.DropDownStyle = ComboBoxStyle.DropDown;

            this.Controls.Add(comboBox);
            this.Size = new Size(200, 30);

         
           
                    refreshCategories();
               
            
        }



        public void refreshCategories()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            using (var context = new MyContext())
            {
                var categories = context.Categories.Select(c => c.CategoryName).ToList();

                comboBox.DataSource = null;
                comboBox.DataSource = categories;
            }

            CategoryChanged?.Invoke(this, EventArgs.Empty);


        }








    }
}
