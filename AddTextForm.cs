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
    public partial class AddTextForm : Form
    {
        public AddTextForm()
        {
            InitializeComponent();
        }

        public string NewText
        {
            get
            {
                return textBox1.Text;
            }
        }
    }


}
