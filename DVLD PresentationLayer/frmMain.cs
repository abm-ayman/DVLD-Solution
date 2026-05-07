using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;




namespace DVLD_PresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain(clsUser user)
        {
            InitializeComponent();


            this.user = user;
        }

        clsUser user;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"LoggedIn user: {user.UserName}");
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople frmManagePeople = new frmManagePeople();
            frmManagePeople.ShowDialog();
        }
    }
}
