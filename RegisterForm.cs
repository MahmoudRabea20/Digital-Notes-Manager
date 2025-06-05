using Login.Model;
using Login.Context;

namespace Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            RegisterUsernameLbl.ForeColor = Color.Red;
            RegisterUsernameLbl.Hide();
            RegisterPasswordLbl.ForeColor = Color.Red;
            RegisterPasswordLbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = RegisterUsernameTxt.Text.Trim();
            string password = RegisterPasswordTxt.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                RegisterUsernameLbl.Show();
            }
            else
            {
                RegisterUsernameLbl.Hide();
            }
            if (string.IsNullOrEmpty(password))
            {
                RegisterPasswordLbl.Show();
            }
            else
            {
                RegisterPasswordLbl.Hide();
            }
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MyContext context = new MyContext();

                var currentUsers = context.Users;

                foreach (var item in currentUsers)
                {
                    if (item.Username == username)
                    {
                        MessageBox.Show("The name is not available, enter different name", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                User user = new User() { Username = username, Password = password};

                context.Users.Add(user);

                context.SaveChanges();



                MessageBox.Show("Account has been created successfully!", "Success", MessageBoxButtons.OK);
                RegisterUsernameTxt.Text = "";
                RegisterPasswordTxt.Text = "";
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
            
        }


    }
}
