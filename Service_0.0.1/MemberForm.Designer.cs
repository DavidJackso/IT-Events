﻿namespace Service
{
    partial class MemberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.member_tabcntrl = new Guna.UI2.WinForms.Guna2TabControl();
            this.profile = new System.Windows.Forms.TabPage();
            this.organization_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeprofiledata_button = new Guna.UI2.WinForms.Guna2Button();
            this.saveprofiledata_button = new Guna.UI2.WinForms.Guna2Button();
            this.email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastname_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstname_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.events_tabpage = new System.Windows.Forms.TabPage();
            this.details_button = new Guna.UI2.WinForms.Guna2Button();
            this.signup_button = new Guna.UI2.WinForms.Guna2Button();
            this.events_datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.event_id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_type_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_location_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_end_regestration_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_organizator_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_regestration_status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.events = new System.Windows.Forms.TabPage();
            this.next_event_text = new System.Windows.Forms.Label();
            this.next_event_label = new System.Windows.Forms.Label();
            this.user_events_datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.myeventid_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_type_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_location_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_data_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_close_regestration_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_oraganizator_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myevent_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healder_panel = new System.Windows.Forms.Panel();
            this.exit_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ApplicationName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.member_tabcntrl.SuspendLayout();
            this.profile.SuspendLayout();
            this.events_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.events_datagrid)).BeginInit();
            this.events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_events_datagrid)).BeginInit();
            this.healder_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // member_tabcntrl
            // 
            this.member_tabcntrl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.member_tabcntrl.Controls.Add(this.profile);
            this.member_tabcntrl.Controls.Add(this.events_tabpage);
            this.member_tabcntrl.Controls.Add(this.events);
            this.member_tabcntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.member_tabcntrl.ItemSize = new System.Drawing.Size(100, 40);
            this.member_tabcntrl.Location = new System.Drawing.Point(0, 26);
            this.member_tabcntrl.Margin = new System.Windows.Forms.Padding(0);
            this.member_tabcntrl.Name = "member_tabcntrl";
            this.member_tabcntrl.Padding = new System.Drawing.Point(0, 0);
            this.member_tabcntrl.SelectedIndex = 0;
            this.member_tabcntrl.Size = new System.Drawing.Size(1143, 549);
            this.member_tabcntrl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.member_tabcntrl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.member_tabcntrl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.member_tabcntrl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.member_tabcntrl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.member_tabcntrl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.member_tabcntrl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.member_tabcntrl.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.member_tabcntrl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.member_tabcntrl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.member_tabcntrl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(255)))), ((int)(((byte)(137)))));
            this.member_tabcntrl.TabButtonSize = new System.Drawing.Size(100, 40);
            this.member_tabcntrl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.member_tabcntrl.TabIndex = 2;
            this.member_tabcntrl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.profile.Controls.Add(this.organization_textbox);
            this.profile.Controls.Add(this.changeprofiledata_button);
            this.profile.Controls.Add(this.saveprofiledata_button);
            this.profile.Controls.Add(this.email_textbox);
            this.profile.Controls.Add(this.lastname_textbox);
            this.profile.Controls.Add(this.firstname_textbox);
            this.profile.Location = new System.Drawing.Point(104, 4);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(1035, 541);
            this.profile.TabIndex = 0;
            this.profile.Text = "Профиль";
            // 
            // organization_textbox
            // 
            this.organization_textbox.Animated = true;
            this.organization_textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "lol",
            "kek",
            "lol",
            "ha"});
            this.organization_textbox.BorderRadius = 10;
            this.organization_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.organization_textbox.DefaultText = "";
            this.organization_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.organization_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.organization_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.organization_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.organization_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.organization_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.organization_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.organization_textbox.Location = new System.Drawing.Point(26, 178);
            this.organization_textbox.Name = "organization_textbox";
            this.organization_textbox.PasswordChar = '\0';
            this.organization_textbox.PlaceholderText = "Место учебы/работы";
            this.organization_textbox.SelectedText = "";
            this.organization_textbox.Size = new System.Drawing.Size(200, 36);
            this.organization_textbox.TabIndex = 6;
            // 
            // changeprofiledata_button
            // 
            this.changeprofiledata_button.BorderRadius = 10;
            this.changeprofiledata_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeprofiledata_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeprofiledata_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeprofiledata_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeprofiledata_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.changeprofiledata_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeprofiledata_button.ForeColor = System.Drawing.Color.White;
            this.changeprofiledata_button.Location = new System.Drawing.Point(26, 228);
            this.changeprofiledata_button.Name = "changeprofiledata_button";
            this.changeprofiledata_button.Size = new System.Drawing.Size(200, 45);
            this.changeprofiledata_button.TabIndex = 5;
            this.changeprofiledata_button.Text = "Изменить";
            this.changeprofiledata_button.Click += new System.EventHandler(this.changeprofiledata_button_Click);
            // 
            // saveprofiledata_button
            // 
            this.saveprofiledata_button.BorderRadius = 10;
            this.saveprofiledata_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveprofiledata_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveprofiledata_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveprofiledata_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveprofiledata_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.saveprofiledata_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveprofiledata_button.ForeColor = System.Drawing.Color.White;
            this.saveprofiledata_button.Location = new System.Drawing.Point(26, 287);
            this.saveprofiledata_button.Name = "saveprofiledata_button";
            this.saveprofiledata_button.Size = new System.Drawing.Size(200, 45);
            this.saveprofiledata_button.TabIndex = 4;
            this.saveprofiledata_button.Text = "Сохранить";
            this.saveprofiledata_button.Click += new System.EventHandler(this.saveprofiledata_button_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Animated = true;
            this.email_textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "lol",
            "kek",
            "lol",
            "ha"});
            this.email_textbox.BorderRadius = 10;
            this.email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textbox.DefaultText = "";
            this.email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.Location = new System.Drawing.Point(26, 128);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.PasswordChar = '\0';
            this.email_textbox.PlaceholderText = "Email";
            this.email_textbox.SelectedText = "";
            this.email_textbox.Size = new System.Drawing.Size(200, 36);
            this.email_textbox.TabIndex = 2;
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Animated = true;
            this.lastname_textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "lol",
            "kek",
            "lol",
            "ha"});
            this.lastname_textbox.BorderRadius = 10;
            this.lastname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname_textbox.DefaultText = "";
            this.lastname_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastname_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastname_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastname_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_textbox.Location = new System.Drawing.Point(26, 78);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.PasswordChar = '\0';
            this.lastname_textbox.PlaceholderText = "Фамилия";
            this.lastname_textbox.SelectedText = "";
            this.lastname_textbox.Size = new System.Drawing.Size(200, 36);
            this.lastname_textbox.TabIndex = 1;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Animated = true;
            this.firstname_textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "lol",
            "kek",
            "lol",
            "ha"});
            this.firstname_textbox.BorderRadius = 10;
            this.firstname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname_textbox.DefaultText = "";
            this.firstname_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstname_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstname_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstname_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_textbox.Location = new System.Drawing.Point(26, 28);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.PasswordChar = '\0';
            this.firstname_textbox.PlaceholderText = "Имя";
            this.firstname_textbox.SelectedText = "";
            this.firstname_textbox.Size = new System.Drawing.Size(200, 36);
            this.firstname_textbox.TabIndex = 0;
            // 
            // events_tabpage
            // 
            this.events_tabpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events_tabpage.Controls.Add(this.details_button);
            this.events_tabpage.Controls.Add(this.signup_button);
            this.events_tabpage.Controls.Add(this.events_datagrid);
            this.events_tabpage.Location = new System.Drawing.Point(104, 4);
            this.events_tabpage.Name = "events_tabpage";
            this.events_tabpage.Size = new System.Drawing.Size(1035, 541);
            this.events_tabpage.TabIndex = 2;
            this.events_tabpage.Text = "Мероприятия";
            // 
            // details_button
            // 
            this.details_button.BorderRadius = 10;
            this.details_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.details_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.details_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.details_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.details_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.details_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.details_button.ForeColor = System.Drawing.Color.White;
            this.details_button.Location = new System.Drawing.Point(209, 433);
            this.details_button.Name = "details_button";
            this.details_button.Size = new System.Drawing.Size(200, 45);
            this.details_button.TabIndex = 6;
            this.details_button.Text = "Подробнее";
            this.details_button.Click += new System.EventHandler(this.details_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BorderRadius = 10;
            this.signup_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.signup_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(5, 433);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(200, 45);
            this.signup_button.TabIndex = 5;
            this.signup_button.Text = "Зарегестрироваться";
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // events_datagrid
            // 
            this.events_datagrid.AllowUserToAddRows = false;
            this.events_datagrid.AllowUserToDeleteRows = false;
            this.events_datagrid.AllowUserToResizeColumns = false;
            this.events_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.events_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.events_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.events_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.events_datagrid.ColumnHeadersHeight = 17;
            this.events_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.events_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_id_column,
            this.event_name_column,
            this.event_type_column,
            this.event_location_column,
            this.event_date_column,
            this.event_end_regestration_column,
            this.event_organizator_column,
            this.event_regestration_status_column});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.events_datagrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.events_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.events_datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.events_datagrid.Location = new System.Drawing.Point(5, 5);
            this.events_datagrid.MultiSelect = false;
            this.events_datagrid.Name = "events_datagrid";
            this.events_datagrid.ReadOnly = true;
            this.events_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.events_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.events_datagrid.RowHeadersVisible = false;
            this.events_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.events_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events_datagrid.RowTemplate.Height = 25;
            this.events_datagrid.RowTemplate.ReadOnly = true;
            this.events_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.events_datagrid.Size = new System.Drawing.Size(1021, 305);
            this.events_datagrid.TabIndex = 1;
            this.events_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.events_datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.events_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.events_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.events_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.events_datagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events_datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.events_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.events_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.events_datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.events_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.events_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.events_datagrid.ThemeStyle.HeaderStyle.Height = 17;
            this.events_datagrid.ThemeStyle.ReadOnly = true;
            this.events_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.events_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.events_datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.events_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.events_datagrid.ThemeStyle.RowsStyle.Height = 25;
            this.events_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.events_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // event_id_column
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.event_id_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.event_id_column.HeaderText = "ID";
            this.event_id_column.Name = "event_id_column";
            this.event_id_column.ReadOnly = true;
            this.event_id_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.event_id_column.Visible = false;
            // 
            // event_name_column
            // 
            this.event_name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.event_name_column.DefaultCellStyle = dataGridViewCellStyle4;
            this.event_name_column.FillWeight = 635.7867F;
            this.event_name_column.HeaderText = "Название мероприятия";
            this.event_name_column.MinimumWidth = 50;
            this.event_name_column.Name = "event_name_column";
            this.event_name_column.ReadOnly = true;
            this.event_name_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.event_name_column.Width = 151;
            // 
            // event_type_column
            // 
            this.event_type_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_type_column.FillWeight = 19.03555F;
            this.event_type_column.HeaderText = "Тип мероприятия";
            this.event_type_column.Name = "event_type_column";
            this.event_type_column.ReadOnly = true;
            // 
            // event_location_column
            // 
            this.event_location_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_location_column.FillWeight = 19.03555F;
            this.event_location_column.HeaderText = "Место проведения";
            this.event_location_column.Name = "event_location_column";
            this.event_location_column.ReadOnly = true;
            // 
            // event_date_column
            // 
            this.event_date_column.FillWeight = 19.03555F;
            this.event_date_column.HeaderText = "Дата:Время проведения";
            this.event_date_column.Name = "event_date_column";
            this.event_date_column.ReadOnly = true;
            // 
            // event_end_regestration_column
            // 
            this.event_end_regestration_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_end_regestration_column.FillWeight = 19.03555F;
            this.event_end_regestration_column.HeaderText = "Закрытие регистрации";
            this.event_end_regestration_column.Name = "event_end_regestration_column";
            this.event_end_regestration_column.ReadOnly = true;
            // 
            // event_organizator_column
            // 
            this.event_organizator_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_organizator_column.FillWeight = 19.03555F;
            this.event_organizator_column.HeaderText = "Организатор";
            this.event_organizator_column.Name = "event_organizator_column";
            this.event_organizator_column.ReadOnly = true;
            // 
            // event_regestration_status_column
            // 
            this.event_regestration_status_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_regestration_status_column.FillWeight = 19.03555F;
            this.event_regestration_status_column.HeaderText = "Регистрация";
            this.event_regestration_status_column.Name = "event_regestration_status_column";
            this.event_regestration_status_column.ReadOnly = true;
            // 
            // events
            // 
            this.events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.events.Controls.Add(this.next_event_text);
            this.events.Controls.Add(this.next_event_label);
            this.events.Controls.Add(this.user_events_datagrid);
            this.events.Location = new System.Drawing.Point(104, 4);
            this.events.Name = "events";
            this.events.Padding = new System.Windows.Forms.Padding(3);
            this.events.Size = new System.Drawing.Size(1035, 541);
            this.events.TabIndex = 1;
            this.events.Text = "Мои мероприятия";
            // 
            // next_event_text
            // 
            this.next_event_text.AutoSize = true;
            this.next_event_text.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_event_text.ForeColor = System.Drawing.Color.White;
            this.next_event_text.Location = new System.Drawing.Point(6, 373);
            this.next_event_text.Name = "next_event_text";
            this.next_event_text.Size = new System.Drawing.Size(181, 17);
            this.next_event_text.TabIndex = 9;
            this.next_event_text.Text = "Ближайшее мероприятие:";
            // 
            // next_event_label
            // 
            this.next_event_label.AutoSize = true;
            this.next_event_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_event_label.ForeColor = System.Drawing.Color.White;
            this.next_event_label.Location = new System.Drawing.Point(16, 399);
            this.next_event_label.Name = "next_event_label";
            this.next_event_label.Size = new System.Drawing.Size(181, 17);
            this.next_event_label.TabIndex = 8;
            this.next_event_label.Text = "Ближайшее мероприятие:";
            // 
            // user_events_datagrid
            // 
            this.user_events_datagrid.AllowUserToAddRows = false;
            this.user_events_datagrid.AllowUserToDeleteRows = false;
            this.user_events_datagrid.AllowUserToResizeColumns = false;
            this.user_events_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.user_events_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.user_events_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.user_events_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_events_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.user_events_datagrid.ColumnHeadersHeight = 17;
            this.user_events_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.user_events_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.myeventid_column,
            this.myevent_name_column,
            this.myevent_type_column,
            this.myevent_location_column,
            this.myevent_data_column,
            this.myevent_close_regestration_column,
            this.myevent_oraganizator_column,
            this.myevent_status});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_events_datagrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.user_events_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.user_events_datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.user_events_datagrid.Location = new System.Drawing.Point(5, 5);
            this.user_events_datagrid.MultiSelect = false;
            this.user_events_datagrid.Name = "user_events_datagrid";
            this.user_events_datagrid.ReadOnly = true;
            this.user_events_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_events_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.user_events_datagrid.RowHeadersVisible = false;
            this.user_events_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.user_events_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.user_events_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.user_events_datagrid.RowTemplate.Height = 25;
            this.user_events_datagrid.RowTemplate.ReadOnly = true;
            this.user_events_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_events_datagrid.Size = new System.Drawing.Size(1021, 300);
            this.user_events_datagrid.TabIndex = 0;
            this.user_events_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.user_events_datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.user_events_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.user_events_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.user_events_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.user_events_datagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.user_events_datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.user_events_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.user_events_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.user_events_datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_events_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.user_events_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.user_events_datagrid.ThemeStyle.HeaderStyle.Height = 17;
            this.user_events_datagrid.ThemeStyle.ReadOnly = true;
            this.user_events_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.user_events_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.user_events_datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_events_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.user_events_datagrid.ThemeStyle.RowsStyle.Height = 25;
            this.user_events_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.user_events_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // myeventid_column
            // 
            this.myeventid_column.HeaderText = "ID";
            this.myeventid_column.Name = "myeventid_column";
            this.myeventid_column.ReadOnly = true;
            this.myeventid_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.myeventid_column.Visible = false;
            // 
            // myevent_name_column
            // 
            this.myevent_name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.myevent_name_column.FillWeight = 635.7867F;
            this.myevent_name_column.HeaderText = "Название мероприятия";
            this.myevent_name_column.MinimumWidth = 50;
            this.myevent_name_column.Name = "myevent_name_column";
            this.myevent_name_column.ReadOnly = true;
            this.myevent_name_column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.myevent_name_column.Width = 151;
            // 
            // myevent_type_column
            // 
            this.myevent_type_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myevent_type_column.FillWeight = 19.03555F;
            this.myevent_type_column.HeaderText = "Тип мероприятия";
            this.myevent_type_column.Name = "myevent_type_column";
            this.myevent_type_column.ReadOnly = true;
            // 
            // myevent_location_column
            // 
            this.myevent_location_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myevent_location_column.FillWeight = 19.03555F;
            this.myevent_location_column.HeaderText = "Место проведения";
            this.myevent_location_column.Name = "myevent_location_column";
            this.myevent_location_column.ReadOnly = true;
            // 
            // myevent_data_column
            // 
            this.myevent_data_column.FillWeight = 19.03555F;
            this.myevent_data_column.HeaderText = "Дата:Время проведения";
            this.myevent_data_column.Name = "myevent_data_column";
            this.myevent_data_column.ReadOnly = true;
            // 
            // myevent_close_regestration_column
            // 
            this.myevent_close_regestration_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myevent_close_regestration_column.FillWeight = 19.03555F;
            this.myevent_close_regestration_column.HeaderText = "Закрытие регистрации";
            this.myevent_close_regestration_column.Name = "myevent_close_regestration_column";
            this.myevent_close_regestration_column.ReadOnly = true;
            // 
            // myevent_oraganizator_column
            // 
            this.myevent_oraganizator_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myevent_oraganizator_column.FillWeight = 19.03555F;
            this.myevent_oraganizator_column.HeaderText = "Организатор";
            this.myevent_oraganizator_column.Name = "myevent_oraganizator_column";
            this.myevent_oraganizator_column.ReadOnly = true;
            // 
            // myevent_status
            // 
            this.myevent_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myevent_status.FillWeight = 19.03555F;
            this.myevent_status.HeaderText = "Регестрация";
            this.myevent_status.Name = "myevent_status";
            this.myevent_status.ReadOnly = true;
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
            this.healder_panel.Size = new System.Drawing.Size(1143, 26);
            this.healder_panel.TabIndex = 3;
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
            this.exit_button.Location = new System.Drawing.Point(1115, 0);
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
            this.ApplicationName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ApplicationName.Location = new System.Drawing.Point(51, 0);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(90, 22);
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
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 575);
            this.Controls.Add(this.member_tabcntrl);
            this.Controls.Add(this.healder_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OraganizatorForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.member_tabcntrl.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.events_tabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.events_datagrid)).EndInit();
            this.events.ResumeLayout(false);
            this.events.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_events_datagrid)).EndInit();
            this.healder_panel.ResumeLayout(false);
            this.healder_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl member_tabcntrl;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage events;
        private Guna.UI2.WinForms.Guna2TextBox firstname_textbox;
        private System.Windows.Forms.Panel healder_panel;
        private System.Windows.Forms.Label ApplicationName;
        private Guna.UI2.WinForms.Guna2ImageButton exit_button;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2TextBox email_textbox;
        private Guna.UI2.WinForms.Guna2TextBox lastname_textbox;
        private Guna.UI2.WinForms.Guna2Button changeprofiledata_button;
        private Guna.UI2.WinForms.Guna2Button saveprofiledata_button;
        private Guna.UI2.WinForms.Guna2DataGridView user_events_datagrid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TabPage events_tabpage;
        private Guna.UI2.WinForms.Guna2DataGridView events_datagrid;
        private Guna.UI2.WinForms.Guna2Button details_button;
        private Guna.UI2.WinForms.Guna2Button signup_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn myeventid_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_type_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_location_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_data_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_close_regestration_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_oraganizator_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn myevent_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_type_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_location_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_end_regestration_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_organizator_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_regestration_status_column;
        private System.Windows.Forms.Label next_event_label;
        private Guna.UI2.WinForms.Guna2TextBox organization_textbox;
        private System.Windows.Forms.Label next_event_text;
    }
}