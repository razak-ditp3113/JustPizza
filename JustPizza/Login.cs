using System;
using System.Windows.Forms;

namespace JustPizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "pizza")
                {
                    MessageBox.Show("Login successful");
                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
