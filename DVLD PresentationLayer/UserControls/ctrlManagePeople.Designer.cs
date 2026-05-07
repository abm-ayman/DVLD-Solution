namespace DVLD_PresentationLayer.UserControls
{
    partial class ctrlManagePeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVPeople = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnAddNewPerson = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPeople
            // 
            this.DGVPeople.AllowUserToResizeRows = false;
            this.DGVPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPeople.EnableHeadersVisualStyles = false;
            this.DGVPeople.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVPeople.Location = new System.Drawing.Point(4, 42);
            this.DGVPeople.Name = "DGVPeople";
            this.DGVPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPeople.Size = new System.Drawing.Size(1037, 276);
            this.DGVPeople.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            this.DGVPeople.TabIndex = 2;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.CheckButton = false;
            this.btnAddNewPerson.Checked = false;
            this.btnAddNewPerson.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddNewPerson.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddNewPerson.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddNewPerson.Content = "";
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.HoverBackground = System.Drawing.Color.White;
            this.btnAddNewPerson.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnAddNewPerson.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnAddNewPerson.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddNewPerson.Image = global::DVLD_PresentationLayer.Properties.Resources.incorporation;
            this.btnAddNewPerson.ImageExpand = new System.Drawing.Point(5, 5);
            this.btnAddNewPerson.Location = new System.Drawing.Point(988, 4);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.NormalBackground = System.Drawing.Color.White;
            this.btnAddNewPerson.NormalForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.NormalImageTint = System.Drawing.Color.Black;
            this.btnAddNewPerson.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddNewPerson.OutlineThickness = 1F;
            this.btnAddNewPerson.Padding = new System.Windows.Forms.Padding(12);
            this.btnAddNewPerson.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewPerson.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddNewPerson.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddNewPerson.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddNewPerson.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAddNewPerson.Size = new System.Drawing.Size(53, 32);
            this.btnAddNewPerson.TabIndex = 1;
            this.btnAddNewPerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddNewPerson.TextPadding = 12;
            this.btnAddNewPerson.TextSpacing = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // cuiComboBox1
            // 
            this.cuiComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiComboBox1.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cuiComboBox1.DropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.cuiComboBox1.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cuiComboBox1.ForeColor = System.Drawing.Color.Gray;
            this.cuiComboBox1.Items = new string[] {
        "Item 1",
        "Item 2",
        "Item 3"};
            this.cuiComboBox1.Location = new System.Drawing.Point(102, 7);
            this.cuiComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cuiComboBox1.MaxDropDownHeight = 240;
            this.cuiComboBox1.Name = "cuiComboBox1";
            this.cuiComboBox1.NoSelectionText = "None";
            this.cuiComboBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiComboBox1.OutlineThickness = 1F;
            this.cuiComboBox1.Rounding = 8;
            this.cuiComboBox1.SelectedIndex = -1;
            this.cuiComboBox1.SelectedItem = "";
            this.cuiComboBox1.Size = new System.Drawing.Size(187, 32);
            this.cuiComboBox1.SortAlphabetically = true;
            this.cuiComboBox1.TabIndex = 4;
            // 
            // ctrlManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPeople);
            this.Controls.Add(this.btnAddNewPerson);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlManagePeople";
            this.Size = new System.Drawing.Size(1057, 332);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CuoreUI.Controls.cuiButton btnAddNewPerson;
        private ReaLTaiizor.Controls.PoisonDataGridView DGVPeople;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
    }
}
