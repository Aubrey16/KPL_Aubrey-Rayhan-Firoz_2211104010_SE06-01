using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modul15_2211104010_WindowsForm
{
    public partial class RegisterForm : Form
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();

            SuspendLayout();

            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.Text = "Username";

            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.Text = "Password";

            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);

            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(120, 130);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.Text = "Register";
            btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "Register User";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (UserService.Register(username, password, out string message))
            {
                MessageBox.Show("Registrasi berhasil!");
                this.Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
