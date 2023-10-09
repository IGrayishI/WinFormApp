namespace WinFormApp
{
    public partial class SignUpForm : Form
    {
        List<User> users = new List<User>();
        User user = new User("firstName", "lastname", "username", "password");

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            User user = new User(textBoxFirstName.Text, textBoxLastName.Text, textBoxUsername.Text, textBoxPassword.Text);
            users.Add(user);
            this.Close();
        }

        public bool VerifyPassword(string usernameInput, string passwordInput)
        {

            foreach (User user in users)
            {
                if (user.Username == usernameInput && user.Password == passwordInput)
                {
                    return true;
                }
            } 
            return false;
        }

        
    }
}