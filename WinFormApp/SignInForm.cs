using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class SignInForm : Form
    {
        User user;
        SignUpForm signupwindow = new SignUpForm();

        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            if (signupwindow.VerifyPassword(textBoxUsername.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Welcome");
            } else
            {
                MessageBox.Show("Wrong login");
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            signupwindow.Show();
        }
    }
}
