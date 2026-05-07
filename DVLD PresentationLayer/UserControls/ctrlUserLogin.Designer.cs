namespace DVLD_PresentationLayer.UserControls
{
    partial class ctrlUserLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chbRememberMe = new CuoreUI.Controls.cuiCheckbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.txtPassword = new CuoreUI.Controls.cuiTextBox();
            this.txtUsername = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.Checked = false;
            this.chbRememberMe.CheckedForeground = System.Drawing.Color.Black;
            this.chbRememberMe.CheckedOutlineColor = System.Drawing.Color.White;
            this.chbRememberMe.CheckedSymbolColor = System.Drawing.Color.White;
            this.chbRememberMe.Content = "Remember Me";
            this.chbRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbRememberMe.ForeColor = System.Drawing.Color.Black;
            this.chbRememberMe.Location = new System.Drawing.Point(4, 78);
            this.chbRememberMe.MinimumSize = new System.Drawing.Size(16, 16);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.OutlineThickness = 1F;
            this.chbRememberMe.Rounding = 4;
            this.chbRememberMe.ShowSymbols = true;
            this.chbRememberMe.Size = new System.Drawing.Size(90, 16);
            this.chbRememberMe.TabIndex = 5;
            this.chbRememberMe.UncheckedForeground = System.Drawing.Color.Empty;
            this.chbRememberMe.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chbRememberMe.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.Content = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnLogin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.Image = global::DVLD_PresentationLayer.Properties.Resources.Login_Arrow;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.Location = new System.Drawing.Point(117, 101);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.White;
            this.btnLogin.NormalForeColor = System.Drawing.Color.Black;
            this.btnLogin.NormalImageTint = System.Drawing.Color.Black;
            this.btnLogin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.OutlineThickness = 1F;
            this.btnLogin.Padding = new System.Windows.Forms.Padding(12);
            this.btnLogin.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogin.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(8);
            this.btnLogin.Size = new System.Drawing.Size(153, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.TextPadding = 12;
            this.btnLogin.TextSpacing = 2;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtPassword.Content = "";
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errorProvider1.SetError(this.txtPassword, "Password feild cannot be empty!");
            this.txtPassword.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtPassword.FocusImageTint = System.Drawing.Color.White;
            this.txtPassword.FocusOutlineColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Image = global::DVLD_PresentationLayer.Properties.Resources.padlock;
            this.txtPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtPassword.Location = new System.Drawing.Point(4, 48);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormalImageTint = System.Drawing.Color.White;
            this.txtPassword.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassword.Padding = new System.Windows.Forms.Padding(41, 3, 41, 0);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtPassword.PlaceholderText = "Password...";
            this.txtPassword.Rounding = new System.Windows.Forms.Padding(8);
            this.txtPassword.Size = new System.Drawing.Size(266, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextOffset = new System.Drawing.Size(25, 0);
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // txtUsername
            // 
            this.txtUsername.BackgroundColor = System.Drawing.Color.White;
            this.txtUsername.Content = "";
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errorProvider1.SetError(this.txtUsername, "Username feild cannot be empty!");
            this.txtUsername.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtUsername.FocusImageTint = System.Drawing.Color.White;
            this.txtUsername.FocusOutlineColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Image = global::DVLD_PresentationLayer.Properties.Resources.user;
            this.txtUsername.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtUsername.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtUsername.Location = new System.Drawing.Point(5, 4);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NormalImageTint = System.Drawing.Color.White;
            this.txtUsername.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUsername.Padding = new System.Windows.Forms.Padding(41, 3, 41, 0);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtUsername.PlaceholderText = "Username...";
            this.txtUsername.Rounding = new System.Windows.Forms.Padding(8);
            this.txtUsername.Size = new System.Drawing.Size(266, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextOffset = new System.Drawing.Size(25, 0);
            this.txtUsername.UnderlinedStyle = true;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBox);
            // 
            // ctrlUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chbRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "ctrlUserLogin";
            this.Size = new System.Drawing.Size(289, 153);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiTextBox txtUsername;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private CuoreUI.Controls.cuiCheckbox chbRememberMe;
        private CuoreUI.Controls.cuiButton btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
