using Estant.Material.Utilities;
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
    public partial class ProfileForm : Form
    {
        public static ProfileForm Instance
        {
            get => Singleton<ProfileForm>.Instance;
        }
        public ProfileForm()
        {
            InitializeComponent();
        }

        public void UpdateInfoUser()
        {
            var currentUser = Store.CurrentUser;
            if (currentUser != null)
            {
                pbAvatar.LoadAsync(currentUser.photoUrl);
                lbDisplayName.Text = currentUser.displayName;
                lbEmail.Text = currentUser.email;
            }
        }
    }
}
