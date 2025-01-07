namespace Service
{
    partial class login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.healder_panel = new System.Windows.Forms.Panel();
            this.ApplicationName = new System.Windows.Forms.Label();
            this.exit_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.regestration = new System.Windows.Forms.TabPage();
            this.role_rbutton_organizator = new Guna.UI2.WinForms.Guna2RadioButton();
            this.role_rbutton_member = new Guna.UI2.WinForms.Guna2RadioButton();
            this.regestration_button = new Guna.UI2.WinForms.Guna2Button();
            this.repeatpass_textbox_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_textbox_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_textbox_reg = new Guna.UI2.WinForms.Guna2TextBox();
            this.login = new System.Windows.Forms.TabPage();
            this.password_textbox_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button_login = new Guna.UI2.WinForms.Guna2Button();
            this.username_textbox_login = new Guna.UI2.WinForms.Guna2TextBox();
            this.logint_tabcntrl = new Guna.UI2.WinForms.Guna2TabControl();
            this.healder_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.regestration.SuspendLayout();
            this.login.SuspendLayout();
            this.logint_tabcntrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // healder_panel
            // 
            this.healder_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.healder_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.healder_panel.Controls.Add(this.ApplicationName);
            this.healder_panel.Controls.Add(this.exit_button);
            this.healder_panel.Controls.Add(this.logo);
            this.healder_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.healder_panel.Location = new System.Drawing.Point(0, 0);
            this.healder_panel.Name = "healder_panel";
            this.healder_panel.Size = new System.Drawing.Size(450, 26);
            this.healder_panel.TabIndex = 0;
            // 
            // ApplicationName
            // 
            this.ApplicationName.AutoSize = true;
            this.ApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ApplicationName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApplicationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ApplicationName.Location = new System.Drawing.Point(51, 0);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(80, 21);
            this.ApplicationName.TabIndex = 1;
            this.ApplicationName.Text = "IT-Events";
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.exit_button.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.exit_button.Image = global::Service_0._0._1.Properties.Resources.black_icon_exit;
            this.exit_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit_button.ImageRotate = 0F;
            this.exit_button.ImageSize = new System.Drawing.Size(63, 63);
            this.exit_button.Location = new System.Drawing.Point(418, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit_button.ShadowDecoration.BorderRadius = 20;
            this.exit_button.ShadowDecoration.Color = System.Drawing.Color.BlanchedAlmond;
            this.exit_button.Size = new System.Drawing.Size(29, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
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
            // regestration
            // 
            this.regestration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.regestration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regestration.Controls.Add(this.role_rbutton_organizator);
            this.regestration.Controls.Add(this.role_rbutton_member);
            this.regestration.Controls.Add(this.regestration_button);
            this.regestration.Controls.Add(this.repeatpass_textbox_reg);
            this.regestration.Controls.Add(this.password_textbox_reg);
            this.regestration.Controls.Add(this.username_textbox_reg);
            this.regestration.Location = new System.Drawing.Point(4, 44);
            this.regestration.Name = "regestration";
            this.regestration.Padding = new System.Windows.Forms.Padding(3);
            this.regestration.Size = new System.Drawing.Size(300, 315);
            this.regestration.TabIndex = 1;
            this.regestration.Text = "Регистрация";
            // 
            // role_rbutton_organizator
            // 
            this.role_rbutton_organizator.AutoSize = true;
            this.role_rbutton_organizator.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.role_rbutton_organizator.CheckedState.BorderThickness = 0;
            this.role_rbutton_organizator.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.role_rbutton_organizator.CheckedState.InnerColor = System.Drawing.Color.White;
            this.role_rbutton_organizator.CheckedState.InnerOffset = -4;
            this.role_rbutton_organizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.role_rbutton_organizator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role_rbutton_organizator.Location = new System.Drawing.Point(53, 188);
            this.role_rbutton_organizator.Name = "role_rbutton_organizator";
            this.role_rbutton_organizator.Size = new System.Drawing.Size(91, 17);
            this.role_rbutton_organizator.TabIndex = 10;
            this.role_rbutton_organizator.Text = "Организатор";
            this.role_rbutton_organizator.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.role_rbutton_organizator.UncheckedState.BorderThickness = 2;
            this.role_rbutton_organizator.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.role_rbutton_organizator.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // role_rbutton_member
            // 
            this.role_rbutton_member.AutoSize = true;
            this.role_rbutton_member.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.role_rbutton_member.CheckedState.BorderThickness = 0;
            this.role_rbutton_member.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.role_rbutton_member.CheckedState.InnerColor = System.Drawing.Color.White;
            this.role_rbutton_member.CheckedState.InnerOffset = -4;
            this.role_rbutton_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.role_rbutton_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role_rbutton_member.Location = new System.Drawing.Point(180, 188);
            this.role_rbutton_member.Name = "role_rbutton_member";
            this.role_rbutton_member.Size = new System.Drawing.Size(73, 17);
            this.role_rbutton_member.TabIndex = 9;
            this.role_rbutton_member.Text = "Участник";
            this.role_rbutton_member.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.role_rbutton_member.UncheckedState.BorderThickness = 2;
            this.role_rbutton_member.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.role_rbutton_member.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // regestration_button
            // 
            this.regestration_button.BorderRadius = 10;
            this.regestration_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regestration_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regestration_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regestration_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regestration_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.regestration_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regestration_button.ForeColor = System.Drawing.Color.White;
            this.regestration_button.Location = new System.Drawing.Point(53, 241);
            this.regestration_button.Name = "regestration_button";
            this.regestration_button.Size = new System.Drawing.Size(200, 45);
            this.regestration_button.TabIndex = 6;
            this.regestration_button.Text = "Зарегистрироваться";
            this.regestration_button.Click += new System.EventHandler(this.regestration_button_Click);
            // 
            // repeatpass_textbox_reg
            // 
            this.repeatpass_textbox_reg.BorderRadius = 10;
            this.repeatpass_textbox_reg.BorderThickness = 0;
            this.repeatpass_textbox_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeatpass_textbox_reg.DefaultText = "";
            this.repeatpass_textbox_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repeatpass_textbox_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repeatpass_textbox_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatpass_textbox_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatpass_textbox_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repeatpass_textbox_reg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.repeatpass_textbox_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repeatpass_textbox_reg.Location = new System.Drawing.Point(53, 136);
            this.repeatpass_textbox_reg.Name = "repeatpass_textbox_reg";
            this.repeatpass_textbox_reg.PasswordChar = '\0';
            this.repeatpass_textbox_reg.PlaceholderText = "Повторите пароль";
            this.repeatpass_textbox_reg.SelectedText = "";
            this.repeatpass_textbox_reg.Size = new System.Drawing.Size(200, 36);
            this.repeatpass_textbox_reg.TabIndex = 5;
            // 
            // password_textbox_reg
            // 
            this.password_textbox_reg.BorderRadius = 10;
            this.password_textbox_reg.BorderThickness = 0;
            this.password_textbox_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox_reg.DefaultText = "";
            this.password_textbox_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textbox_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textbox_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox_reg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_textbox_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox_reg.Location = new System.Drawing.Point(53, 89);
            this.password_textbox_reg.Name = "password_textbox_reg";
            this.password_textbox_reg.PasswordChar = '\0';
            this.password_textbox_reg.PlaceholderText = "Пароль";
            this.password_textbox_reg.SelectedText = "";
            this.password_textbox_reg.Size = new System.Drawing.Size(200, 36);
            this.password_textbox_reg.TabIndex = 4;
            // 
            // username_textbox_reg
            // 
            this.username_textbox_reg.BorderRadius = 10;
            this.username_textbox_reg.BorderThickness = 0;
            this.username_textbox_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox_reg.DefaultText = "";
            this.username_textbox_reg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_textbox_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_textbox_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox_reg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox_reg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox_reg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_textbox_reg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox_reg.Location = new System.Drawing.Point(53, 42);
            this.username_textbox_reg.Name = "username_textbox_reg";
            this.username_textbox_reg.PasswordChar = '\0';
            this.username_textbox_reg.PlaceholderText = "Логин";
            this.username_textbox_reg.SelectedText = "";
            this.username_textbox_reg.Size = new System.Drawing.Size(200, 36);
            this.username_textbox_reg.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.login.Controls.Add(this.password_textbox_login);
            this.login.Controls.Add(this.login_button_login);
            this.login.Controls.Add(this.username_textbox_login);
            this.login.Location = new System.Drawing.Point(4, 44);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(300, 315);
            this.login.TabIndex = 0;
            this.login.Text = "Войти";
            // 
            // password_textbox_login
            // 
            this.password_textbox_login.BorderRadius = 15;
            this.password_textbox_login.BorderThickness = 0;
            this.password_textbox_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox_login.DefaultText = "";
            this.password_textbox_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textbox_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textbox_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_textbox_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox_login.Location = new System.Drawing.Point(50, 115);
            this.password_textbox_login.Name = "password_textbox_login";
            this.password_textbox_login.PasswordChar = '*';
            this.password_textbox_login.PlaceholderText = "Пароль";
            this.password_textbox_login.SelectedText = "";
            this.password_textbox_login.Size = new System.Drawing.Size(200, 36);
            this.password_textbox_login.TabIndex = 3;
            // 
            // login_button_login
            // 
            this.login_button_login.BorderRadius = 20;
            this.login_button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(67)))));
            this.login_button_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_button_login.ForeColor = System.Drawing.Color.White;
            this.login_button_login.Location = new System.Drawing.Point(50, 173);
            this.login_button_login.Name = "login_button_login";
            this.login_button_login.Size = new System.Drawing.Size(200, 45);
            this.login_button_login.TabIndex = 2;
            this.login_button_login.Text = "Войти";
            this.login_button_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_textbox_login
            // 
            this.username_textbox_login.BorderRadius = 15;
            this.username_textbox_login.BorderThickness = 0;
            this.username_textbox_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox_login.DefaultText = "";
            this.username_textbox_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_textbox_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_textbox_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_textbox_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textbox_login.Location = new System.Drawing.Point(50, 57);
            this.username_textbox_login.Name = "username_textbox_login";
            this.username_textbox_login.PasswordChar = '\0';
            this.username_textbox_login.PlaceholderText = "Логин";
            this.username_textbox_login.SelectedText = "";
            this.username_textbox_login.Size = new System.Drawing.Size(200, 36);
            this.username_textbox_login.TabIndex = 0;
            // 
            // logint_tabcntrl
            // 
            this.logint_tabcntrl.Controls.Add(this.login);
            this.logint_tabcntrl.Controls.Add(this.regestration);
            this.logint_tabcntrl.ItemSize = new System.Drawing.Size(150, 40);
            this.logint_tabcntrl.Location = new System.Drawing.Point(66, 78);
            this.logint_tabcntrl.Margin = new System.Windows.Forms.Padding(0);
            this.logint_tabcntrl.Name = "logint_tabcntrl";
            this.logint_tabcntrl.Padding = new System.Drawing.Point(0, 0);
            this.logint_tabcntrl.SelectedIndex = 0;
            this.logint_tabcntrl.Size = new System.Drawing.Size(308, 363);
            this.logint_tabcntrl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.logint_tabcntrl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.logint_tabcntrl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.logint_tabcntrl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.logint_tabcntrl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.logint_tabcntrl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.logint_tabcntrl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.logint_tabcntrl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.logint_tabcntrl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(255)))), ((int)(((byte)(137)))));
            this.logint_tabcntrl.TabButtonSize = new System.Drawing.Size(150, 40);
            this.logint_tabcntrl.TabIndex = 1;
            this.logint_tabcntrl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.logint_tabcntrl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.logint_tabcntrl);
            this.Controls.Add(this.healder_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.healder_panel.ResumeLayout(false);
            this.healder_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.regestration.ResumeLayout(false);
            this.regestration.PerformLayout();
            this.login.ResumeLayout(false);
            this.logint_tabcntrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel healder_panel;
        private Guna.UI2.WinForms.Guna2ImageButton exit_button;
        private System.Windows.Forms.Label ApplicationName;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2TabControl logint_tabcntrl;
        private System.Windows.Forms.TabPage login;
        private Guna.UI2.WinForms.Guna2TextBox password_textbox_login;
        private Guna.UI2.WinForms.Guna2Button login_button_login;
        private Guna.UI2.WinForms.Guna2TextBox username_textbox_login;
        private System.Windows.Forms.TabPage regestration;
        private Guna.UI2.WinForms.Guna2Button regestration_button;
        private Guna.UI2.WinForms.Guna2TextBox repeatpass_textbox_reg;
        private Guna.UI2.WinForms.Guna2TextBox password_textbox_reg;
        private Guna.UI2.WinForms.Guna2TextBox username_textbox_reg;
        private Guna.UI2.WinForms.Guna2RadioButton role_rbutton_organizator;
        private Guna.UI2.WinForms.Guna2RadioButton role_rbutton_member;
    }
}

