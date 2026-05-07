namespace DVLD_PresentationLayer
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.ctrlUserLogin1 = new DVLD_PresentationLayer.UserControls.ctrlUserLogin();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(227, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(248, 46);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Welcome back ";
            // 
            // ctrlUserLogin1
            // 
            this.ctrlUserLogin1.AllowEmptyText = false;
            this.ctrlUserLogin1.Location = new System.Drawing.Point(104, 70);
            this.ctrlUserLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlUserLogin1.Name = "ctrlUserLogin1";
            this.ctrlUserLogin1.Password = "";
            this.ctrlUserLogin1.Size = new System.Drawing.Size(450, 234);
            this.ctrlUserLogin1.TabIndex = 0;
            this.ctrlUserLogin1.Username = "";
            this.ctrlUserLogin1.OnLoginButtonClick += new System.Action(this.ctrlUserLogin1_OnLoginButtonClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 333);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.ctrlUserLogin1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ctrlUserLogin ctrlUserLogin1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}