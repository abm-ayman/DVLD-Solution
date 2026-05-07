using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

           
        }


        private void ctrlUserLogin1_OnLoginButtonClick()
        {
            if (!string.IsNullOrWhiteSpace(ctrlUserLogin1.Username) && !string.IsNullOrWhiteSpace(ctrlUserLogin1.Password))
            {

                clsUser user = BusinessLayer.clsUser.FindUser(ctrlUserLogin1.Username, ctrlUserLogin1.Password);

                if (user != null)
                {

                    frmMain frmMain = new frmMain(user);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    ctrlUserLogin1.ShowWrongUsernameOrPassWordError("Wrong username or password");
                    ctrlUserLogin1.Password = string.Empty;
                }

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ctrlUserLogin1.Username = "user4";
            ctrlUserLogin1.Password = "1234";
        }
    }
}
