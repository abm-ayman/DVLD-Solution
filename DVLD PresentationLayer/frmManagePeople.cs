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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlManagePeople1_Load(object sender, EventArgs e)
        {
            ctrlManagePeople1.dtPeople = BusinessLayer.clsUser.GetPeople();
        }

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.ctrlManagePeople2 = new DVLD_PresentationLayer.UserControls.ctrlManagePeople();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cuiPanel1);
            this.kryptonPanel1.Controls.Add(this.ctrlManagePeople2);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.kryptonPanel1.Size = new System.Drawing.Size(1086, 506);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.cuiPictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 63);
            this.panel1.TabIndex = 0;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_PresentationLayer.Properties.Resources.team;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox2.Location = new System.Drawing.Point(582, 4);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(64, 56);
            this.cuiPictureBox2.TabIndex = 1;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(323, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(253, 46);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "Manage People";
            // 
            // ctrlManagePeople2
            // 
            this.ctrlManagePeople2.BackColor = System.Drawing.Color.Transparent;
            this.ctrlManagePeople2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlManagePeople2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlManagePeople2.Location = new System.Drawing.Point(0, 63);
            this.ctrlManagePeople2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlManagePeople2.Name = "ctrlManagePeople2";
            this.ctrlManagePeople2.Size = new System.Drawing.Size(1086, 443);
            this.ctrlManagePeople2.TabIndex = 1;
            // 
            // cuiButton1
            // 
            this.cuiButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.DimGray;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(996, 3);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.Padding = new System.Windows.Forms.Padding(12);
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(78, 33);
            this.cuiButton1.TabIndex = 2;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextPadding = 12;
            this.cuiButton1.TextSpacing = 2;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.cuiButton1);
            this.cuiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel1.Location = new System.Drawing.Point(0, 466);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(1086, 40);
            this.cuiPanel1.TabIndex = 3;
            // 
            // frmManagePeople
            // 
            this.ClientSize = new System.Drawing.Size(1086, 506);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }
}
