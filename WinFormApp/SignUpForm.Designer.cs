namespace WinFormApp
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFirstName = new Label();
            labelLastName = new Label();
            labelUsername = new Label();
            LabelPassword = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(73, 58);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(70, 96);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(73, 138);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(73, 182);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Password";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(143, 55);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(195, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(143, 93);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(195, 23);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(143, 135);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(195, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 179);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(195, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(190, 228);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 23);
            SignUpButton.TabIndex = 8;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignUpButton);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(LabelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Name = "SignUpForm";
            Text = "User Signup";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelUsername;
        private Label LabelPassword;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button SignUpButton;
    }
}