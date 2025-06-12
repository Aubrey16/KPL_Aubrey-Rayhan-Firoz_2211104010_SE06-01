private void btnRegister_Click(object sender, EventArgs e)
{
    string username = txtUsername.Text;
    string password = txtPassword.Text;

    if (UserService.Register(username, password, out string message))
    {
        MessageBox.Show("Registrasi berhasil!");
        this.Close(); // Kembali ke login
    }
    else
    {
        MessageBox.Show(message);
    }
}
