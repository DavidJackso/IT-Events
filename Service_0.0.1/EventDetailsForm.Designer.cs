namespace Service_0._0._1
{
    partial class EventDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDetailsForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.healder_panel = new System.Windows.Forms.Panel();
            this.exit_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ApplicationName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.event_name = new System.Windows.Forms.Label();
            this.event_location = new System.Windows.Forms.Label();
            this.event_time_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.event_description_label = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.healder_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.healder_panel.Size = new System.Drawing.Size(426, 26);
            this.healder_panel.TabIndex = 4;
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
            this.exit_button.Location = new System.Drawing.Point(398, 0);
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
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.ForeColor = System.Drawing.Color.White;
            this.event_name.Location = new System.Drawing.Point(41, 57);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(75, 17);
            this.event_name.TabIndex = 5;
            this.event_name.Text = "Название:";
            // 
            // event_location
            // 
            this.event_location.AutoSize = true;
            this.event_location.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_location.ForeColor = System.Drawing.Color.White;
            this.event_location.Location = new System.Drawing.Point(41, 93);
            this.event_location.Name = "event_location";
            this.event_location.Size = new System.Drawing.Size(135, 17);
            this.event_location.TabIndex = 7;
            this.event_location.Text = "Место проведения:";
            // 
            // event_time_label
            // 
            this.event_time_label.AutoSize = true;
            this.event_time_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_time_label.ForeColor = System.Drawing.Color.White;
            this.event_time_label.Location = new System.Drawing.Point(41, 129);
            this.event_time_label.Name = "event_time_label";
            this.event_time_label.Size = new System.Drawing.Size(127, 17);
            this.event_time_label.TabIndex = 8;
            this.event_time_label.Text = "Дата проведения:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(196, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Описание";
            // 
            // event_description_label
            // 
            this.event_description_label.AutoSize = true;
            this.event_description_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_description_label.ForeColor = System.Drawing.Color.White;
            this.event_description_label.Location = new System.Drawing.Point(41, 208);
            this.event_description_label.Name = "event_description_label";
            this.event_description_label.Size = new System.Drawing.Size(99, 17);
            this.event_description_label.TabIndex = 11;
            this.event_description_label.Text = "Описание мп";
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(426, 443);
            this.Controls.Add(this.event_description_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.event_time_label);
            this.Controls.Add(this.event_location);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.healder_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventDetailsForm";
            this.Text = "DecriptionForm";
            this.Load += new System.EventHandler(this.EventDetailsForm_Load);
            this.healder_panel.ResumeLayout(false);
            this.healder_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel healder_panel;
        private Guna.UI2.WinForms.Guna2ImageButton exit_button;
        private System.Windows.Forms.Label ApplicationName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label event_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label event_time_label;
        private System.Windows.Forms.Label event_location;
        private System.Windows.Forms.Label event_description_label;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}