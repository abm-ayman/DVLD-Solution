using CuoreUI.Controls;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_PresentationLayer.UserControls
{
    public partial class ctrlUserLogin : UserControl
    {
        public ctrlUserLogin()
        {
            InitializeComponent();
        }

        public event Action OnLoginButtonClick;

        protected virtual void LoginButtonClick(object sender, EventArgs e)
        {
            OnLoginButtonClick?.Invoke();
        }


        public string Username { get { return txtUsername.Text; } set { txtUsername.Text = value; } }

        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }

        public bool RememberMe { get { return chbRememberMe.Checked; } }

        public bool AllowEmptyText { get; set; } = true;

        public bool ValidateInput(cuiTextBox textBox)
        {
            if (!AllowEmptyText && string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "This field cannot be empty");
                return false;
            }

            errorProvider1.SetError(textBox, "");
            return true;
        }

        public void ShowWrongUsernameOrPassWordError(string errorMessage)
        {
            errorProvider1.SetError(txtPassword, errorMessage);
            errorProvider1.SetError(txtUsername, errorMessage);
        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            ValidateInput(sender as cuiTextBox);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (OnLoginButtonClick != null)
                LoginButtonClick(sender, e);
        }
    }
}
