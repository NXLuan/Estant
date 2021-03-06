using Estant.Material.Utilities;
using Estant.View.Extensions;
using Estant.View.FormUI.PopupUI;
using EstantNF.Core.Handlers;
using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.AuthUI
{
    public partial class AuthForm : Form
    {
        public static AuthForm Instance
        {
            get => Singleton<AuthForm>.Instance;
        }
        public AuthForm()
        {
            InitializeComponent();
        }

        private void lbCreateAccount_Click(object sender, EventArgs e)
        {
            tabForm.SelectedIndex = (int)AuthPageForm.SIGNUP;
        }

        private void pbBackFromSignUp_Click(object sender, EventArgs e)
        {
            tabForm.SelectedIndex = (int)AuthPageForm.SIGNIN;
        }

        private void pbBackFromReset_Click(object sender, EventArgs e)
        {
            tabForm.SelectedIndex = (int)AuthPageForm.SIGNIN;
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            tabForm.SelectedIndex = (int)AuthPageForm.FORGOTPASSWORD;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInHandle();
        }

        public async void SignInHandle()
        {
            Loading.ShowPopup();
            var response = await AuthHandler.SignIn(tbEmail.TextInput, tbPassword.TextInput);
            Loading.EndPopup();

            if (response.IsSuccess())
            {
                Store.CurrentUser = response.data;
                MainForm.Instance.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(response.message, "Notification");
            }
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpHandle();
        }

        public async void SignUpHandle()
        {
            Loading.ShowPopup();
            var response = await AuthHandler.SignUp(tbName.TextInput, tbEmailSignUp.TextInput, tbPasswordSignUp.TextInput, tbConfirmPassword.TextInput);
            Loading.EndPopup();

            MessageBox.Show(response.message, "Notification");
            if (response.IsSuccess())
            {
                tabForm.SelectedIndex = (int)AuthPageForm.SIGNIN;
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordHandle();
        }

        public async void ResetPasswordHandle()
        {
            Loading.ShowPopup();
            var response = await AuthHandler.ResetPassword(tbEmailReset.TextInput);
            Loading.EndPopup();

            MessageBox.Show(response.message, "Notification");
            if (response.IsSuccess())
            {
                tabForm.SelectedIndex = (int)AuthPageForm.SIGNIN;
            }
        }
    }
}
