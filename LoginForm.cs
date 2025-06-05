using System.ComponentModel;
using Login.Context;
using NoteEditor.Models;
using WindowsFormsApp1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
           
            InitializeComponent();
            LoginUsernameLbl.ForeColor = Color.Red;
            LoginUsernameLbl.Hide();
            LoginPasswordLbl.ForeColor = Color.Red;
            LoginPasswordLbl.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTxt.Text.Trim();
            string password = LoginPasswordTxt.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                LoginUsernameLbl.Show();
            }
            else
            {
                LoginUsernameLbl.Hide();
            }
            if (string.IsNullOrEmpty(password))
            {
                LoginPasswordLbl.Show();
            }
            else
            {
                LoginPasswordLbl.Hide();
            }
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MyContext context = new MyContext();

                var currentUsers = context.Users;

                var searchResult = currentUsers.SingleOrDefault(u => u.Username == username && u.Password == password);

                if (searchResult == null)
                {
                    MessageBox.Show("Invalid username or password", "Wrong User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginUsernameTxt.Text = "";
                    LoginPasswordTxt.Text = "";
                    return;
                }
                //LoginUser = username;
                //LoginUsernameTxt.Text = "";
                //LoginPasswordTxt.Text = "";
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm menuStrip = new MainForm(username);
                this.Hide();
                menuStrip.ShowDialog();
            }
        }


    }

}
