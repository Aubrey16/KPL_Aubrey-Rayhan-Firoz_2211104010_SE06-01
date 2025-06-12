using System;
using System.Windows.Forms;

namespace Modul15_2211104010_WindowsForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (UserService.Login(username, password))
            {
                MessageBox.Show("Login berhasil!");
                this.Close(); // atau buka form utama
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa username atau password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
