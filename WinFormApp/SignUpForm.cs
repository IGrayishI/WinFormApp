namespace WinFormApp
{
    public partial class SignUpForm : Form
    {
        List<User> users = new List<User>();
        //User user = new User("firstName", "lastname", "username", "password");

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if ( textBoxFirstName != null && textBoxLastName != null && textBoxPassword != null && textBoxUsername != null )
            {
            User user = new User(textBoxFirstName.Text, textBoxLastName.Text, textBoxUsername.Text, textBoxPassword.Text);
            users.Add(user);
            this.Close();
            }
            else
            {
                MessageBox.Show("Please input in all boxes");
            }
        }

        public User VerifyPassword(string usernameInput, string passwordInput)
        {
            User emptyUser = new User();
            foreach (User user in users)
            {
                if (user.Username == usernameInput && user.Password == passwordInput)
                {
                    return user;
                }
            }
            return emptyUser;
        }
    }
}