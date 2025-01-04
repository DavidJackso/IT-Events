using System;
using System.Windows.Forms;

namespace Service
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var username = username_textbox_login.Text;
            var password = password_textbox_login.Text;
            var loginuser = new User(username, password, "", Guid.NewGuid());
            var usersBase = new UsersBase();

            if (usersBase.SucessLogin(loginuser))
            {
                loginuser = usersBase.GetUser(loginuser);
                Form nextForm = loginuser.Role == "organizator" ? (Form)new OraganizatorForm(loginuser) : new MemberForm(loginuser);
                nextForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Данные для входа введены неверно!", "Ошибка аунтефикации.");
            }
        }

        private void regestration_button_Click(object sender, EventArgs e)
        {
            string role = role_rbutton_member.Checked ? "member" : role_rbutton_organizator.Checked ? "organizator" : null;

            if (new ValidData().RegestrationDataisValid(username_textbox_reg.Text, password_textbox_reg.Text, repeatpass_textbox_reg.Text, role))
            {
                var regestrationuser = new User(username_textbox_reg.Text, password_textbox_reg.Text, role, Guid.NewGuid());
                var adduser = new UsersBase(regestrationuser);
                adduser.AddUser();
            }
        }
    }
}
