using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.UserControls
{
    public partial class ctrlManagePeople : UserControl
    {
        public ctrlManagePeople()
        {
            InitializeComponent();
        }

        public DataTable dtPeople { set { DGVPeople.DataSource = value; } }

    }
}
