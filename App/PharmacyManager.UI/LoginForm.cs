using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Business.Services.Realization;
using PharmacyManager.Shared.Entities;
using System;
using System.Windows.Forms;

namespace PharmacyManager.UI
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService = new UserService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User currentUser = null;

            if (this.IsRegister.Checked)
            {
                _userService.Save(new User
                {
                    Login = this.loginBox.Text,
                    Password = this.passwordBox.Text,
                    Role = Shared.Enums.RoleType.User
                });
            }

            currentUser = _userService.GetByCredentials(this.loginBox.Text, this.passwordBox.Text);
            if (currentUser != null)
            {
                this.Hide();
                var mainMenu = new MainController(currentUser);
                mainMenu.Show();
            }
        }
    }
}
