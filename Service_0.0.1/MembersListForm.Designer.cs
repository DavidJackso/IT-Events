namespace Service_0._0._1
{
    partial class MembersListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.healder_panel = new System.Windows.Forms.Panel();
            this.exit_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ApplicationName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.members_datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.first_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healder_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.members_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // healder_panel
            // 
            this.healder_panel.AllowDrop = true;
            this.healder_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.healder_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.healder_panel.Controls.Add(this.exit_button);
            this.healder_panel.Controls.Add(this.ApplicationName);
            this.healder_panel.Controls.Add(this.logo);
            this.healder_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.healder_panel.Location = new System.Drawing.Point(0, 0);
            this.healder_panel.Name = "healder_panel";
            this.healder_panel.Size = new System.Drawing.Size(400, 26);
            this.healder_panel.TabIndex = 5;
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.exit_button.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.exit_button.Image = global::Service_0._0._1.Properties.Resources.black_icon_exit;
            this.exit_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit_button.ImageRotate = 0F;
            this.exit_button.ImageSize = new System.Drawing.Size(63, 63);
            this.exit_button.Location = new System.Drawing.Point(372, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit_button.ShadowDecoration.BorderRadius = 20;
            this.exit_button.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.exit_button.Size = new System.Drawing.Size(28, 26);
            this.exit_button.TabIndex = 1;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ApplicationName
            // 
            this.ApplicationName.AutoSize = true;
            this.ApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.ApplicationName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApplicationName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ApplicationName.Location = new System.Drawing.Point(51, 0);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(80, 21);
            this.ApplicationName.TabIndex = 1;
            this.ApplicationName.Text = "IT-Events";
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.ErrorImage = null;
            this.logo.Image = global::Service_0._0._1.Properties.Resources.logo;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(51, 26);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // members_datagrid
            // 
            this.members_datagrid.AllowUserToAddRows = false;
            this.members_datagrid.AllowUserToDeleteRows = false;
            this.members_datagrid.AllowUserToResizeColumns = false;
            this.members_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.members_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.members_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.members_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.members_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.members_datagrid.ColumnHeadersHeight = 17;
            this.members_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.members_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.first_name_column,
            this.last_name_column,
            this.email_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.members_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.members_datagrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.members_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.members_datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.members_datagrid.Location = new System.Drawing.Point(0, 26);
            this.members_datagrid.MultiSelect = false;
            this.members_datagrid.Name = "members_datagrid";
            this.members_datagrid.ReadOnly = true;
            this.members_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.members_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.members_datagrid.RowHeadersVisible = false;
            this.members_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.members_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.members_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.members_datagrid.RowTemplate.Height = 25;
            this.members_datagrid.RowTemplate.ReadOnly = true;
            this.members_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.members_datagrid.Size = new System.Drawing.Size(400, 249);
            this.members_datagrid.TabIndex = 6;
            this.members_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.members_datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.members_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.members_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.members_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.members_datagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.members_datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.members_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.members_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.members_datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.members_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.members_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.members_datagrid.ThemeStyle.HeaderStyle.Height = 17;
            this.members_datagrid.ThemeStyle.ReadOnly = true;
            this.members_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.members_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.members_datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.members_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.members_datagrid.ThemeStyle.RowsStyle.Height = 25;
            this.members_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.members_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // first_name_column
            // 
            this.first_name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.first_name_column.Frozen = true;
            this.first_name_column.HeaderText = "Имя";
            this.first_name_column.Name = "first_name_column";
            this.first_name_column.ReadOnly = true;
            this.first_name_column.Width = 5;
            // 
            // last_name_column
            // 
            this.last_name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.last_name_column.FillWeight = 19.03555F;
            this.last_name_column.Frozen = true;
            this.last_name_column.HeaderText = "Фамилия";
            this.last_name_column.Name = "last_name_column";
            this.last_name_column.ReadOnly = true;
            this.last_name_column.Width = 5;
            // 
            // email_column
            // 
            this.email_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.email_column.FillWeight = 19.03555F;
            this.email_column.Frozen = true;
            this.email_column.HeaderText = "Email";
            this.email_column.Name = "email_column";
            this.email_column.ReadOnly = true;
            this.email_column.Width = 5;
            // 
            // MembersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.members_datagrid);
            this.Controls.Add(this.healder_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembersListForm";
            this.Text = "MembersListForm";
            this.Load += new System.EventHandler(this.MembersListForm_Load);
            this.healder_panel.ResumeLayout(false);
            this.healder_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.members_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel healder_panel;
        private Guna.UI2.WinForms.Guna2ImageButton exit_button;
        private System.Windows.Forms.Label ApplicationName;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2DataGridView members_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_column;
    }
}